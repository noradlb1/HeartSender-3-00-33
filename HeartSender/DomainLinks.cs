using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HeartSender
{
	// Token: 0x02000015 RID: 21
	public partial class DomainLinks : Form
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x0000DADB File Offset: 0x0000BCDB
		public DomainLinks(Main _main)
		{
			this.InitializeComponent();
			this.main = _main;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000DAF0 File Offset: 0x0000BCF0
		private void btnSave_Click(object sender, EventArgs e)
		{
			this.list = this.ctrlLinks.Text.Trim().Split(new string[]
			{
				"\r\n",
				"\r",
				"\n"
			}, StringSplitOptions.None);
			Main.populateLinksList(this.list, this.main);
			base.Close();
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000DB50 File Offset: 0x0000BD50
		private void DomainLinks_Load(object sender, EventArgs e)
		{
			foreach (string link in Main.links)
			{
				RichTextBox richTextBox = this.ctrlLinks;
				richTextBox.Text += link;
				RichTextBox richTextBox2 = this.ctrlLinks;
				richTextBox2.Text += "\n";
			}
		}

		// Token: 0x040000CF RID: 207
		private string[] list;

		// Token: 0x040000D0 RID: 208
		private Main main;
	}
}
