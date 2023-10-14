namespace HeartSender
{
	// Token: 0x02000017 RID: 23
	public partial class Help : global::System.Windows.Forms.Form
	{
		// Token: 0x060000AE RID: 174 RVA: 0x0000E2A0 File Offset: 0x0000C4A0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000E2C0 File Offset: 0x0000C4C0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::HeartSender.Help));
			this.linkLabel1 = new global::System.Windows.Forms.LinkLabel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.linkLabel1.Location = new global::System.Drawing.Point(12, 45);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new global::System.Drawing.Size(335, 16);
			this.linkLabel1.TabIndex = 0;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "https://www.youtube.com/watch?v=h0p0vCFoTzo&t=195s";
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(12, 11);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(93, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "How to use:";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(12, 84);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(127, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Supported Tags:";
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.Location = new global::System.Drawing.Point(16, 124);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(114, 28);
			this.button1.TabIndex = 3;
			this.button1.Text = "View Tags";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(355, 173);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.linkLabel1);
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Help";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Help";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000DA RID: 218
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000DB RID: 219
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x040000DC RID: 220
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000DD RID: 221
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000DE RID: 222
		private global::System.Windows.Forms.Button button1;
	}
}
