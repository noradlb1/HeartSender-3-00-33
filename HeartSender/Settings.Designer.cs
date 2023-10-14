namespace HeartSender
{
	// Token: 0x0200001E RID: 30
	public partial class Settings : global::System.Windows.Forms.Form
	{
		// Token: 0x06000156 RID: 342 RVA: 0x0002183F File Offset: 0x0001FA3F
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00021860 File Offset: 0x0001FA60
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::HeartSender.Settings));
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.chkAllowDuplicate = new global::System.Windows.Forms.CheckBox();
			this.txtReplyEmail = new global::System.Windows.Forms.TextBox();
			this.label14 = new global::System.Windows.Forms.Label();
			this.label13 = new global::System.Windows.Forms.Label();
			this.ctrlPreHeader = new global::System.Windows.Forms.RichTextBox();
			this.label11 = new global::System.Windows.Forms.Label();
			this.txtAttachmentName = new global::System.Windows.Forms.TextBox();
			this.ctrlFromNameEncoding = new global::System.Windows.Forms.ComboBox();
			this.ctrlLinkEncoding = new global::System.Windows.Forms.ComboBox();
			this.ctrlSubjectEncoding = new global::System.Windows.Forms.ComboBox();
			this.ctrlLetterEncryption = new global::System.Windows.Forms.ComboBox();
			this.ctrlLetterEncoding = new global::System.Windows.Forms.ComboBox();
			this.label12 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.txtYourEmail = new global::System.Windows.Forms.TextBox();
			this.ctrlAlternativeView = new global::System.Windows.Forms.ComboBox();
			this.ctrlDeliveryFormat = new global::System.Windows.Forms.ComboBox();
			this.ctrlBodyTransfer = new global::System.Windows.Forms.ComboBox();
			this.ctrlTextEncoding = new global::System.Windows.Forms.ComboBox();
			this.ctrlTimeout = new global::System.Windows.Forms.NumericUpDown();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.chkEmailMX = new global::System.Windows.Forms.CheckBox();
			this.label15 = new global::System.Windows.Forms.Label();
			this.txtApiKey = new global::System.Windows.Forms.TextBox();
			this.btnOk = new global::System.Windows.Forms.Button();
			this.btnDone = new global::System.Windows.Forms.Button();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.label16 = new global::System.Windows.Forms.Label();
			this.txtScriptDomain = new global::System.Windows.Forms.TextBox();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.label19 = new global::System.Windows.Forms.Label();
			this.label18 = new global::System.Windows.Forms.Label();
			this.ctrlIMAPRun = new global::System.Windows.Forms.NumericUpDown();
			this.label17 = new global::System.Windows.Forms.Label();
			this.txtIMAPList = new global::System.Windows.Forms.RichTextBox();
			this.btnTokenReset = new global::System.Windows.Forms.Button();
			this.chkAllowValidate = new global::System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.ctrlTimeout).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.ctrlIMAPRun).BeginInit();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.chkAllowValidate);
			this.groupBox1.Controls.Add(this.chkAllowDuplicate);
			this.groupBox1.Controls.Add(this.txtReplyEmail);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.ctrlPreHeader);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.txtAttachmentName);
			this.groupBox1.Controls.Add(this.ctrlFromNameEncoding);
			this.groupBox1.Controls.Add(this.ctrlLinkEncoding);
			this.groupBox1.Controls.Add(this.ctrlSubjectEncoding);
			this.groupBox1.Controls.Add(this.ctrlLetterEncryption);
			this.groupBox1.Controls.Add(this.ctrlLetterEncoding);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtYourEmail);
			this.groupBox1.Controls.Add(this.ctrlAlternativeView);
			this.groupBox1.Controls.Add(this.ctrlDeliveryFormat);
			this.groupBox1.Controls.Add(this.ctrlBodyTransfer);
			this.groupBox1.Controls.Add(this.ctrlTextEncoding);
			this.groupBox1.Controls.Add(this.ctrlTimeout);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.chkEmailMX);
			this.groupBox1.Location = new global::System.Drawing.Point(10, 10);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(578, 370);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Settings";
			this.chkAllowDuplicate.AutoSize = true;
			this.chkAllowDuplicate.Location = new global::System.Drawing.Point(439, 245);
			this.chkAllowDuplicate.Name = "chkAllowDuplicate";
			this.chkAllowDuplicate.Size = new global::System.Drawing.Size(127, 17);
			this.chkAllowDuplicate.TabIndex = 27;
			this.chkAllowDuplicate.Text = "Allow Duplicate Email";
			this.chkAllowDuplicate.UseVisualStyleBackColor = true;
			this.txtReplyEmail.Location = new global::System.Drawing.Point(439, 211);
			this.txtReplyEmail.Name = "txtReplyEmail";
			this.txtReplyEmail.Size = new global::System.Drawing.Size(128, 20);
			this.txtReplyEmail.TabIndex = 25;
			this.label14.AutoSize = true;
			this.label14.Location = new global::System.Drawing.Point(320, 211);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(62, 13);
			this.label14.TabIndex = 24;
			this.label14.Text = "Reply Email";
			this.label13.AutoSize = true;
			this.label13.Location = new global::System.Drawing.Point(23, 279);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(58, 13);
			this.label13.TabIndex = 23;
			this.label13.Text = "PreHeader";
			this.ctrlPreHeader.Location = new global::System.Drawing.Point(159, 276);
			this.ctrlPreHeader.Name = "ctrlPreHeader";
			this.ctrlPreHeader.Size = new global::System.Drawing.Size(408, 57);
			this.ctrlPreHeader.TabIndex = 22;
			this.ctrlPreHeader.Text = "";
			this.label11.AutoSize = true;
			this.label11.Location = new global::System.Drawing.Point(23, 243);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(92, 13);
			this.label11.TabIndex = 21;
			this.label11.Text = "Attachment Name";
			this.txtAttachmentName.Location = new global::System.Drawing.Point(159, 243);
			this.txtAttachmentName.Name = "txtAttachmentName";
			this.txtAttachmentName.Size = new global::System.Drawing.Size(267, 20);
			this.txtAttachmentName.TabIndex = 3;
			this.ctrlFromNameEncoding.FormattingEnabled = true;
			this.ctrlFromNameEncoding.Items.AddRange(new object[]
			{
				"Yes",
				"No",
				"Cap Code",
				"Caret Code"
			});
			this.ctrlFromNameEncoding.Location = new global::System.Drawing.Point(439, 179);
			this.ctrlFromNameEncoding.Name = "ctrlFromNameEncoding";
			this.ctrlFromNameEncoding.Size = new global::System.Drawing.Size(128, 21);
			this.ctrlFromNameEncoding.TabIndex = 20;
			this.ctrlFromNameEncoding.Text = "Yes";
			this.ctrlLinkEncoding.FormattingEnabled = true;
			this.ctrlLinkEncoding.Items.AddRange(new object[]
			{
				"Normal",
				"Unicode",
				"Url Encode"
			});
			this.ctrlLinkEncoding.Location = new global::System.Drawing.Point(439, 141);
			this.ctrlLinkEncoding.Name = "ctrlLinkEncoding";
			this.ctrlLinkEncoding.Size = new global::System.Drawing.Size(128, 21);
			this.ctrlLinkEncoding.TabIndex = 18;
			this.ctrlLinkEncoding.Text = "Normal";
			this.ctrlSubjectEncoding.FormattingEnabled = true;
			this.ctrlSubjectEncoding.Items.AddRange(new object[]
			{
				"Normal",
				"Unicode",
				"Punny Code",
				"Cap Code",
				"Caret Code"
			});
			this.ctrlSubjectEncoding.Location = new global::System.Drawing.Point(439, 109);
			this.ctrlSubjectEncoding.Name = "ctrlSubjectEncoding";
			this.ctrlSubjectEncoding.Size = new global::System.Drawing.Size(128, 21);
			this.ctrlSubjectEncoding.TabIndex = 17;
			this.ctrlSubjectEncoding.Text = "Punny Code";
			this.ctrlLetterEncryption.FormattingEnabled = true;
			this.ctrlLetterEncryption.Items.AddRange(new object[]
			{
				"No",
				"ZeroFont",
				"ZeroFont2",
				"Max Zero",
				"Punny Code",
				"Small Font",
				"Dev Encryption",
				"Cap Code",
				"Max2",
				"Max3",
				"Caret Code",
				"MaxCaret",
				"ArabCode",
				"FancyCode",
				"SoftCode",
				"ShortMixer",
				"ShortMixer2",
				"Covider",
				"Fontr",
				"SuperFontr",
				"MasterInboxer",
				"Shipr",
				"Stylor"
			});
			this.ctrlLetterEncryption.Location = new global::System.Drawing.Point(439, 76);
			this.ctrlLetterEncryption.Name = "ctrlLetterEncryption";
			this.ctrlLetterEncryption.Size = new global::System.Drawing.Size(128, 21);
			this.ctrlLetterEncryption.TabIndex = 16;
			this.ctrlLetterEncryption.Text = "No";
			this.ctrlLetterEncoding.FormattingEnabled = true;
			this.ctrlLetterEncoding.Items.AddRange(new object[]
			{
				"No",
				"Base64",
				"Quarted Printed"
			});
			this.ctrlLetterEncoding.Location = new global::System.Drawing.Point(439, 39);
			this.ctrlLetterEncoding.Name = "ctrlLetterEncoding";
			this.ctrlLetterEncoding.Size = new global::System.Drawing.Size(128, 21);
			this.ctrlLetterEncoding.TabIndex = 15;
			this.ctrlLetterEncoding.Text = "No";
			this.label12.AutoSize = true;
			this.label12.Location = new global::System.Drawing.Point(320, 185);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(106, 13);
			this.label12.TabIndex = 13;
			this.label12.Text = "FromName Encoding";
			this.label10.AutoSize = true;
			this.label10.Location = new global::System.Drawing.Point(320, 144);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(75, 13);
			this.label10.TabIndex = 13;
			this.label10.Text = "Link Encoding";
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(320, 112);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(91, 13);
			this.label9.TabIndex = 14;
			this.label9.Text = "Subject Encoding";
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(320, 79);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(87, 13);
			this.label8.TabIndex = 13;
			this.label8.Text = "Letter Encryption";
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(320, 42);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(82, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Letter Encoding";
			this.txtYourEmail.Location = new global::System.Drawing.Point(159, 211);
			this.txtYourEmail.Name = "txtYourEmail";
			this.txtYourEmail.Size = new global::System.Drawing.Size(128, 20);
			this.txtYourEmail.TabIndex = 11;
			this.ctrlAlternativeView.FormattingEnabled = true;
			this.ctrlAlternativeView.Items.AddRange(new object[]
			{
				"Yes",
				"No"
			});
			this.ctrlAlternativeView.Location = new global::System.Drawing.Point(159, 177);
			this.ctrlAlternativeView.Name = "ctrlAlternativeView";
			this.ctrlAlternativeView.Size = new global::System.Drawing.Size(128, 21);
			this.ctrlAlternativeView.TabIndex = 10;
			this.ctrlAlternativeView.Text = "Yes";
			this.ctrlDeliveryFormat.FormattingEnabled = true;
			this.ctrlDeliveryFormat.Items.AddRange(new object[]
			{
				"International",
				"SevenBit",
				"None"
			});
			this.ctrlDeliveryFormat.Location = new global::System.Drawing.Point(159, 141);
			this.ctrlDeliveryFormat.Name = "ctrlDeliveryFormat";
			this.ctrlDeliveryFormat.Size = new global::System.Drawing.Size(128, 21);
			this.ctrlDeliveryFormat.TabIndex = 9;
			this.ctrlDeliveryFormat.Text = "None";
			this.ctrlBodyTransfer.FormattingEnabled = true;
			this.ctrlBodyTransfer.Items.AddRange(new object[]
			{
				"Base64",
				"EightBit",
				"QuotedPrintable",
				"SevenBit",
				"Unknown"
			});
			this.ctrlBodyTransfer.Location = new global::System.Drawing.Point(159, 104);
			this.ctrlBodyTransfer.Name = "ctrlBodyTransfer";
			this.ctrlBodyTransfer.Size = new global::System.Drawing.Size(128, 21);
			this.ctrlBodyTransfer.TabIndex = 8;
			this.ctrlBodyTransfer.Text = "Base64";
			this.ctrlTextEncoding.FormattingEnabled = true;
			this.ctrlTextEncoding.Items.AddRange(new object[]
			{
				"ASCII",
				"BigEndianUnicode",
				"Default",
				"Unicode",
				"UTF32",
				"UTF7",
				"UTF8"
			});
			this.ctrlTextEncoding.Location = new global::System.Drawing.Point(159, 71);
			this.ctrlTextEncoding.Name = "ctrlTextEncoding";
			this.ctrlTextEncoding.Size = new global::System.Drawing.Size(128, 21);
			this.ctrlTextEncoding.TabIndex = 7;
			this.ctrlTextEncoding.Text = "UTF8";
			this.ctrlTimeout.Location = new global::System.Drawing.Point(159, 39);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.ctrlTimeout;
			int[] array = new int[4];
			array[0] = 100000;
			numericUpDown.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.ctrlTimeout;
			int[] array2 = new int[4];
			array2[0] = 5000;
			numericUpDown2.Minimum = new decimal(array2);
			this.ctrlTimeout.Name = "ctrlTimeout";
			this.ctrlTimeout.Size = new global::System.Drawing.Size(128, 20);
			this.ctrlTimeout.TabIndex = 6;
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.ctrlTimeout;
			int[] array3 = new int[4];
			array3[0] = 5000;
			numericUpDown3.Value = new decimal(array3);
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(23, 211);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(57, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Your Email";
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(22, 177);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(83, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Alternative View";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(21, 144);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(80, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Delivery Format";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(21, 107);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(121, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Body Transfer Encoding";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(19, 74);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(73, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "TextEncoding";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(19, 42);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(69, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "TimeOut (ms)";
			this.chkEmailMX.AutoSize = true;
			this.chkEmailMX.Checked = true;
			this.chkEmailMX.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.chkEmailMX.Enabled = false;
			this.chkEmailMX.Location = new global::System.Drawing.Point(159, 339);
			this.chkEmailMX.Name = "chkEmailMX";
			this.chkEmailMX.Size = new global::System.Drawing.Size(108, 17);
			this.chkEmailMX.TabIndex = 26;
			this.chkEmailMX.Text = "Send Bug Report";
			this.chkEmailMX.UseVisualStyleBackColor = true;
			this.label15.AutoSize = true;
			this.label15.Location = new global::System.Drawing.Point(23, 19);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(43, 13);
			this.label15.TabIndex = 27;
			this.label15.Text = "Api Key";
			this.txtApiKey.Location = new global::System.Drawing.Point(159, 19);
			this.txtApiKey.Name = "txtApiKey";
			this.txtApiKey.Size = new global::System.Drawing.Size(408, 20);
			this.txtApiKey.TabIndex = 26;
			this.btnOk.Image = (global::System.Drawing.Image)resources.GetObject("btnOk.Image");
			this.btnOk.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOk.Location = new global::System.Drawing.Point(555, 488);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new global::System.Drawing.Size(139, 37);
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "Save";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new global::System.EventHandler(this.btnOk_Click);
			this.btnDone.Image = (global::System.Drawing.Image)resources.GetObject("btnDone.Image");
			this.btnDone.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDone.Location = new global::System.Drawing.Point(707, 488);
			this.btnDone.Name = "btnDone";
			this.btnDone.Size = new global::System.Drawing.Size(139, 37);
			this.btnDone.TabIndex = 2;
			this.btnDone.Text = "Ok";
			this.btnDone.UseVisualStyleBackColor = true;
			this.btnDone.Click += new global::System.EventHandler(this.btnDone_Click);
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.Controls.Add(this.txtScriptDomain);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.txtApiKey);
			this.groupBox2.Location = new global::System.Drawing.Point(10, 386);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(578, 95);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Script";
			this.label16.AutoSize = true;
			this.label16.Location = new global::System.Drawing.Point(23, 49);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(43, 13);
			this.label16.TabIndex = 29;
			this.label16.Text = "Domain";
			this.txtScriptDomain.Location = new global::System.Drawing.Point(159, 49);
			this.txtScriptDomain.Name = "txtScriptDomain";
			this.txtScriptDomain.Size = new global::System.Drawing.Size(408, 20);
			this.txtScriptDomain.TabIndex = 28;
			this.groupBox3.Controls.Add(this.label19);
			this.groupBox3.Controls.Add(this.label18);
			this.groupBox3.Controls.Add(this.ctrlIMAPRun);
			this.groupBox3.Controls.Add(this.label17);
			this.groupBox3.Controls.Add(this.txtIMAPList);
			this.groupBox3.Location = new global::System.Drawing.Point(594, 10);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(252, 471);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "IMAP Settings";
			this.label19.AutoSize = true;
			this.label19.Location = new global::System.Drawing.Point(215, 446);
			this.label19.Name = "label19";
			this.label19.Size = new global::System.Drawing.Size(31, 13);
			this.label19.TabIndex = 28;
			this.label19.Text = "mins.";
			this.label18.AutoSize = true;
			this.label18.Location = new global::System.Drawing.Point(3, 446);
			this.label18.Name = "label18";
			this.label18.Size = new global::System.Drawing.Size(60, 13);
			this.label18.TabIndex = 26;
			this.label18.Text = "Run Every:";
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.ctrlIMAPRun;
			int[] array4 = new int[4];
			array4[0] = 5;
			numericUpDown4.Increment = new decimal(array4);
			this.ctrlIMAPRun.Location = new global::System.Drawing.Point(150, 442);
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.ctrlIMAPRun;
			int[] array5 = new int[4];
			array5[0] = 500;
			numericUpDown5.Maximum = new decimal(array5);
			global::System.Windows.Forms.NumericUpDown numericUpDown6 = this.ctrlIMAPRun;
			int[] array6 = new int[4];
			array6[0] = 10;
			numericUpDown6.Minimum = new decimal(array6);
			this.ctrlIMAPRun.Name = "ctrlIMAPRun";
			this.ctrlIMAPRun.Size = new global::System.Drawing.Size(59, 20);
			this.ctrlIMAPRun.TabIndex = 27;
			global::System.Windows.Forms.NumericUpDown numericUpDown7 = this.ctrlIMAPRun;
			int[] array7 = new int[4];
			array7[0] = 10;
			numericUpDown7.Value = new decimal(array7);
			this.label17.AutoSize = true;
			this.label17.Location = new global::System.Drawing.Point(4, 23);
			this.label17.Name = "label17";
			this.label17.Size = new global::System.Drawing.Size(148, 13);
			this.label17.TabIndex = 26;
			this.label17.Text = "Enter Comma Separated Title:";
			this.txtIMAPList.Location = new global::System.Drawing.Point(6, 39);
			this.txtIMAPList.Name = "txtIMAPList";
			this.txtIMAPList.Size = new global::System.Drawing.Size(240, 397);
			this.txtIMAPList.TabIndex = 5;
			this.txtIMAPList.Text = "";
			this.btnTokenReset.Image = (global::System.Drawing.Image)resources.GetObject("btnTokenReset.Image");
			this.btnTokenReset.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTokenReset.Location = new global::System.Drawing.Point(10, 488);
			this.btnTokenReset.Name = "btnTokenReset";
			this.btnTokenReset.Size = new global::System.Drawing.Size(139, 37);
			this.btnTokenReset.TabIndex = 5;
			this.btnTokenReset.Text = "Reset Token?";
			this.btnTokenReset.UseVisualStyleBackColor = true;
			this.btnTokenReset.Click += new global::System.EventHandler(this.btnTokenReset_Click);
			this.chkAllowValidate.AutoSize = true;
			this.chkAllowValidate.Location = new global::System.Drawing.Point(273, 339);
			this.chkAllowValidate.Name = "chkAllowValidate";
			this.chkAllowValidate.Size = new global::System.Drawing.Size(120, 17);
			this.chkAllowValidate.TabIndex = 28;
			this.chkAllowValidate.Text = "Allow Validate Email";
			this.chkAllowValidate.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(858, 533);
			base.Controls.Add(this.btnTokenReset);
			base.Controls.Add(this.groupBox3);
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.btnDone);
			base.Controls.Add(this.btnOk);
			base.Controls.Add(this.groupBox1);
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Settings";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Additional Settings";
			base.Load += new global::System.EventHandler(this.Settings_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.ctrlTimeout).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.ctrlIMAPRun).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040001E4 RID: 484
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040001E5 RID: 485
		public global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040001E6 RID: 486
		public global::System.Windows.Forms.Label label1;

		// Token: 0x040001E7 RID: 487
		public global::System.Windows.Forms.Label label2;

		// Token: 0x040001E8 RID: 488
		public global::System.Windows.Forms.Label label3;

		// Token: 0x040001E9 RID: 489
		public global::System.Windows.Forms.Label label4;

		// Token: 0x040001EA RID: 490
		public global::System.Windows.Forms.Label label5;

		// Token: 0x040001EB RID: 491
		public global::System.Windows.Forms.Label label6;

		// Token: 0x040001EC RID: 492
		public global::System.Windows.Forms.ComboBox ctrlBodyTransfer;

		// Token: 0x040001ED RID: 493
		public global::System.Windows.Forms.ComboBox ctrlTextEncoding;

		// Token: 0x040001EE RID: 494
		public global::System.Windows.Forms.NumericUpDown ctrlTimeout;

		// Token: 0x040001EF RID: 495
		public global::System.Windows.Forms.ComboBox ctrlAlternativeView;

		// Token: 0x040001F0 RID: 496
		public global::System.Windows.Forms.ComboBox ctrlDeliveryFormat;

		// Token: 0x040001F1 RID: 497
		public global::System.Windows.Forms.TextBox txtYourEmail;

		// Token: 0x040001F2 RID: 498
		public global::System.Windows.Forms.Label label7;

		// Token: 0x040001F3 RID: 499
		public global::System.Windows.Forms.Label label8;

		// Token: 0x040001F4 RID: 500
		public global::System.Windows.Forms.Label label9;

		// Token: 0x040001F5 RID: 501
		public global::System.Windows.Forms.Label label10;

		// Token: 0x040001F6 RID: 502
		public global::System.Windows.Forms.Label label12;

		// Token: 0x040001F7 RID: 503
		public global::System.Windows.Forms.ComboBox ctrlFromNameEncoding;

		// Token: 0x040001F8 RID: 504
		public global::System.Windows.Forms.ComboBox ctrlLinkEncoding;

		// Token: 0x040001F9 RID: 505
		public global::System.Windows.Forms.ComboBox ctrlSubjectEncoding;

		// Token: 0x040001FA RID: 506
		public global::System.Windows.Forms.ComboBox ctrlLetterEncryption;

		// Token: 0x040001FB RID: 507
		public global::System.Windows.Forms.ComboBox ctrlLetterEncoding;

		// Token: 0x040001FC RID: 508
		public global::System.Windows.Forms.Button btnOk;

		// Token: 0x040001FD RID: 509
		public global::System.Windows.Forms.Button btnDone;

		// Token: 0x040001FE RID: 510
		private global::System.Windows.Forms.Label label11;

		// Token: 0x040001FF RID: 511
		private global::System.Windows.Forms.TextBox txtAttachmentName;

		// Token: 0x04000200 RID: 512
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000201 RID: 513
		private global::System.Windows.Forms.RichTextBox ctrlPreHeader;

		// Token: 0x04000202 RID: 514
		public global::System.Windows.Forms.TextBox txtReplyEmail;

		// Token: 0x04000203 RID: 515
		public global::System.Windows.Forms.Label label14;

		// Token: 0x04000204 RID: 516
		private global::System.Windows.Forms.Label label15;

		// Token: 0x04000205 RID: 517
		private global::System.Windows.Forms.TextBox txtApiKey;

		// Token: 0x04000206 RID: 518
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000207 RID: 519
		private global::System.Windows.Forms.Label label16;

		// Token: 0x04000208 RID: 520
		private global::System.Windows.Forms.TextBox txtScriptDomain;

		// Token: 0x04000209 RID: 521
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x0400020A RID: 522
		private global::System.Windows.Forms.RichTextBox txtIMAPList;

		// Token: 0x0400020B RID: 523
		public global::System.Windows.Forms.Label label17;

		// Token: 0x0400020C RID: 524
		public global::System.Windows.Forms.Label label18;

		// Token: 0x0400020D RID: 525
		private global::System.Windows.Forms.NumericUpDown ctrlIMAPRun;

		// Token: 0x0400020E RID: 526
		public global::System.Windows.Forms.Label label19;

		// Token: 0x0400020F RID: 527
		private global::System.Windows.Forms.CheckBox chkEmailMX;

		// Token: 0x04000210 RID: 528
		private global::System.Windows.Forms.CheckBox chkAllowDuplicate;

		// Token: 0x04000211 RID: 529
		public global::System.Windows.Forms.Button btnTokenReset;

		// Token: 0x04000212 RID: 530
		private global::System.Windows.Forms.CheckBox chkAllowValidate;
	}
}
