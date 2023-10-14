using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CommonSender;

namespace HeartSender
{
	// Token: 0x02000016 RID: 22
	public partial class Feedback : Form
	{
		// Token: 0x060000A8 RID: 168 RVA: 0x0000DEDE File Offset: 0x0000C0DE
		public Feedback()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000DEEC File Offset: 0x0000C0EC
		private void btnSubmit_Click(object sender, EventArgs e)
		{
			try
			{
				if (new GxApi().submitFeedabck(this.txtMessage.Text.Trim()) == "101")
				{
					MessageBox.Show("Sorry, something went wrong. Please try again later!", "HeartSender", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					MessageBox.Show("Your feedback successfully submitted!", "HeartSender", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Sorry, something went wrong. Please try again later!", "HeartSender", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
	}
}
