namespace HeartSender
{
	// Token: 0x0200001F RID: 31
	public partial class SpamWords : global::System.Windows.Forms.Form
	{
		// Token: 0x0600015B RID: 347 RVA: 0x00023668 File Offset: 0x00021868
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00023688 File Offset: 0x00021888
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::HeartSender.SpamWords));
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.ctrlSpamWords = new global::System.Windows.Forms.RichTextBox();
			this.btnSave = new global::System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.ctrlSpamWords);
			this.groupBox1.Location = new global::System.Drawing.Point(4, 2);
			this.groupBox1.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new global::System.Drawing.Size(353, 460);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.ctrlSpamWords.Location = new global::System.Drawing.Point(7, 14);
			this.ctrlSpamWords.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ctrlSpamWords.Name = "ctrlSpamWords";
			this.ctrlSpamWords.Size = new global::System.Drawing.Size(337, 438);
			this.ctrlSpamWords.TabIndex = 0;
			this.ctrlSpamWords.Text = "";
			this.btnSave.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnSave.Image = (global::System.Drawing.Image)resources.GetObject("btnSave.Image");
			this.btnSave.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new global::System.Drawing.Point(250, 470);
			this.btnSave.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(108, 43);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(363, 521);
			base.Controls.Add(this.btnSave);
			base.Controls.Add(this.groupBox1);
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "SpamWords";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Spam Words";
			base.Load += new global::System.EventHandler(this.SpamWords_Load);
			this.groupBox1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000215 RID: 533
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000216 RID: 534
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000217 RID: 535
		private global::System.Windows.Forms.RichTextBox ctrlSpamWords;

		// Token: 0x04000218 RID: 536
		private global::System.Windows.Forms.Button btnSave;
	}
}
