namespace HeartSender
{
	// Token: 0x0200000F RID: 15
	public partial class About : global::System.Windows.Forms.Form
	{
		// Token: 0x0600006E RID: 110
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600006F RID: 111
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::HeartSender.About));
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.linkLabel1 = new global::System.Windows.Forms.LinkLabel();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.linkLabel1);
			this.groupBox1.Location = new global::System.Drawing.Point(10, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(191, 127);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.button1.Location = new global::System.Drawing.Point(35, 75);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(114, 26);
			this.button1.TabIndex = 5;
			this.button1.Text = "Ok";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.linkLabel1.Location = new global::System.Drawing.Point(2, 28);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new global::System.Drawing.Size(169, 20);
			this.linkLabel1.TabIndex = 4;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "TELEGRAM:@MONSTERMC";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(212, 140);
			base.Controls.Add(this.groupBox1);
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "About";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About Us";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400008E RID: 142
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400008F RID: 143
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000090 RID: 144
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x04000091 RID: 145
		private global::System.Windows.Forms.Button button1;
	}
}
