namespace HeartSender
{
	// Token: 0x02000012 RID: 18
	public partial class BulkSMTP : global::System.Windows.Forms.Form
	{
		// Token: 0x0600008C RID: 140 RVA: 0x0000A2BE File Offset: 0x000084BE
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000A2E0 File Offset: 0x000084E0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::HeartSender.BulkSMTP));
			this.btnAllSMTPChecker = new global::System.Windows.Forms.Button();
			this.gridSMTPs = new global::System.Windows.Forms.DataGridView();
			this.Host = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Port = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Username = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Password = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Secure = new global::System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Status = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.btnClear = new global::System.Windows.Forms.Button();
			this.btnImport = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.gridSMTPs).BeginInit();
			this.groupBox3.SuspendLayout();
			base.SuspendLayout();
			this.btnAllSMTPChecker.Image = (global::System.Drawing.Image)resources.GetObject("btnAllSMTPChecker.Image");
			this.btnAllSMTPChecker.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAllSMTPChecker.Location = new global::System.Drawing.Point(536, 280);
			this.btnAllSMTPChecker.Name = "btnAllSMTPChecker";
			this.btnAllSMTPChecker.Size = new global::System.Drawing.Size(122, 36);
			this.btnAllSMTPChecker.TabIndex = 9;
			this.btnAllSMTPChecker.Text = "  Test All SMTP(s)";
			this.btnAllSMTPChecker.UseVisualStyleBackColor = true;
			this.btnAllSMTPChecker.Click += new global::System.EventHandler(this.btnAllSMTPChecker_Click);
			this.gridSMTPs.AllowUserToAddRows = false;
			this.gridSMTPs.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridSMTPs.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.Host,
				this.Port,
				this.Username,
				this.Password,
				this.Secure,
				this.Status
			});
			this.gridSMTPs.Location = new global::System.Drawing.Point(9, 18);
			this.gridSMTPs.Name = "gridSMTPs";
			this.gridSMTPs.RowHeadersWidth = 51;
			this.gridSMTPs.Size = new global::System.Drawing.Size(649, 256);
			this.gridSMTPs.TabIndex = 0;
			this.gridSMTPs.EditingControlShowing += new global::System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gridSMTPs_EditingControlShowing);
			this.gridSMTPs.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.gridSMTPs_MouseClick);
			this.Host.HeaderText = "Host";
			this.Host.MinimumWidth = 6;
			this.Host.Name = "Host";
			this.Host.Width = 125;
			this.Port.HeaderText = "Port";
			this.Port.MaxInputLength = 7;
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
			this.Secure.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.Secure.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Secure.Width = 125;
			this.Status.HeaderText = "Status";
			this.Status.MinimumWidth = 6;
			this.Status.Name = "Status";
			this.Status.Width = 125;
			this.groupBox3.Controls.Add(this.btnClear);
			this.groupBox3.Controls.Add(this.btnImport);
			this.groupBox3.Controls.Add(this.btnAllSMTPChecker);
			this.groupBox3.Controls.Add(this.gridSMTPs);
			this.groupBox3.Location = new global::System.Drawing.Point(10, 6);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(670, 326);
			this.groupBox3.TabIndex = 10;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "SMTP List";
			this.btnClear.Image = (global::System.Drawing.Image)resources.GetObject("btnClear.Image");
			this.btnClear.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClear.Location = new global::System.Drawing.Point(9, 280);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new global::System.Drawing.Size(101, 36);
			this.btnClear.TabIndex = 11;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new global::System.EventHandler(this.btnClear_Click);
			this.btnImport.Image = (global::System.Drawing.Image)resources.GetObject("btnImport.Image");
			this.btnImport.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnImport.Location = new global::System.Drawing.Point(424, 280);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new global::System.Drawing.Size(101, 36);
			this.btnImport.TabIndex = 10;
			this.btnImport.Text = "Import";
			this.btnImport.UseVisualStyleBackColor = true;
			this.btnImport.Click += new global::System.EventHandler(this.btnImport_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(690, 341);
			base.Controls.Add(this.groupBox3);
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "BulkSMTP";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bulk SMTP Checker";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.BulkSMTP_FormClosing);
			base.Load += new global::System.EventHandler(this.BulkSMTP_Load);
			((global::System.ComponentModel.ISupportInitialize)this.gridSMTPs).EndInit();
			this.groupBox3.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040000A1 RID: 161
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000A2 RID: 162
		private global::System.Windows.Forms.Button btnAllSMTPChecker;

		// Token: 0x040000A3 RID: 163
		private global::System.Windows.Forms.DataGridView gridSMTPs;

		// Token: 0x040000A4 RID: 164
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x040000A5 RID: 165
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Host;

		// Token: 0x040000A6 RID: 166
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Port;

		// Token: 0x040000A7 RID: 167
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Username;

		// Token: 0x040000A8 RID: 168
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Password;

		// Token: 0x040000A9 RID: 169
		private global::System.Windows.Forms.DataGridViewCheckBoxColumn Secure;

		// Token: 0x040000AA RID: 170
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Status;

		// Token: 0x040000AB RID: 171
		private global::System.Windows.Forms.Button btnImport;

		// Token: 0x040000AC RID: 172
		private global::System.Windows.Forms.Button btnClear;
	}
}
