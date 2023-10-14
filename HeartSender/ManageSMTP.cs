using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using CommonSender;
using Microsoft.VisualBasic;

namespace HeartSender
{
	// Token: 0x0200001B RID: 27
	public partial class ManageSMTP : Form
	{
		// Token: 0x06000135 RID: 309 RVA: 0x0001BD61 File Offset: 0x00019F61
		public ManageSMTP(Main _main)
		{
			this.InitializeComponent();
			this.main = _main;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0001BD84 File Offset: 0x00019F84
		private void ManageSMTP_Load(object sender, EventArgs e)
		{
			if (Main.smtps.Count > 0)
			{
				GxDB db = new GxDB();
				foreach (GxSMTP smtp in Main.smtps)
				{
					int index = this.gridSMTPs.Rows.Add();
					smtp.usage_count = db.getSmtpCount(smtp.getMd5Code());
					this.gridSMTPs.Rows[index].Cells["Host"].Value = smtp.host;
					this.gridSMTPs.Rows[index].Cells["Port"].Value = smtp.port.ToString();
					this.gridSMTPs.Rows[index].Cells["Username"].Value = smtp.username;
					this.gridSMTPs.Rows[index].Cells["Password"].Value = smtp.password;
					this.gridSMTPs.Rows[index].Cells["Secure"].Value = (smtp.secure ? "ssl" : "");
					this.gridSMTPs.Rows[index].Cells["Limit"].Value = smtp.max_limit;
					this.gridSMTPs.Rows[index].Cells["Usage"].Value = smtp.usage_count;
					this.gridSMTPs.Rows[index].Cells["FromEmail"].Value = smtp.from_email;
				}
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0001BF94 File Offset: 0x0001A194
		private void button4_Click(object sender, EventArgs e)
		{
			Main.smtps.Clear();
			GxDB db = new GxDB();
			for (int index = 0; index < this.gridSMTPs.Rows.Count; index++)
			{
				if ((this.gridSMTPs.Rows[index].Cells["Host"].Value.ToString().Trim().Length != 0 && int.Parse(this.gridSMTPs.Rows[index].Cells["Port"].Value.ToString()) > 0 && this.gridSMTPs.Rows[index].Cells["Username"].Value.ToString().Trim().Length != 0 && this.gridSMTPs.Rows[index].Cells["Password"].Value.ToString().Trim().Length != 0) || !(this.gridSMTPs.Rows[index].Cells["Host"].Value.ToString().Trim().ToLower() != "direct"))
				{
					GxSMTP new_smtp = new GxSMTP();
					new_smtp.host = this.gridSMTPs.Rows[index].Cells["Host"].Value.ToString().Trim();
					new_smtp.port = int.Parse(this.gridSMTPs.Rows[index].Cells["Port"].Value.ToString().Trim());
					new_smtp.username = this.gridSMTPs.Rows[index].Cells["Username"].Value.ToString().Trim();
					new_smtp.password = this.gridSMTPs.Rows[index].Cells["Password"].Value.ToString().Trim();
					new_smtp.max_limit = int.Parse(this.gridSMTPs.Rows[index].Cells["Limit"].Value.ToString().Trim());
					new_smtp.usage_count = db.getSmtpCount(new_smtp.getMd5Code());
					new_smtp.secure = false;
					if (this.gridSMTPs.Rows[index].Cells["Secure"].Value != null)
					{
						new_smtp.secure = (this.gridSMTPs.Rows[index].Cells["Secure"].Value.ToString() == "tls" || this.gridSMTPs.Rows[index].Cells["Secure"].Value.ToString() == "ssl");
					}
					new_smtp.from_email = this.gridSMTPs.Rows[index].Cells["FromEmail"].Value.ToString().Trim();
					Main.smtps.Add(new_smtp);
				}
			}
			this.main.populateSMTPs();
			base.Close();
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0001C309 File Offset: 0x0001A509
		private void button5_Click(object sender, EventArgs e)
		{
			this.gridSMTPs.Rows.Clear();
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0001C31C File Offset: 0x0001A51C
		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (this.gridSMTPs.SelectedRows.Count > 0)
			{
				using (IEnumerator enumerator = this.gridSMTPs.SelectedRows.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						DataGridViewRow row = (DataGridViewRow)obj;
						this.gridSMTPs.Rows.RemoveAt(row.Index);
					}
					return;
				}
			}
			MessageBox.Show("Please select atleast one row to delete.");
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0001C3A8 File Offset: 0x0001A5A8
		private void btnAddSMTP_Click(object sender, EventArgs e)
		{
			if ((this.txtHost.Text.Trim().Length == 0 || this.ctrlNumPort.Value <= 0m || this.txtUsername.Text.Trim().Length == 0 || this.txtPassword.Text.Trim().Length == 0) && this.txtHost.Text.Trim() != "localhost" && this.txtHost.Text.Trim() != "127.0.0.1" && !this.chkDirectDelivery.Checked)
			{
				MessageBox.Show("Please enter valid detail for SMTP.");
				return;
			}
			int index = this.gridSMTPs.Rows.Add();
			this.gridSMTPs.Rows[index].Cells["Host"].Value = this.txtHost.Text.Trim();
			this.gridSMTPs.Rows[index].Cells["Port"].Value = this.ctrlNumPort.Value.ToString();
			this.gridSMTPs.Rows[index].Cells["Username"].Value = this.txtUsername.Text.Trim();
			this.gridSMTPs.Rows[index].Cells["Password"].Value = this.txtPassword.Text.Trim();
			this.gridSMTPs.Rows[index].Cells["Secure"].Value = (this.chkSSL.Checked ? "ssl" : "");
			this.gridSMTPs.Rows[index].Cells["Limit"].Value = 0;
			if (this.txtMaxLimit.Text.Trim().Length > 0)
			{
				this.gridSMTPs.Rows[index].Cells["Limit"].Value = this.txtMaxLimit.Text.Trim();
			}
			this.gridSMTPs.Rows[index].Cells["Usage"].Value = 0;
			this.gridSMTPs.Rows[index].Cells["FromEmail"].Value = this.txtFromEmail.Text.Trim();
			GxSMTP new_smtp = new GxSMTP();
			new_smtp.host = this.txtHost.Text;
			new_smtp.port = int.Parse(this.ctrlNumPort.Value.ToString());
			new_smtp.username = this.txtUsername.Text;
			new_smtp.password = this.txtPassword.Text;
			new_smtp.secure = this.chkSSL.Checked;
			new_smtp.max_limit = 0;
			if (this.txtMaxLimit.Text.Trim().Length > 0)
			{
				new_smtp.max_limit = int.Parse(this.txtMaxLimit.Text.Trim());
			}
			new_smtp.from_email = this.txtFromEmail.Text.Trim();
			Main.smtps.Add(new_smtp);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0001C724 File Offset: 0x0001A924
		private void btnTest_Click(object sender, EventArgs e)
		{
			if (this.txtHost.Text.Trim().Length == 0 || this.ctrlNumPort.Value <= 0m)
			{
				MessageBox.Show("Please enter valid detail for SMTP.");
			}
			else if (this.txtToEmail.Text == "")
			{
				MessageBox.Show("Please enter valid [To Email] address.");
			}
			else if (this.txtFromEmail.Text == "")
			{
				MessageBox.Show("Please enter valid [From Email] address.");
			}
			else if (this.txtToEmail.Text == this.txtFromEmail.Text)
			{
				MessageBox.Show("[From Email] and [To Email] address should be different.");
			}
			else
			{
				this.btnTest.Enabled = false;
				MessageBox.Show(new GxApi().isValidSMTP(GxConfig.baseUrl() + "backend/smtp-checker", new string[]
				{
					this.txtHost.Text.Trim(),
					this.txtUsername.Text.Trim(),
					this.txtPassword.Text.Trim(),
					this.ctrlNumPort.Value.ToString().Trim(),
					this.chkSSL.Checked ? "1" : "0",
					this.txtFromEmail.Text.Trim(),
					this.txtToEmail.Text.Trim()
				}));
			}
			this.btnTest.Enabled = true;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0001C8C0 File Offset: 0x0001AAC0
		private void btnCheckIP_Click(object sender, EventArgs e)
		{
			int count = new GxApi().isValidIPAddress(GxConfig.baseUrl() + "backend/ip-checker");
			if (count >= 0)
			{
				MessageBox.Show("IP Address Ok!", "HeartSender", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (count == -1)
			{
				MessageBox.Show("Sorry, there is some problem verifying your IP Address. Please try again later.", "HeartSender", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			MessageBox.Show("IP Address blacklist on " + count.ToString() + " sites.", "HeartSender", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0001C93C File Offset: 0x0001AB3C
		private void chkDirectDelivery_CheckedChanged(object sender, EventArgs e)
		{
			if (this.chkDirectDelivery.Checked)
			{
				this.txtHost.Text = "Direct";
				this.ctrlNumPort.Value = 1m;
				return;
			}
			this.txtHost.Text = "";
			this.ctrlNumPort.Value = 587m;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0001C99C File Offset: 0x0001AB9C
		private void btnAllSMTPChecker_Click(object sender, EventArgs e)
		{
			Rectangle screensize = Screen.PrimaryScreen.Bounds;
			string input = Interaction.InputBox("Your Email:", "Input Your Email to Check SMTP:", "", screensize.Width / 2 - 200, screensize.Height / 2);
			if (input == "" && input.Split(new char[]
			{
				'@'
			}).Length != 2)
			{
				MessageBox.Show("Please enter valid email address.", "HeartSender");
				return;
			}
			GxApi api = new GxApi();
			for (int index = 0; index < this.gridSMTPs.Rows.Count; index++)
			{
				if ((this.gridSMTPs.Rows[index].Cells["Host"].Value.ToString().Trim().Length != 0 && int.Parse(this.gridSMTPs.Rows[index].Cells["Port"].Value.ToString()) > 0 && this.gridSMTPs.Rows[index].Cells["Username"].Value.ToString().Trim().Length != 0 && this.gridSMTPs.Rows[index].Cells["Password"].Value.ToString().Trim().Length != 0) || !(this.gridSMTPs.Rows[index].Cells["Host"].Value.ToString().Trim().ToLower() != "direct"))
				{
					GxSMTP new_smtp = new GxSMTP();
					new_smtp.host = this.gridSMTPs.Rows[index].Cells["Host"].Value.ToString().Trim();
					new_smtp.port = int.Parse(this.gridSMTPs.Rows[index].Cells["Port"].Value.ToString().Trim());
					new_smtp.username = this.gridSMTPs.Rows[index].Cells["Username"].Value.ToString().Trim();
					new_smtp.password = this.gridSMTPs.Rows[index].Cells["Password"].Value.ToString().Trim();
					new_smtp.max_limit = int.Parse(this.gridSMTPs.Rows[index].Cells["Limit"].Value.ToString().Trim());
					new_smtp.secure = false;
					if (this.gridSMTPs.Rows[index].Cells["Secure"].Value != null)
					{
						new_smtp.secure = (this.gridSMTPs.Rows[index].Cells["Secure"].Value.ToString() == "tls" || this.gridSMTPs.Rows[index].Cells["Secure"].Value.ToString() == "ssl");
					}
					new_smtp.from_email = this.gridSMTPs.Rows[index].Cells["FromEmail"].Value.ToString().Trim();
					this.gridSMTPs.Rows[index].Cells["Status"].Value = api.isValidSMTP(GxConfig.baseUrl() + "backend/smtp-checker", new string[]
					{
						new_smtp.host.Trim(),
						new_smtp.username.Trim(),
						new_smtp.password.Trim(),
						new_smtp.port.ToString().Trim(),
						new_smtp.secure ? "1" : "0",
						"sender@oneskyrocket.com",
						input.Trim()
					});
				}
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0001CDF8 File Offset: 0x0001AFF8
		private void btnOnlineCheck_Click(object sender, EventArgs e)
		{
			if (this.txtHost.Text.Trim().Length == 0 || this.ctrlNumPort.Value <= 0m)
			{
				MessageBox.Show("Please enter valid detail for SMTP.");
				return;
			}
			if (this.txtToEmail.Text == "")
			{
				MessageBox.Show("Please enter valid [To Email] address.");
				return;
			}
			if (this.txtFromEmail.Text == "")
			{
				MessageBox.Show("Please enter valid [From Email] address.");
				return;
			}
			if (this.txtToEmail.Text == this.txtFromEmail.Text)
			{
				MessageBox.Show("[From Email] and [To Email] address should be different.");
				return;
			}
			string auth = this.chkSSL.Checked ? "1" : "0";
			string paramters = string.Concat(new string[]
			{
				"host=",
				this.txtHost.Text,
				"&port=",
				this.ctrlNumPort.Value.ToString(),
				"&username=",
				this.txtUsername.Text,
				"&password=",
				this.txtPassword.Text,
				"&auth=",
				auth,
				"&fromemail=",
				this.txtFromEmail.Text,
				"&toemail=",
				this.txtToEmail.Text
			});
			string api_url = "https://bestfriendstore.net/web/leads/check-smtp?" + paramters;
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(api_url);
				httpWebRequest.Method = "GET";
				HttpWebResponse webresponse = (HttpWebResponse)httpWebRequest.GetResponse();
				Encoding enc = Encoding.GetEncoding("utf-8");
				string result = new StreamReader(webresponse.GetResponseStream(), enc).ReadToEnd();
				webresponse.Close();
				if (result.ToString().Trim() == "ok")
				{
					MessageBox.Show("Smtp Working Prefect !!");
				}
				else
				{
					MessageBox.Show(result.ToString().Trim());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0400019F RID: 415
		public Main main;

		// Token: 0x040001A0 RID: 416
		private string EA_license = "ES-D1508812687-00796-43EDA8441T7A552E-FV3A13A8DF3826B7";
	}
}
