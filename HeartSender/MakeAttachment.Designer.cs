namespace HeartSender
{
	// Token: 0x02000011 RID: 17
	public partial class MakeAttachment : global::System.Windows.Forms.Form
	{
		// Token: 0x0600007F RID: 127 RVA: 0x00008BA1 File Offset: 0x00006DA1
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00008BC0 File Offset: 0x00006DC0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::HeartSender.MakeAttachment));
			this.ctrlHTMLEditor = new global::Zoople.HTMLEditControl();
			this.cbTags = new global::System.Windows.Forms.ComboBox();
			this.label12 = new global::System.Windows.Forms.Label();
			this.btnImport = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.saveFileDialog1 = new global::System.Windows.Forms.SaveFileDialog();
			base.SuspendLayout();
			this.ctrlHTMLEditor.AcceptsReturn = true;
			this.ctrlHTMLEditor.AllowDragInternal = true;
			this.ctrlHTMLEditor.BaseURL = null;
			this.ctrlHTMLEditor.CleanMSWordHTMLOnPaste = true;
			this.ctrlHTMLEditor.CodeEditor.Enabled = true;
			this.ctrlHTMLEditor.CodeEditor.Locked = false;
			this.ctrlHTMLEditor.CodeEditor.WordWrap = false;
			this.ctrlHTMLEditor.CSSText = null;
			this.ctrlHTMLEditor.DocumentHTML = null;
			this.ctrlHTMLEditor.EditingDisabled = false;
			this.ctrlHTMLEditor.EnableInlineSpelling = true;
			this.ctrlHTMLEditor.FontsList = null;
			this.ctrlHTMLEditor.HiddenButtons = null;
			this.ctrlHTMLEditor.ImageStorageLocation = null;
			this.ctrlHTMLEditor.InCodeView = false;
			this.ctrlHTMLEditor.LanguageFile = null;
			this.ctrlHTMLEditor.LicenceKey = "KPH1014-934F-1893";
			this.ctrlHTMLEditor.LicenceKeyInlineSpelling = null;
			this.ctrlHTMLEditor.Location = new global::System.Drawing.Point(28, 53);
			this.ctrlHTMLEditor.Name = "ctrlHTMLEditor";
			this.ctrlHTMLEditor.Size = new global::System.Drawing.Size(831, 397);
			this.ctrlHTMLEditor.SpellingAutoCorrectionList = (global::System.Collections.Hashtable)resources.GetObject("ctrlHTMLEditor.SpellingAutoCorrectionList");
			this.ctrlHTMLEditor.TabIndex = 1;
			this.ctrlHTMLEditor.ToolstripImageScalingSize = new global::System.Drawing.Size(16, 16);
			this.ctrlHTMLEditor.UseParagraphAsDefault = true;
			this.ctrlHTMLEditor.Load += new global::System.EventHandler(this.ctrlHTMLEditor_Load);
			this.cbTags.FormattingEnabled = true;
			this.cbTags.Items.AddRange(new object[]
			{
				"ANDROID DEVICE NAMES",
				"ANDROID BROWSER NAMES ",
				"APPLE DEVICE NAMES",
				"APPLE PHONE NAMES",
				"APPLE APPS NAMES",
				"RANDOME IP",
				"RECEIVER EMAIL",
				"Random character 1",
				"Random character 2",
				"Random character 3",
				"Random character 4",
				"Random character 5",
				"Random character 6",
				"Random character 7",
				"Random character 8",
				"Random character 9",
				"Random character 10",
				"Random number 1",
				"Random number 2",
				"Random number 3",
				"Random number 4",
				"Random number 5",
				"Random number 6",
				"Random number 7",
				"Random number 8",
				"Random number 9",
				"Random number 10",
				"Random number ( Change 10 to any digit to 99 for more numbers )",
				"Random character ( Change 10 to any digit to 99 for more letters )",
				"RANDOM EMAIL ADDRESS SHOW IN LETTER",
				"SHOW SECOND IN LETTER",
				"SHOW Minutes IN LETTER",
				"SHOW HOURS IN LETTER",
				"SHOW TIME IN LETTER",
				"SHOW LONG TIME IN LETTER ( MINS , SECOND , HOURS )",
				"SHOW LONG DATE IN LETTER ( DAY , YEAR , MONTH )",
				"SHOW SHORT DATE IN LETTER ( MONTH )",
				"SHOW RANDOM COUNTRIES IN LETTER",
				"SHOW RANDOM CITY IN LETTER",
				"SHOW RANDOM COMPANY IN LETTER",
				"SHOW SENDER EMAIL",
				"SHOW DATE",
				"SHOW DATE & TIME",
				"SHOW RECEIVER EMAIL NAME ( LIKE ITS GRAB FIRST NAME BEFORE @ )",
				"SHOW DOMAIN NAME ( AFTER @ LIKE GMAIL.COM ETC )",
				"SHOW RANDOM number & character MIX",
				"SHOW RANDOM FAKE NAMES",
				"SHOW RANDOM FAKE ADDRESS",
				"SHOW RANDOM FAKE DATE OF BIRTH",
				"SHOW RANDOM FAKE PHONE NUMBERS",
				"SHOW RANDOM FAKE EMAILS ADDRESS",
				"SHOW RANDOM FAKE CREDIT CARDS",
				"SHOW RANDOM FAKE VIN_NUMBER",
				"SHOW RANDOM FAKE BUSINESS EMAIL",
				"SHOW RANDOM FAKE INSTITUTE",
				"SHOW RANDOM COMPANY ADDRESS",
				"SHOW RANDOM FAKE JOB TITLE",
				"SHOW SMTP DOMAIN",
				"SHOW SMTP USER",
				"SHOW email Links",
				"SHOW Main Domain",
				"Show SMTP DOMAIN",
				"SHOW EMAIL ADDRESS IN BASE64 ( MOST USE FULL TAG )",
				"SHOW return Random characters",
				"Random characters and numbers with 32 characters length",
				"Current date with Japanese format yyyy mm dd H:mm:ss",
				"THIS TAG USE FOR RANDOM ROTATES LINKS",
				"show random letterupp 10",
				"show random letter low 10",
				"show random letternumber 10",
				"show random letternumberlow 10",
				"show random  letternumberupp 10"
			});
			this.cbTags.Location = new global::System.Drawing.Point(498, 15);
			this.cbTags.Margin = new global::System.Windows.Forms.Padding(4);
			this.cbTags.Name = "cbTags";
			this.cbTags.Size = new global::System.Drawing.Size(361, 21);
			this.cbTags.TabIndex = 26;
			this.cbTags.Text = "Select";
			this.cbTags.SelectedIndexChanged += new global::System.EventHandler(this.cbTags_SelectedIndexChanged);
			this.label12.AutoSize = true;
			this.label12.Location = new global::System.Drawing.Point(424, 20);
			this.label12.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(50, 13);
			this.label12.TabIndex = 25;
			this.label12.Text = "Pick Tag";
			this.btnImport.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnImport.Location = new global::System.Drawing.Point(28, 456);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new global::System.Drawing.Size(136, 39);
			this.btnImport.TabIndex = 27;
			this.btnImport.Text = "Import";
			this.btnImport.UseVisualStyleBackColor = true;
			this.btnImport.Click += new global::System.EventHandler(this.btnImport_Click);
			this.button1.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new global::System.Drawing.Point(723, 456);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(136, 39);
			this.button1.TabIndex = 28;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.saveFileDialog1.FileOk += new global::System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(894, 507);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.btnImport);
			base.Controls.Add(this.cbTags);
			base.Controls.Add(this.label12);
			base.Controls.Add(this.ctrlHTMLEditor);
			base.Name = "MakeAttachment";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Attachment";
			base.Load += new global::System.EventHandler(this.Attachment_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000098 RID: 152
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000099 RID: 153
		private global::Zoople.HTMLEditControl ctrlHTMLEditor;

		// Token: 0x0400009A RID: 154
		public global::System.Windows.Forms.ComboBox cbTags;

		// Token: 0x0400009B RID: 155
		public global::System.Windows.Forms.Label label12;

		// Token: 0x0400009C RID: 156
		public global::System.Windows.Forms.Button btnImport;

		// Token: 0x0400009D RID: 157
		public global::System.Windows.Forms.Button button1;

		// Token: 0x0400009E RID: 158
		private global::System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}
