using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

using HidLibrary;

namespace MCP2515DM_BM_Controller
{
    public partial class Form1 : Form
    {

        private int VendorId = 0x04d8;
        private int[] ProductIds = new[] { 0x0070 };
        private static HidDevice _device;
        private static byte[] buffer = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};

        StreamWriter outfile;
        bool recording = false;

        Stopwatch timer = new Stopwatch();
        double prevtime = 0.0;

        bool setup;

        public Form1()
        {
            InitializeComponent();
            setUpCanDisp();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SearchHidDevices();
        }

        private void setUpCanDisp()
        {
            cangrid.ColumnCount = 5;
            cangrid.Columns[0].Name = "Time (ms)";
            cangrid.Columns[1].Name = "ID";
            cangrid.Columns[2].Name = "Length";
            cangrid.Columns[3].Name = "Data";
            cangrid.Columns[4].Name = "Dir";
            cangrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void connectbtn_Click(object sender, EventArgs e)
        {
            if (connectbtn.Text == "Connect")
            {
                if (_device != null)
                {
                    _device.OpenDevice();
                    _device.MonitorDeviceEvents = true;
                    _device.Read(OnRead);
                    _device.Removed += _device_Removed;
                    //byte id = 1;
                    //_device.ReadFeatureData(buffer, id);
                    //_device.ReadReport(OnReport);
                    //_device.Capabilities.OutputReportByteLength = 64;
                }
                else
                {
                    statuslbl.Text = "HID Device failed to connect";
                }

                if (_device.IsOpen)
                {
                    statuslbl.Text = "HID device connected";
                    connectbtn.Text = "Disconnect";
                    if (startupdatachckbox.Checked == true) startupcomms();
                    //setupRoutine(null);
                    //setup = true;
                }
                else
                {
                    statuslbl.Text = "HID Device failed to connect";
                }
            }
            else
            {
                _device.CloseDevice();
                _device.Dispose();
                if (_device.IsOpen)
                {
                    statuslbl.Text = "Failed to disconnect from HID device";
                }
                else
                {
                    statuslbl.Text = "HID device disconnected";
                    connectbtn.Text = "Connect";
                }
            }
           
        }

        void _device_Removed()
        {
            statuslbl.Text = "MCP2515DM-BM removed - All STOP";
            if (outfile != null)
            {
                if (outfile.BaseStream != null)
                {
                    recording = false;
                    outfile.Close();
                }
            }
            _device.CloseDevice();
            _device.Dispose();
        }

        private void SearchHidDevices()
        {
            //VendorId = Convert.ToInt32(vidtxtbox.Text);
            foreach (var productId in ProductIds)
            {
                _device = HidDevices.Enumerate(VendorId, productId).FirstOrDefault();
            }
            if (_device != null)
            {
                hiddeviceslistbox.Items.Add(_device.ToString());
                statuslbl.Text = "Found MCP2515DM-BM device";
            }
        }

        private void OnRead(HidDeviceData data)
        {
            double interval;
            string time = "0";
            if (data.Data[1] != 0)
            {
                if (timer.IsRunning)
                {
                    interval = timer.ElapsedMilliseconds;
                    time = Convert.ToString(interval - prevtime);
                    prevtime = interval;
                }
                else
                {
                    timer.Start();
                    time = DateTime.Now.ToString("HH:mm:ss");
                }

                byte[] inbuffer = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };  
                Array.Copy(data.Data, 1, inbuffer,0,64);
                if (setup == true)
                {
                    setupRoutine(inbuffer);
                }
                DecodeCan(inbuffer, time, "usbEvent");
                if (recording)
                {
                    DecodeCan(inbuffer, time, "softwareEvent");
                }
                ReadSettings(inbuffer);
            }
            if (_device.IsOpen) _device.Read(OnRead);
        }

