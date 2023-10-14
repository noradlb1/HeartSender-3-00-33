namespace HeartSender
{
	// Token: 0x0200001B RID: 27
	public partial class ManageSMTP : global::System.Windows.Forms.Form
	{
		// Token: 0x06000140 RID: 320 RVA: 0x0001D020 File Offset: 0x0001B220
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0001D040 File Offset: 0x0001B240
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::HeartSender.ManageSMTP));
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.txtMaxLimit = new global::System.Windows.Forms.TextBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.btnCheckIP = new global::System.Windows.Forms.Button();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.chkDirectDelivery = new global::System.Windows.Forms.CheckBox();
			this.txtToEmail = new global::System.Windows.Forms.TextBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.txtFromEmail = new global::System.Windows.Forms.TextBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.txtPassword = new global::System.Windows.Forms.TextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.txtUsername = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.chkSSL = new global::System.Windows.Forms.CheckBox();
			this.chkAuth = new global::System.Windows.Forms.CheckBox();
			this.btnAddSMTP = new global::System.Windows.Forms.Button();
			this.btnTest = new global::System.Windows.Forms.Button();
			this.ctrlNumPort = new global::System.Windows.Forms.NumericUpDown();
			this.label2 = new global::System.Windows.Forms.Label();
			this.txtHost = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.btnClear = new global::System.Windows.Forms.Button();
			this.btnDone = new global::System.Windows.Forms.Button();
			this.btnRemove = new global::System.Windows.Forms.Button();
			this.gridSMTPs = new global::System.Windows.Forms.DataGridView();
			this.Host = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Port = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Username = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Password = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Secure = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Limit = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Usage = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FromEmail = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnOnlineCheck = new global::System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.ctrlNumPort).BeginInit();
			this.groupBox3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.gridSMTPs).BeginInit();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.btnOnlineCheck);
			this.groupBox1.Controls.Add(this.txtMaxLimit);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.btnCheckIP);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.btnAddSMTP);
			this.groupBox1.Controls.Add(this.btnTest);
			this.groupBox1.Controls.Add(this.ctrlNumPort);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtHost);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new global::System.Drawing.Point(7, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(670, 231);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Add SMTP";
			this.txtMaxLimit.Location = new global::System.Drawing.Point(557, 20);
			this.txtMaxLimit.Name = "txtMaxLimit";
			this.txtMaxLimit.Size = new global::System.Drawing.Size(64, 20);
			this.txtMaxLimit.TabIndex = 17;
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(497, 22);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(54, 13);
			this.label7.TabIndex = 18;
			this.label7.Text = "Max Limit:";
			this.btnCheckIP.Image = (global::System.Drawing.Image)resources.GetObject("btnCheckIP.Image");
			this.btnCheckIP.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCheckIP.Location = new global::System.Drawing.Point(9, 182);
			this.btnCheckIP.Name = "btnCheckIP";
			this.btnCheckIP.Size = new global::System.Drawing.Size(111, 38);
			this.btnCheckIP.TabIndex = 9;
			this.btnCheckIP.Text = "   Check Your IP";
			this.btnCheckIP.UseVisualStyleBackColor = true;
			this.btnCheckIP.Click += new global::System.EventHandler(this.btnCheckIP_Click);
			this.groupBox2.Controls.Add(this.chkDirectDelivery);
			this.groupBox2.Controls.Add(this.txtToEmail);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.txtFromEmail);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.txtPassword);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.txtUsername);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.chkSSL);
			this.groupBox2.Controls.Add(this.chkAuth);
			this.groupBox2.Location = new global::System.Drawing.Point(9, 55);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(645, 121);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.chkDirectDelivery.AutoSize = true;
			this.chkDirectDelivery.ForeColor = global::System.Drawing.Color.Blue;
			this.chkDirectDelivery.Location = new global::System.Drawing.Point(83, 97);
			this.chkDirectDelivery.Name = "chkDirectDelivery";
			this.chkDirectDelivery.Size = new global::System.Drawing.Size(95, 17);
			this.chkDirectDelivery.TabIndex = 16;
			this.chkDirectDelivery.Text = "Direct Delivery";
			this.chkDirectDelivery.UseVisualStyleBackColor = true;
			this.chkDirectDelivery.CheckedChanged += new global::System.EventHandler(this.chkDirectDelivery_CheckedChanged);
			this.txtToEmail.Location = new global::System.Drawing.Point(421, 31);
			this.txtToEmail.Name = "txtToEmail";
			this.txtToEmail.Size = new global::System.Drawing.Size(191, 20);
			this.txtToEmail.TabIndex = 14;
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(361, 33);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(48, 13);
			this.label6.TabIndex = 15;
			this.label6.Text = "To Email";
			this.txtFromEmail.Location = new global::System.Drawing.Point(83, 31);
			this.txtFromEmail.Name = "txtFromEmail";
			this.txtFromEmail.Size = new global::System.Drawing.Size(191, 20);
			this.txtFromEmail.TabIndex = 12;
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(23, 34);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(58, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "From Email";
			this.txtPassword.Location = new global::System.Drawing.Point(421, 63);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new global::System.Drawing.Size(191, 20);
			this.txtPassword.TabIndex = 11;
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(361, 63);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(30, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Pass";
			this.txtUsername.Location = new global::System.Drawing.Point(83, 63);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new global::System.Drawing.Size(191, 20);
			this.txtUsername.TabIndex = 8;
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(25, 63);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(29, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "User";
			this.chkSSL.AutoSize = true;
			this.chkSSL.Location = new global::System.Drawing.Point(84, 0);
			this.chkSSL.Name = "chkSSL";
			this.chkSSL.Size = new global::System.Drawing.Size(77, 17);
			this.chkSSL.TabIndex = 9;
			this.chkSSL.Text = "SSL / TLS";
			this.chkSSL.UseVisualStyleBackColor = true;
			this.chkAuth.AutoSize = true;
			this.chkAuth.Checked = true;
			this.chkAuth.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.chkAuth.Location = new global::System.Drawing.Point(25, 0);
			this.chkAuth.Name = "chkAuth";
			this.chkAuth.Size = new global::System.Drawing.Size(48, 17);
			this.chkAuth.TabIndex = 8;
			this.chkAuth.Text = "Auth";
			this.chkAuth.UseVisualStyleBackColor = true;
			this.btnAddSMTP.Image = (global::System.Drawing.Image)resources.GetObject("btnAddSMTP.Image");
			this.btnAddSMTP.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAddSMTP.Location = new global::System.Drawing.Point(232, 182);
			this.btnAddSMTP.Name = "btnAddSMTP";
			this.btnAddSMTP.Size = new global::System.Drawing.Size(101, 38);
			this.btnAddSMTP.TabIndex = 6;
			this.btnAddSMTP.Text = "Add";
			this.btnAddSMTP.UseVisualStyleBackColor = true;
			this.btnAddSMTP.Click += new global::System.EventHandler(this.btnAddSMTP_Click);
			this.btnTest.Image = (global::System.Drawing.Image)resources.GetObject("btnTest.Image");
			this.btnTest.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTest.Location = new global::System.Drawing.Point(126, 182);
			this.btnTest.Name = "btnTest";
			this.btnTest.Size = new global::System.Drawing.Size(101, 38);
			this.btnTest.TabIndex = 5;
			this.btnTest.Text = "Test SMTP";
			this.btnTest.UseVisualStyleBackColor = true;
			this.btnTest.Click += new global::System.EventHandler(this.btnTest_Click);
			this.ctrlNumPort.Location = new global::System.Drawing.Point(430, 20);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.ctrlNumPort;
			int[] array = new int[4];
			array[0] = 9999999;
			numericUpDown.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.ctrlNumPort;
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Minimum = new decimal(array2);
			this.ctrlNumPort.Name = "ctrlNumPort";
			this.ctrlNumPort.Size = new global::System.Drawing.Size(58, 20);
			this.ctrlNumPort.TabIndex = 4;
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.ctrlNumPort;
			int[] array3 = new int[4];
			array3[0] = 587;
			numericUpDown3.Value = new decimal(array3);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(370, 20);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(38, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Port  : ";
			this.txtHost.Location = new global::System.Drawing.Point(92, 19);
			this.txtHost.Name = "txtHost";
			this.txtHost.Size = new global::System.Drawing.Size(191, 20);
			this.txtHost.TabIndex = 2;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(31, 20);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(41, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Host  : ";
			this.groupBox3.Controls.Add(this.btnClear);
			this.groupBox3.Controls.Add(this.btnDone);
			this.groupBox3.Controls.Add(this.btnRemove);
			this.groupBox3.Controls.Add(this.gridSMTPs);
			this.groupBox3.Location = new global::System.Drawing.Point(7, 245);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(670, 326);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "SMTP List";
			this.btnClear.Image = (global::System.Drawing.Image)resources.GetObject("btnClear.Image");
			this.btnClear.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClear.Location = new global::System.Drawing.Point(8, 280);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new global::System.Drawing.Size(112, 36);
			this.btnClear.TabIndex = 3;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new global::System.EventHandler(this.button5_Click);
			this.btnDone.Image = (global::System.Drawing.Image)resources.GetObject("btnDone.Image");
			this.btnDone.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDone.Location = new global::System.Drawing.Point(238, 280);
			this.btnDone.Name = "btnDone";
			this.btnDone.Size = new global::System.Drawing.Size(101, 36);
			this.btnDone.TabIndex = 2;
			this.btnDone.Text = "Done";
			this.btnDone.UseVisualStyleBackColor = true;
			this.btnDone.Click += new global::System.EventHandler(this.button4_Click);
			this.btnRemove.Image = (global::System.Drawing.Image)resources.GetObject("btnRemove.Image");
			this.btnRemove.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRemove.Location = new global::System.Drawing.Point(122, 280);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new global::System.Drawing.Size(112, 36);
			this.btnRemove.TabIndex = 1;
			this.btnRemove.Text = "  Remove Row";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new global::System.EventHandler(this.btnRemove_Click);
			this.gridSMTPs.AllowUserToAddRows = false;
			this.gridSMTPs.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridSMTPs.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.Host,
				this.Port,
				this.Username,
				this.Password,
				this.Secure,
				this.Limit,
				this.Usage,
				this.FromEmail
			});
			this.gridSMTPs.Location = new global::System.Drawing.Point(9, 18);
			this.gridSMTPs.Name = "gridSMTPs";
			this.gridSMTPs.RowHeadersWidth = 51;
			this.gridSMTPs.Size = new global::System.Drawing.Size(649, 256);
			this.gridSMTPs.TabIndex = 0;
			this.Host.HeaderText = "Host";
			this.Host.MinimumWidth = 6;
			this.Host.Name = "Host";
			this.Host.Width = 125;
			this.Port.HeaderText = "Port";
			this.Port.MinimumWidth = 6;
			this.Port.Name = "Port";
			this.Port.Width = 125;
			this.Username.HeaderText = "Username";
			this.Username.MinimumWidth = 6;
			this.Username.Name = "Username";
			this.Username.Width = 125;
			this.Password.HeaderText = "Password";
			this.Password.MinimumWidth = 6;
			this.Password.Name = "Password";
			this.Password.Width = 125;
			this.Secure.HeaderText = "Secure";
			this.Secure.MinimumWidth = 6;
			this.Secure.Name = "Secure";
			this.Secure.Width = 125;
			this.Limit.HeaderText = "Limit";
			this.Limit.Name = "Limit";
			this.Usage.HeaderText = "Usage";
			this.Usage.Name = "Usage";
			this.FromEmail.HeaderText = "FromEmail";
			this.FromEmail.Name = "FromEmail";
			this.btnOnlineCheck.BackColor = global::System.Drawing.Color.LimeGreen;
			this.btnOnlineCheck.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnOnlineCheck.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnOnlineCheck.Font = new global::System.Drawing.Font("Microsoft JhengHei", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnOnlineCheck.ForeColor = global::System.Drawing.Color.White;
			this.btnOnlineCheck.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOnlineCheck.Location = new global::System.Drawing.Point(548, 182);
			this.btnOnlineCheck.Name = "btnOnlineCheck";
			this.btnOnlineCheck.Size = new global::System.Drawing.Size(106, 38);
			this.btnOnlineCheck.TabIndex = 20;
			this.btnOnlineCheck.Text = "Check Online";
			this.btnOnlineCheck.UseVisualStyleBackColor = false;
			this.btnOnlineCheck.Click += new global::System.EventHandler(this.btnOnlineCheck_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(684, 576);
			base.Controls.Add(this.groupBox3);
			base.Controls.Add(this.groupBox1);
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ManageSMTP";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "HeartSender - Add / Edit SMTP";
			base.Load += new global::System.EventHandler(this.ManageSMTP_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.ctrlNumPort).EndInit();
			this.groupBox3.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.gridSMTPs).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040001A1 RID: 417
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040001A2 RID: 418
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040001A3 RID: 419
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040001A4 RID: 420
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040001A5 RID: 421
		private global::System.Windows.Forms.TextBox txtHost;

		// Token: 0x040001A6 RID: 422
		private global::System.Windows.Forms.NumericUpDown ctrlNumPort;

		// Token: 0x040001A7 RID: 423
		private global::System.Windows.Forms.Button btnAddSMTP;

		// Token: 0x040001A8 RID: 424
		private global::System.Windows.Forms.Button btnTest;

		// Token: 0x040001A9 RID: 425
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x040001AA RID: 426
		private global::System.Windows.Forms.CheckBox chkAuth;

		// Token: 0x040001AB RID: 427
		private global::System.Windows.Forms.CheckBox chkSSL;

		// Token: 0x040001AC RID: 428
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040001AD RID: 429
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040001AE RID: 430
		private global::System.Windows.Forms.TextBox txtUsername;

		// Token: 0x040001AF RID: 431
		private global::System.Windows.Forms.TextBox txtPassword;

		// Token: 0x040001B0 RID: 432
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x040001B1 RID: 433
		private global::System.Windows.Forms.DataGridView gridSMTPs;

		// Token: 0x040001B2 RID: 434
		private global::System.Windows.Forms.Button btnClear;

		// Token: 0x040001B3 RID: 435
		private global::System.Windows.Forms.Button btnDone;

		// Token: 0x040001B4 RID: 436
		private global::System.Windows.Forms.Button btnRemove;

		// Token: 0x040001B5 RID: 437
		private global::System.Windows.Forms.Button btnCheckIP;

		// Token: 0x040001B6 RID: 438
		private global::System.Windows.Forms.TextBox txtToEmail;

		// Token: 0x040001B7 RID: 439
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040001B8 RID: 440
		private global::System.Windows.Forms.TextBox txtFromEmail;

		// Token: 0x040001B9 RID: 441
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040001BA RID: 442
		private global::System.Windows.Forms.CheckBox chkDirectDelivery;

		// Token: 0x040001BB RID: 443
		private global::System.Windows.Forms.TextBox txtMaxLimit;

		// Token: 0x040001BC RID: 444
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040001BD RID: 445
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Host;

		// Token: 0x040001BE RID: 446
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Port;

		// Token: 0x040001BF RID: 447
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Username;

		// Token: 0x040001C0 RID: 448
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Password;

		// Token: 0x040001C1 RID: 449
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Secure;

		// Token: 0x040001C2 RID: 450
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Limit;

		// Token: 0x040001C3 RID: 451
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Usage;

		// Token: 0x040001C4 RID: 452
		private global::System.Windows.Forms.DataGridViewTextBoxColumn FromEmail;

		// Token: 0x040001C5 RID: 453
		private global::System.Windows.Forms.Button btnOnlineCheck;
	}
}
