namespace MCP2515DM_BM_Controller
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.connectbtn = new System.Windows.Forms.Button();
            this.hiddeviceslistbox = new System.Windows.Forms.ListBox();
            this.hidconnectiongroupdbox = new System.Windows.Forms.GroupBox();
            this.startupdatachckbox = new System.Windows.Forms.CheckBox();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.pidlbl = new System.Windows.Forms.Label();
            this.vidlbl = new System.Windows.Forms.Label();
            this.pidtxtbox = new System.Windows.Forms.TextBox();
            this.vidtxtbox = new System.Windows.Forms.TextBox();
            this.hiddevicegroupdbox = new System.Windows.Forms.GroupBox();
            this.sendmsggroupbox = new System.Windows.Forms.GroupBox();
            this.byte8lbl = new System.Windows.Forms.Label();
            this.byte7lbl = new System.Windows.Forms.Label();
            this.byte6lbl = new System.Windows.Forms.Label();
            this.byte5lbl = new System.Windows.Forms.Label();
            this.byte4lbl = new System.Windows.Forms.Label();
            this.byte3lbl = new System.Windows.Forms.Label();
            this.byte2lbl = new System.Windows.Forms.Label();
            this.byte1lbl = new System.Windows.Forms.Label();
            this.messagelengthlbl = new System.Windows.Forms.Label();
            this.canidlbl = new System.Windows.Forms.Label();
            this.canidtxtbox = new System.Windows.Forms.TextBox();
            this.byte8txtbox = new System.Windows.Forms.TextBox();
            this.byte1txtbox = new System.Windows.Forms.TextBox();
            this.canmessagelengthtxtbox = new System.Windows.Forms.TextBox();
            this.byte7txtbox = new System.Windows.Forms.TextBox();
            this.byte2txtbox = new System.Windows.Forms.TextBox();
            this.byte6txtbox = new System.Windows.Forms.TextBox();
            this.byte5txtbox = new System.Windows.Forms.TextBox();
            this.byte3txtbox = new System.Windows.Forms.TextBox();
            this.byte4txtbox = new System.Windows.Forms.TextBox();
            this.sendbtn = new System.Windows.Forms.Button();
            this.cangrid = new System.Windows.Forms.DataGridView();
            this.recbtn = new System.Windows.Forms.Button();
            this.rawusblistbox = new System.Windows.Forms.ListBox();
            this.setcanstatuslbl = new System.Windows.Forms.Label();
            this.canstatuscombobox = new System.Windows.Forms.ComboBox();
            this.canstatuslbl = new System.Windows.Forms.Label();
            this.canstatustxtbox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statuslbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.sendrecordingbtn = new System.Windows.Forms.Button();
            this.hidconnectiongroupdbox.SuspendLayout();
            this.hiddevicegroupdbox.SuspendLayout();
            this.sendmsggroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cangrid)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectbtn
            // 
            this.connectbtn.Location = new System.Drawing.Point(12, 123);
            this.connectbtn.Name = "connectbtn";
            this.connectbtn.Size = new System.Drawing.Size(75, 23);
            this.connectbtn.TabIndex = 0;
            this.connectbtn.Text = "Connect";
            this.connectbtn.UseVisualStyleBackColor = true;
            this.connectbtn.Click += new System.EventHandler(this.connectbtn_Click);
            // 
            // hiddeviceslistbox
            // 
            this.hiddeviceslistbox.FormattingEnabled = true;
            this.hiddeviceslistbox.Location = new System.Drawing.Point(12, 8);
            this.hiddeviceslistbox.Name = "hiddeviceslistbox";
            this.hiddeviceslistbox.Size = new System.Drawing.Size(781, 43);
            this.hiddeviceslistbox.TabIndex = 1;
            // 
            // hidconnectiongroupdbox
            // 
            this.hidconnectiongroupdbox.Controls.Add(this.startupdatachckbox);
            this.hidconnectiongroupdbox.Controls.Add(this.refreshbtn);
            this.hidconnectiongroupdbox.Controls.Add(this.pidlbl);
            this.hidconnectiongroupdbox.Controls.Add(this.vidlbl);
            this.hidconnectiongroupdbox.Controls.Add(this.pidtxtbox);
            this.hidconnectiongroupdbox.Controls.Add(this.vidtxtbox);
            this.hidconnectiongroupdbox.Controls.Add(this.connectbtn);
            this.hidconnectiongroupdbox.Location = new System.Drawing.Point(6, 13);
            this.hidconnectiongroupdbox.Name = "hidconnectiongroupdbox";
            this.hidconnectiongroupdbox.Size = new System.Drawing.Size(100, 184);
            this.hidconnectiongroupdbox.TabIndex = 2;
            this.hidconnectiongroupdbox.TabStop = false;
            this.hidconnectiongroupdbox.Text = "HID Connection";
            // 
            // startupdatachckbox
            // 
            this.startupdatachckbox.AutoSize = true;
            this.startupdatachckbox.Location = new System.Drawing.Point(12, 100);
            this.startupdatachckbox.Name = "startupdatachckbox";
            this.startupdatachckbox.Size = new System.Drawing.Size(84, 17);
            this.startupdatachckbox.TabIndex = 9;
            this.startupdatachckbox.Text = "Start comms";
            this.startupdatachckbox.UseVisualStyleBackColor = true;
            // 
            // refreshbtn
            // 
            this.refreshbtn.Location = new System.Drawing.Point(12, 152);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(75, 23);
            this.refreshbtn.TabIndex = 6;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = true;
            // 
            // pidlbl
            // 
            this.pidlbl.AutoSize = true;
            this.pidlbl.Location = new System.Drawing.Point(12, 58);
            this.pidlbl.Name = "pidlbl";
            this.pidlbl.Size = new System.Drawing.Size(25, 13);
            this.pidlbl.TabIndex = 5;
            this.pidlbl.Text = "PID";
            // 
            // vidlbl
            // 
            this.vidlbl.AutoSize = true;
            this.vidlbl.Location = new System.Drawing.Point(12, 16);
            this.vidlbl.Name = "vidlbl";
            this.vidlbl.Size = new System.Drawing.Size(25, 13);
            this.vidlbl.TabIndex = 3;
            this.vidlbl.Text = "VID";
            // 
            // pidtxtbox
            // 
            this.pidtxtbox.Enabled = false;
            this.pidtxtbox.Location = new System.Drawing.Point(12, 74);
            this.pidtxtbox.Name = "pidtxtbox";
            this.pidtxtbox.Size = new System.Drawing.Size(73, 20);
            this.pidtxtbox.TabIndex = 4;
            this.pidtxtbox.Text = "0x0070";
            // 
            // vidtxtbox
            // 
            this.vidtxtbox.Enabled = false;
            this.vidtxtbox.Location = new System.Drawing.Point(12, 32);
            this.vidtxtbox.Name = "vidtxtbox";
            this.vidtxtbox.Size = new System.Drawing.Size(73, 20);
            this.vidtxtbox.TabIndex = 3;
            this.vidtxtbox.Text = "0x04d8";
            // 
            // hiddevicegroupdbox
            // 
            this.hiddevicegroupdbox.Controls.Add(this.sendrecordingbtn);
            this.hiddevicegroupdbox.Controls.Add(this.sendmsggroupbox);
            this.hiddevicegroupdbox.Controls.Add(this.cangrid);
            this.hiddevicegroupdbox.Controls.Add(this.recbtn);
            this.hiddevicegroupdbox.Controls.Add(this.hidconnectiongroupdbox);
            this.hiddevicegroupdbox.Controls.Add(this.rawusblistbox);
            this.hiddevicegroupdbox.Controls.Add(this.setcanstatuslbl);
            this.hiddevicegroupdbox.Controls.Add(this.canstatuscombobox);
            this.hiddevicegroupdbox.Controls.Add(this.canstatuslbl);
            this.hiddevicegroupdbox.Controls.Add(this.canstatustxtbox);
            this.hiddevicegroupdbox.Location = new System.Drawing.Point(12, 57);
            this.hiddevicegroupdbox.Name = "hiddevicegroupdbox";
            this.hiddevicegroupdbox.Size = new System.Drawing.Size(781, 327);
            this.hiddevicegroupdbox.TabIndex = 3;
            this.hiddevicegroupdbox.TabStop = false;
            this.hiddevicegroupdbox.Text = "MCP2515DM-BM";
            // 
            // sendmsggroupbox
            // 
            this.sendmsggroupbox.Controls.Add(this.byte8lbl);
            this.sendmsggroupbox.Controls.Add(this.sendbtn);
            this.sendmsggroupbox.Controls.Add(this.byte7lbl);
            this.sendmsggroupbox.Controls.Add(this.byte6lbl);
            this.sendmsggroupbox.Controls.Add(this.byte5lbl);
            this.sendmsggroupbox.Controls.Add(this.byte4lbl);
            this.sendmsggroupbox.Controls.Add(this.byte3lbl);
            this.sendmsggroupbox.Controls.Add(this.byte2lbl);
            this.sendmsggroupbox.Controls.Add(this.byte1lbl);
            this.sendmsggroupbox.Controls.Add(this.messagelengthlbl);
            this.sendmsggroupbox.Controls.Add(this.canidlbl);
            this.sendmsggroupbox.Controls.Add(this.canidtxtbox);
            this.sendmsggroupbox.Controls.Add(this.byte8txtbox);
            this.sendmsggroupbox.Controls.Add(this.byte1txtbox);
            this.sendmsggroupbox.Controls.Add(this.canmessagelengthtxtbox);
            this.sendmsggroupbox.Controls.Add(this.byte7txtbox);
            this.sendmsggroupbox.Controls.Add(this.byte2txtbox);
            this.sendmsggroupbox.Controls.Add(this.byte6txtbox);
            this.sendmsggroupbox.Controls.Add(this.byte5txtbox);
            this.sendmsggroupbox.Controls.Add(this.byte3txtbox);
            this.sendmsggroupbox.Controls.Add(this.byte4txtbox);
            this.sendmsggroupbox.Location = new System.Drawing.Point(112, 13);
            this.sendmsggroupbox.Name = "sendmsggroupbox";
            this.sendmsggroupbox.Size = new System.Drawing.Size(203, 223);
            this.sendmsggroupbox.TabIndex = 25;
            this.sendmsggroupbox.TabStop = false;
            this.sendmsggroupbox.Text = "Send Message";
            // 
            // byte8lbl
            // 
            this.byte8lbl.AutoSize = true;
            this.byte8lbl.Location = new System.Drawing.Point(105, 201);
            this.byte8lbl.Name = "byte8lbl";
            this.byte8lbl.Size = new System.Drawing.Size(37, 13);
            this.byte8lbl.TabIndex = 35;
            this.byte8lbl.Text = "Byte 8";
            // 
            // byte7lbl
            // 
            this.byte7lbl.AutoSize = true;
            this.byte7lbl.Location = new System.Drawing.Point(105, 175);
            this.byte7lbl.Name = "byte7lbl";
            this.byte7lbl.Size = new System.Drawing.Size(37, 13);
            this.byte7lbl.TabIndex = 34;
            this.byte7lbl.Text = "Byte 7";
            // 
            // byte6lbl
            // 
            this.byte6lbl.AutoSize = true;
            this.byte6lbl.Location = new System.Drawing.Point(105, 149);
            this.byte6lbl.Name = "byte6lbl";
            this.byte6lbl.Size = new System.Drawing.Size(37, 13);
            this.byte6lbl.TabIndex = 33;
            this.byte6lbl.Text = "Byte 6";
            // 
            // byte5lbl
            // 
            this.byte5lbl.AutoSize = true;
            this.byte5lbl.Location = new System.Drawing.Point(105, 123);
            this.byte5lbl.Name = "byte5lbl";
            this.byte5lbl.Size = new System.Drawing.Size(37, 13);
            this.byte5lbl.TabIndex = 32;
            this.byte5lbl.Text = "Byte 5";
            // 
            // byte4lbl
            // 
            this.byte4lbl.AutoSize = true;
            this.byte4lbl.Location = new System.Drawing.Point(105, 97);
            this.byte4lbl.Name = "byte4lbl";
            this.byte4lbl.Size = new System.Drawing.Size(37, 13);
            this.byte4lbl.TabIndex = 31;
            this.byte4lbl.Text = "Byte 4";
            // 
            // byte3lbl
            // 
            this.byte3lbl.AutoSize = true;
            this.byte3lbl.Location = new System.Drawing.Point(105, 71);
            this.byte3lbl.Name = "byte3lbl";
            this.byte3lbl.Size = new System.Drawing.Size(37, 13);
            this.byte3lbl.TabIndex = 30;
            this.byte3lbl.Text = "Byte 3";
            // 
            // byte2lbl
            // 
            this.byte2lbl.AutoSize = true;
            this.byte2lbl.Location = new System.Drawing.Point(105, 45);
            this.byte2lbl.Name = "byte2lbl";
            this.byte2lbl.Size = new System.Drawing.Size(37, 13);
            this.byte2lbl.TabIndex = 29;
            this.byte2lbl.Text = "Byte 2";
            // 
            // byte1lbl
            // 
            this.byte1lbl.AutoSize = true;
            this.byte1lbl.Location = new System.Drawing.Point(105, 19);
            this.byte1lbl.Name = "byte1lbl";
            this.byte1lbl.Size = new System.Drawing.Size(37, 13);
            this.byte1lbl.TabIndex = 27;
            this.byte1lbl.Text = "Byte 1";
            // 
            // messagelengthlbl
            // 
            this.messagelengthlbl.AutoSize = true;
            this.messagelengthlbl.Location = new System.Drawing.Point(6, 45);
            this.messagelengthlbl.Name = "messagelengthlbl";
            this.messagelengthlbl.Size = new System.Drawing.Size(40, 13);
            this.messagelengthlbl.TabIndex = 26;
            this.messagelengthlbl.Text = "Length";
            // 
            // canidlbl
            // 
            this.canidlbl.AutoSize = true;
            this.canidlbl.Location = new System.Drawing.Point(6, 19);
            this.canidlbl.Name = "canidlbl";
            this.canidlbl.Size = new System.Drawing.Size(43, 13);
            this.canidlbl.TabIndex = 25;
            this.canidlbl.Text = "CAN ID";
            // 
            // canidtxtbox
            // 
            this.canidtxtbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.canidtxtbox.Location = new System.Drawing.Point(51, 16);
            this.canidtxtbox.Name = "canidtxtbox";
            this.canidtxtbox.Size = new System.Drawing.Size(48, 20);
            this.canidtxtbox.TabIndex = 11;
            this.canidtxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.canidtxtbox_KeyPress);
            // 
            // byte8txtbox
            // 
            this.byte8txtbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.byte8txtbox.Enabled = false;
            this.byte8txtbox.Location = new System.Drawing.Point(146, 198);
            this.byte8txtbox.Name = "byte8txtbox";
            this.byte8txtbox.Size = new System.Drawing.Size(48, 20);
            this.byte8txtbox.TabIndex = 24;
            // 
            // byte1txtbox
            // 
            this.byte1txtbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.byte1txtbox.Enabled = false;
            this.byte1txtbox.Location = new System.Drawing.Point(146, 16);
            this.byte1txtbox.Name = "byte1txtbox";
            this.byte1txtbox.Size = new System.Drawing.Size(48, 20);
            this.byte1txtbox.TabIndex = 15;
            this.byte1txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.byte1txtbox_KeyPress);
            // 
            // canmessagelengthtxtbox
            // 
            this.canmessagelengthtxtbox.Location = new System.Drawing.Point(51, 42);
            this.canmessagelengthtxtbox.Name = "canmessagelengthtxtbox";
            this.canmessagelengthtxtbox.Size = new System.Drawing.Size(48, 20);
            this.canmessagelengthtxtbox.TabIndex = 14;
            this.canmessagelengthtxtbox.TextChanged += new System.EventHandler(this.canmessagelengthtxtbox_TextChanged);
            this.canmessagelengthtxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.canmessagelengthtxtbox_KeyPress);
            // 
            // byte7txtbox
            // 
            this.byte7txtbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.byte7txtbox.Enabled = false;
            this.byte7txtbox.Location = new System.Drawing.Point(146, 172);
            this.byte7txtbox.Name = "byte7txtbox";
            this.byte7txtbox.Size = new System.Drawing.Size(48, 20);
            this.byte7txtbox.TabIndex = 23;
            // 
            // byte2txtbox
            // 
            this.byte2txtbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.byte2txtbox.Enabled = false;
            this.byte2txtbox.Location = new System.Drawing.Point(146, 42);
            this.byte2txtbox.Name = "byte2txtbox";
            this.byte2txtbox.Size = new System.Drawing.Size(48, 20);
            this.byte2txtbox.TabIndex = 16;
            this.byte2txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.byte2txtbox_KeyPress);
            // 
            // byte6txtbox
            // 
            this.byte6txtbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.byte6txtbox.Enabled = false;
            this.byte6txtbox.Location = new System.Drawing.Point(146, 146);
            this.byte6txtbox.Name = "byte6txtbox";
            this.byte6txtbox.Size = new System.Drawing.Size(48, 20);
            this.byte6txtbox.TabIndex = 21;
            // 
            // byte5txtbox
            // 
            this.byte5txtbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.byte5txtbox.Enabled = false;
            this.byte5txtbox.Location = new System.Drawing.Point(146, 120);
            this.byte5txtbox.Name = "byte5txtbox";
            this.byte5txtbox.Size = new System.Drawing.Size(48, 20);
            this.byte5txtbox.TabIndex = 22;
            // 
            // byte3txtbox
            // 
            this.byte3txtbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.byte3txtbox.Enabled = false;
            this.byte3txtbox.Location = new System.Drawing.Point(146, 68);
            this.byte3txtbox.Name = "byte3txtbox";
            this.byte3txtbox.Size = new System.Drawing.Size(48, 20);
            this.byte3txtbox.TabIndex = 19;
            // 
            // byte4txtbox
            // 
            this.byte4txtbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.byte4txtbox.Enabled = false;
            this.byte4txtbox.Location = new System.Drawing.Point(146, 94);
            this.byte4txtbox.Name = "byte4txtbox";
            this.byte4txtbox.Size = new System.Drawing.Size(48, 20);
            this.byte4txtbox.TabIndex = 20;
            // 
            // sendbtn
            // 
            this.sendbtn.Location = new System.Drawing.Point(6, 194);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(75, 23);
            this.sendbtn.TabIndex = 9;
            this.sendbtn.Text = "Send";
            this.sendbtn.UseVisualStyleBackColor = true;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // cangrid
            // 
            this.cangrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cangrid.Location = new System.Drawing.Point(321, 13);
            this.cangrid.Name = "cangrid";
            this.cangrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cangrid.RowHeadersVisible = false;
            this.cangrid.RowHeadersWidth = 42;
            this.cangrid.Size = new System.Drawing.Size(452, 299);
            this.cangrid.TabIndex = 8;
            // 
            // recbtn
            // 
            this.recbtn.Location = new System.Drawing.Point(6, 298);
            this.recbtn.Name = "recbtn";
            this.recbtn.Size = new System.Drawing.Size(107, 23);
            this.recbtn.TabIndex = 6;
            this.recbtn.Text = "Record";
            this.recbtn.UseVisualStyleBackColor = true;
            this.recbtn.Click += new System.EventHandler(this.recbtn_Click);
            // 
            // rawusblistbox
            // 
            this.rawusblistbox.FormattingEnabled = true;
            this.rawusblistbox.Location = new System.Drawing.Point(112, 242);
            this.rawusblistbox.Name = "rawusblistbox";
            this.rawusblistbox.Size = new System.Drawing.Size(203, 43);
            this.rawusblistbox.TabIndex = 5;
            // 
            // setcanstatuslbl
            // 
            this.setcanstatuslbl.AutoSize = true;
            this.setcanstatuslbl.Location = new System.Drawing.Point(6, 241);
            this.setcanstatuslbl.Name = "setcanstatuslbl";
            this.setcanstatuslbl.Size = new System.Drawing.Size(81, 13);
            this.setcanstatuslbl.TabIndex = 4;
            this.setcanstatuslbl.Text = "Set CAN Status";
            // 
            // canstatuscombobox
            // 
            this.canstatuscombobox.Enabled = false;
            this.canstatuscombobox.FormattingEnabled = true;
            this.canstatuscombobox.Items.AddRange(new object[] {
            "Normal",
            "Sleep",
            "Loopback",
            "Listen",
            "Config"});
            this.canstatuscombobox.Location = new System.Drawing.Point(6, 257);
            this.canstatuscombobox.Name = "canstatuscombobox";
            this.canstatuscombobox.Size = new System.Drawing.Size(100, 21);
            this.canstatuscombobox.TabIndex = 3;
            this.canstatuscombobox.SelectedIndexChanged += new System.EventHandler(this.canstatuscombobox_SelectedIndexChanged);
            // 
            // canstatuslbl
            // 
            this.canstatuslbl.AutoSize = true;
            this.canstatuslbl.Location = new System.Drawing.Point(6, 200);
            this.canstatuslbl.Name = "canstatuslbl";
            this.canstatuslbl.Size = new System.Drawing.Size(62, 13);
            this.canstatuslbl.TabIndex = 2;
            this.canstatuslbl.Text = "CAN Status";
            // 
            // canstatustxtbox
            // 
            this.canstatustxtbox.Location = new System.Drawing.Point(6, 216);
            this.canstatustxtbox.Name = "canstatustxtbox";
            this.canstatustxtbox.Size = new System.Drawing.Size(100, 20);
            this.canstatustxtbox.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 391);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(803, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statuslbl
            // 
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(0, 17);
            // 
            // sendrecordingbtn
            // 
            this.sendrecordingbtn.Location = new System.Drawing.Point(119, 298);
            this.sendrecordingbtn.Name = "sendrecordingbtn";
            this.sendrecordingbtn.Size = new System.Drawing.Size(107, 23);
            this.sendrecordingbtn.TabIndex = 26;
            this.sendrecordingbtn.Text = "Send Recording";
            this.sendrecordingbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 413);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.hiddevicegroupdbox);
            this.Controls.Add(this.hiddeviceslistbox);
            this.Name = "Form1";
            this.Text = "MCP2515DM-BM controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.hidconnectiongroupdbox.ResumeLayout(false);
            this.hidconnectiongroupdbox.PerformLayout();
            this.hiddevicegroupdbox.ResumeLayout(false);
            this.hiddevicegroupdbox.PerformLayout();
            this.sendmsggroupbox.ResumeLayout(false);
            this.sendmsggroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cangrid)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectbtn;
        private System.Windows.Forms.ListBox hiddeviceslistbox;
        private System.Windows.Forms.GroupBox hidconnectiongroupdbox;
        private System.Windows.Forms.Label pidlbl;
        private System.Windows.Forms.Label vidlbl;
        private System.Windows.Forms.TextBox pidtxtbox;
        private System.Windows.Forms.TextBox vidtxtbox;
        private System.Windows.Forms.GroupBox hiddevicegroupdbox;
        private System.Windows.Forms.Label setcanstatuslbl;
        private System.Windows.Forms.ComboBox canstatuscombobox;
        private System.Windows.Forms.Label canstatuslbl;
        private System.Windows.Forms.TextBox canstatustxtbox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statuslbl;
        private System.Windows.Forms.ListBox rawusblistbox;
        private System.Windows.Forms.Button recbtn;
        private System.Windows.Forms.DataGridView cangrid;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.CheckBox startupdatachckbox;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.TextBox byte2txtbox;
        private System.Windows.Forms.TextBox byte1txtbox;
        private System.Windows.Forms.TextBox canmessagelengthtxtbox;
        private System.Windows.Forms.TextBox canidtxtbox;
        private System.Windows.Forms.TextBox byte8txtbox;
        private System.Windows.Forms.TextBox byte7txtbox;
        private System.Windows.Forms.TextBox byte5txtbox;
        private System.Windows.Forms.TextBox byte6txtbox;
        private System.Windows.Forms.TextBox byte4txtbox;
        private System.Windows.Forms.TextBox byte3txtbox;
        private System.Windows.Forms.GroupBox sendmsggroupbox;
        private System.Windows.Forms.Label byte8lbl;
        private System.Windows.Forms.Label byte7lbl;
        private System.Windows.Forms.Label byte6lbl;
        private System.Windows.Forms.Label byte5lbl;
        private System.Windows.Forms.Label byte4lbl;
        private System.Windows.Forms.Label byte3lbl;
        private System.Windows.Forms.Label byte2lbl;
        private System.Windows.Forms.Label byte1lbl;
        private System.Windows.Forms.Label messagelengthlbl;
        private System.Windows.Forms.Label canidlbl;
        private System.Windows.Forms.Button sendrecordingbtn;
    }
}

