namespace HeartSender
{
	// Token: 0x02000015 RID: 21
	public partial class DomainLinks : global::System.Windows.Forms.Form
	{
		// Token: 0x060000A6 RID: 166 RVA: 0x0000DBD0 File Offset: 0x0000BDD0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000DBF0 File Offset: 0x0000BDF0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::HeartSender.DomainLinks));
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.ctrlLinks = new global::System.Windows.Forms.RichTextBox();
			this.btnSave = new global::System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.ctrlLinks);
			this.groupBox1.Location = new global::System.Drawing.Point(12, 9);
			this.groupBox1.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new global::System.Drawing.Size(353, 332);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.ctrlLinks.Location = new global::System.Drawing.Point(7, 14);
			this.ctrlLinks.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ctrlLinks.Name = "ctrlLinks";
			this.ctrlLinks.Size = new global::System.Drawing.Size(337, 312);
			this.ctrlLinks.TabIndex = 0;
			this.ctrlLinks.Text = "";
			this.btnSave.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnSave.Image = (global::System.Drawing.Image)resources.GetObject("btnSave.Image");
			this.btnSave.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new global::System.Drawing.Point(257, 348);
			this.btnSave.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(109, 43);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(376, 405);
			base.Controls.Add(this.btnSave);
			base.Controls.Add(this.groupBox1);
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "DomainLinks";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Links";
			base.Load += new global::System.EventHandler(this.DomainLinks_Load);
			this.groupBox1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040000D1 RID: 209
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000D2 RID: 210
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040000D3 RID: 211
		private global::System.Windows.Forms.RichTextBox ctrlLinks;

		// Token: 0x040000D4 RID: 212
		private global::System.Windows.Forms.Button btnSave;
	}
}
