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
            this.pidlbl = new System.Windows.Forms.Label();
            this.vidlbl = new System.Windows.Forms.Label();
            this.pidtxtbox = new System.Windows.Forms.TextBox();
            this.vidtxtbox = new System.Windows.Forms.TextBox();
            this.hiddevicegroupdbox = new System.Windows.Forms.GroupBox();
            this.cangrid = new System.Windows.Forms.DataGridView();
            this.recbtn = new System.Windows.Forms.Button();
            this.rawusblistbox = new System.Windows.Forms.ListBox();
            this.setcanstatuslbl = new System.Windows.Forms.Label();
            this.canstatuscombobox = new System.Windows.Forms.ComboBox();
            this.canstatuslbl = new System.Windows.Forms.Label();
            this.canstatustxtbox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statuslbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.startupdatachckbox = new System.Windows.Forms.CheckBox();
            this.hidconnectiongroupdbox.SuspendLayout();
            this.hiddevicegroupdbox.SuspendLayout();
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
            this.hiddeviceslistbox.Size = new System.Drawing.Size(837, 82);
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
            this.hiddevicegroupdbox.Controls.Add(this.cangrid);
            this.hiddevicegroupdbox.Controls.Add(this.recbtn);
            this.hiddevicegroupdbox.Controls.Add(this.hidconnectiongroupdbox);
            this.hiddevicegroupdbox.Controls.Add(this.rawusblistbox);
            this.hiddevicegroupdbox.Controls.Add(this.setcanstatuslbl);
            this.hiddevicegroupdbox.Controls.Add(this.canstatuscombobox);
            this.hiddevicegroupdbox.Controls.Add(this.canstatuslbl);
            this.hiddevicegroupdbox.Controls.Add(this.canstatustxtbox);
            this.hiddevicegroupdbox.Location = new System.Drawing.Point(12, 96);
            this.hiddevicegroupdbox.Name = "hiddevicegroupdbox";
            this.hiddevicegroupdbox.Size = new System.Drawing.Size(837, 327);
            this.hiddevicegroupdbox.TabIndex = 3;
            this.hiddevicegroupdbox.TabStop = false;
            this.hiddevicegroupdbox.Text = "MCP2515DM-BM";
            // 
            // cangrid
            // 
            this.cangrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cangrid.Location = new System.Drawing.Point(379, 19);
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
            this.rawusblistbox.Location = new System.Drawing.Point(112, 19);
            this.rawusblistbox.Name = "rawusblistbox";
            this.rawusblistbox.Size = new System.Drawing.Size(233, 134);
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
            this.canstatuscombobox.Size = new System.Drawing.Size(121, 21);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 431);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(864, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statuslbl
            // 
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(0, 17);
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
            // startupdatachckbox
            // 
            this.startupdatachckbox.AutoSize = true;
            this.startupdatachckbox.Checked = true;
            this.startupdatachckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.startupdatachckbox.Location = new System.Drawing.Point(12, 100);
            this.startupdatachckbox.Name = "startupdatachckbox";
            this.startupdatachckbox.Size = new System.Drawing.Size(84, 17);
            this.startupdatachckbox.TabIndex = 9;
            this.startupdatachckbox.Text = "Start comms";
            this.startupdatachckbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 453);
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
    }
}

