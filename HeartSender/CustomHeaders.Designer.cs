namespace HeartSender
{
	// Token: 0x02000014 RID: 20
	public partial class CustomHeaders : global::System.Windows.Forms.Form
	{
		// Token: 0x060000A1 RID: 161 RVA: 0x0000D5C3 File Offset: 0x0000B7C3
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000D5E4 File Offset: 0x0000B7E4
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::HeartSender.CustomHeaders));
			this.gridHeaders = new global::System.Windows.Forms.DataGridView();
			this.Key = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Value = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.btnDel = new global::System.Windows.Forms.Button();
			this.btnImport = new global::System.Windows.Forms.Button();
			this.btnOk = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.gridHeaders).BeginInit();
			base.SuspendLayout();
			this.gridHeaders.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridHeaders.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.Key,
				this.Value
			});
			this.gridHeaders.Location = new global::System.Drawing.Point(9, 9);
			this.gridHeaders.Name = "gridHeaders";
			this.gridHeaders.RowHeadersWidth = 51;
			this.gridHeaders.Size = new global::System.Drawing.Size(531, 405);
			this.gridHeaders.TabIndex = 0;
			this.Key.HeaderText = "Key";
			this.Key.MinimumWidth = 6;
			this.Key.Name = "Key";
			this.Key.Width = 125;
			this.Value.HeaderText = "Value";
			this.Value.MinimumWidth = 6;
			this.Value.Name = "Value";
			this.Value.Width = 125;
			this.btnAdd.Image = (global::System.Drawing.Image)resources.GetObject("btnAdd.Image");
			this.btnAdd.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdd.Location = new global::System.Drawing.Point(152, 420);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new global::System.Drawing.Size(94, 33);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "  Add Rows";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new global::System.EventHandler(this.btnAdd_Click);
			this.btnDel.Image = (global::System.Drawing.Image)resources.GetObject("btnDel.Image");
			this.btnDel.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDel.Location = new global::System.Drawing.Point(250, 420);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new global::System.Drawing.Size(91, 33);
			this.btnDel.TabIndex = 2;
			this.btnDel.Text = "   Del. Rows";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new global::System.EventHandler(this.btnDel_Click);
			this.btnImport.Image = (global::System.Drawing.Image)resources.GetObject("btnImport.Image");
			this.btnImport.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnImport.Location = new global::System.Drawing.Point(346, 420);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new global::System.Drawing.Size(94, 33);
			this.btnImport.TabIndex = 3;
			this.btnImport.Text = "Import";
			this.btnImport.UseVisualStyleBackColor = true;
			this.btnImport.Click += new global::System.EventHandler(this.btnImport_Click);
			this.btnOk.Image = (global::System.Drawing.Image)resources.GetObject("btnOk.Image");
			this.btnOk.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOk.Location = new global::System.Drawing.Point(446, 420);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new global::System.Drawing.Size(94, 33);
			this.btnOk.TabIndex = 5;
			this.btnOk.Text = "Done";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new global::System.EventHandler(this.btnOk_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(551, 465);
			base.Controls.Add(this.btnOk);
			base.Controls.Add(this.btnImport);
			base.Controls.Add(this.btnDel);
			base.Controls.Add(this.btnAdd);
			base.Controls.Add(this.gridHeaders);
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "CustomHeaders";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Custom Headers";
			base.Load += new global::System.EventHandler(this.CustomHeaders_Load);
			((global::System.ComponentModel.ISupportInitialize)this.gridHeaders).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040000C7 RID: 199
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000C8 RID: 200
		private global::System.Windows.Forms.DataGridView gridHeaders;

		// Token: 0x040000C9 RID: 201
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Key;

		// Token: 0x040000CA RID: 202
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Value;

		// Token: 0x040000CB RID: 203
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x040000CC RID: 204
		private global::System.Windows.Forms.Button btnDel;

		// Token: 0x040000CD RID: 205
		private global::System.Windows.Forms.Button btnImport;

		// Token: 0x040000CE RID: 206
		private global::System.Windows.Forms.Button btnOk;
	}
}
