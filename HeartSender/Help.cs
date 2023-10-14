using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using CommonSender;

namespace HeartSender
{
	// Token: 0x02000017 RID: 23
	public partial class Help : Form
	{
		// Token: 0x060000AC RID: 172 RVA: 0x0000E276 File Offset: 0x0000C476
		public Help()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000E284 File Offset: 0x0000C484
		private void button1_Click(object sender, EventArgs e)
		{
			Process.Start("notepad.exe", GxConfig.getBasePath() + "tags.txt");
		}
	}
}
