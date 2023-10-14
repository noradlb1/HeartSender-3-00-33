namespace HeartSender
{
	// Token: 0x0200001A RID: 26
	public partial class Main : global::System.Windows.Forms.Form
	{
		// Token: 0x06000132 RID: 306 RVA: 0x00017C1F File Offset: 0x00015E1F
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000133 RID: 307
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::HeartSender.Main));
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.menuStrip1 = new global::System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.loadSettingsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.saveSettingsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ecryptionsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.configurationToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.customHeaderToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.manageProxiesToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.addLinksToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.addKeywordsToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.spamWordsToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.bluckToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.iMAPAccountsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.aboutMeToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.registerToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.feedbackToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.groupBox9 = new global::System.Windows.Forms.GroupBox();
			this.chkFastSending = new global::System.Windows.Forms.CheckBox();
			this.ctrlMailPriority = new global::System.Windows.Forms.ComboBox();
			this.btnStart = new global::System.Windows.Forms.Button();
			this.btnStop = new global::System.Windows.Forms.Button();
			this.ctrlFailedNum = new global::System.Windows.Forms.NumericUpDown();
			this.ctrlSleepNum = new global::System.Windows.Forms.NumericUpDown();
			this.ctrlPauseNum = new global::System.Windows.Forms.NumericUpDown();
			this.chkRetryFailed = new global::System.Windows.Forms.CheckBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.ctrlConNum = new global::System.Windows.Forms.NumericUpDown();
			this.label4 = new global::System.Windows.Forms.Label();
			this.groupBox10 = new global::System.Windows.Forms.GroupBox();
			this.groupBox11 = new global::System.Windows.Forms.GroupBox();
			this.groupBox12 = new global::System.Windows.Forms.GroupBox();
			this.groupBox5 = new global::System.Windows.Forms.GroupBox();
			this.gridLetter = new global::System.Windows.Forms.DataGridView();
			this.Column1 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new global::System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.btnComposeLetter = new global::System.Windows.Forms.Button();
			this.btnAttachment = new global::System.Windows.Forms.Button();
			this.btnClr = new global::System.Windows.Forms.Button();
			this.groupBox4 = new global::System.Windows.Forms.GroupBox();
			this.btnIMAPList = new global::System.Windows.Forms.Button();
			this.btnLoad = new global::System.Windows.Forms.Button();
			this.btnClear = new global::System.Windows.Forms.Button();
			this.btnEmailAdd = new global::System.Windows.Forms.Button();
			this.lblTotalEmails = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.gridEmailList = new global::System.Windows.Forms.DataGridView();
			this.No = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.first_name = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.last_name = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.email = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.status = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Info = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.btnSMTPEdit = new global::System.Windows.Forms.Button();
			this.gridHostList = new global::System.Windows.Forms.DataGridView();
			this.Host = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Port = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Username = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Password = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Secure = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Limit = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Usage = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FromEmail = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new global::System.Windows.Forms.Button();
			this.lblTotalSMTP = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.groupBox14 = new global::System.Windows.Forms.GroupBox();
			this.ctrlProgress = new global::System.Windows.Forms.ProgressBar();
			this.lbProgressStatus = new global::System.Windows.Forms.Label();
			this.lblAnnouncement = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.lbIp = new global::System.Windows.Forms.Label();
			this.groupBox15 = new global::System.Windows.Forms.GroupBox();
			this.txtLogs = new global::System.Windows.Forms.RichTextBox();
			this.label8 = new global::System.Windows.Forms.Label();
			this.btnClearLogs = new global::System.Windows.Forms.Button();
			this.btnEdit = new global::System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox9.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.ctrlFailedNum).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ctrlSleepNum).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ctrlPauseNum).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ctrlConNum).BeginInit();
			this.groupBox10.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.gridLetter).BeginInit();
			this.groupBox4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.gridEmailList).BeginInit();
			this.groupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.gridHostList).BeginInit();
			this.groupBox14.SuspendLayout();
			this.groupBox15.SuspendLayout();
			base.SuspendLayout();
			this.menuStrip1.ImageScalingSize = new global::System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.fileToolStripMenuItem,
				this.ecryptionsToolStripMenuItem,
				this.configurationToolStripMenuItem,
				this.iMAPAccountsToolStripMenuItem,
				this.aboutToolStripMenuItem,
				this.feedbackToolStripMenuItem
			});
			this.menuStrip1.Location = new global::System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new global::System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip1.Size = new global::System.Drawing.Size(998, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.fileToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.loadSettingsToolStripMenuItem,
				this.saveSettingsToolStripMenuItem,
				this.exitToolStripMenuItem
			});
			this.fileToolStripMenuItem.Image = (global::System.Drawing.Image)resources.GetObject("fileToolStripMenuItem.Image");
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new global::System.Drawing.Size(57, 24);
			this.fileToolStripMenuItem.Text = "File";
			this.fileToolStripMenuItem.Click += new global::System.EventHandler(this.fileToolStripMenuItem_Click);
			this.loadSettingsToolStripMenuItem.Image = (global::System.Drawing.Image)resources.GetObject("loadSettingsToolStripMenuItem.Image");
			this.loadSettingsToolStripMenuItem.Name = "loadSettingsToolStripMenuItem";
			this.loadSettingsToolStripMenuItem.Size = new global::System.Drawing.Size(145, 22);
			this.loadSettingsToolStripMenuItem.Text = "Load Settings";
			this.loadSettingsToolStripMenuItem.Click += new global::System.EventHandler(this.loadSettingsToolStripMenuItem_Click_1);
			this.saveSettingsToolStripMenuItem.Image = (global::System.Drawing.Image)resources.GetObject("saveSettingsToolStripMenuItem.Image");
			this.saveSettingsToolStripMenuItem.Name = "saveSettingsToolStripMenuItem";
			this.saveSettingsToolStripMenuItem.Size = new global::System.Drawing.Size(145, 22);
			this.saveSettingsToolStripMenuItem.Text = "Save Settings";
			this.saveSettingsToolStripMenuItem.Click += new global::System.EventHandler(this.saveSettingsToolStripMenuItem_Click_1);
			this.exitToolStripMenuItem.Image = (global::System.Drawing.Image)resources.GetObject("exitToolStripMenuItem.Image");
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new global::System.Drawing.Size(145, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new global::System.EventHandler(this.exitToolStripMenuItem_Click);
			this.ecryptionsToolStripMenuItem.Image = (global::System.Drawing.Image)resources.GetObject("ecryptionsToolStripMenuItem.Image");
			this.ecryptionsToolStripMenuItem.Name = "ecryptionsToolStripMenuItem";
			this.ecryptionsToolStripMenuItem.Size = new global::System.Drawing.Size(113, 24);
			this.ecryptionsToolStripMenuItem.Text = "Configuration";
			this.ecryptionsToolStripMenuItem.Click += new global::System.EventHandler(this.ecryptionsToolStripMenuItem_Click);
			this.configurationToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.customHeaderToolStripMenuItem,
				this.manageProxiesToolStripMenuItem,
				this.addLinksToolStripMenuItem1,
				this.addKeywordsToolStripMenuItem1,
				this.spamWordsToolStripMenuItem1,
				this.bluckToolStripMenuItem
			});
			this.configurationToolStripMenuItem.Image = (global::System.Drawing.Image)resources.GetObject("configurationToolStripMenuItem.Image");
			this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
			this.configurationToolStripMenuItem.Size = new global::System.Drawing.Size(83, 24);
			this.configurationToolStripMenuItem.Text = "Features";
			this.customHeaderToolStripMenuItem.Image = (global::System.Drawing.Image)resources.GetObject("customHeaderToolStripMenuItem.Image");
			this.customHeaderToolStripMenuItem.Name = "customHeaderToolStripMenuItem";
			this.customHeaderToolStripMenuItem.Size = new global::System.Drawing.Size(176, 22);
			this.customHeaderToolStripMenuItem.Text = "Custom Headers";
			this.customHeaderToolStripMenuItem.Click += new global::System.EventHandler(this.customHeaderToolStripMenuItem_Click);
			this.manageProxiesToolStripMenuItem.Image = (global::System.Drawing.Image)resources.GetObject("manageProxiesToolStripMenuItem.Image");
			this.manageProxiesToolStripMenuItem.Name = "manageProxiesToolStripMenuItem";
			this.manageProxiesToolStripMenuItem.Size = new global::System.Drawing.Size(176, 22);
			this.manageProxiesToolStripMenuItem.Text = "Manage Proxies";
			this.manageProxiesToolStripMenuItem.Click += new global::System.EventHandler(this.manageProxiesToolStripMenuItem_Click);
			this.addLinksToolStripMenuItem1.Image = (global::System.Drawing.Image)resources.GetObject("addLinksToolStripMenuItem1.Image");
			this.addLinksToolStripMenuItem1.Name = "addLinksToolStripMenuItem1";
			this.addLinksToolStripMenuItem1.Size = new global::System.Drawing.Size(176, 22);
			this.addLinksToolStripMenuItem1.Text = "Add Links";
			this.addLinksToolStripMenuItem1.Click += new global::System.EventHandler(this.addLinksToolStripMenuItem1_Click);
			this.addKeywordsToolStripMenuItem1.Image = (global::System.Drawing.Image)resources.GetObject("addKeywordsToolStripMenuItem1.Image");
			this.addKeywordsToolStripMenuItem1.Name = "addKeywordsToolStripMenuItem1";
			this.addKeywordsToolStripMenuItem1.Size = new global::System.Drawing.Size(176, 22);
			this.addKeywordsToolStripMenuItem1.Text = "Add Keywords";
			this.addKeywordsToolStripMenuItem1.Click += new global::System.EventHandler(this.addKeywordsToolStripMenuItem1_Click);
			this.spamWordsToolStripMenuItem1.Image = (global::System.Drawing.Image)resources.GetObject("spamWordsToolStripMenuItem1.Image");
			this.spamWordsToolStripMenuItem1.Name = "spamWordsToolStripMenuItem1";
			this.spamWordsToolStripMenuItem1.Size = new global::System.Drawing.Size(176, 22);
			this.spamWordsToolStripMenuItem1.Text = "Spam Words";
			this.spamWordsToolStripMenuItem1.Click += new global::System.EventHandler(this.spamWordsToolStripMenuItem1_Click);
			this.bluckToolStripMenuItem.Image = (global::System.Drawing.Image)resources.GetObject("bluckToolStripMenuItem.Image");
			this.bluckToolStripMenuItem.Name = "bluckToolStripMenuItem";
			this.bluckToolStripMenuItem.Size = new global::System.Drawing.Size(176, 22);
			this.bluckToolStripMenuItem.Text = "Bulk SMTP Checker";
			this.bluckToolStripMenuItem.Click += new global::System.EventHandler(this.bluckToolStripMenuItem_Click);
			this.iMAPAccountsToolStripMenuItem.Image = (global::System.Drawing.Image)resources.GetObject("iMAPAccountsToolStripMenuItem.Image");
			this.iMAPAccountsToolStripMenuItem.Name = "iMAPAccountsToolStripMenuItem";
			this.iMAPAccountsToolStripMenuItem.Size = new global::System.Drawing.Size(121, 24);
			this.iMAPAccountsToolStripMenuItem.Text = "IMAP Accounts";
			this.iMAPAccountsToolStripMenuItem.Click += new global::System.EventHandler(this.iMAPAccountsToolStripMenuItem_Click);
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.aboutMeToolStripMenuItem,
				this.registerToolStripMenuItem
			});
			this.aboutToolStripMenuItem.Image = (global::System.Drawing.Image)resources.GetObject("aboutToolStripMenuItem.Image");
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new global::System.Drawing.Size(72, 24);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
			this.aboutMeToolStripMenuItem.Size = new global::System.Drawing.Size(127, 22);
			this.aboutMeToolStripMenuItem.Text = "About Me";
			this.aboutMeToolStripMenuItem.Click += new global::System.EventHandler(this.aboutMeToolStripMenuItem_Click);
			this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
			this.registerToolStripMenuItem.Size = new global::System.Drawing.Size(127, 22);
			this.registerToolStripMenuItem.Text = "Register";
			this.registerToolStripMenuItem.Click += new global::System.EventHandler(this.registerToolStripMenuItem_Click);
			this.feedbackToolStripMenuItem.Image = (global::System.Drawing.Image)resources.GetObject("feedbackToolStripMenuItem.Image");
			this.feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
			this.feedbackToolStripMenuItem.Size = new global::System.Drawing.Size(89, 24);
			this.feedbackToolStripMenuItem.Text = "Feedback";
			this.feedbackToolStripMenuItem.Click += new global::System.EventHandler(this.feedbackToolStripMenuItem_Click);
			this.groupBox1.AutoSize = true;
			this.groupBox1.BackColor = global::System.Drawing.SystemColors.Control;
			this.groupBox1.Controls.Add(this.groupBox9);
			this.groupBox1.Controls.Add(this.groupBox5);
			this.groupBox1.Controls.Add(this.groupBox4);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Location = new global::System.Drawing.Point(12, 54);
			this.groupBox1.MinimumSize = new global::System.Drawing.Size(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(977, 553);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox9.BackColor = global::System.Drawing.SystemColors.Control;
			this.groupBox9.Controls.Add(this.chkFastSending);
			this.groupBox9.Controls.Add(this.ctrlMailPriority);
			this.groupBox9.Controls.Add(this.btnStart);
			this.groupBox9.Controls.Add(this.btnStop);
			this.groupBox9.Controls.Add(this.ctrlFailedNum);
			this.groupBox9.Controls.Add(this.ctrlSleepNum);
			this.groupBox9.Controls.Add(this.ctrlPauseNum);
			this.groupBox9.Controls.Add(this.chkRetryFailed);
			this.groupBox9.Controls.Add(this.label7);
			this.groupBox9.Controls.Add(this.label6);
			this.groupBox9.Controls.Add(this.label5);
			this.groupBox9.Controls.Add(this.ctrlConNum);
			this.groupBox9.Controls.Add(this.label4);
			this.groupBox9.Controls.Add(this.groupBox10);
			this.groupBox9.Controls.Add(this.groupBox12);
			this.groupBox9.Location = new global::System.Drawing.Point(802, 292);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new global::System.Drawing.Size(169, 242);
			this.groupBox9.TabIndex = 5;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "Start Send";
			this.groupBox9.Enter += new global::System.EventHandler(this.groupBox9_Enter);
			this.chkFastSending.AutoSize = true;
			this.chkFastSending.Location = new global::System.Drawing.Point(14, 170);
			this.chkFastSending.Name = "chkFastSending";
			this.chkFastSending.Size = new global::System.Drawing.Size(88, 17);
			this.chkFastSending.TabIndex = 17;
			this.chkFastSending.Text = "Fast Sending";
			this.chkFastSending.UseVisualStyleBackColor = true;
			this.ctrlMailPriority.DisplayMember = "None";
			this.ctrlMailPriority.FormattingEnabled = true;
			this.ctrlMailPriority.Items.AddRange(new object[]
			{
				"None",
				"Low",
				"Normal",
				"High"
			});
			this.ctrlMailPriority.Location = new global::System.Drawing.Point(102, 110);
			this.ctrlMailPriority.Name = "ctrlMailPriority";
			this.ctrlMailPriority.Size = new global::System.Drawing.Size(61, 21);
			this.ctrlMailPriority.TabIndex = 16;
			this.ctrlMailPriority.Text = "High";
			this.btnStart.Image = (global::System.Drawing.Image)resources.GetObject("btnStart.Image");
			this.btnStart.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnStart.Location = new global::System.Drawing.Point(102, 198);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new global::System.Drawing.Size(61, 34);
			this.btnStart.TabIndex = 15;
			this.btnStart.Text = "    Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new global::System.EventHandler(this.btnStart_Click);
			this.btnStop.Image = (global::System.Drawing.Image)resources.GetObject("btnStop.Image");
			this.btnStop.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnStop.Location = new global::System.Drawing.Point(14, 198);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new global::System.Drawing.Size(68, 34);
			this.btnStop.TabIndex = 14;
			this.btnStop.Text = "   Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new global::System.EventHandler(this.btnStop_Click);
			this.ctrlFailedNum.Location = new global::System.Drawing.Point(102, 142);
			this.ctrlFailedNum.Name = "ctrlFailedNum";
			this.ctrlFailedNum.Size = new global::System.Drawing.Size(61, 20);
			this.ctrlFailedNum.TabIndex = 13;
			this.ctrlSleepNum.Location = new global::System.Drawing.Point(102, 80);
			this.ctrlSleepNum.Name = "ctrlSleepNum";
			this.ctrlSleepNum.Size = new global::System.Drawing.Size(61, 20);
			this.ctrlSleepNum.TabIndex = 12;
			this.ctrlPauseNum.Location = new global::System.Drawing.Point(102, 51);
			this.ctrlPauseNum.Name = "ctrlPauseNum";
			this.ctrlPauseNum.Size = new global::System.Drawing.Size(61, 20);
			this.ctrlPauseNum.TabIndex = 11;
			this.chkRetryFailed.AutoSize = true;
			this.chkRetryFailed.Location = new global::System.Drawing.Point(15, 144);
			this.chkRetryFailed.Name = "chkRetryFailed";
			this.chkRetryFailed.Size = new global::System.Drawing.Size(79, 17);
			this.chkRetryFailed.TabIndex = 10;
			this.chkRetryFailed.Text = "Rety Failed";
			this.chkRetryFailed.UseVisualStyleBackColor = true;
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(12, 113);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(78, 13);
			this.label7.TabIndex = 9;
			this.label7.Text = "Mail Priority     :";
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(11, 82);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(79, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "Long Sleep     :";
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(11, 53);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(79, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Pause Every   :";
			this.ctrlConNum.Location = new global::System.Drawing.Point(102, 22);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.ctrlConNum;
			int[] array = new int[4];
			array[0] = 30;
			numericUpDown.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.ctrlConNum;
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Minimum = new decimal(array2);
			this.ctrlConNum.Name = "ctrlConNum";
			this.ctrlConNum.Size = new global::System.Drawing.Size(61, 20);
			this.ctrlConNum.TabIndex = 6;
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.ctrlConNum;
			int[] array3 = new int[4];
			array3[0] = 1;
			numericUpDown3.Value = new decimal(array3);
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(11, 24);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(79, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Connection     :";
			this.groupBox10.Controls.Add(this.groupBox11);
			this.groupBox10.Location = new global::System.Drawing.Point(525, 0);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.Size = new global::System.Drawing.Size(169, 242);
			this.groupBox10.TabIndex = 4;
			this.groupBox10.TabStop = false;
			this.groupBox10.Text = "Letter";
			this.groupBox11.Location = new global::System.Drawing.Point(525, 0);
			this.groupBox11.Name = "groupBox11";
			this.groupBox11.Size = new global::System.Drawing.Size(169, 242);
			this.groupBox11.TabIndex = 3;
			this.groupBox11.TabStop = false;
			this.groupBox11.Text = "Letter";
			this.groupBox12.Location = new global::System.Drawing.Point(525, 0);
			this.groupBox12.Name = "groupBox12";
			this.groupBox12.Size = new global::System.Drawing.Size(169, 242);
			this.groupBox12.TabIndex = 3;
			this.groupBox12.TabStop = false;
			this.groupBox12.Text = "Letter";
			this.groupBox5.BackColor = global::System.Drawing.SystemColors.Control;
			this.groupBox5.Controls.Add(this.btnEdit);
			this.groupBox5.Controls.Add(this.gridLetter);
			this.groupBox5.Controls.Add(this.btnComposeLetter);
			this.groupBox5.Controls.Add(this.btnAttachment);
			this.groupBox5.Controls.Add(this.btnClr);
			this.groupBox5.Location = new global::System.Drawing.Point(15, 292);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new global::System.Drawing.Size(781, 242);
			this.groupBox5.TabIndex = 2;
			this.groupBox5.TabStop = false;
			this.gridLetter.AllowUserToAddRows = false;
			this.gridLetter.AllowUserToDeleteRows = false;
			this.gridLetter.AllowUserToResizeColumns = false;
			this.gridLetter.AllowUserToResizeRows = false;
			dataGridViewCellStyle5.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle5.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.SelectionForeColor = global::System.Drawing.Color.Black;
			dataGridViewCellStyle5.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.gridLetter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.gridLetter.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridLetter.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.Column1,
				this.Column2,
				this.Column3,
				this.Column4,
				this.Column5,
				this.Column6
			});
			this.gridLetter.Location = new global::System.Drawing.Point(7, 12);
			this.gridLetter.Name = "gridLetter";
			this.gridLetter.RowHeadersVisible = false;
			this.gridLetter.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridLetter.Size = new global::System.Drawing.Size(768, 191);
			this.gridLetter.TabIndex = 23;
			this.gridLetter.CellMouseUp += new global::System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridLetter_CellMouseUp);
			this.gridLetter.CellValueChanged += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.gridLetter_CellValueChanged);
			this.Column1.HeaderText = "From Name";
			this.Column1.Name = "Column1";
			this.Column1.Width = 130;
			this.Column2.HeaderText = "From Email";
			this.Column2.Name = "Column2";
			this.Column2.Width = 130;
			this.Column3.HeaderText = "Subject";
			this.Column3.Name = "Column3";
			this.Column3.Width = 130;
			this.Column4.HeaderText = "Letter Name";
			this.Column4.Name = "Column4";
			this.Column4.Width = 130;
			this.Column5.HeaderText = "Letter Attachment";
			this.Column5.Name = "Column5";
			this.Column5.Width = 150;
			this.Column6.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column6.HeaderText = "Enable";
			this.Column6.Name = "Column6";
			this.btnComposeLetter.Image = (global::System.Drawing.Image)resources.GetObject("btnComposeLetter.Image");
			this.btnComposeLetter.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnComposeLetter.Location = new global::System.Drawing.Point(252, 209);
			this.btnComposeLetter.Name = "btnComposeLetter";
			this.btnComposeLetter.Size = new global::System.Drawing.Size(136, 28);
			this.btnComposeLetter.TabIndex = 22;
			this.btnComposeLetter.Text = "Compose Letter";
			this.btnComposeLetter.UseVisualStyleBackColor = true;
			this.btnComposeLetter.Click += new global::System.EventHandler(this.btnComposeLetter_Click_1);
			this.btnAttachment.Image = (global::System.Drawing.Image)resources.GetObject("btnAttachment.Image");
			this.btnAttachment.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAttachment.Location = new global::System.Drawing.Point(110, 209);
			this.btnAttachment.Name = "btnAttachment";
			this.btnAttachment.Size = new global::System.Drawing.Size(138, 28);
			this.btnAttachment.TabIndex = 21;
			this.btnAttachment.Text = "Remove Selected";
			this.btnAttachment.UseVisualStyleBackColor = true;
			this.btnAttachment.Click += new global::System.EventHandler(this.btnAttachment_Click_1);
			this.btnClr.Image = (global::System.Drawing.Image)resources.GetObject("btnClr.Image");
			this.btnClr.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClr.Location = new global::System.Drawing.Point(533, 209);
			this.btnClr.Name = "btnClr";
			this.btnClr.Size = new global::System.Drawing.Size(137, 28);
			this.btnClr.TabIndex = 20;
			this.btnClr.Text = "Clear All";
			this.btnClr.UseVisualStyleBackColor = true;
			this.btnClr.Click += new global::System.EventHandler(this.btnClr_Click);
			this.groupBox4.BackColor = global::System.Drawing.SystemColors.Control;
			this.groupBox4.Controls.Add(this.btnIMAPList);
			this.groupBox4.Controls.Add(this.btnLoad);
			this.groupBox4.Controls.Add(this.btnClear);
			this.groupBox4.Controls.Add(this.btnEmailAdd);
			this.groupBox4.Controls.Add(this.lblTotalEmails);
			this.groupBox4.Controls.Add(this.label2);
			this.groupBox4.Controls.Add(this.gridEmailList);
			this.groupBox4.Location = new global::System.Drawing.Point(268, 12);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new global::System.Drawing.Size(703, 274);
			this.groupBox4.TabIndex = 1;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Email List";
			this.btnIMAPList.Image = (global::System.Drawing.Image)resources.GetObject("btnIMAPList.Image");
			this.btnIMAPList.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnIMAPList.Location = new global::System.Drawing.Point(274, 13);
			this.btnIMAPList.Name = "btnIMAPList";
			this.btnIMAPList.Size = new global::System.Drawing.Size(128, 34);
			this.btnIMAPList.TabIndex = 69;
			this.btnIMAPList.Text = "Enable IMAP List";
			this.btnIMAPList.UseVisualStyleBackColor = true;
			this.btnIMAPList.Click += new global::System.EventHandler(this.btnIMAPList_Click);
			this.btnLoad.Image = (global::System.Drawing.Image)resources.GetObject("btnLoad.Image");
			this.btnLoad.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLoad.Location = new global::System.Drawing.Point(408, 13);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new global::System.Drawing.Size(128, 34);
			this.btnLoad.TabIndex = 68;
			this.btnLoad.Text = "Load From File";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new global::System.EventHandler(this.btnLoad_Click);
			this.btnClear.Image = (global::System.Drawing.Image)resources.GetObject("btnClear.Image");
			this.btnClear.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClear.Location = new global::System.Drawing.Point(541, 13);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new global::System.Drawing.Size(75, 34);
			this.btnClear.TabIndex = 4;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new global::System.EventHandler(this.btnClear_Click);
			this.btnEmailAdd.Image = (global::System.Drawing.Image)resources.GetObject("btnEmailAdd.Image");
			this.btnEmailAdd.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEmailAdd.Location = new global::System.Drawing.Point(622, 13);
			this.btnEmailAdd.Name = "btnEmailAdd";
			this.btnEmailAdd.Size = new global::System.Drawing.Size(75, 34);
			this.btnEmailAdd.TabIndex = 3;
			this.btnEmailAdd.Text = "Add";
			this.btnEmailAdd.UseVisualStyleBackColor = true;
			this.btnEmailAdd.Click += new global::System.EventHandler(this.btnEmailAdd_Click);
			this.lblTotalEmails.AutoSize = true;
			this.lblTotalEmails.Location = new global::System.Drawing.Point(80, 28);
			this.lblTotalEmails.Name = "lblTotalEmails";
			this.lblTotalEmails.Size = new global::System.Drawing.Size(13, 13);
			this.lblTotalEmails.TabIndex = 2;
			this.lblTotalEmails.Text = "0";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(6, 28);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(67, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Total Emails:";
			this.gridEmailList.AllowUserToAddRows = false;
			this.gridEmailList.AllowUserToDeleteRows = false;
			this.gridEmailList.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridEmailList.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.No,
				this.first_name,
				this.last_name,
				this.email,
				this.status,
				this.Info
			});
			this.gridEmailList.Location = new global::System.Drawing.Point(6, 55);
			this.gridEmailList.Name = "gridEmailList";
			this.gridEmailList.RowHeadersWidth = 51;
			this.gridEmailList.Size = new global::System.Drawing.Size(691, 213);
			this.gridEmailList.TabIndex = 0;
			this.gridEmailList.CellContentClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.gridEmailList_CellContentClick);
			this.No.HeaderText = "No";
			this.No.MinimumWidth = 6;
			this.No.Name = "No";
			this.No.Width = 50;
			this.first_name.HeaderText = "First Name";
			this.first_name.Name = "first_name";
			this.last_name.HeaderText = "Last Name";
			this.last_name.Name = "last_name";
			this.email.HeaderText = "Email";
			this.email.MinimumWidth = 6;
			this.email.Name = "email";
			this.email.Width = 200;
			this.status.HeaderText = "Status";
			this.status.MinimumWidth = 6;
			this.status.Name = "status";
			this.status.Width = 70;
			this.Info.HeaderText = "Info";
			this.Info.MinimumWidth = 6;
			this.Info.Name = "Info";
			this.Info.Width = 400;
			this.groupBox2.BackColor = global::System.Drawing.SystemColors.Control;
			this.groupBox2.Controls.Add(this.btnSMTPEdit);
			this.groupBox2.Controls.Add(this.gridHostList);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.lblTotalSMTP);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new global::System.Drawing.Point(6, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(256, 274);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "SMTP";
			this.btnSMTPEdit.Image = (global::System.Drawing.Image)resources.GetObject("btnSMTPEdit.Image");
			this.btnSMTPEdit.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSMTPEdit.Location = new global::System.Drawing.Point(182, 14);
			this.btnSMTPEdit.Name = "btnSMTPEdit";
			this.btnSMTPEdit.Size = new global::System.Drawing.Size(71, 34);
			this.btnSMTPEdit.TabIndex = 2;
			this.btnSMTPEdit.Text = "Edit";
			this.btnSMTPEdit.UseVisualStyleBackColor = true;
			this.btnSMTPEdit.Click += new global::System.EventHandler(this.btnSMTPEdit_Click);
			this.gridHostList.AllowUserToAddRows = false;
			this.gridHostList.AllowUserToDeleteRows = false;
			this.gridHostList.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridHostList.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.Host,
				this.Port,
				this.Username,
				this.Password,
				this.Secure,
				this.Limit,
				this.Usage,
				this.FromEmail
			});
			this.gridHostList.Location = new global::System.Drawing.Point(6, 55);
			this.gridHostList.Name = "gridHostList";
			this.gridHostList.RowHeadersWidth = 51;
			this.gridHostList.Size = new global::System.Drawing.Size(244, 213);
			this.gridHostList.TabIndex = 1;
			this.Host.HeaderText = "Host";
			this.Host.MinimumWidth = 6;
			this.Host.Name = "Host";
			this.Host.Width = 125;
			this.Port.HeaderText = "Port";
			this.Port.MinimumWidth = 6;
			this.Port.Name = "Port";
			this.Port.Width = 125;
			this.Username.HeaderText = "Username";
			this.Username.MinimumWidth = 6;
			this.Username.Name = "Username";
			this.Username.Width = 125;
			this.Password.HeaderText = "Password";
			this.Password.MinimumWidth = 6;
			this.Password.Name = "Password";
			this.Password.Width = 125;
			this.Secure.HeaderText = "Secure";
			this.Secure.MinimumWidth = 6;
			this.Secure.Name = "Secure";
			this.Secure.Width = 125;
			this.Limit.HeaderText = "Limit";
			this.Limit.MinimumWidth = 6;
			this.Limit.Name = "Limit";
			this.Limit.Width = 125;
			this.Usage.HeaderText = "Usage";
			this.Usage.MinimumWidth = 6;
			this.Usage.Name = "Usage";
			this.Usage.Width = 125;
			this.FromEmail.HeaderText = "FromEmail";
			this.FromEmail.Name = "FromEmail";
			this.button1.Image = (global::System.Drawing.Image)resources.GetObject("button1.Image");
			this.button1.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new global::System.Drawing.Point(108, 14);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(71, 34);
			this.button1.TabIndex = 0;
			this.button1.Text = "  Import";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.lblTotalSMTP.AutoSize = true;
			this.lblTotalSMTP.Location = new global::System.Drawing.Point(73, 28);
			this.lblTotalSMTP.Name = "lblTotalSMTP";
			this.lblTotalSMTP.Size = new global::System.Drawing.Size(13, 13);
			this.lblTotalSMTP.TabIndex = 1;
			this.lblTotalSMTP.Text = "0";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(6, 28);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(67, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Total SMTP:";
			this.groupBox14.Controls.Add(this.ctrlProgress);
			this.groupBox14.Controls.Add(this.lbProgressStatus);
			this.groupBox14.Location = new global::System.Drawing.Point(13, 720);
			this.groupBox14.Name = "groupBox14";
			this.groupBox14.Size = new global::System.Drawing.Size(976, 53);
			this.groupBox14.TabIndex = 3;
			this.groupBox14.TabStop = false;
			this.groupBox14.Text = "Status: Ready";
			this.ctrlProgress.Location = new global::System.Drawing.Point(270, 12);
			this.ctrlProgress.Name = "ctrlProgress";
			this.ctrlProgress.Size = new global::System.Drawing.Size(701, 34);
			this.ctrlProgress.TabIndex = 5;
			this.lbProgressStatus.AutoSize = true;
			this.lbProgressStatus.Location = new global::System.Drawing.Point(7, 24);
			this.lbProgressStatus.Name = "lbProgressStatus";
			this.lbProgressStatus.Size = new global::System.Drawing.Size(0, 13);
			this.lbProgressStatus.TabIndex = 5;
			this.lblAnnouncement.AutoSize = true;
			this.lblAnnouncement.BackColor = global::System.Drawing.Color.FromArgb(192, 0, 0);
			this.lblAnnouncement.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblAnnouncement.ForeColor = global::System.Drawing.Color.Yellow;
			this.lblAnnouncement.Location = new global::System.Drawing.Point(14, 31);
			this.lblAnnouncement.Name = "lblAnnouncement";
			this.lblAnnouncement.Size = new global::System.Drawing.Size(0, 16);
			this.lblAnnouncement.TabIndex = 4;
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft JhengHei", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.label3.Location = new global::System.Drawing.Point(823, 36);
			this.label3.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(51, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "Your IP :";
			this.lbIp.AutoSize = true;
			this.lbIp.Font = new global::System.Drawing.Font("Microsoft JhengHei", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lbIp.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.lbIp.Location = new global::System.Drawing.Point(876, 36);
			this.lbIp.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbIp.Name = "lbIp";
			this.lbIp.Size = new global::System.Drawing.Size(51, 15);
			this.lbIp.TabIndex = 6;
			this.lbIp.Text = "Your IP :";
			this.groupBox15.Controls.Add(this.txtLogs);
			this.groupBox15.Location = new global::System.Drawing.Point(15, 648);
			this.groupBox15.Margin = new global::System.Windows.Forms.Padding(2);
			this.groupBox15.Name = "groupBox15";
			this.groupBox15.Padding = new global::System.Windows.Forms.Padding(2);
			this.groupBox15.Size = new global::System.Drawing.Size(974, 67);
			this.groupBox15.TabIndex = 7;
			this.groupBox15.TabStop = false;
			this.txtLogs.BackColor = global::System.Drawing.Color.Gainsboro;
			this.txtLogs.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.txtLogs.Location = new global::System.Drawing.Point(5, 11);
			this.txtLogs.Margin = new global::System.Windows.Forms.Padding(2);
			this.txtLogs.Name = "txtLogs";
			this.txtLogs.Size = new global::System.Drawing.Size(964, 50);
			this.txtLogs.TabIndex = 0;
			this.txtLogs.Text = "";
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(14, 635);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(75, 13);
			this.label8.TabIndex = 8;
			this.label8.Text = "Sending Logs:";
			this.btnClearLogs.Image = (global::System.Drawing.Image)resources.GetObject("btnClearLogs.Image");
			this.btnClearLogs.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClearLogs.Location = new global::System.Drawing.Point(879, 614);
			this.btnClearLogs.Name = "btnClearLogs";
			this.btnClearLogs.Size = new global::System.Drawing.Size(110, 34);
			this.btnClearLogs.TabIndex = 18;
			this.btnClearLogs.Text = "Clear Logs";
			this.btnClearLogs.UseVisualStyleBackColor = true;
			this.btnClearLogs.Click += new global::System.EventHandler(this.btnClearLogs_Click);
			this.btnEdit.Image = (global::System.Drawing.Image)resources.GetObject("btnEdit.Image");
			this.btnEdit.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEdit.Location = new global::System.Drawing.Point(392, 209);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new global::System.Drawing.Size(137, 28);
			this.btnEdit.TabIndex = 24;
			this.btnEdit.Text = "Edit Letter";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new global::System.EventHandler(this.btnEdit_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			base.ClientSize = new global::System.Drawing.Size(998, 781);
			base.Controls.Add(this.btnClearLogs);
			base.Controls.Add(this.groupBox14);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.groupBox15);
			base.Controls.Add(this.lbIp);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.lblAnnouncement);
			base.Controls.Add(this.menuStrip1);
			base.Controls.Add(this.groupBox1);
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MainMenuStrip = this.menuStrip1;
			base.MaximizeBox = false;
			base.Name = "Main";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "HeartSender Clened By MONSTERMC";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.Main_Closing);
			base.Load += new global::System.EventHandler(this.Main_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox9.ResumeLayout(false);
			this.groupBox9.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.ctrlFailedNum).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ctrlSleepNum).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ctrlPauseNum).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ctrlConNum).EndInit();
			this.groupBox10.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.gridLetter).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.gridEmailList).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.gridHostList).EndInit();
			this.groupBox14.ResumeLayout(false);
			this.groupBox14.PerformLayout();
			this.groupBox15.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000148 RID: 328
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000149 RID: 329
		public global::System.Windows.Forms.MenuStrip menuStrip1;

		// Token: 0x0400014A RID: 330
		public global::System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;

		// Token: 0x0400014B RID: 331
		public global::System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

		// Token: 0x0400014C RID: 332
		public global::System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;

		// Token: 0x0400014D RID: 333
		public global::System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;

		// Token: 0x0400014E RID: 334
		public global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x0400014F RID: 335
		public global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000150 RID: 336
		public global::System.Windows.Forms.GroupBox groupBox4;

		// Token: 0x04000151 RID: 337
		public global::System.Windows.Forms.GroupBox groupBox5;

		// Token: 0x04000152 RID: 338
		public global::System.Windows.Forms.GroupBox groupBox9;

		// Token: 0x04000153 RID: 339
		public global::System.Windows.Forms.GroupBox groupBox10;

		// Token: 0x04000154 RID: 340
		public global::System.Windows.Forms.GroupBox groupBox11;

		// Token: 0x04000155 RID: 341
		public global::System.Windows.Forms.GroupBox groupBox12;

		// Token: 0x04000156 RID: 342
		public global::System.Windows.Forms.GroupBox groupBox14;

		// Token: 0x04000157 RID: 343
		public global::System.Windows.Forms.ProgressBar ctrlProgress;

		// Token: 0x04000158 RID: 344
		public global::System.Windows.Forms.Label label1;

		// Token: 0x04000159 RID: 345
		public global::System.Windows.Forms.Label lblTotalSMTP;

		// Token: 0x0400015A RID: 346
		public global::System.Windows.Forms.Button button1;

		// Token: 0x0400015B RID: 347
		public global::System.Windows.Forms.DataGridView gridEmailList;

		// Token: 0x0400015C RID: 348
		public global::System.Windows.Forms.DataGridView gridHostList;

		// Token: 0x0400015D RID: 349
		public global::System.Windows.Forms.Label label2;

		// Token: 0x0400015E RID: 350
		public global::System.Windows.Forms.Label lblTotalEmails;

		// Token: 0x0400015F RID: 351
		public global::System.Windows.Forms.Button btnClear;

		// Token: 0x04000160 RID: 352
		public global::System.Windows.Forms.Button btnEmailAdd;

		// Token: 0x04000161 RID: 353
		public global::System.Windows.Forms.Label label4;

		// Token: 0x04000162 RID: 354
		public global::System.Windows.Forms.NumericUpDown ctrlConNum;

		// Token: 0x04000163 RID: 355
		public global::System.Windows.Forms.Label label5;

		// Token: 0x04000164 RID: 356
		public global::System.Windows.Forms.Label label6;

		// Token: 0x04000165 RID: 357
		public global::System.Windows.Forms.Label label7;

		// Token: 0x04000166 RID: 358
		public global::System.Windows.Forms.CheckBox chkRetryFailed;

		// Token: 0x04000167 RID: 359
		public global::System.Windows.Forms.NumericUpDown ctrlSleepNum;

		// Token: 0x04000168 RID: 360
		public global::System.Windows.Forms.NumericUpDown ctrlPauseNum;

		// Token: 0x04000169 RID: 361
		public global::System.Windows.Forms.NumericUpDown ctrlFailedNum;

		// Token: 0x0400016A RID: 362
		public global::System.Windows.Forms.Button btnStop;

		// Token: 0x0400016B RID: 363
		public global::System.Windows.Forms.Button btnStart;

		// Token: 0x0400016C RID: 364
		public global::System.Windows.Forms.ComboBox ctrlMailPriority;

		// Token: 0x0400016D RID: 365
		public global::System.Windows.Forms.Label lbProgressStatus;

		// Token: 0x0400016E RID: 366
		public global::System.Windows.Forms.Button btnSMTPEdit;

		// Token: 0x0400016F RID: 367
		private global::System.Windows.Forms.Label lblAnnouncement;

		// Token: 0x04000170 RID: 368
		private global::System.Windows.Forms.ToolStripMenuItem ecryptionsToolStripMenuItem;

		// Token: 0x04000171 RID: 369
		private global::System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;

		// Token: 0x04000172 RID: 370
		private global::System.Windows.Forms.ToolStripMenuItem loadSettingsToolStripMenuItem;

		// Token: 0x04000173 RID: 371
		private global::System.Windows.Forms.ToolStripMenuItem saveSettingsToolStripMenuItem;

		// Token: 0x04000174 RID: 372
		private global::System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

		// Token: 0x04000175 RID: 373
		private global::System.Windows.Forms.ToolStripMenuItem customHeaderToolStripMenuItem;

		// Token: 0x04000176 RID: 374
		private global::System.Windows.Forms.ToolStripMenuItem manageProxiesToolStripMenuItem;

		// Token: 0x04000177 RID: 375
		private global::System.Windows.Forms.ToolStripMenuItem addLinksToolStripMenuItem1;

		// Token: 0x04000178 RID: 376
		private global::System.Windows.Forms.ToolStripMenuItem addKeywordsToolStripMenuItem1;

		// Token: 0x04000179 RID: 377
		private global::System.Windows.Forms.ToolStripMenuItem spamWordsToolStripMenuItem1;

		// Token: 0x0400017A RID: 378
		private global::System.Windows.Forms.ToolStripMenuItem bluckToolStripMenuItem;

		// Token: 0x0400017B RID: 379
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400017C RID: 380
		private global::System.Windows.Forms.Label lbIp;

		// Token: 0x0400017D RID: 381
		private global::System.Windows.Forms.GroupBox groupBox15;

		// Token: 0x0400017E RID: 382
		private global::System.Windows.Forms.RichTextBox txtLogs;

		// Token: 0x0400017F RID: 383
		public global::System.Windows.Forms.Button btnLoad;

		// Token: 0x04000180 RID: 384
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000181 RID: 385
		public global::System.Windows.Forms.CheckBox chkFastSending;

		// Token: 0x04000182 RID: 386
		private global::System.Windows.Forms.ToolStripMenuItem iMAPAccountsToolStripMenuItem;

		// Token: 0x04000183 RID: 387
		private global::System.Windows.Forms.Button btnClearLogs;

		// Token: 0x04000184 RID: 388
		public global::System.Windows.Forms.Button btnIMAPList;

		// Token: 0x04000185 RID: 389
		private global::System.Windows.Forms.ToolStripMenuItem feedbackToolStripMenuItem;

		// Token: 0x04000186 RID: 390
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Host;

		// Token: 0x04000187 RID: 391
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Port;

		// Token: 0x04000188 RID: 392
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Username;

		// Token: 0x04000189 RID: 393
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Password;

		// Token: 0x0400018A RID: 394
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Secure;

		// Token: 0x0400018B RID: 395
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Limit;

		// Token: 0x0400018C RID: 396
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Usage;

		// Token: 0x0400018D RID: 397
		private global::System.Windows.Forms.DataGridViewTextBoxColumn FromEmail;

		// Token: 0x0400018E RID: 398
		private global::System.Windows.Forms.DataGridViewTextBoxColumn No;

		// Token: 0x0400018F RID: 399
		private global::System.Windows.Forms.DataGridViewTextBoxColumn first_name;

		// Token: 0x04000190 RID: 400
		private global::System.Windows.Forms.DataGridViewTextBoxColumn last_name;

		// Token: 0x04000191 RID: 401
		private global::System.Windows.Forms.DataGridViewTextBoxColumn email;

		// Token: 0x04000192 RID: 402
		private global::System.Windows.Forms.DataGridViewTextBoxColumn status;

		// Token: 0x04000193 RID: 403
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Info;

		// Token: 0x04000194 RID: 404
		public global::System.Windows.Forms.Button btnComposeLetter;

		// Token: 0x04000195 RID: 405
		private global::System.Windows.Forms.Button btnAttachment;

		// Token: 0x04000196 RID: 406
		public global::System.Windows.Forms.Button btnClr;

		// Token: 0x04000197 RID: 407
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Column1;

		// Token: 0x04000198 RID: 408
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Column2;

		// Token: 0x04000199 RID: 409
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Column3;

		// Token: 0x0400019A RID: 410
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Column4;

		// Token: 0x0400019B RID: 411
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Column5;

		// Token: 0x0400019C RID: 412
		private global::System.Windows.Forms.DataGridViewCheckBoxColumn Column6;

		// Token: 0x0400019D RID: 413
		public global::System.Windows.Forms.DataGridView gridLetter;

		// Token: 0x0400019E RID: 414
		public global::System.Windows.Forms.Button btnEdit;
	}
}