        private void ReadSettings(byte[] items)
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(new Action<byte[]>(ReadSettings), new object[] { items });
                return;
            }

            /*settings array
             * 52 = number of can messages to send
             * 53 = CANINTF
             * 54 = EFLG
             * 55 = Tx error counter
             * 56 = rx error counter
             * 57 = CANstat
             * 58 = CANctrl
             * 59 = Status
             * 60 = SPI command - can reset 0xc0, can read 0x03, can write 0x02, can rts 0x80, can rts txb0 0x81, can txb1 0x82, can rts txb2 0x84, can rd status 0xA0, can bit modify 0x05, can rx status 0xB0, can rd rx buff 0x90, can load tx 0x40
             * 61 = Register
             * 62 = Data
             * 63 = U_res
             * */

            StringBuilder rawusb = new StringBuilder();
            for (int i = 52; i < 64; i++)
            {
                rawusb.Append(items[i].ToString());
                rawusb.Append(" ");
            }

            rawusblistbox.Items.Add(rawusb);
            rawusblistbox.SelectedIndex = rawusblistbox.Items.Count - 1;

                int opMode = items[57];
                switch (opMode)
                {
                    case 0:
                        canstatustxtbox.Text = "Normal";
                        //Drivermodecombobox.SelectedIndex = 0;
                        break;
                    case 2:
                        canstatustxtbox.Text = "Sleep";
                        //Drivermodecombobox.SelectedIndex = 1;
                        break;
                    case 4:
                        canstatustxtbox.Text = "Loopback";
                        //Drivermodecombobox.SelectedIndex = 2;
                        break;
                    case 6:
                        canstatustxtbox.Text = "Listen - Only";
                        //Drivermodecombobox.SelectedIndex = 3;
                        break;
                    case 8:
                        canstatustxtbox.Text = "Configuration";
                        //Drivermodecombobox.SelectedIndex = 4;
                        break;
                    default:
                        canstatustxtbox.Text = "Error";
                        break;
                }
        }

        private void DecodeCan(byte[] items, string timeStamp, string sender)
        {
            string hexconfig = items[0].ToString("X");
            string configbinary = hextobinary(hexconfig);
            bool standardID = true;
            int dataLength = 0;
            string id = "";
            string data = "";

            if (configbinary[0] == '1')
            {
                //string hexDataLength = hexconfig[1].ToString();
                dataLength = int.Parse(hexconfig[0].ToString(), System.Globalization.NumberStyles.HexNumber);

                //byte 1 and 2 = standard id
                string ID1 = items[1].ToString("X");
                string byte3 = hextobinary(items[2].ToString("X"));
                byte3 = byte3.Substring(5, byte3.Length - 5);

                string binaryID = Convert.ToString(Convert.ToInt32(ID1, 16), 2);
                binaryID = "00" + binaryID + byte3;
                id = Convert.ToInt32(binaryID, 2).ToString("X");

                if (hexconfig[0].ToString() == "A")//extended ID
                {
                    standardID = false;
                    string byte3again = hextobinary(items[2].ToString("X"));
                    byte3again = byte3again.Substring(0, 2);
                    binaryID = binaryID.Substring(2, binaryID.Length - 2);
                    binaryID = binaryID.Substring(0, binaryID.Length - 3);
                    binaryID = binaryID + byte3again + byte3 + hextobinary(items[3].ToString("X")) + hextobinary(items[4].ToString("X"));
                    id = Convert.ToInt32(binaryID, 2).ToString("X");
                }
                Debug.Print(id + " " + dataLength);
                data = " ";
                if (dataLength > 0)
                {
                    int i;
                    if (standardID == true) i = 3;//data starts at items[4]
                    else i = 5; //data starts at items[4] 
                    int j = dataLength;
                    while (j > 0)
                    {
                        string value = items[i].ToString("X");
                        if (value.Length < 2)
                        {
                            value = value.PadLeft(2, '0');
                        }
                        data = data + value + " ";
                        i++;
                        j--;
                    }
                }

                string dir = "RX";

                if (sender == "usbEvent")
                {
                    toGUI(timeStamp, id, dataLength.ToString(), data, dir);
                }
            }
            //return Format(timeStamp, ID, dataLength.ToString(), data);
        }

        private void toGUI(string timeStamp, string id, string dataLength, string data, string dir)
        {
            string[] newRow = new string[] { timeStamp, id, dataLength.ToString(), data, dir };
            cangrid.Invoke(new Action(() => cangrid.Rows.Add(newRow)));
            cangrid.Invoke(new Action(() => cangrid.FirstDisplayedScrollingRowIndex = cangrid.RowCount - 1));

            cangrid.Invoke(new Action(() => cangrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells));
        }

        private string Format(string timeStamp, string ID, string length, string data)
        {
            string canMessage;
            canMessage = timeStamp + " " + ID + " " + length.PadLeft(2, ' ') + " " + data;

            return canMessage;
        }

        public string bytetohex(byte[] input)
        {
            string hex = BitConverter.ToString(input);
            return hex.Replace("_", "");
        }

        public int hexToInt(string hex)
        {
            if (hex != "")
            {
                int intOut = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
                return intOut;
            }
            return 0;
        }

        private string hextobinary(string hex)
        {
            string binary = "NA";
            if (hex.Length == 1)
            {
                switch (hex[0])
                {
                    case '0':
                        binary = "00000000";
                        break;
                    case '1':
                        binary = "00000001";
                        break;
                    case '2':
                        binary = "00000010";
                        break;
                    case '3':
                        binary = "00000011";
                        break;
                    case '4':
                        binary = "00000100";
                        break;
                    case '5':
                        binary = "00000101";
                        break;
                    case '6':
                        binary = "00000110";
                        break;
                    case '7':
                        binary = "00000111";
                        break;
                    case '8':
                        binary = "00001000";
                        break;
                    case '9':
                        binary = "00001001";
                        break;
                    case 'A':
                        binary = "00001010";
                        break;
                    case 'B':
                        binary = "00001011";
                        break;
                    case 'C':
                        binary = "00001100";
                        break;
                    case 'D':
                        binary = "00001101";
                        break;
                    case 'E':
                        binary = "00001110";
                        break;
                    case 'F':
                        binary = "00001111";
                        break;
                }
            }
            else
            {
                switch (hex[0])
                {
                    case '0':
                        binary = "0000";
                        break;
                    case '1':
                        binary = "0001";
                        break;
                    case '2':
                        binary = "0010";
                        break;
                    case '3':
                        binary = "0011";
                        break;
                    case '4':
                        binary = "0100";
                        break;
                    case '5':
                        binary = "0101";
                        break;
                    case '6':
                        binary = "0110";
                        break;
                    case '7':
                        binary = "0111";
                        break;
                    case '8':
                        binary = "1000";
                        break;
                    case '9':
                        binary = "1001";
                        break;
                    case 'A':
                        binary = "1010";
                        break;
                    case 'B':
                        binary = "1011";
                        break;
                    case 'C':
                        binary = "1100";
                        break;
                    case 'D':
                        binary = "1101";
                        break;
                    case 'E':
                        binary = "1110";
                        break;
                    case 'F':
                        binary = "1111";
                        break;
                }
            }

            if (hex.Length > 1)
            {
                switch (hex[1])
                {
                    case '0':
                        binary = binary + "0000";
                        break;
                    case '1':
                        binary = binary + "0001";
                        break;
                    case '2':
                        binary = binary + "0010";
                        break;
                    case '3':
                        binary = binary + "0011";
                        break;
                    case '4':
                        binary = binary + "0100";
                        break;
                    case '5':
                        binary = binary + "0101";
                        break;
                    case '6':
                        binary = binary + "0110";
                        break;
                    case '7':
                        binary = binary + "0111";
                        break;
                    case '8':
                        binary = binary + "1000";
                        break;
                    case '9':
                        binary = binary + "1001";
                        break;
                    case 'A':
                        binary = binary + "1010";
                        break;
                    case 'B':
                        binary = binary + "1011";
                        break;
                    case 'C':
                        binary = binary + "1100";
                        break;
                    case 'D':
                        binary = binary + "1101";
                        break;
                    case 'E':
                        binary = binary + "1110";
                        break;
                    case 'F':
                        binary = binary + "1111";
                        break;
                }
            }

            if (hex.Length > 2)
            {
                switch (hex[2])
                {
                    case '0':
                        binary = binary + "0000";
                        break;
                    case '1':
                        binary = binary + "0001";
                        break;
                    case '2':
                        binary = binary + "0010";
                        break;
                    case '3':
                        binary = binary + "0011";
                        break;
                    case '4':
                        binary = binary + "0100";
                        break;
                    case '5':
                        binary = binary + "0101";
                        break;
                    case '6':
                        binary = binary + "0110";
                        break;
                    case '7':
                        binary = binary + "0111";
                        break;
                    case '8':
                        binary = binary + "1000";
                        break;
                    case '9':
                        binary = binary + "1001";
                        break;
                    case 'A':
                        binary = binary + "1010";
                        break;
                    case 'B':
                        binary = binary + "1011";
                        break;
                    case 'C':
                        binary = binary + "1100";
                        break;
                    case 'D':
                        binary = binary + "1101";
                        break;
                    case 'E':
                        binary = binary + "1110";
                        break;
                    case 'F':
                        binary = binary + "1111";
                        break;
                }
            }

            if (hex.Length > 3)
            {
                switch (hex[3])
                {
                    case '0':
                        binary = binary + "0000";
                        break;
                    case '1':
                        binary = binary + "0001";
                        break;
                    case '2':
                        binary = binary + "0010";
                        break;
                    case '3':
                        binary = binary + "0011";
                        break;
                    case '4':
                        binary = binary + "0100";
                        break;
                    case '5':
                        binary = binary + "0101";
                        break;
                    case '6':
                        binary = binary + "0110";
                        break;
                    case '7':
                        binary = binary + "0111";
                        break;
                    case '8':
                        binary = binary + "1000";
                        break;
                    case '9':
                        binary = binary + "1001";
                        break;
                    case 'A':
                        binary = binary + "1010";
                        break;
                    case 'B':
                        binary = binary + "1011";
                        break;
                    case 'C':
                        binary = binary + "1100";
                        break;
                    case 'D':
                        binary = binary + "1101";
                        break;
                    case 'E':
                        binary = binary + "1110";
                        break;
                    case 'F':
                        binary = binary + "1111";
                        break;
                }
            }
            return binary;
        }

        private string binaryToHex(string binary)
        {
            string hexOut = "";
            if (binary.Length > 0)
            {
                hexOut = Convert.ToInt32(binary, 2).ToString("X");
            }
            return hexOut;
        }

        private void canstatuscombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            buffer[58] = 3;
            buffer[60] = 2;
            buffer[61] = 15;
            //buffer[61] = Convert.ToByte(500);
            bool ans = _device.Write(buffer);
            if (ans == true) statuslbl.Text = "Write successful";
            else statuslbl.Text = "Write unsuccessful";
        }

        private void saveToFile(string timeStamp, string ID, string length, string data, string dir)
        {
            if (outfile.BaseStream != null)
            {
                outfile.WriteLine(timeStamp + "," + ID + "," + length + "," + data + "," + dir);
            }
            else
            {
                recording = false;
                if (timer.IsRunning)
                {
                    timer.Stop();
                }
                statuslbl.Text = "Recording to file closed Unexpectedly";
            }
        }

        private void startupcomms()
        {
            buffer[59] = 7;
            buffer[61] = 3;
            buffer[62] = 14; //0e in decimal

            bool ans = _device.Write(buffer);
            if (ans == true) statuslbl.Text = "Write successful";
            else statuslbl.Text = "Write unsuccessful";
        }

        private void recbtn_Click(object sender, EventArgs e)
        {
            if (outfile == null)
            {
                SaveFileDialog savedirectory = new SaveFileDialog();
                savedirectory.Filter = "CSV | *.csv";
                savedirectory.DefaultExt = "csv";
                DialogResult result = savedirectory.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string file = savedirectory.FileName;
                    outfile = new StreamWriter(file);
                    if (outfile.BaseStream != null)
                    {
                        recording = true;
                        outfile.WriteLine("Time Stamp (ms),ID,Length,Data,Dir");
                        statuslbl.Text = "Recording to file";
                        recbtn.Text = "Stop Recording";
                    }
                    else
                    {
                        recording = false;
                        if (timer.IsRunning)
                        {
                            timer.Stop();
                        }
                        statuslbl.Text = "Recording stream failed to open";
                        recbtn.Text = "Record";
                    }
                }
            }
            else
            {
                recording = false;
                outfile.Close();
                recbtn.Text = "Record";
                statuslbl.Text = "Recording stopped";
            }
            
        }

        private void setupRoutine(byte[] respsonse)
        {
            int step = 0;
            if (respsonse != null)
            {
                if (respsonse[60] == 3 && respsonse[61] == 14)
                {
                    step = 1;
                }
                else if (respsonse[60] == 3 && respsonse[61] == 15 && respsonse[62] == 7)
                {
                    step = 2;
                }
                else if (respsonse[57] == 128 && respsonse[61] == 15 && respsonse[62] == 7)
                {
                    step = 3;
                }
                else if (respsonse[57] == 128 && respsonse[60] == 3 && respsonse[61] == 14 && respsonse[62] == 128)
                {
                    step = 4;
                }
            }
            
            switch (step)
            {
                case 0:
                    Array.Clear(buffer, 0, buffer.Length);
                    buffer[58] = 7; //set to config hex 87 decimal 135
                    buffer[60] = 3;
                    buffer[61] = 14;//set to e hex 
                    //buffer[62] = 1;
                    _device.Write(buffer);
                    break;
                case 1:
                    Array.Clear(buffer, 0, buffer.Length);
                    buffer[58] = 7; //set to config hex 87 decimal 135
                    buffer[60] = 3;
                    buffer[61] = 15;//set to f hex 
                    //buffer[62] = 1;
                    _device.Write(buffer);
                    break;
                case 2:
                    Array.Clear(buffer, 0, buffer.Length);
                    buffer[58] = 135; //set to config hex 87 decimal 135
                    buffer[60] = 3;
                    buffer[61] = 15;//set to f hex 
                    buffer[62] = 135;//set to 87 hex
                    _device.Write(buffer);
                    break;
                case 3:
                    Array.Clear(buffer, 0, buffer.Length);
                    buffer[58] = 135; //set to config hex 87 decimal 135
                    buffer[60] = 3;
                    buffer[61] = 14;//set to e hex 
                    _device.Write(buffer);
                    break;
                case 4:
                    Array.Clear(buffer, 0, buffer.Length);
                    buffer[58] = 135; //set to config hex 87 decimal 135
                    buffer[60] = 3;
                    buffer[61] = 15;//set to e hex 
                    _device.Write(buffer);
                    break;
            }
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            byte[] outbuffer = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Array.Clear(buffer, 0, buffer.Length);
            //buffer[0] = Convert.ToByte("");
            string binid = Convert.ToString(Convert.ToInt32(canidtxtbox.Text, 16), 2);
            if (binid.Length != 11)
            {
                if (binid.Length < 11)
                {
                    binid = binid.PadLeft(11, '0');
                }
                if (binid.Length > 11)
                {
                    binid = binid.Substring(0, 11);
                }
            }
            string byte1 = binid.Substring(0, binid.Length - 3);
            string byte2bits = binid.Substring(8, 3) + "00000";
            buffer[1] = Convert.ToByte(Convert.ToInt64(byte1, 2));
            buffer[2] = Convert.ToByte(Convert.ToInt64(byte2bits, 2));
            //int intval = hexToInt(canidtxtbox.Text);

            //buffer[3] = Convert.ToByte(textBox3.Text);
            buffer[5] = Convert.ToByte(canmessagelengthtxtbox.Text);
            buffer[6] = Convert.ToByte(hexToInt(byte1txtbox.Text));
            buffer[7] = Convert.ToByte(hexToInt(byte2txtbox.Text));
            buffer[8] = Convert.ToByte(hexToInt(byte3txtbox.Text));
            buffer[9] = Convert.ToByte(hexToInt(byte4txtbox.Text));
            buffer[10] = Convert.ToByte(hexToInt(byte6txtbox.Text));
            buffer[11] = Convert.ToByte(hexToInt(byte5txtbox.Text));
            buffer[12] = Convert.ToByte(hexToInt(byte7txtbox.Text));
            buffer[13] = Convert.ToByte(hexToInt(byte8txtbox.Text));

            buffer[53] = Convert.ToByte(1);
            //buffer[59] = Convert.ToByte(textBox8.Text);
            //buffer[60] = 2;
            //buffer[61] = 15;
            //buffer[62] = 2;
            //Array.Copy(buffer, 1, outbuffer, 0, 63);

            bool ans = _device.Write(buffer);
            if (ans == true) statuslbl.Text = "Can message sent";
            else statuslbl.Text = "Can message failed to send";


            toGUI(DateTime.Now.ToString("HH:mm:ss"), canidtxtbox.Text, canmessagelengthtxtbox.Text, byte1txtbox.Text + " " + byte2txtbox.Text + " " + byte3txtbox.Text + " " + byte4txtbox.Text + " " + byte5txtbox.Text + " " + byte6txtbox.Text + " " + byte7txtbox.Text + " " + byte8txtbox.Text, "TX");
            //buffer[0] = 255;
            //DecodeCan(buffer, "0", "softwareEvent");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Array.Clear(buffer, 0, buffer.Length);
            buffer[58] = 0;
            buffer[60] = 2;
            buffer[61] = 15;
            buffer[62] = 0;

            bool ans = _device.Write(buffer);
            if (ans == true) statuslbl.Text = "Control message sent";
            else statuslbl.Text = "Control message failed to send";
        }

        private void canmessagelengthtxtbox_TextChanged(object sender, EventArgs e)
        {
            if (canmessagelengthtxtbox.Text != "")
            {
                if (Convert.ToInt32(canmessagelengthtxtbox.Text) == 1)
                {
                    byte1txtbox.Enabled = true;
                    byte2txtbox.Enabled = false;
                    byte3txtbox.Enabled = false;
                    byte4txtbox.Enabled = false;
                    byte5txtbox.Enabled = false;
                    byte6txtbox.Enabled = false;
                    byte7txtbox.Enabled = false;
                    byte8txtbox.Enabled = false;
                }
                else if (Convert.ToInt32(canmessagelengthtxtbox.Text) == 2)
                {
                    byte1txtbox.Enabled = true;
                    byte2txtbox.Enabled = true;
                    byte3txtbox.Enabled = false;
                    byte4txtbox.Enabled = false;
                    byte5txtbox.Enabled = false;
                    byte6txtbox.Enabled = false;
                    byte7txtbox.Enabled = false;
                    byte8txtbox.Enabled = false;
                }
                else if (Convert.ToInt32(canmessagelengthtxtbox.Text) == 3)
                {
                    byte1txtbox.Enabled = true;
                    byte2txtbox.Enabled = true;
                    byte3txtbox.Enabled = true;
                    byte4txtbox.Enabled = false;
                    byte5txtbox.Enabled = false;
                    byte6txtbox.Enabled = false;
                    byte7txtbox.Enabled = false;
                    byte8txtbox.Enabled = false;
                }
                else if (Convert.ToInt32(canmessagelengthtxtbox.Text) == 4)
                {
                    byte1txtbox.Enabled = true;
                    byte2txtbox.Enabled = true;
                    byte3txtbox.Enabled = true;
                    byte4txtbox.Enabled = true;
                    byte5txtbox.Enabled = false;
                    byte6txtbox.Enabled = false;
                    byte7txtbox.Enabled = false;
                    byte8txtbox.Enabled = false;
                }
                else if (Convert.ToInt32(canmessagelengthtxtbox.Text) == 5)
                {
                    byte1txtbox.Enabled = true;
                    byte2txtbox.Enabled = true;
                    byte3txtbox.Enabled = true;
                    byte4txtbox.Enabled = true;
                    byte5txtbox.Enabled = true;
                    byte6txtbox.Enabled = false;
                    byte7txtbox.Enabled = false;
                    byte8txtbox.Enabled = false;
                }
                else if (Convert.ToInt32(canmessagelengthtxtbox.Text) == 6)
                {
                    byte1txtbox.Enabled = true;
                    byte2txtbox.Enabled = true;
                    byte3txtbox.Enabled = true;
                    byte4txtbox.Enabled = true;
                    byte5txtbox.Enabled = true;
                    byte6txtbox.Enabled = true;
                    byte7txtbox.Enabled = false;
                    byte8txtbox.Enabled = false;
                }
                else if (Convert.ToInt32(canmessagelengthtxtbox.Text) == 7)
                {
                    byte1txtbox.Enabled = true;
                    byte2txtbox.Enabled = true;
                    byte3txtbox.Enabled = true;
                    byte4txtbox.Enabled = true;
                    byte5txtbox.Enabled = true;
                    byte6txtbox.Enabled = true;
                    byte7txtbox.Enabled = true;
                    byte8txtbox.Enabled = false;
                }
                else if (Convert.ToInt32(canmessagelengthtxtbox.Text) == 8)
                {
                    byte1txtbox.Enabled = true;
                    byte2txtbox.Enabled = true;
                    byte3txtbox.Enabled = true;
                    byte4txtbox.Enabled = true;
                    byte5txtbox.Enabled = true;
                    byte6txtbox.Enabled = true;
                    byte7txtbox.Enabled = true;
                    byte8txtbox.Enabled = true;
                }
                else if (Convert.ToInt32(canmessagelengthtxtbox.Text) > 0)
                {
                    byte1txtbox.Enabled = true;
                    byte2txtbox.Enabled = true;
                    byte3txtbox.Enabled = true;
                    byte4txtbox.Enabled = true;
                    byte5txtbox.Enabled = true;
                    byte6txtbox.Enabled = true;
                    byte7txtbox.Enabled = true;
                    byte8txtbox.Enabled = true;
                    canmessagelengthtxtbox.Text = "8";
                }
            }
        }

        private void canidtxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void canmessagelengthtxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void byte1txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void byte2txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void sendrecordingbtn_Click(object sender, EventArgs e)
        {

        }

    }
}
