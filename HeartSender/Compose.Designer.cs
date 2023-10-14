namespace HeartSender
{
	// Token: 0x02000013 RID: 19
	public partial class Compose : global::System.Windows.Forms.Form
	{
		// Token: 0x06000097 RID: 151 RVA: 0x0000BF84 File Offset: 0x0000A184
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000BFA4 File Offset: 0x0000A1A4
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::HeartSender.Compose));
			this.btnDone = new global::System.Windows.Forms.Button();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.txtMessage = new global::System.Windows.Forms.RichTextBox();
			this.cbTags = new global::System.Windows.Forms.ComboBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.lblTitle = new global::System.Windows.Forms.Label();
			this.tbLetterName = new global::System.Windows.Forms.TextBox();
			this.btnClear = new global::System.Windows.Forms.Button();
			this.btnSpam = new global::System.Windows.Forms.Button();
			this.btnAttachment = new global::System.Windows.Forms.Button();
			this.isHtml = new global::System.Windows.Forms.CheckBox();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.groupBox4 = new global::System.Windows.Forms.GroupBox();
			this.txtSubject = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.groupBox5 = new global::System.Windows.Forms.GroupBox();
			this.txtFromEmail = new global::System.Windows.Forms.RichTextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.txtFromName = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox5.SuspendLayout();
			base.SuspendLayout();
			this.btnDone.Image = (global::System.Drawing.Image)resources.GetObject("btnDone.Image");
			this.btnDone.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDone.Location = new global::System.Drawing.Point(747, 537);
			this.btnDone.Name = "btnDone";
			this.btnDone.Size = new global::System.Drawing.Size(136, 33);
			this.btnDone.TabIndex = 19;
			this.btnDone.Text = "Save";
			this.btnDone.UseVisualStyleBackColor = true;
			this.btnDone.Click += new global::System.EventHandler(this.btnDone_Click);
			this.groupBox1.Controls.Add(this.txtMessage);
			this.groupBox1.Location = new global::System.Drawing.Point(9, 185);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(874, 346);
			this.groupBox1.TabIndex = 137;
			this.groupBox1.TabStop = false;
			this.txtMessage.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.txtMessage.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.txtMessage.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.txtMessage.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtMessage.ForeColor = global::System.Drawing.Color.Black;
			this.txtMessage.Location = new global::System.Drawing.Point(3, 16);
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new global::System.Drawing.Size(868, 327);
			this.txtMessage.TabIndex = 0;
			this.txtMessage.Text = "";
			this.cbTags.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.cbTags.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.cbTags.ForeColor = global::System.Drawing.Color.Black;
			this.cbTags.FormattingEnabled = true;
			this.cbTags.Items.AddRange(new object[]
			{
				"Get Seconds",
				"Get Minutes",
				"Get Hours",
				"Get LongTime",
				"Get LongDate",
				"Get ShortDate",
				"Get TIME",
				"Random Links",
				"Random Android OS",
				"Random Android Browser",
				"Random Apple Macbook Device",
				"Random Apple Phone Device",
				"Random Apple Phone Apps",
				"Random IP",
				"Get Email Target",
				"Random 1 Character",
				"Random 2 Character",
				"Random 3 Character",
				"Random 4 Character",
				"Random 5 Character",
				"Random 6 Character",
				"Random 7 Character",
				"Random 8 Character",
				"Random 9 Character",
				"Random 10 Character",
				"Get Date",
				"Random 1 Number",
				"Random 2 Number",
				"Random 3 Number",
				"Random 4 Number",
				"Random 5 Number",
				"Random 6 Number",
				"Random 7 Number",
				"Random 8 Number",
				"Random 9 Number",
				"Random 10 Number",
				"Get Username From Email",
				"Get Domain From Email",
				"Random Text And Number",
				"Get A Fake Name",
				"Get A Fake Address",
				"Get A Fake DOB",
				"Get A Fake Phone Number",
				"Get A Fake Mail",
				"Get A Fake Card Number",
				"Email in base64",
				"Generate 10 random letter mix UPPERCASE or lowercase",
				"Generate 10 random letter UPPERCASE",
				"Generate 10 random letter lowercase",
				"Generate 10 random number and letter mix uppercase or lowercase",
				"Generate 10 random number and letter UPPERCASE",
				"Generate 10 random number and letter lowercase",
				"Generate random country",
				"Generate random email like : res*****@yahoo.com",
				"Random COMPANY Name"
			});
			this.cbTags.Location = new global::System.Drawing.Point(101, 95);
			this.cbTags.Name = "cbTags";
			this.cbTags.Size = new global::System.Drawing.Size(295, 21);
			this.cbTags.TabIndex = 136;
			this.cbTags.Text = "Select";
			this.cbTags.SelectedIndexChanged += new global::System.EventHandler(this.cbTags_SelectedIndexChanged);
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font("Microsoft JhengHei", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.ForeColor = global::System.Drawing.Color.Black;
			this.label7.Location = new global::System.Drawing.Point(20, 99);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(50, 15);
			this.label7.TabIndex = 135;
			this.label7.Text = "Pick Tag";
			this.lblTitle.AutoSize = true;
			this.lblTitle.BackColor = global::System.Drawing.Color.Transparent;
			this.lblTitle.Font = new global::System.Drawing.Font("Microsoft JhengHei", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTitle.ForeColor = global::System.Drawing.Color.Black;
			this.lblTitle.Location = new global::System.Drawing.Point(20, 66);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new global::System.Drawing.Size(32, 15);
			this.lblTitle.TabIndex = 134;
			this.lblTitle.Text = "Title:";
			this.tbLetterName.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.tbLetterName.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbLetterName.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.tbLetterName.ForeColor = global::System.Drawing.Color.Black;
			this.tbLetterName.Location = new global::System.Drawing.Point(101, 62);
			this.tbLetterName.Name = "tbLetterName";
			this.tbLetterName.Size = new global::System.Drawing.Size(295, 21);
			this.tbLetterName.TabIndex = 133;
			this.btnClear.Image = (global::System.Drawing.Image)resources.GetObject("btnClear.Image");
			this.btnClear.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClear.Location = new global::System.Drawing.Point(605, 537);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new global::System.Drawing.Size(136, 33);
			this.btnClear.TabIndex = 138;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new global::System.EventHandler(this.btnClear_Click);
			this.btnSpam.Image = (global::System.Drawing.Image)resources.GetObject("btnSpam.Image");
			this.btnSpam.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSpam.Location = new global::System.Drawing.Point(153, 537);
			this.btnSpam.Name = "btnSpam";
			this.btnSpam.Size = new global::System.Drawing.Size(136, 33);
			this.btnSpam.TabIndex = 139;
			this.btnSpam.Text = "Spam";
			this.btnSpam.UseVisualStyleBackColor = true;
			this.btnSpam.Click += new global::System.EventHandler(this.btnSpam_Click);
			this.btnAttachment.Image = (global::System.Drawing.Image)resources.GetObject("btnAttachment.Image");
			this.btnAttachment.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAttachment.Location = new global::System.Drawing.Point(11, 537);
			this.btnAttachment.Name = "btnAttachment";
			this.btnAttachment.Size = new global::System.Drawing.Size(136, 33);
			this.btnAttachment.TabIndex = 140;
			this.btnAttachment.Text = "Attachement";
			this.btnAttachment.UseVisualStyleBackColor = true;
			this.btnAttachment.Click += new global::System.EventHandler(this.btnAttachment_Click);
			this.isHtml.AutoSize = true;
			this.isHtml.Location = new global::System.Drawing.Point(97, 128);
			this.isHtml.Name = "isHtml";
			this.isHtml.Size = new global::System.Drawing.Size(87, 17);
			this.isHtml.TabIndex = 141;
			this.isHtml.Text = "Is Not Html ?";
			this.isHtml.UseVisualStyleBackColor = true;
			this.groupBox2.Controls.Add(this.groupBox4);
			this.groupBox2.Controls.Add(this.groupBox3);
			this.groupBox2.Location = new global::System.Drawing.Point(12, 13);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(868, 166);
			this.groupBox2.TabIndex = 142;
			this.groupBox2.TabStop = false;
			this.groupBox4.Controls.Add(this.txtSubject);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Controls.Add(this.tbLetterName);
			this.groupBox4.Controls.Add(this.cbTags);
			this.groupBox4.Controls.Add(this.label7);
			this.groupBox4.Controls.Add(this.lblTitle);
			this.groupBox4.Controls.Add(this.isHtml);
			this.groupBox4.Location = new global::System.Drawing.Point(443, 8);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new global::System.Drawing.Size(419, 152);
			this.groupBox4.TabIndex = 143;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Letter Settings";
			this.txtSubject.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.txtSubject.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSubject.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtSubject.ForeColor = global::System.Drawing.Color.Black;
			this.txtSubject.Location = new global::System.Drawing.Point(101, 29);
			this.txtSubject.Name = "txtSubject";
			this.txtSubject.Size = new global::System.Drawing.Size(295, 21);
			this.txtSubject.TabIndex = 139;
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.Transparent;
			this.label3.Font = new global::System.Drawing.Font("Microsoft JhengHei", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.Black;
			this.label3.Location = new global::System.Drawing.Point(16, 32);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(51, 15);
			this.label3.TabIndex = 140;
			this.label3.Text = "Subject :";
			this.groupBox3.Controls.Add(this.groupBox5);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.txtFromName);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Location = new global::System.Drawing.Point(6, 8);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(421, 152);
			this.groupBox3.TabIndex = 142;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Config";
			this.groupBox5.Controls.Add(this.txtFromEmail);
			this.groupBox5.Location = new global::System.Drawing.Point(98, 61);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new global::System.Drawing.Size(295, 84);
			this.groupBox5.TabIndex = 139;
			this.groupBox5.TabStop = false;
			this.txtFromEmail.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.txtFromEmail.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.txtFromEmail.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.txtFromEmail.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f);
			this.txtFromEmail.Location = new global::System.Drawing.Point(3, 16);
			this.txtFromEmail.Name = "txtFromEmail";
			this.txtFromEmail.Size = new global::System.Drawing.Size(289, 65);
			this.txtFromEmail.TabIndex = 140;
			this.txtFromEmail.Text = "";
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.Transparent;
			this.label2.Font = new global::System.Drawing.Font("Microsoft JhengHei", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.Black;
			this.label2.Location = new global::System.Drawing.Point(13, 97);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(71, 15);
			this.label2.TabIndex = 138;
			this.label2.Text = "From Email :";
			this.txtFromName.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.txtFromName.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFromName.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtFromName.ForeColor = global::System.Drawing.Color.Black;
			this.txtFromName.Location = new global::System.Drawing.Point(98, 27);
			this.txtFromName.Name = "txtFromName";
			this.txtFromName.Size = new global::System.Drawing.Size(295, 21);
			this.txtFromName.TabIndex = 135;
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("Microsoft JhengHei", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.Black;
			this.label1.Location = new global::System.Drawing.Point(13, 30);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(74, 15);
			this.label1.TabIndex = 136;
			this.label1.Text = "From Name :";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(896, 582);
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.btnAttachment);
			base.Controls.Add(this.btnSpam);
			base.Controls.Add(this.btnClear);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.btnDone);
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Compose";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Compose Letter";
			base.Load += new global::System.EventHandler(this.Compose_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040000B0 RID: 176
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000B1 RID: 177
		public global::System.Windows.Forms.Button btnDone;

		// Token: 0x040000B2 RID: 178
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040000B3 RID: 179
		private global::System.Windows.Forms.RichTextBox txtMessage;

		// Token: 0x040000B4 RID: 180
		private global::System.Windows.Forms.ComboBox cbTags;

		// Token: 0x040000B5 RID: 181
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040000B6 RID: 182
		private global::System.Windows.Forms.Label lblTitle;

		// Token: 0x040000B7 RID: 183
		private global::System.Windows.Forms.TextBox tbLetterName;

		// Token: 0x040000B8 RID: 184
		public global::System.Windows.Forms.Button btnClear;

		// Token: 0x040000B9 RID: 185
		public global::System.Windows.Forms.Button btnSpam;

		// Token: 0x040000BA RID: 186
		public global::System.Windows.Forms.Button btnAttachment;

		// Token: 0x040000BB RID: 187
		private global::System.Windows.Forms.CheckBox isHtml;

		// Token: 0x040000BC RID: 188
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x040000BD RID: 189
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x040000BE RID: 190
		private global::System.Windows.Forms.TextBox txtFromName;

		// Token: 0x040000BF RID: 191
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000C0 RID: 192
		private global::System.Windows.Forms.TextBox txtSubject;

		// Token: 0x040000C1 RID: 193
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040000C2 RID: 194
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000C3 RID: 195
		private global::System.Windows.Forms.GroupBox groupBox4;

		// Token: 0x040000C4 RID: 196
		private global::System.Windows.Forms.GroupBox groupBox5;

		// Token: 0x040000C5 RID: 197
		private global::System.Windows.Forms.RichTextBox txtFromEmail;
	}
}
