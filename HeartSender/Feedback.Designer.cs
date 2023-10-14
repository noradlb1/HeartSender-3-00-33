namespace HeartSender
{
	// Token: 0x02000016 RID: 22
	public partial class Feedback : global::System.Windows.Forms.Form
	{
		// Token: 0x060000AA RID: 170 RVA: 0x0000DF70 File Offset: 0x0000C170
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000DF90 File Offset: 0x0000C190
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::HeartSender.Feedback));
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.txtMessage = new global::System.Windows.Forms.TextBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.btnSubmit = new global::System.Windows.Forms.Button();
			this.groupBox2.SuspendLayout();
			base.SuspendLayout();
			this.groupBox2.Controls.Add(this.btnSubmit);
			this.groupBox2.Controls.Add(this.txtMessage);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Location = new global::System.Drawing.Point(5, 4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(441, 150);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.txtMessage.Location = new global::System.Drawing.Point(6, 24);
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new global::System.Drawing.Size(428, 84);
			this.txtMessage.TabIndex = 12;
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(3, 4);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(53, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Message:";
			this.btnSubmit.Image = (global::System.Drawing.Image)resources.GetObject("btnSubmit.Image");
			this.btnSubmit.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSubmit.Location = new global::System.Drawing.Point(333, 113);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new global::System.Drawing.Size(101, 30);
			this.btnSubmit.TabIndex = 9;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new global::System.EventHandler(this.btnSubmit_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(450, 158);
			base.Controls.Add(this.groupBox2);
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Feedback";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Submit Feedback";
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040000D5 RID: 213
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000D6 RID: 214
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x040000D7 RID: 215
		private global::System.Windows.Forms.TextBox txtMessage;

		// Token: 0x040000D8 RID: 216
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040000D9 RID: 217
		private global::System.Windows.Forms.Button btnSubmit;
	}
}
