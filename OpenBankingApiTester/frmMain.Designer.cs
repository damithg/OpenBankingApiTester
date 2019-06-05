namespace OpenBankingApiTester
{
    partial class frmMain
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ofdPFX = new System.Windows.Forms.OpenFileDialog();
            this.pnlSelectQWAC = new System.Windows.Forms.Panel();
            this.cmdSelectQWAC = new System.Windows.Forms.Button();
            this.txtQWACDir = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtQSEALDir = new System.Windows.Forms.TextBox();
            this.cmdSelectQSEAL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRequestBody = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdSendRequest = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlSelectQWAC.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.pnlSelectQWAC);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(901, 62);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Certificates";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRequestBody);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtURL);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(901, 275);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Request";
            // 
            // ofdPFX
            // 
            this.ofdPFX.FileName = "PFX";
            this.ofdPFX.Filter = "Certificates (*.pfx)|*.pfx";
            // 
            // pnlSelectQWAC
            // 
            this.pnlSelectQWAC.Controls.Add(this.txtQWACDir);
            this.pnlSelectQWAC.Controls.Add(this.cmdSelectQWAC);
            this.pnlSelectQWAC.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSelectQWAC.Location = new System.Drawing.Point(3, 16);
            this.pnlSelectQWAC.Name = "pnlSelectQWAC";
            this.pnlSelectQWAC.Size = new System.Drawing.Size(895, 20);
            this.pnlSelectQWAC.TabIndex = 4;
            // 
            // cmdSelectQWAC
            // 
            this.cmdSelectQWAC.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdSelectQWAC.Location = new System.Drawing.Point(0, 0);
            this.cmdSelectQWAC.Name = "cmdSelectQWAC";
            this.cmdSelectQWAC.Size = new System.Drawing.Size(125, 20);
            this.cmdSelectQWAC.TabIndex = 3;
            this.cmdSelectQWAC.Text = "Select QWAC(TPP) pfx";
            this.cmdSelectQWAC.UseVisualStyleBackColor = true;
            this.cmdSelectQWAC.Click += new System.EventHandler(this.CmdSelectQWAC_Click);
            // 
            // txtQWACDir
            // 
            this.txtQWACDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQWACDir.Location = new System.Drawing.Point(125, 0);
            this.txtQWACDir.Name = "txtQWACDir";
            this.txtQWACDir.ReadOnly = true;
            this.txtQWACDir.Size = new System.Drawing.Size(770, 20);
            this.txtQWACDir.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtQSEALDir);
            this.panel1.Controls.Add(this.cmdSelectQSEAL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 20);
            this.panel1.TabIndex = 5;
            // 
            // txtQSEALDir
            // 
            this.txtQSEALDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQSEALDir.Location = new System.Drawing.Point(125, 0);
            this.txtQSEALDir.Name = "txtQSEALDir";
            this.txtQSEALDir.ReadOnly = true;
            this.txtQSEALDir.Size = new System.Drawing.Size(770, 20);
            this.txtQSEALDir.TabIndex = 4;
            // 
            // cmdSelectQSEAL
            // 
            this.cmdSelectQSEAL.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdSelectQSEAL.Location = new System.Drawing.Point(0, 0);
            this.cmdSelectQSEAL.Name = "cmdSelectQSEAL";
            this.cmdSelectQSEAL.Size = new System.Drawing.Size(125, 20);
            this.cmdSelectQSEAL.TabIndex = 3;
            this.cmdSelectQSEAL.Text = "Select QSEAL pfx";
            this.cmdSelectQSEAL.UseVisualStyleBackColor = true;
            this.cmdSelectQSEAL.Click += new System.EventHandler(this.CmdSelectQSEAL_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "URL :";
            // 
            // txtURL
            // 
            this.txtURL.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtURL.Location = new System.Drawing.Point(3, 29);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(895, 20);
            this.txtURL.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Body :";
            // 
            // txtRequestBody
            // 
            this.txtRequestBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRequestBody.Location = new System.Drawing.Point(3, 62);
            this.txtRequestBody.Multiline = true;
            this.txtRequestBody.Name = "txtRequestBody";
            this.txtRequestBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRequestBody.Size = new System.Drawing.Size(895, 210);
            this.txtRequestBody.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdSendRequest);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 337);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 46);
            this.panel2.TabIndex = 4;
            // 
            // cmdSendRequest
            // 
            this.cmdSendRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSendRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmdSendRequest.Location = new System.Drawing.Point(12, 7);
            this.cmdSendRequest.Name = "cmdSendRequest";
            this.cmdSendRequest.Size = new System.Drawing.Size(210, 33);
            this.cmdSendRequest.TabIndex = 0;
            this.cmdSendRequest.Text = "Send REQUEST";
            this.cmdSendRequest.UseVisualStyleBackColor = true;
            this.cmdSendRequest.Click += new System.EventHandler(this.CmdSendRequest_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtResponse);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 383);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(901, 220);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Response";
            // 
            // txtResponse
            // 
            this.txtResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResponse.Location = new System.Drawing.Point(3, 16);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ReadOnly = true;
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResponse.Size = new System.Drawing.Size(895, 201);
            this.txtResponse.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 603);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenBanking API Tester";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlSelectQWAC.ResumeLayout(false);
            this.pnlSelectQWAC.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtQSEALDir;
        private System.Windows.Forms.Button cmdSelectQSEAL;
        private System.Windows.Forms.Panel pnlSelectQWAC;
        private System.Windows.Forms.TextBox txtQWACDir;
        private System.Windows.Forms.Button cmdSelectQWAC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog ofdPFX;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRequestBody;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdSendRequest;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtResponse;
    }
}

