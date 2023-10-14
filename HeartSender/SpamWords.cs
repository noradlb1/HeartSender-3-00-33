using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HeartSender
{
	// Token: 0x0200001F RID: 31
	public partial class SpamWords : Form
	{
		// Token: 0x06000158 RID: 344 RVA: 0x00023541 File Offset: 0x00021741
		public SpamWords(Main _main)
		{
			this.InitializeComponent();
			this.main = _main;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00023558 File Offset: 0x00021758
		private void btnSave_Click(object sender, EventArgs e)
		{
			this.list = this.ctrlSpamWords.Text.Trim().Split(new string[]
			{
				"\r\n",
				"\r",
				"\n"
			}, StringSplitOptions.None);
			Main.populateSpamWordsList(this.list, this.main);
			this.main.settings[34] = string.Join(",", Main.spamwords);
			base.Close();
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000235D4 File Offset: 0x000217D4
		private void SpamWords_Load(object sender, EventArgs e)
		{
			Main.spamwords = Main.spamwords.Distinct<string>().ToList<string>();
			foreach (string link in Main.spamwords)
			{
				RichTextBox richTextBox = this.ctrlSpamWords;
				richTextBox.Text += link;
				RichTextBox richTextBox2 = this.ctrlSpamWords;
				richTextBox2.Text += "\n";
			}
		}

		// Token: 0x04000213 RID: 531
		private string[] list;

		// Token: 0x04000214 RID: 532
		private Main main;
	}
}
