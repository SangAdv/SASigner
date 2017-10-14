namespace SASigner
{
	partial class frmSigner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSigner));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbFiles = new System.Windows.Forms.GroupBox();
            this.btnFileRemove = new System.Windows.Forms.Button();
            this.btnFileClear = new System.Windows.Forms.Button();
            this.btnFileAdd = new System.Windows.Forms.Button();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnSign = new System.Windows.Forms.Button();
            this.gbCertificate = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCertificatePassword = new System.Windows.Forms.TextBox();
            this.btnCertificate = new System.Windows.Forms.Button();
            this.lblCertificatePath = new System.Windows.Forms.Label();
            this.gbTimeStamp = new System.Windows.Forms.GroupBox();
            this.cmbTimeStampServer = new System.Windows.Forms.ComboBox();
            this.chkTimeStamping = new System.Windows.Forms.CheckBox();
            this.gbSign = new System.Windows.Forms.GroupBox();
            this.btnSignToolPath = new System.Windows.Forms.Button();
            this.lblSignToolPath = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.chkDetailOutput = new System.Windows.Forms.CheckBox();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.ofDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbFiles.SuspendLayout();
            this.gbCertificate.SuspendLayout();
            this.gbTimeStamp.SuspendLayout();
            this.gbSign.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1064, 532);
            this.splitContainer1.SplitterDistance = 540;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbFiles);
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.btnSign);
            this.panel1.Controls.Add(this.gbCertificate);
            this.panel1.Controls.Add(this.gbTimeStamp);
            this.panel1.Controls.Add(this.gbSign);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 532);
            this.panel1.TabIndex = 0;
            // 
            // gbFiles
            // 
            this.gbFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiles.Controls.Add(this.btnFileRemove);
            this.gbFiles.Controls.Add(this.btnFileClear);
            this.gbFiles.Controls.Add(this.btnFileAdd);
            this.gbFiles.Controls.Add(this.lstFiles);
            this.gbFiles.Location = new System.Drawing.Point(10, 227);
            this.gbFiles.Name = "gbFiles";
            this.gbFiles.Size = new System.Drawing.Size(521, 264);
            this.gbFiles.TabIndex = 15;
            this.gbFiles.TabStop = false;
            this.gbFiles.Text = "Files";
            // 
            // btnFileRemove
            // 
            this.btnFileRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFileRemove.Location = new System.Drawing.Point(356, 235);
            this.btnFileRemove.Name = "btnFileRemove";
            this.btnFileRemove.Size = new System.Drawing.Size(75, 23);
            this.btnFileRemove.TabIndex = 3;
            this.btnFileRemove.Text = "Remove";
            this.btnFileRemove.UseVisualStyleBackColor = true;
            this.btnFileRemove.Click += new System.EventHandler(this.btnFileRemove_Click);
            // 
            // btnFileClear
            // 
            this.btnFileClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFileClear.Location = new System.Drawing.Point(437, 235);
            this.btnFileClear.Name = "btnFileClear";
            this.btnFileClear.Size = new System.Drawing.Size(75, 23);
            this.btnFileClear.TabIndex = 2;
            this.btnFileClear.Text = "Clear";
            this.btnFileClear.UseVisualStyleBackColor = true;
            this.btnFileClear.Click += new System.EventHandler(this.btnFileClear_Click);
            // 
            // btnFileAdd
            // 
            this.btnFileAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFileAdd.Location = new System.Drawing.Point(6, 235);
            this.btnFileAdd.Name = "btnFileAdd";
            this.btnFileAdd.Size = new System.Drawing.Size(75, 23);
            this.btnFileAdd.TabIndex = 1;
            this.btnFileAdd.Text = "Add";
            this.btnFileAdd.UseVisualStyleBackColor = true;
            this.btnFileAdd.Click += new System.EventHandler(this.btnFileAdd_Click);
            // 
            // lstFiles
            // 
            this.lstFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(6, 15);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstFiles.Size = new System.Drawing.Size(506, 212);
            this.lstFiles.Sorted = true;
            this.lstFiles.TabIndex = 0;
            this.lstFiles.Click += new System.EventHandler(this.lstFiles_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Location = new System.Drawing.Point(456, 497);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 14;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(110, 502);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(65, 13);
            this.lblMessage.TabIndex = 13;
            this.lblMessage.Text = "lblMessage";
            // 
            // btnSign
            // 
            this.btnSign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSign.Location = new System.Drawing.Point(10, 497);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(75, 23);
            this.btnSign.TabIndex = 12;
            this.btnSign.Text = "Sign";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // gbCertificate
            // 
            this.gbCertificate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCertificate.Controls.Add(this.label1);
            this.gbCertificate.Controls.Add(this.txtCertificatePassword);
            this.gbCertificate.Controls.Add(this.btnCertificate);
            this.gbCertificate.Controls.Add(this.lblCertificatePath);
            this.gbCertificate.Location = new System.Drawing.Point(10, 129);
            this.gbCertificate.Name = "gbCertificate";
            this.gbCertificate.Size = new System.Drawing.Size(521, 92);
            this.gbCertificate.TabIndex = 7;
            this.gbCertificate.TabStop = false;
            this.gbCertificate.Text = "Certificate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password:";
            // 
            // txtCertificatePassword
            // 
            this.txtCertificatePassword.Location = new System.Drawing.Point(71, 63);
            this.txtCertificatePassword.Name = "txtCertificatePassword";
            this.txtCertificatePassword.Size = new System.Drawing.Size(144, 22);
            this.txtCertificatePassword.TabIndex = 5;
            this.txtCertificatePassword.UseSystemPasswordChar = true;
            this.txtCertificatePassword.TextChanged += new System.EventHandler(this.txtCertificatePassword_TextChanged);
            // 
            // btnCertificate
            // 
            this.btnCertificate.Location = new System.Drawing.Point(6, 21);
            this.btnCertificate.Name = "btnCertificate";
            this.btnCertificate.Size = new System.Drawing.Size(75, 23);
            this.btnCertificate.TabIndex = 4;
            this.btnCertificate.Text = "Browse";
            this.btnCertificate.UseVisualStyleBackColor = true;
            this.btnCertificate.Click += new System.EventHandler(this.btnCertificate_Click);
            // 
            // lblCertificatePath
            // 
            this.lblCertificatePath.AutoSize = true;
            this.lblCertificatePath.Location = new System.Drawing.Point(6, 47);
            this.lblCertificatePath.Name = "lblCertificatePath";
            this.lblCertificatePath.Size = new System.Drawing.Size(95, 13);
            this.lblCertificatePath.TabIndex = 3;
            this.lblCertificatePath.Text = "lblCertificatePath";
            // 
            // gbTimeStamp
            // 
            this.gbTimeStamp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTimeStamp.Controls.Add(this.cmbTimeStampServer);
            this.gbTimeStamp.Controls.Add(this.chkTimeStamping);
            this.gbTimeStamp.Location = new System.Drawing.Point(10, 79);
            this.gbTimeStamp.Name = "gbTimeStamp";
            this.gbTimeStamp.Size = new System.Drawing.Size(521, 44);
            this.gbTimeStamp.TabIndex = 6;
            this.gbTimeStamp.TabStop = false;
            this.gbTimeStamp.Text = "Time Stamping";
            // 
            // cmbTimeStampServer
            // 
            this.cmbTimeStampServer.FormattingEnabled = true;
            this.cmbTimeStampServer.Location = new System.Drawing.Point(149, 17);
            this.cmbTimeStampServer.Name = "cmbTimeStampServer";
            this.cmbTimeStampServer.Size = new System.Drawing.Size(174, 21);
            this.cmbTimeStampServer.TabIndex = 4;
            this.cmbTimeStampServer.SelectedIndexChanged += new System.EventHandler(this.cmbTimeStampServer_SelectedIndexChanged);
            // 
            // chkTimeStamping
            // 
            this.chkTimeStamping.AutoSize = true;
            this.chkTimeStamping.Checked = true;
            this.chkTimeStamping.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTimeStamping.Location = new System.Drawing.Point(6, 21);
            this.chkTimeStamping.Name = "chkTimeStamping";
            this.chkTimeStamping.Size = new System.Drawing.Size(140, 17);
            this.chkTimeStamping.TabIndex = 3;
            this.chkTimeStamping.Text = "Enable time stamping:";
            this.chkTimeStamping.UseVisualStyleBackColor = true;
            this.chkTimeStamping.CheckedChanged += new System.EventHandler(this.chkTimeStamping_CheckedChanged);
            // 
            // gbSign
            // 
            this.gbSign.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSign.Controls.Add(this.btnSignToolPath);
            this.gbSign.Controls.Add(this.lblSignToolPath);
            this.gbSign.Location = new System.Drawing.Point(10, 5);
            this.gbSign.Name = "gbSign";
            this.gbSign.Size = new System.Drawing.Size(521, 68);
            this.gbSign.TabIndex = 5;
            this.gbSign.TabStop = false;
            this.gbSign.Text = "Sign Tool";
            // 
            // btnSignToolPath
            // 
            this.btnSignToolPath.Location = new System.Drawing.Point(6, 21);
            this.btnSignToolPath.Name = "btnSignToolPath";
            this.btnSignToolPath.Size = new System.Drawing.Size(75, 23);
            this.btnSignToolPath.TabIndex = 2;
            this.btnSignToolPath.Text = "Browse";
            this.btnSignToolPath.UseVisualStyleBackColor = true;
            this.btnSignToolPath.Click += new System.EventHandler(this.btnSignToolPath_Click);
            // 
            // lblSignToolPath
            // 
            this.lblSignToolPath.AutoSize = true;
            this.lblSignToolPath.Location = new System.Drawing.Point(3, 47);
            this.lblSignToolPath.Name = "lblSignToolPath";
            this.lblSignToolPath.Size = new System.Drawing.Size(87, 13);
            this.lblSignToolPath.TabIndex = 1;
            this.lblSignToolPath.Text = "lblSignToolPath";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gbOutput);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(520, 532);
            this.panel2.TabIndex = 0;
            // 
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.chkDetailOutput);
            this.gbOutput.Controls.Add(this.lstOutput);
            this.gbOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOutput.Location = new System.Drawing.Point(5, 5);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(510, 522);
            this.gbOutput.TabIndex = 9;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "Output";
            // 
            // chkDetailOutput
            // 
            this.chkDetailOutput.AutoSize = true;
            this.chkDetailOutput.Checked = true;
            this.chkDetailOutput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDetailOutput.Location = new System.Drawing.Point(6, 17);
            this.chkDetailOutput.Name = "chkDetailOutput";
            this.chkDetailOutput.Size = new System.Drawing.Size(147, 17);
            this.chkDetailOutput.TabIndex = 4;
            this.chkDetailOutput.Text = "Display detailed output";
            this.chkDetailOutput.UseVisualStyleBackColor = true;
            this.chkDetailOutput.CheckedChanged += new System.EventHandler(this.chkDetailOutput_CheckedChanged);
            // 
            // lstOutput
            // 
            this.lstOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(6, 39);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstOutput.Size = new System.Drawing.Size(498, 472);
            this.lstOutput.TabIndex = 0;
            // 
            // ofDialog
            // 
            this.ofDialog.FileName = "openFileDialog1";
            // 
            // frmSigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 532);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSigner";
            this.Text = "SASigner";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbFiles.ResumeLayout(false);
            this.gbCertificate.ResumeLayout(false);
            this.gbCertificate.PerformLayout();
            this.gbTimeStamp.ResumeLayout(false);
            this.gbTimeStamp.PerformLayout();
            this.gbSign.ResumeLayout(false);
            this.gbSign.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.gbOutput.ResumeLayout(false);
            this.gbOutput.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.GroupBox gbOutput;
		private System.Windows.Forms.CheckBox chkDetailOutput;
		private System.Windows.Forms.ListBox lstOutput;
		private System.Windows.Forms.GroupBox gbSign;
		private System.Windows.Forms.Button btnSignToolPath;
		private System.Windows.Forms.Label lblSignToolPath;
		private System.Windows.Forms.GroupBox gbTimeStamp;
		private System.Windows.Forms.CheckBox chkTimeStamping;
		private System.Windows.Forms.GroupBox gbCertificate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCertificatePassword;
		private System.Windows.Forms.Button btnCertificate;
		private System.Windows.Forms.Label lblCertificatePath;
		private System.Windows.Forms.Button btnAbout;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.Button btnSign;
		private System.Windows.Forms.GroupBox gbFiles;
		private System.Windows.Forms.Button btnFileRemove;
		private System.Windows.Forms.Button btnFileClear;
		private System.Windows.Forms.Button btnFileAdd;
		private System.Windows.Forms.ListBox lstFiles;
		private System.Windows.Forms.OpenFileDialog ofDialog;
        private System.Windows.Forms.ComboBox cmbTimeStampServer;
    }
}