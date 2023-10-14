namespace HeartSender
{
	// Token: 0x0200001D RID: 29
	public partial class ProxiesList : global::System.Windows.Forms.Form
	{
		// Token: 0x0600014F RID: 335 RVA: 0x0001F3DC File Offset: 0x0001D5DC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0001F3FC File Offset: 0x0001D5FC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::HeartSender.ProxiesList));
			this.btnDone = new global::System.Windows.Forms.Button();
			this.btnRemove = new global::System.Windows.Forms.Button();
			this.gridProxies = new global::System.Windows.Forms.DataGridView();
			this.btnAddSMTP = new global::System.Windows.Forms.Button();
			this.ctrlNumPort = new global::System.Windows.Forms.NumericUpDown();
			this.btnClear = new global::System.Windows.Forms.Button();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.txtHost = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.btnProxyChecker = new global::System.Windows.Forms.Button();
			this.label5 = new global::System.Windows.Forms.Label();
			this.cmbType = new global::System.Windows.Forms.ComboBox();
			this.txtPassword = new global::System.Windows.Forms.TextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.txtUsername = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.btnBulkTest = new global::System.Windows.Forms.Button();
			this.btnClean = new global::System.Windows.Forms.Button();
			this.btnImport = new global::System.Windows.Forms.Button();
			this.Host = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Port = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Username = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Password = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProxyType = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			((global::System.ComponentModel.ISupportInitialize)this.gridProxies).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ctrlNumPort).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.btnDone.Image = (global::System.Drawing.Image)resources.GetObject("btnDone.Image");
			this.btnDone.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDone.Location = new global::System.Drawing.Point(529, 295);
			this.btnDone.Name = "btnDone";
			this.btnDone.Size = new global::System.Drawing.Size(94, 36);
			this.btnDone.TabIndex = 2;
			this.btnDone.Text = "Done";
			this.btnDone.UseVisualStyleBackColor = true;
			this.btnDone.Click += new global::System.EventHandler(this.btnDone_Click);
			this.btnRemove.Image = (global::System.Drawing.Image)resources.GetObject("btnRemove.Image");
			this.btnRemove.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRemove.Location = new global::System.Drawing.Point(190, 295);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new global::System.Drawing.Size(110, 36);
			this.btnRemove.TabIndex = 1;
			this.btnRemove.Text = "Remove Row";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new global::System.EventHandler(this.btnRemove_Click);
			this.gridProxies.AllowUserToAddRows = false;
			this.gridProxies.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridProxies.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.Host,
				this.Port,
				this.Username,
				this.Password,
				this.ProxyType,
				this.Column1
			});
			this.gridProxies.Location = new global::System.Drawing.Point(6, 21);
			this.gridProxies.Name = "gridProxies";
			this.gridProxies.RowHeadersWidth = 51;
			this.gridProxies.Size = new global::System.Drawing.Size(617, 259);
			this.gridProxies.TabIndex = 0;
			this.btnAddSMTP.Location = new global::System.Drawing.Point(545, 83);
			this.btnAddSMTP.Name = "btnAddSMTP";
			this.btnAddSMTP.Size = new global::System.Drawing.Size(78, 27);
			this.btnAddSMTP.TabIndex = 6;
			this.btnAddSMTP.Text = "Add";
			this.btnAddSMTP.UseVisualStyleBackColor = true;
			this.btnAddSMTP.Click += new global::System.EventHandler(this.btnAddSMTP_Click);
			this.ctrlNumPort.Location = new global::System.Drawing.Point(42, 90);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.ctrlNumPort;
			int[] array = new int[4];
			array[0] = 9999999;
			numericUpDown.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.ctrlNumPort;
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Minimum = new decimal(array2);
			this.ctrlNumPort.Name = "ctrlNumPort";
			this.ctrlNumPort.Size = new global::System.Drawing.Size(240, 20);
			this.ctrlNumPort.TabIndex = 4;
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.ctrlNumPort;
			int[] array3 = new int[4];
			array3[0] = 1;
			numericUpDown3.Value = new decimal(array3);
			this.btnClear.Image = (global::System.Drawing.Image)resources.GetObject("btnClear.Image");
			this.btnClear.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClear.Location = new global::System.Drawing.Point(93, 295);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new global::System.Drawing.Size(94, 36);
			this.btnClear.TabIndex = 3;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new global::System.EventHandler(this.btnClear_Click);
			this.groupBox3.Controls.Add(this.btnImport);
			this.groupBox3.Controls.Add(this.btnClean);
			this.groupBox3.Controls.Add(this.btnBulkTest);
			this.groupBox3.Controls.Add(this.btnClear);
			this.groupBox3.Controls.Add(this.btnDone);
			this.groupBox3.Controls.Add(this.btnRemove);
			this.groupBox3.Controls.Add(this.gridProxies);
			this.groupBox3.Location = new global::System.Drawing.Point(12, 139);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(629, 337);
			this.groupBox3.TabIndex = 10;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Proxies List";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(10, 90);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(32, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Port: ";
			this.txtHost.Location = new global::System.Drawing.Point(42, 57);
			this.txtHost.Name = "txtHost";
			this.txtHost.Size = new global::System.Drawing.Size(240, 20);
			this.txtHost.TabIndex = 2;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(9, 60);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(35, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Host: ";
			this.groupBox1.Controls.Add(this.btnProxyChecker);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.cmbType);
			this.groupBox1.Controls.Add(this.txtPassword);
			this.groupBox1.Controls.Add(this.btnAddSMTP);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.ctrlNumPort);
			this.groupBox1.Controls.Add(this.txtUsername);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtHost);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new global::System.Drawing.Point(12, 9);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(629, 125);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Add Sock Proxy";
			this.btnProxyChecker.Location = new global::System.Drawing.Point(467, 83);
			this.btnProxyChecker.Name = "btnProxyChecker";
			this.btnProxyChecker.Size = new global::System.Drawing.Size(72, 27);
			this.btnProxyChecker.TabIndex = 14;
			this.btnProxyChecker.Text = "Test Proxy";
			this.btnProxyChecker.UseVisualStyleBackColor = true;
			this.btnProxyChecker.Click += new global::System.EventHandler(this.btnProxyChecker_Click);
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(343, 53);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(34, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Type:";
			this.cmbType.FormattingEnabled = true;
			this.cmbType.Items.AddRange(new object[]
			{
				"Http",
				"Sock4",
				"Sock5"
			});
			this.cmbType.Location = new global::System.Drawing.Point(383, 53);
			this.cmbType.Name = "cmbType";
			this.cmbType.Size = new global::System.Drawing.Size(240, 21);
			this.cmbType.TabIndex = 12;
			this.cmbType.Text = "Sock5";
			this.txtPassword.Location = new global::System.Drawing.Point(383, 18);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new global::System.Drawing.Size(240, 20);
			this.txtPassword.TabIndex = 11;
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(344, 18);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(33, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Pass:";
			this.txtUsername.Location = new global::System.Drawing.Point(42, 25);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new global::System.Drawing.Size(240, 20);
			this.txtUsername.TabIndex = 8;
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(9, 25);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(32, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "User:";
			this.btnBulkTest.Image = (global::System.Drawing.Image)resources.GetObject("btnBulkTest.Image");
			this.btnBulkTest.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBulkTest.Location = new global::System.Drawing.Point(431, 295);
			this.btnBulkTest.Name = "btnBulkTest";
			this.btnBulkTest.Size = new global::System.Drawing.Size(94, 36);
			this.btnBulkTest.TabIndex = 6;
			this.btnBulkTest.Text = "Test all";
			this.btnBulkTest.UseVisualStyleBackColor = true;
			this.btnBulkTest.Click += new global::System.EventHandler(this.btnBulkTest_Click);
			this.btnClean.Image = (global::System.Drawing.Image)resources.GetObject("btnClean.Image");
			this.btnClean.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClean.Location = new global::System.Drawing.Point(303, 295);
			this.btnClean.Name = "btnClean";
			this.btnClean.Size = new global::System.Drawing.Size(126, 36);
			this.btnClean.TabIndex = 7;
			this.btnClean.Text = "Clean proxies";
			this.btnClean.UseVisualStyleBackColor = true;
			this.btnClean.Click += new global::System.EventHandler(this.btnClean_Click);
			this.btnImport.Image = (global::System.Drawing.Image)resources.GetObject("btnImport.Image");
			this.btnImport.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnImport.Location = new global::System.Drawing.Point(7, 294);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new global::System.Drawing.Size(82, 36);
			this.btnImport.TabIndex = 8;
			this.btnImport.Text = "Import";
			this.btnImport.UseVisualStyleBackColor = true;
			this.btnImport.Click += new global::System.EventHandler(this.btnImport_Click);
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
			this.ProxyType.HeaderText = "ProxyType";
			this.ProxyType.MinimumWidth = 6;
			this.ProxyType.Name = "ProxyType";
			this.ProxyType.Width = 125;
			this.Column1.HeaderText = "Status";
			this.Column1.Name = "Column1";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(653, 488);
			base.Controls.Add(this.groupBox3);
			base.Controls.Add(this.groupBox1);
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ProxiesList";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Manage Proxies";
			base.Load += new global::System.EventHandler(this.ProxiesList_Load);
			((global::System.ComponentModel.ISupportInitialize)this.gridProxies).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ctrlNumPort).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040001C7 RID: 455
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040001C8 RID: 456
		private global::System.Windows.Forms.Button btnDone;

		// Token: 0x040001C9 RID: 457
		private global::System.Windows.Forms.Button btnRemove;

		// Token: 0x040001CA RID: 458
		private global::System.Windows.Forms.DataGridView gridProxies;

		// Token: 0x040001CB RID: 459
		private global::System.Windows.Forms.Button btnAddSMTP;

		// Token: 0x040001CC RID: 460
		private global::System.Windows.Forms.NumericUpDown ctrlNumPort;

		// Token: 0x040001CD RID: 461
		private global::System.Windows.Forms.Button btnClear;

		// Token: 0x040001CE RID: 462
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x040001CF RID: 463
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040001D0 RID: 464
		private global::System.Windows.Forms.TextBox txtHost;

		// Token: 0x040001D1 RID: 465
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040001D2 RID: 466
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040001D3 RID: 467
		private global::System.Windows.Forms.TextBox txtPassword;

		// Token: 0x040001D4 RID: 468
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040001D5 RID: 469
		private global::System.Windows.Forms.TextBox txtUsername;

		// Token: 0x040001D6 RID: 470
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040001D7 RID: 471
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040001D8 RID: 472
		private global::System.Windows.Forms.ComboBox cmbType;

		// Token: 0x040001D9 RID: 473
		private global::System.Windows.Forms.Button btnProxyChecker;

		// Token: 0x040001DA RID: 474
		private global::System.Windows.Forms.Button btnBulkTest;

		// Token: 0x040001DB RID: 475
		private global::System.Windows.Forms.Button btnClean;

		// Token: 0x040001DC RID: 476
		private global::System.Windows.Forms.Button btnImport;

		// Token: 0x040001DD RID: 477
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Host;

		// Token: 0x040001DE RID: 478
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Port;

		// Token: 0x040001DF RID: 479
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Username;

		// Token: 0x040001E0 RID: 480
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Password;

		// Token: 0x040001E1 RID: 481
		private global::System.Windows.Forms.DataGridViewTextBoxColumn ProxyType;

		// Token: 0x040001E2 RID: 482
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Column1;
	}
}
