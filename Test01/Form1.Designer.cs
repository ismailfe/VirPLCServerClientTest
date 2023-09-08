namespace VirPLCServerClientTest
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStopServer = new System.Windows.Forms.Button();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.txtStsServer = new System.Windows.Forms.TextBox();
            this.txtIPServer = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtStsClient = new System.Windows.Forms.TextBox();
            this.numVal = new System.Windows.Forms.NumericUpDown();
            this.numBitAdd = new System.Windows.Forms.NumericUpDown();
            this.numOffset = new System.Windows.Forms.NumericUpDown();
            this.numDBno = new System.Windows.Forms.NumericUpDown();
            this.numOffsetAdd = new System.Windows.Forms.NumericUpDown();
            this.numDbNoAdd = new System.Windows.Forms.NumericUpDown();
            this.cboxValType = new System.Windows.Forms.ComboBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnClientWriteData = new System.Windows.Forms.Button();
            this.btnStopClient = new System.Windows.Forms.Button();
            this.btnClientStart = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBitAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDBno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOffsetAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDbNoAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnStopServer);
            this.groupBox1.Controls.Add(this.btnStartServer);
            this.groupBox1.Controls.Add(this.txtStsServer);
            this.groupBox1.Controls.Add(this.txtIPServer);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Virtual PLC (Server)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP Addr:";
            // 
            // btnStopServer
            // 
            this.btnStopServer.Enabled = false;
            this.btnStopServer.Location = new System.Drawing.Point(206, 19);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(60, 23);
            this.btnStopServer.TabIndex = 1;
            this.btnStopServer.Text = "STOP";
            this.btnStopServer.UseVisualStyleBackColor = true;
            this.btnStopServer.Click += new System.EventHandler(this.btnStopServer_Click);
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(147, 19);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(60, 23);
            this.btnStartServer.TabIndex = 1;
            this.btnStartServer.Text = "START";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // txtStsServer
            // 
            this.txtStsServer.Enabled = false;
            this.txtStsServer.Location = new System.Drawing.Point(6, 47);
            this.txtStsServer.Name = "txtStsServer";
            this.txtStsServer.ReadOnly = true;
            this.txtStsServer.Size = new System.Drawing.Size(252, 20);
            this.txtStsServer.TabIndex = 0;
            // 
            // txtIPServer
            // 
            this.txtIPServer.Location = new System.Drawing.Point(57, 21);
            this.txtIPServer.Name = "txtIPServer";
            this.txtIPServer.Size = new System.Drawing.Size(91, 20);
            this.txtIPServer.TabIndex = 0;
            this.txtIPServer.Text = "192.168.1.101";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtStsClient);
            this.groupBox2.Controls.Add(this.numVal);
            this.groupBox2.Controls.Add(this.numBitAdd);
            this.groupBox2.Controls.Add(this.numOffset);
            this.groupBox2.Controls.Add(this.numDBno);
            this.groupBox2.Controls.Add(this.numOffsetAdd);
            this.groupBox2.Controls.Add(this.numDbNoAdd);
            this.groupBox2.Controls.Add(this.cboxValType);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Controls.Add(this.btnClientWriteData);
            this.groupBox2.Controls.Add(this.btnStopClient);
            this.groupBox2.Controls.Add(this.btnClientStart);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(308, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 512);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Read System (Client)";
            // 
            // txtStsClient
            // 
            this.txtStsClient.Enabled = false;
            this.txtStsClient.Location = new System.Drawing.Point(9, 38);
            this.txtStsClient.Name = "txtStsClient";
            this.txtStsClient.ReadOnly = true;
            this.txtStsClient.Size = new System.Drawing.Size(288, 20);
            this.txtStsClient.TabIndex = 3;
            // 
            // numVal
            // 
            this.numVal.Location = new System.Drawing.Point(171, 86);
            this.numVal.Name = "numVal";
            this.numVal.Size = new System.Drawing.Size(66, 20);
            this.numVal.TabIndex = 7;
            this.numVal.Value = new decimal(new int[] {
            55,
            0,
            0,
            0});
            // 
            // numBitAdd
            // 
            this.numBitAdd.Location = new System.Drawing.Point(125, 162);
            this.numBitAdd.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numBitAdd.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numBitAdd.Name = "numBitAdd";
            this.numBitAdd.Size = new System.Drawing.Size(51, 20);
            this.numBitAdd.TabIndex = 7;
            this.numBitAdd.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numOffset
            // 
            this.numOffset.Location = new System.Drawing.Point(114, 86);
            this.numOffset.Name = "numOffset";
            this.numOffset.Size = new System.Drawing.Size(51, 20);
            this.numOffset.TabIndex = 7;
            // 
            // numDBno
            // 
            this.numDBno.Location = new System.Drawing.Point(56, 86);
            this.numDBno.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDBno.Name = "numDBno";
            this.numDBno.Size = new System.Drawing.Size(51, 20);
            this.numDBno.TabIndex = 7;
            this.numDBno.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numOffsetAdd
            // 
            this.numOffsetAdd.Location = new System.Drawing.Point(68, 162);
            this.numOffsetAdd.Name = "numOffsetAdd";
            this.numOffsetAdd.Size = new System.Drawing.Size(51, 20);
            this.numOffsetAdd.TabIndex = 7;
            // 
            // numDbNoAdd
            // 
            this.numDbNoAdd.Location = new System.Drawing.Point(10, 162);
            this.numDbNoAdd.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDbNoAdd.Name = "numDbNoAdd";
            this.numDbNoAdd.Size = new System.Drawing.Size(51, 20);
            this.numDbNoAdd.TabIndex = 7;
            // 
            // cboxValType
            // 
            this.cboxValType.FormattingEnabled = true;
            this.cboxValType.Location = new System.Drawing.Point(182, 162);
            this.cboxValType.Name = "cboxValType";
            this.cboxValType.Size = new System.Drawing.Size(67, 21);
            this.cboxValType.TabIndex = 6;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(10, 188);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(313, 303);
            this.listBox2.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(143, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Bit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(77, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Offset";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Val";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "DBNo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Offset";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "DBNo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Oku";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yaz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP Addr:";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(255, 160);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(68, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnClientWriteData
            // 
            this.btnClientWriteData.Enabled = false;
            this.btnClientWriteData.Location = new System.Drawing.Point(243, 84);
            this.btnClientWriteData.Name = "btnClientWriteData";
            this.btnClientWriteData.Size = new System.Drawing.Size(75, 23);
            this.btnClientWriteData.TabIndex = 1;
            this.btnClientWriteData.Text = "Yaz";
            this.btnClientWriteData.UseVisualStyleBackColor = true;
            this.btnClientWriteData.Click += new System.EventHandler(this.btnClientWriteData_Click);
            // 
            // btnStopClient
            // 
            this.btnStopClient.Enabled = false;
            this.btnStopClient.Location = new System.Drawing.Point(237, 14);
            this.btnStopClient.Name = "btnStopClient";
            this.btnStopClient.Size = new System.Drawing.Size(60, 23);
            this.btnStopClient.TabIndex = 1;
            this.btnStopClient.Text = "STOP";
            this.btnStopClient.UseVisualStyleBackColor = true;
            this.btnStopClient.Click += new System.EventHandler(this.btnStopClient_Click);
            // 
            // btnClientStart
            // 
            this.btnClientStart.Location = new System.Drawing.Point(171, 14);
            this.btnClientStart.Name = "btnClientStart";
            this.btnClientStart.Size = new System.Drawing.Size(60, 23);
            this.btnClientStart.TabIndex = 1;
            this.btnClientStart.Text = "START";
            this.btnClientStart.UseVisualStyleBackColor = true;
            this.btnClientStart.Click += new System.EventHandler(this.btnClientStart_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(57, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(108, 20);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "192.168.1.101";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 536);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "VirPLCServerClientTest";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBitAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDBno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOffsetAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDbNoAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.TextBox txtIPServer;
        private System.Windows.Forms.Button btnClientStart;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStsServer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClientWriteData;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboxValType;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numVal;
        private System.Windows.Forms.NumericUpDown numBitAdd;
        private System.Windows.Forms.NumericUpDown numOffset;
        private System.Windows.Forms.NumericUpDown numDBno;
        private System.Windows.Forms.NumericUpDown numOffsetAdd;
        private System.Windows.Forms.NumericUpDown numDbNoAdd;
        private System.Windows.Forms.TextBox txtStsClient;
        private System.Windows.Forms.Button btnStopServer;
        private System.Windows.Forms.Button btnStopClient;
    }
}

