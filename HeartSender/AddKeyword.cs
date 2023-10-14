using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HeartSender
{
	// Token: 0x02000010 RID: 16
	public partial class AddKeyword : Form
	{
		// Token: 0x06000070 RID: 112 RVA: 0x0000786D File Offset: 0x00005A6D
		public AddKeyword(Main _main)
		{
			this.InitializeComponent();
			this.main = _main;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00007882 File Offset: 0x00005A82
		private void AddKeyword_Load(object sender, EventArgs e)
		{
			this.txtKeywords.Text = Main.keywords_list.Trim();
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00007899 File Offset: 0x00005A99
		private void btnSave_Click(object sender, EventArgs e)
		{
			Main.keywords_list = this.txtKeywords.Text.Trim();
			base.Close();
		}

		// Token: 0x04000092 RID: 146
		private Main main;
	}
}
