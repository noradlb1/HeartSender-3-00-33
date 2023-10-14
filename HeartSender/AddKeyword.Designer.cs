namespace HeartSender
{
	// Token: 0x02000010 RID: 16
	public partial class AddKeyword : global::System.Windows.Forms.Form
	{
		// Token: 0x06000073 RID: 115 RVA: 0x000078B6 File Offset: 0x00005AB6
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000078D8 File Offset: 0x00005AD8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::HeartSender.AddKeyword));
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.txtKeywords = new global::System.Windows.Forms.RichTextBox();
			this.btnSave = new global::System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.txtKeywords);
			this.groupBox1.Location = new global::System.Drawing.Point(11, 16);
			this.groupBox1.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new global::System.Drawing.Size(507, 369);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Enter Comma separated keywords";
			this.txtKeywords.Location = new global::System.Drawing.Point(7, 25);
			this.txtKeywords.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtKeywords.Name = "txtKeywords";
			this.txtKeywords.Size = new global::System.Drawing.Size(491, 336);
			this.txtKeywords.TabIndex = 1;
			this.txtKeywords.Text = "";
			this.btnSave.Image = (global::System.Drawing.Image)resources.GetObject("btnSave.Image");
			this.btnSave.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new global::System.Drawing.Point(383, 393);
			this.btnSave.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(134, 47);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(529, 447);
			base.Controls.Add(this.btnSave);
			base.Controls.Add(this.groupBox1);
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AddKeyword";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Keywords";
			base.Load += new global::System.EventHandler(this.AddKeyword_Load);
			this.groupBox1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000093 RID: 147
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000094 RID: 148
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000095 RID: 149
		private global::System.Windows.Forms.RichTextBox txtKeywords;

		// Token: 0x04000096 RID: 150
		private global::System.Windows.Forms.Button btnSave;
	}
}
