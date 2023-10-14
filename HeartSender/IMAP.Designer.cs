namespace HeartSender
{
	// Token: 0x02000018 RID: 24
	public partial class IMAP : global::System.Windows.Forms.Form
	{
		// Token: 0x060000C4 RID: 196 RVA: 0x0000F472 File Offset: 0x0000D672
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000F494 File Offset: 0x0000D694
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::HeartSender.IMAP));
			this.gridIMAPEmails = new global::System.Windows.Forms.DataGridView();
			this.Email = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.btnImport = new global::System.Windows.Forms.Button();
			this.btnAddSMTP = new global::System.Windows.Forms.Button();
			this.btnCheckIP = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.txtLimit = new global::System.Windows.Forms.TextBox();
			this.ntbPort = new global::System.Windows.Forms.NumericUpDown();
			this.radioButton2 = new global::System.Windows.Forms.RadioButton();
			this.rbSSL = new global::System.Windows.Forms.RadioButton();
			this.lbImap = new global::System.Windows.Forms.Label();
			this.lbPassword = new global::System.Windows.Forms.Label();
			this.lbUserName = new global::System.Windows.Forms.Label();
			this.lbPort = new global::System.Windows.Forms.Label();
			this.txtImap = new global::System.Windows.Forms.TextBox();
			this.txtPassword = new global::System.Windows.Forms.TextBox();
			this.txtUsername = new global::System.Windows.Forms.TextBox();
			this.btnStart = new global::System.Windows.Forms.Button();
			this.btnStop = new global::System.Windows.Forms.Button();
			this.btnSave = new global::System.Windows.Forms.Button();
			this.gridIMAPAccounts = new global::System.Windows.Forms.DataGridView();
			this.IMAPServer = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Password = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Port = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SSL = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Limit = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.btnClear = new global::System.Windows.Forms.Button();
			this.btnRemove = new global::System.Windows.Forms.Button();
			this.btnRmDpl = new global::System.Windows.Forms.Button();
			this.btnClose = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.gridIMAPEmails).BeginInit();
			this.groupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.ntbPort).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.gridIMAPAccounts).BeginInit();
			base.SuspendLayout();
			this.gridIMAPEmails.AllowUserToAddRows = false;
			this.gridIMAPEmails.AllowUserToDeleteRows = false;
			this.gridIMAPEmails.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridIMAPEmails.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.Email
			});
			this.gridIMAPEmails.Location = new global::System.Drawing.Point(7, 42);
			this.gridIMAPEmails.Margin = new global::System.Windows.Forms.Padding(4);
			this.gridIMAPEmails.Name = "gridIMAPEmails";
			this.gridIMAPEmails.RowHeadersWidth = 51;
			this.gridIMAPEmails.Size = new global::System.Drawing.Size(393, 438);
			this.gridIMAPEmails.TabIndex = 0;
			this.Email.HeaderText = "Email";
			this.Email.MinimumWidth = 6;
			this.Email.Name = "Email";
			this.Email.Width = 250;
			this.groupBox1.Controls.Add(this.btnImport);
			this.groupBox1.Controls.Add(this.btnAddSMTP);
			this.groupBox1.Controls.Add(this.btnCheckIP);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtLimit);
			this.groupBox1.Controls.Add(this.ntbPort);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.rbSSL);
			this.groupBox1.Controls.Add(this.lbImap);
			this.groupBox1.Controls.Add(this.lbPassword);
			this.groupBox1.Controls.Add(this.lbUserName);
			this.groupBox1.Controls.Add(this.lbPort);
			this.groupBox1.Controls.Add(this.txtImap);
			this.groupBox1.Controls.Add(this.txtPassword);
			this.groupBox1.Controls.Add(this.txtUsername);
			this.groupBox1.Location = new global::System.Drawing.Point(408, 5);
			this.groupBox1.Margin = new global::System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new global::System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new global::System.Drawing.Size(677, 206);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.btnImport.Image = (global::System.Drawing.Image)resources.GetObject("btnImport.Image");
			this.btnImport.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnImport.Location = new global::System.Drawing.Point(349, 159);
			this.btnImport.Margin = new global::System.Windows.Forms.Padding(4);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new global::System.Drawing.Size(100, 41);
			this.btnImport.TabIndex = 87;
			this.btnImport.Text = "Import";
			this.btnImport.UseVisualStyleBackColor = true;
			this.btnImport.Click += new global::System.EventHandler(this.btnImport_Click);
			this.btnAddSMTP.Image = (global::System.Drawing.Image)resources.GetObject("btnAddSMTP.Image");
			this.btnAddSMTP.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAddSMTP.Location = new global::System.Drawing.Point(239, 159);
			this.btnAddSMTP.Margin = new global::System.Windows.Forms.Padding(4);
			this.btnAddSMTP.Name = "btnAddSMTP";
			this.btnAddSMTP.Size = new global::System.Drawing.Size(103, 41);
			this.btnAddSMTP.TabIndex = 86;
			this.btnAddSMTP.Text = "Add";
			this.btnAddSMTP.UseVisualStyleBackColor = true;
			this.btnAddSMTP.Click += new global::System.EventHandler(this.btnAddSMTP_Click);
			this.btnCheckIP.Image = (global::System.Drawing.Image)resources.GetObject("btnCheckIP.Image");
			this.btnCheckIP.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCheckIP.Location = new global::System.Drawing.Point(131, 159);
			this.btnCheckIP.Margin = new global::System.Windows.Forms.Padding(4);
			this.btnCheckIP.Name = "btnCheckIP";
			this.btnCheckIP.Size = new global::System.Drawing.Size(100, 41);
			this.btnCheckIP.TabIndex = 84;
			this.btnCheckIP.Text = "   Check";
			this.btnCheckIP.UseVisualStyleBackColor = true;
			this.btnCheckIP.Click += new global::System.EventHandler(this.btnCheckIP_Click);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft JhengHei", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(339, 85);
			this.label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(48, 18);
			this.label2.TabIndex = 77;
			this.label2.Text = "Limit :";
			this.txtLimit.BackColor = global::System.Drawing.Color.FromArgb(246, 248, 249);
			this.txtLimit.Font = new global::System.Drawing.Font("Microsoft JhengHei", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtLimit.ForeColor = global::System.Drawing.Color.FromArgb(68, 77, 101);
			this.txtLimit.Location = new global::System.Drawing.Point(431, 80);
			this.txtLimit.Margin = new global::System.Windows.Forms.Padding(4);
			this.txtLimit.Name = "txtLimit";
			this.txtLimit.Size = new global::System.Drawing.Size(237, 32);
			this.txtLimit.TabIndex = 76;
			this.txtLimit.Text = "0";
			this.ntbPort.BackColor = global::System.Drawing.Color.FromArgb(246, 248, 249);
			this.ntbPort.Font = new global::System.Drawing.Font("Microsoft JhengHei", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ntbPort.Location = new global::System.Drawing.Point(132, 81);
			this.ntbPort.Margin = new global::System.Windows.Forms.Padding(4);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.ntbPort;
			int[] array = new int[4];
			array[0] = 9999999;
			numericUpDown.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.ntbPort;
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Minimum = new decimal(array2);
			this.ntbPort.Name = "ntbPort";
			this.ntbPort.Size = new global::System.Drawing.Size(196, 27);
			this.ntbPort.TabIndex = 75;
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.ntbPort;
			int[] array3 = new int[4];
			array3[0] = 993;
			numericUpDown3.Value = new decimal(array3);
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new global::System.Drawing.Point(80, 0);
			this.radioButton2.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new global::System.Drawing.Size(63, 21);
			this.radioButton2.TabIndex = 54;
			this.radioButton2.Text = "None";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.rbSSL.AutoSize = true;
			this.rbSSL.Checked = true;
			this.rbSSL.Location = new global::System.Drawing.Point(12, 0);
			this.rbSSL.Margin = new global::System.Windows.Forms.Padding(4);
			this.rbSSL.Name = "rbSSL";
			this.rbSSL.Size = new global::System.Drawing.Size(55, 21);
			this.rbSSL.TabIndex = 53;
			this.rbSSL.TabStop = true;
			this.rbSSL.Text = "SSL";
			this.rbSSL.UseVisualStyleBackColor = true;
			this.lbImap.AutoSize = true;
			this.lbImap.Font = new global::System.Drawing.Font("Microsoft JhengHei", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lbImap.Location = new global::System.Drawing.Point(16, 126);
			this.lbImap.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbImap.Name = "lbImap";
			this.lbImap.Size = new global::System.Drawing.Size(96, 18);
			this.lbImap.TabIndex = 48;
			this.lbImap.Text = "IMAP Server :";
			this.lbPassword.AutoSize = true;
			this.lbPassword.Font = new global::System.Drawing.Font("Microsoft JhengHei", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lbPassword.Location = new global::System.Drawing.Point(339, 41);
			this.lbPassword.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbPassword.Name = "lbPassword";
			this.lbPassword.Size = new global::System.Drawing.Size(77, 18);
			this.lbPassword.TabIndex = 50;
			this.lbPassword.Text = "Password :";
			this.lbUserName.AutoSize = true;
			this.lbUserName.Font = new global::System.Drawing.Font("Microsoft JhengHei", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lbUserName.Location = new global::System.Drawing.Point(15, 41);
			this.lbUserName.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbUserName.Name = "lbUserName";
			this.lbUserName.Size = new global::System.Drawing.Size(88, 18);
			this.lbUserName.TabIndex = 49;
			this.lbUserName.Text = "User Name :";
			this.lbPort.AutoSize = true;
			this.lbPort.Font = new global::System.Drawing.Font("Microsoft JhengHei", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lbPort.Location = new global::System.Drawing.Point(15, 85);
			this.lbPort.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbPort.Name = "lbPort";
			this.lbPort.Size = new global::System.Drawing.Size(42, 18);
			this.lbPort.TabIndex = 47;
			this.lbPort.Text = "Port :";
			this.txtImap.BackColor = global::System.Drawing.Color.FromArgb(246, 248, 249);
			this.txtImap.Font = new global::System.Drawing.Font("Microsoft JhengHei", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtImap.ForeColor = global::System.Drawing.Color.FromArgb(68, 77, 101);
			this.txtImap.Location = new global::System.Drawing.Point(132, 119);
			this.txtImap.Margin = new global::System.Windows.Forms.Padding(4);
			this.txtImap.Name = "txtImap";
			this.txtImap.Size = new global::System.Drawing.Size(536, 32);
			this.txtImap.TabIndex = 44;
			this.txtPassword.BackColor = global::System.Drawing.Color.FromArgb(246, 248, 249);
			this.txtPassword.Font = new global::System.Drawing.Font("Microsoft JhengHei", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtPassword.ForeColor = global::System.Drawing.Color.FromArgb(68, 77, 101);
			this.txtPassword.Location = new global::System.Drawing.Point(431, 37);
			this.txtPassword.Margin = new global::System.Windows.Forms.Padding(4);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new global::System.Drawing.Size(237, 32);
			this.txtPassword.TabIndex = 46;
			this.txtUsername.BackColor = global::System.Drawing.Color.FromArgb(246, 248, 249);
			this.txtUsername.Font = new global::System.Drawing.Font("Microsoft JhengHei", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtUsername.ForeColor = global::System.Drawing.Color.FromArgb(68, 77, 101);
			this.txtUsername.Location = new global::System.Drawing.Point(132, 37);
			this.txtUsername.Margin = new global::System.Windows.Forms.Padding(4);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new global::System.Drawing.Size(195, 32);
			this.txtUsername.TabIndex = 45;
			this.btnStart.Image = (global::System.Drawing.Image)resources.GetObject("btnStart.Image");
			this.btnStart.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnStart.Location = new global::System.Drawing.Point(7, 484);
			this.btnStart.Margin = new global::System.Windows.Forms.Padding(4);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new global::System.Drawing.Size(111, 42);
			this.btnStart.TabIndex = 82;
			this.btnStart.Text = "    Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new global::System.EventHandler(this.btnStart_Click);
			this.btnStop.Enabled = false;
			this.btnStop.Image = (global::System.Drawing.Image)resources.GetObject("btnStop.Image");
			this.btnStop.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnStop.Location = new global::System.Drawing.Point(127, 484);
			this.btnStop.Margin = new global::System.Windows.Forms.Padding(4);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new global::System.Drawing.Size(113, 42);
			this.btnStop.TabIndex = 81;
			this.btnStop.Text = "   Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new global::System.EventHandler(this.btnStop_Click);
			this.btnSave.Image = (global::System.Drawing.Image)resources.GetObject("btnSave.Image");
			this.btnSave.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new global::System.Drawing.Point(968, 484);
			this.btnSave.Margin = new global::System.Windows.Forms.Padding(4);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(117, 42);
			this.btnSave.TabIndex = 83;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.gridIMAPAccounts.AllowUserToAddRows = false;
			this.gridIMAPAccounts.AllowUserToDeleteRows = false;
			this.gridIMAPAccounts.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridIMAPAccounts.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.IMAPServer,
				this.UserName,
				this.Password,
				this.Port,
				this.SSL,
				this.Limit
			});
			this.gridIMAPAccounts.Location = new global::System.Drawing.Point(408, 241);
			this.gridIMAPAccounts.Margin = new global::System.Windows.Forms.Padding(4);
			this.gridIMAPAccounts.Name = "gridIMAPAccounts";
			this.gridIMAPAccounts.RowHeadersWidth = 51;
			this.gridIMAPAccounts.Size = new global::System.Drawing.Size(677, 239);
			this.gridIMAPAccounts.TabIndex = 84;
			this.IMAPServer.HeaderText = "IMAPServer";
			this.IMAPServer.MinimumWidth = 6;
			this.IMAPServer.Name = "IMAPServer";
			this.IMAPServer.Width = 125;
			this.UserName.HeaderText = "UserName";
			this.UserName.MinimumWidth = 6;
			this.UserName.Name = "UserName";
			this.UserName.Width = 125;
			this.Password.HeaderText = "Password";
			this.Password.MinimumWidth = 6;
			this.Password.Name = "Password";
			this.Password.Width = 125;
			this.Port.HeaderText = "Port";
			this.Port.MinimumWidth = 6;
			this.Port.Name = "Port";
			this.Port.Width = 125;
			this.SSL.HeaderText = "SSL";
			this.SSL.MinimumWidth = 6;
			this.SSL.Name = "SSL";
			this.SSL.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.SSL.Width = 125;
			this.Limit.HeaderText = "Limit";
			this.Limit.MinimumWidth = 6;
			this.Limit.Name = "Limit";
			this.Limit.Width = 125;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft JhengHei", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.label1.Location = new global::System.Drawing.Point(407, 218);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(143, 18);
			this.label1.TabIndex = 85;
			this.label1.Text = "IMAP Accounts List:";
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft JhengHei", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.label3.Location = new global::System.Drawing.Point(7, 14);
			this.label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(291, 18);
			this.label3.TabIndex = 86;
			this.label3.Text = "Email List Extracted From IMAP Accounts:";
			this.btnClear.Image = (global::System.Drawing.Image)resources.GetObject("btnClear.Image");
			this.btnClear.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClear.Location = new global::System.Drawing.Point(407, 484);
			this.btnClear.Margin = new global::System.Windows.Forms.Padding(4);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new global::System.Drawing.Size(120, 42);
			this.btnClear.TabIndex = 88;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new global::System.EventHandler(this.btnClear_Click);
			this.btnRemove.Image = (global::System.Drawing.Image)resources.GetObject("btnRemove.Image");
			this.btnRemove.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRemove.Location = new global::System.Drawing.Point(539, 484);
			this.btnRemove.Margin = new global::System.Windows.Forms.Padding(4);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new global::System.Drawing.Size(136, 42);
			this.btnRemove.TabIndex = 87;
			this.btnRemove.Text = "  Remove Row";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new global::System.EventHandler(this.btnRemove_Click);
			this.btnRmDpl.Image = (global::System.Drawing.Image)resources.GetObject("btnRmDpl.Image");
			this.btnRmDpl.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRmDpl.Location = new global::System.Drawing.Point(295, 484);
			this.btnRmDpl.Margin = new global::System.Windows.Forms.Padding(4);
			this.btnRmDpl.Name = "btnRmDpl";
			this.btnRmDpl.Size = new global::System.Drawing.Size(105, 42);
			this.btnRmDpl.TabIndex = 89;
			this.btnRmDpl.Text = "  Rm Dpl";
			this.btnRmDpl.UseVisualStyleBackColor = true;
			this.btnRmDpl.Click += new global::System.EventHandler(this.btnRmDpl_Click);
			this.btnClose.Image = (global::System.Drawing.Image)resources.GetObject("btnClose.Image");
			this.btnClose.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new global::System.Drawing.Point(846, 484);
			this.btnClose.Margin = new global::System.Windows.Forms.Padding(4);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new global::System.Drawing.Size(117, 42);
			this.btnClose.TabIndex = 90;
			this.btnClose.Text = "hide";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new global::System.EventHandler(this.btnClose_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1092, 530);
			base.Controls.Add(this.btnClose);
			base.Controls.Add(this.btnRmDpl);
			base.Controls.Add(this.btnClear);
			base.Controls.Add(this.btnRemove);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.gridIMAPAccounts);
			base.Controls.Add(this.btnSave);
			base.Controls.Add(this.btnStart);
			base.Controls.Add(this.btnStop);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.gridIMAPEmails);
			this.ForeColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "IMAP";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "IMAP Settings";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.IMAP_FormClosing);
			base.Load += new global::System.EventHandler(this.IMAP_Load);
			((global::System.ComponentModel.ISupportInitialize)this.gridIMAPEmails).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.ntbPort).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.gridIMAPAccounts).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000E4 RID: 228
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000E5 RID: 229
		private global::System.Windows.Forms.DataGridView gridIMAPEmails;

		// Token: 0x040000E6 RID: 230
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040000E7 RID: 231
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000E8 RID: 232
		private global::System.Windows.Forms.TextBox txtLimit;

		// Token: 0x040000E9 RID: 233
		private global::System.Windows.Forms.NumericUpDown ntbPort;

		// Token: 0x040000EA RID: 234
		private global::System.Windows.Forms.RadioButton radioButton2;

		// Token: 0x040000EB RID: 235
		private global::System.Windows.Forms.RadioButton rbSSL;

		// Token: 0x040000EC RID: 236
		private global::System.Windows.Forms.Label lbImap;

		// Token: 0x040000ED RID: 237
		private global::System.Windows.Forms.Label lbPassword;

		// Token: 0x040000EE RID: 238
		private global::System.Windows.Forms.Label lbUserName;

		// Token: 0x040000EF RID: 239
		private global::System.Windows.Forms.Label lbPort;

		// Token: 0x040000F0 RID: 240
		private global::System.Windows.Forms.TextBox txtImap;

		// Token: 0x040000F1 RID: 241
		private global::System.Windows.Forms.TextBox txtPassword;

		// Token: 0x040000F2 RID: 242
		private global::System.Windows.Forms.TextBox txtUsername;

		// Token: 0x040000F3 RID: 243
		public global::System.Windows.Forms.Button btnStart;

		// Token: 0x040000F4 RID: 244
		public global::System.Windows.Forms.Button btnStop;

		// Token: 0x040000F5 RID: 245
		public global::System.Windows.Forms.Button btnSave;

		// Token: 0x040000F6 RID: 246
		private global::System.Windows.Forms.Button btnCheckIP;

		// Token: 0x040000F7 RID: 247
		private global::System.Windows.Forms.DataGridView gridIMAPAccounts;

		// Token: 0x040000F8 RID: 248
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000F9 RID: 249
		private global::System.Windows.Forms.Button btnAddSMTP;

		// Token: 0x040000FA RID: 250
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040000FB RID: 251
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Email;

		// Token: 0x040000FC RID: 252
		private global::System.Windows.Forms.DataGridViewTextBoxColumn IMAPServer;

		// Token: 0x040000FD RID: 253
		private global::System.Windows.Forms.DataGridViewTextBoxColumn UserName;

		// Token: 0x040000FE RID: 254
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Password;

		// Token: 0x040000FF RID: 255
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Port;

		// Token: 0x04000100 RID: 256
		private global::System.Windows.Forms.DataGridViewTextBoxColumn SSL;

		// Token: 0x04000101 RID: 257
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Limit;

		// Token: 0x04000102 RID: 258
		private global::System.Windows.Forms.Button btnClear;

		// Token: 0x04000103 RID: 259
		private global::System.Windows.Forms.Button btnRemove;

		// Token: 0x04000104 RID: 260
		private global::System.Windows.Forms.Button btnRmDpl;

		// Token: 0x04000105 RID: 261
		private global::System.Windows.Forms.Button btnImport;

		// Token: 0x04000106 RID: 262
		public global::System.Windows.Forms.Button btnClose;
	}
}
