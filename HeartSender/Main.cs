using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using CommonSender;

namespace HeartSender
{
	// Token: 0x0200001A RID: 26
	public partial class Main : Form
	{
		// Token: 0x060000D2 RID: 210 RVA: 0x000117D8 File Offset: 0x0000F9D8
		public Main()
		{
			this.InitializeComponent();
			this.bindStartupEvents();
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00011809 File Offset: 0x0000FA09
		private void bindStartupEvents()
		{
			this.AddMouseMoveHandler(this);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00011814 File Offset: 0x0000FA14
		public void checkUpdate(EventArgs e)
		{
			WebClient client = new WebClient();
			try
			{
				string text = client.DownloadString("http://mrcodertools.com/web/updates/HeartSender/version.txt").ToLower().Trim();
				string current_version = GxLogger.getVersionNumber().Trim();
				if (text.CompareTo(current_version) > 0 && MessageBox.Show("You have an update. Do you want to install?", "HeartSender", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					Process.Start(".\\AutoUpdater.exe");
					Application.Exit();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			Main.is_version_checked = true;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0001189C File Offset: 0x0000FA9C
		private void userActivityMonitor()
		{
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000118A0 File Offset: 0x0000FAA0
		private void AddMouseMoveHandler(Control c)
		{
			c.MouseMove += this.Common_MouseMove;
			if (c.Controls.Count > 0)
			{
				foreach (object obj in c.Controls)
				{
					Control ct = (Control)obj;
					this.AddMouseMoveHandler(ct);
				}
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0001191C File Offset: 0x0000FB1C
		public void updateActivity()
		{
			Main.last_activity_time = DateTime.Now;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00011928 File Offset: 0x0000FB28
		private void Main_Closing(object sender, CancelEventArgs e)
		{
			if (Main.is_version_checked && MessageBox.Show("Do you want to save settings", "HeartSender", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.saveSettings("settings.xml");
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00011950 File Offset: 0x0000FB50
		public string GetPublicIP()
		{
			string result;
			try
			{
				result = new StreamReader(WebRequest.Create("http://checkip.dyndns.org").GetResponse().GetResponseStream()).ReadToEnd().Trim().Split(new char[]
				{
					':'
				})[1].Substring(1).Split(new char[]
				{
					'<'
				})[0];
			}
			catch (Exception)
			{
				result = "null";
			}
			return result;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000119C8 File Offset: 0x0000FBC8
		public void CheckingIp(string ip)
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

		// Token: 0x060000DB RID: 219
		private void Main_Load(object sender, EventArgs e)
		{
			this.load_tester_url();
			string ip = this.GetPublicIP();
			this.lbIp.Text = ip;
			this.lbIp.ForeColor = Color.Green;
			if (GxApi.isIPAddressBlocked(this.lbIp.Text.Trim()))
			{
				this.lbIp.ForeColor = Color.Red;
			}
			this.Text = "HeartSender " + GxLogger.getVersionNumber();
			this.AutoSize = false;
			this.lbProgressStatus.Text = "Sent : 0 | Failed : 0 | Pending : 0";
			this.settings = new string[36];
			this.settings[0] = "5000";
			this.settings[1] = "UTF8";
			this.settings[2] = "Unknown";
			this.settings[3] = "International";
			this.settings[4] = "No";
			this.settings[5] = "";
			this.settings[6] = "0";
			this.settings[7] = "0";
			this.settings[8] = "2";
			this.settings[9] = "0";
			this.settings[10] = "0";
			this.settings[11] = "1";
			this.settings[12] = "1";
			this.settings[13] = "0";
			this.settings[14] = "2";
			this.settings[15] = "0";
			this.settings[16] = "";
			this.settings[17] = "";
			this.settings[18] = "1";
			this.settings[19] = "3";
			this.settings[20] = "50";
			this.settings[21] = "3000";
			this.settings[22] = "";
			this.settings[23] = "";
			this.settings[24] = "";
			this.settings[26] = "";
			this.settings[27] = "";
			this.settings[28] = "";
			this.settings[29] = "";
			this.settings[30] = "";
			this.settings[31] = "";
			this.settings[32] = "0";
			this.settings[33] = "0";
			this.settings[34] = "";
			this.settings[35] = "0";
			Main.is_validate = this.settings[35];
			string[] response = new GxLicense().validLicense();
			if (response[0] == "404")
			{
				this.has_valid_license = false;
				MessageBox.Show(response[1]);
			}
			this.btnStart.Enabled = true;
			this.btnStop.Enabled = false;
			this.gridEmailList.VirtualMode = false;
			this.updateActivity();
			if (Main.spamwords.Count == 0)
			{
				Main.spamwords = Main.spamList.ToList<string>();
			}
			Main.spamwords = Main.spamwords.Distinct<string>().ToList<string>();
			this.onInitLoadSettings();
			string message = GxApi.getAnnouncementMessage("backend/get-message");
			if (message != "-1")
			{
				this.lblAnnouncement.Text = message;
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00011D84 File Offset: 0x0000FF84
		public void load_tester_url()
		{
			try
			{
				string html = string.Empty;
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://bestfriendstore.net/web/get/get-url?url=url");
				httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip;
				using (HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse())
				{
					using (Stream stream = response.GetResponseStream())
					{
						using (StreamReader reader = new StreamReader(stream))
						{
							html = reader.ReadToEnd();
						}
					}
				}
				Main.tester_url = html;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00011E3C File Offset: 0x0001003C
		private void onInitLoadSettings()
		{
			try
			{
				string filename = "settings.xml";
				if (File.Exists(filename))
				{
					string data = File.ReadAllText(filename).Trim();
					XmlDocument doc = new XmlDocument();
					doc.LoadXml(data);
					this.loadSMTPs(doc);
					this.loadLetters(doc);
					this.loadBulkSMTPs(doc);
					this.loadEmails(doc);
					this.loadLinks(doc);
					this.loadProxies(doc);
					this.loadSettings(doc);
					this.loadHeaders(doc);
					this.loadIMAPAccounts(doc);
					this.resetSettings();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.StackTrace.ToString(), "HeartSender");
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00011EE0 File Offset: 0x000100E0
		private void Common_MouseMove(object sender, MouseEventArgs e)
		{
			this.updateActivity();
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00011EE8 File Offset: 0x000100E8
		private void extractMailToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Coming Soon...");
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00011EF5 File Offset: 0x000100F5
		private void office365EditionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Coming Soon...");
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00011F02 File Offset: 0x00010102
		private void randomApiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Coming Soon...");
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00011F0F File Offset: 0x0001010F
		private void exiteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00011F16 File Offset: 0x00010116
		private void btnEmailAdd_Click(object sender, EventArgs e)
		{
			new ImportEmail(this).Show();
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00011F24 File Offset: 0x00010124
		public static void populateEmailsList(string[] _emails, Main current_main)
		{
			foreach (string email in _emails)
			{
				if (email != null && !(email == ""))
				{
					string formated_email = email.Replace("\\r\\n", "").Replace("\\r", "").Replace("\\n", "").Trim().ToLower();
					int index = current_main.gridEmailList.Rows.Add();
					current_main.gridEmailList.Rows[index].Cells["No"].Value = index + 1;
					current_main.gridEmailList.Rows[index].Cells["Email"].Value = formated_email;
					current_main.gridEmailList.Rows[index].Cells["Status"].Value = "";
					current_main.gridEmailList.Rows[index].Cells["Info"].Value = "";
				}
			}
			current_main.lblTotalEmails.Text = current_main.gridEmailList.Rows.Count.ToString();
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0001207C File Offset: 0x0001027C
		public static void populateLinksList(string[] _links, Main current_main)
		{
			Main.links.Clear();
			foreach (string link in _links)
			{
				if (link != null && !(link == ""))
				{
					Main.links.Add(link);
				}
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000120C4 File Offset: 0x000102C4
		public static void populateSpamWordsList(string[] _links, Main current_main)
		{
			Main.spamwords.Clear();
			foreach (string link in _links)
			{
				if (link != null && !(link == ""))
				{
					Main.spamwords.Add(link);
				}
			}
			Main.spamwords = Main.spamwords.Distinct<string>().ToList<string>();
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0001211E File Offset: 0x0001031E
		private void btnClear_Click(object sender, EventArgs e)
		{
			this.gridEmailList.Rows.Clear();
			this.lblTotalEmails.Text = "0";
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00012140 File Offset: 0x00010340
		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog file = new OpenFileDialog();
			file.Filter = "txt files (*.txt)|*.txt";
			Stream stream;
			if (file.ShowDialog() == DialogResult.OK && (stream = file.OpenFile()) != null)
			{
				using (StreamReader sr = new StreamReader(stream))
				{
					string[] smtps = sr.ReadToEnd().Split(new string[]
					{
						"\r\n",
						"\r",
						"\n"
					}, StringSplitOptions.None);
					this.loadSMTPData(smtps);
				}
				stream.Close();
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000121CC File Offset: 0x000103CC
		public void loadSMTPData(string[] data)
		{
			try
			{
				Main.smtps.Clear();
				GxDB db = new GxDB();
				for (int i = 0; i < data.Length; i++)
				{
					string[] tokens = data[i].Split(new string[]
					{
						"|"
					}, StringSplitOptions.None);
					int index = this.gridHostList.Rows.Add();
					this.gridHostList.Rows[index].Cells["Host"].Value = tokens[0];
					this.gridHostList.Rows[index].Cells["Port"].Value = tokens[1];
					this.gridHostList.Rows[index].Cells["Username"].Value = tokens[2];
					this.gridHostList.Rows[index].Cells["Password"].Value = tokens[3];
					this.gridHostList.Rows[index].Cells["Secure"].Value = tokens[4];
					this.gridHostList.Rows[index].Cells["Limit"].Value = "0";
					this.gridHostList.Rows[index].Cells["usage"].Value = "0";
					this.gridHostList.Rows[index].Cells["FromEmail"].Value = tokens[5];
					GxSMTP new_smtp = new GxSMTP();
					new_smtp.host = this.gridHostList.Rows[index].Cells["Host"].Value.ToString();
					new_smtp.port = int.Parse(this.gridHostList.Rows[index].Cells["Port"].Value.ToString());
					new_smtp.username = this.gridHostList.Rows[index].Cells["Username"].Value.ToString();
					new_smtp.password = this.gridHostList.Rows[index].Cells["Password"].Value.ToString();
					new_smtp.max_limit = 0;
					new_smtp.usage_count = db.getSmtpCount(new_smtp.getMd5Code());
					new_smtp.secure = false;
					new_smtp.from_email = this.gridHostList.Rows[index].Cells["FromEmail"].Value.ToString();
					if (this.gridHostList.Rows[index].Cells["Secure"].Value != null)
					{
						new_smtp.secure = (this.gridHostList.Rows[index].Cells["Secure"].Value.ToString() == "tls" || this.gridHostList.Rows[index].Cells["Secure"].Value.ToString() == "ssl");
					}
					Main.smtps.Add(new_smtp);
				}
				this.lblTotalSMTP.Text = Main.smtps.Count.ToString();
			}
			catch (Exception)
			{
				MessageBox.Show("Sorry, Invalid file format.");
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0001258C File Offset: 0x0001078C
		public void populateSMTPs()
		{
			this.gridHostList.Rows.Clear();
			foreach (GxSMTP smtp in Main.smtps)
			{
				int index = this.gridHostList.Rows.Add();
				this.gridHostList.Rows[index].Cells["Host"].Value = smtp.host;
				this.gridHostList.Rows[index].Cells["Port"].Value = smtp.port.ToString();
				this.gridHostList.Rows[index].Cells["Username"].Value = smtp.username;
				this.gridHostList.Rows[index].Cells["Password"].Value = smtp.password;
				this.gridHostList.Rows[index].Cells["Secure"].Value = (smtp.secure ? "ssl" : "");
				this.gridHostList.Rows[index].Cells["Limit"].Value = smtp.max_limit.ToString();
				this.gridHostList.Rows[index].Cells["Usage"].Value = smtp.usage_count.ToString();
				this.gridHostList.Rows[index].Cells["FromEmail"].Value = smtp.from_email;
			}
			this.lblTotalSMTP.Text = this.gridHostList.Rows.Count.ToString();
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000127A4 File Offset: 0x000109A4
		private void saveSettings(string filename)
		{
			XmlWriter xmlWriter = XmlWriter.Create(GxConfig.getBasePath() + filename);
			xmlWriter.WriteStartDocument();
			xmlWriter.WriteStartElement("HeartSender");
			xmlWriter.WriteStartElement("Letters");
			for (int i = 0; i < Main.letters.Count; i++)
			{
				xmlWriter.WriteStartElement("Letter");
				xmlWriter.WriteStartElement("Name");
				xmlWriter.WriteString(Main.letters[i].name.ToString());
				xmlWriter.WriteEndElement();
				xmlWriter.WriteStartElement("Letter");
				xmlWriter.WriteString(Main.letters[i].letter.ToString());
				xmlWriter.WriteEndElement();
				xmlWriter.WriteStartElement("Attachment");
				xmlWriter.WriteString(Main.letters[i].attachment.ToString());
				xmlWriter.WriteEndElement();
				xmlWriter.WriteStartElement("Is_Html");
				xmlWriter.WriteString(Main.letters[i].is_html.ToString());
				xmlWriter.WriteEndElement();
				xmlWriter.WriteStartElement("Is_Enable");
				xmlWriter.WriteString(Main.letters[i].is_enable.ToString());
				xmlWriter.WriteEndElement();
				xmlWriter.WriteStartElement("Attachment_tags");
				if (Main.letters[i].attachment_tags.ToString() != "")
				{
					xmlWriter.WriteString(Main.letters[i].attachment_tags.ToString());
				}
				else
				{
					xmlWriter.WriteString("");
				}
				xmlWriter.WriteEndElement();
				xmlWriter.WriteStartElement("FromName");
				xmlWriter.WriteString(Main.letters[i].fromname.ToString());
				xmlWriter.WriteEndElement();
				xmlWriter.WriteStartElement("FromEmail");
				int counter = 0;
				for (int j = 0; j < Main.letters[i].fromemail.Length; j++)
				{
					if (counter == Main.letters[i].fromemail.Length - 1)
					{
						xmlWriter.WriteString(Main.letters[i].fromemail[j].ToString());
					}
					else
					{
						xmlWriter.WriteString(Main.letters[i].fromemail[j].ToString() + "|");
					}
					counter++;
				}
				xmlWriter.WriteEndElement();
				xmlWriter.WriteStartElement("Subject");
				xmlWriter.WriteString(Main.letters[i].subject.ToString());
				xmlWriter.WriteEndElement();
				xmlWriter.WriteEndElement();
			}
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("SMTPS");
			Main.smtps.Clear();
			GxDB db = new GxDB();
			for (int k = 0; k < this.gridHostList.Rows.Count; k++)
			{
				GxSMTP smtp = new GxSMTP();
				xmlWriter.WriteStartElement("SMTP");
				xmlWriter.WriteStartElement("Host");
				xmlWriter.WriteString(this.gridHostList.Rows[k].Cells["Host"].Value.ToString());
				xmlWriter.WriteEndElement();
				xmlWriter.WriteStartElement("Port");
				xmlWriter.WriteString(this.gridHostList.Rows[k].Cells["Port"].Value.ToString());
				xmlWriter.WriteEndElement();
				xmlWriter.WriteStartElement("Username");
				xmlWriter.WriteString(this.gridHostList.Rows[k].Cells["Username"].Value.ToString());
				xmlWriter.WriteEndElement();
				xmlWriter.WriteStartElement("Password");
				xmlWriter.WriteString(this.gridHostList.Rows[k].Cells["Password"].Value.ToString());
				xmlWriter.WriteEndElement();
				xmlWriter.WriteStartElement("Secure");
				if (this.gridHostList.Rows[k].Cells["Secure"].Value != null)
				{
					xmlWriter.WriteString(this.gridHostList.Rows[k].Cells["Secure"].Value.ToString());
				}
				else
				{
					xmlWriter.WriteString("");
				}
				xmlWriter.WriteEndElement();
				xmlWriter.WriteStartElement("Limit");
				xmlWriter.WriteString(this.gridHostList.Rows[k].Cells["Limit"].Value.ToString());
				xmlWriter.WriteEndElement();
				xmlWriter.WriteStartElement("FromEmail");
				xmlWriter.WriteString(this.gridHostList.Rows[k].Cells["FromEmail"].Value.ToString());
				xmlWriter.WriteEndElement();
				smtp.host = this.gridHostList.Rows[k].Cells["Host"].Value.ToString();
				smtp.port = int.Parse(this.gridHostList.Rows[k].Cells["Port"].Value.ToString());
				smtp.username = this.gridHostList.Rows[k].Cells["Username"].Value.ToString();
				smtp.password = this.gridHostList.Rows[k].Cells["Password"].Value.ToString();
				smtp.max_limit = int.Parse(this.gridHostList.Rows[k].Cells["Limit"].Value.ToString());
				smtp.usage_count = db.getSmtpCount(smtp.getMd5Code());
				smtp.secure = false;
				smtp.is_proxy = true;
				smtp.from_email = this.gridHostList.Rows[k].Cells["FromEmail"].Value.ToString();
				xmlWriter.WriteStartElement("Usage");
				xmlWriter.WriteString(smtp.usage_count.ToString());
				xmlWriter.WriteEndElement();
				if (this.gridHostList.Rows[k].Cells["Secure"].Value != null)
				{
					smtp.secure = (this.gridHostList.Rows[k].Cells["Secure"].Value.ToString() == "tls" || this.gridHostList.Rows[k].Cells["Secure"].Value.ToString() == "ssl");
				}
				xmlWriter.WriteEndElement();
				Main.smtps.Add(smtp);
			}
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("BulkSMTPS");
			for (int l = 0; l < Main.bulk_smtps.Count; l++)
			{
				xmlWriter.WriteStartElement("SMTP");
				xmlWriter.WriteStartElement("Host");
				xmlWriter.WriteString(Main.bulk_smtps[l].host.ToString());
				xmlWriter.WriteEndElement();
				xmlWriter.WriteStartElement("Port");
				xmlWriter.WriteString(Main.bulk_smtps[l].port.ToString());
				xmlWriter.WriteEndElement();
				xmlWriter.WriteStartElement("Username");
				xmlWriter.WriteString(Main.bulk_smtps[l].username.ToString());
				xmlWriter.WriteEndElement();
				xmlWriter.WriteStartElement("Password");
				xmlWriter.WriteString(Main.bulk_smtps[l].password.ToString());
				xmlWriter.WriteEndElement();
				xmlWriter.WriteStartElement("Secure");
				if (Main.bulk_smtps[l].secure)
				{
					xmlWriter.WriteString("ssl");
				}
				else
				{
					xmlWriter.WriteString("");
				}
				xmlWriter.WriteEndElement();
				xmlWriter.WriteEndElement();
			}
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("IMAPAccounts");
			for (int m = 0; m < Main.imap_accounts.Count; m++)
			{
				xmlWriter.WriteStartElement("IMAPAccount");
				xmlWriter.WriteStartElement("IMAPServer");
				xmlWriter.WriteString(Main.imap_accounts[m].server_name.ToString());
				xmlWriter.WriteEndElement();
				xmlWriter.WriteStartElement("Port");
				xmlWriter.WriteString(Main.imap_accounts[m].port.ToString());
				xmlWriter.WriteEndElement();
				xmlWriter.WriteStartElement("Username");
				xmlWriter.WriteString(Main.imap_accounts[m].username.ToString());
				xmlWriter.WriteEndElement();
				xmlWriter.WriteStartElement("Password");
				xmlWriter.WriteString(Main.imap_accounts[m].password.ToString());
				xmlWriter.WriteEndElement();
				xmlWriter.WriteStartElement("Limit");
				xmlWriter.WriteString(Main.imap_accounts[m].limit.ToString());
				xmlWriter.WriteEndElement();
				xmlWriter.WriteStartElement("SSL");
				if (Main.imap_accounts[m].is_ssl)
				{
					xmlWriter.WriteString("SSL");
				}
				else
				{
					xmlWriter.WriteString("None");
				}
				xmlWriter.WriteEndElement();
				xmlWriter.WriteEndElement();
			}
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("Emails");
			Main.emails.Clear();
			for (int n = 0; n < this.gridEmailList.Rows.Count; n++)
			{
				xmlWriter.WriteStartElement("Email");
				xmlWriter.WriteString(this.gridEmailList.Rows[n].Cells["Email"].Value.ToString());
				if (this.gridEmailList.Rows[n].Cells["first_name"].Value != null)
				{
					xmlWriter.WriteStartElement("FirstName");
					xmlWriter.WriteString(this.gridEmailList.Rows[n].Cells["first_name"].Value.ToString());
					xmlWriter.WriteEndElement();
					Main.firstname.Add(this.gridEmailList.Rows[n].Cells["first_name"].Value.ToString());
				}
				if (this.gridEmailList.Rows[n].Cells["last_name"].Value != null)
				{
					xmlWriter.WriteStartElement("LastName");
					xmlWriter.WriteString(this.gridEmailList.Rows[n].Cells["last_name"].Value.ToString());
					xmlWriter.WriteEndElement();
					Main.lastname.Add(this.gridEmailList.Rows[n].Cells["last_name"].Value.ToString());
				}
				xmlWriter.WriteEndElement();
				Main.emails.Add(this.gridEmailList.Rows[n].Cells["Email"].Value.ToString());
			}
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("Links");
			for (int i2 = 0; i2 < Main.links.Count; i2++)
			{
				xmlWriter.WriteStartElement("Link");
				xmlWriter.WriteString(Main.links[i2].ToString());
				xmlWriter.WriteEndElement();
			}
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("Headers");
			string[] headers = this.settings[22].Split(new char[]
			{
				';'
			});
			for (int i3 = 0; i3 < headers.Length; i3++)
			{
				xmlWriter.WriteStartElement("Header");
				xmlWriter.WriteString(headers[i3]);
				xmlWriter.WriteEndElement();
			}
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("Proxies");
			for (int i4 = 0; i4 < Main.proxies.Count; i4++)
			{
				xmlWriter.WriteStartElement("Proxy");
				xmlWriter.WriteString(Main.proxies[i4].ToString());
				xmlWriter.WriteEndElement();
			}
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("Settings");
			xmlWriter.WriteStartElement("Connection");
			xmlWriter.WriteString(this.ctrlConNum.Value.ToString());
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("PauseEvery");
			xmlWriter.WriteString(this.ctrlPauseNum.Value.ToString());
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("Delay");
			xmlWriter.WriteString(this.ctrlSleepNum.Value.ToString());
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("RetryFailed");
			xmlWriter.WriteString(this.ctrlFailedNum.Value.ToString());
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("MailPriority");
			xmlWriter.WriteString(this.ctrlMailPriority.Text.ToString());
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("TimeOut");
			xmlWriter.WriteString(this.settings[0]);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("TextEncoding");
			xmlWriter.WriteString(this.settings[1]);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("BodyTransferEncoding");
			xmlWriter.WriteString(this.settings[2]);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("DeliveryFormat");
			xmlWriter.WriteString(this.settings[3]);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("AlternativeView");
			xmlWriter.WriteString(this.settings[4]);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("YourEmail");
			xmlWriter.WriteString(this.settings[5]);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("LetterEncoding");
			xmlWriter.WriteString(this.settings[6]);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("LetterEncryption");
			xmlWriter.WriteString(this.settings[7]);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("SubjectEncoding");
			xmlWriter.WriteString(this.settings[8]);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("LinkEncoding");
			xmlWriter.WriteString(this.settings[9]);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("FromNameEncoding");
			xmlWriter.WriteString(this.settings[10]);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("Attachment");
			xmlWriter.WriteString(this.settings[23]);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("AttachmentName");
			xmlWriter.WriteString(this.settings[24]);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("CustomKeyword");
			xmlWriter.WriteString(Main.keywords_list);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("PreHeader");
			xmlWriter.WriteString(this.settings[26]);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("ReplyEmail");
			xmlWriter.WriteString(this.settings[27]);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("ApiKey");
			xmlWriter.WriteString(this.settings[28]);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("ApiDomain");
			xmlWriter.WriteString(this.settings[29]);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("IMAPKeywords");
			xmlWriter.WriteString(this.settings[30]);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("IMAPRunAt");
			xmlWriter.WriteString(this.settings[31]);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("VerifyEmail");
			xmlWriter.WriteString(this.settings[32]);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("AllowDuplicate");
			xmlWriter.WriteString(this.settings[33]);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("SpamWords");
			xmlWriter.WriteString(this.settings[34]);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteStartElement("AllowValidateEmails");
			xmlWriter.WriteString(this.settings[35]);
			xmlWriter.WriteEndElement();
			xmlWriter.WriteEndElement();
			xmlWriter.WriteEndDocument();
			xmlWriter.Close();
			if (this.ctrlMailPriority.Text.ToLower() == "high")
			{
				this.settings[11] = "1";
			}
			else if (this.ctrlMailPriority.Text.ToLower() == "normal")
			{
				this.settings[11] = "3";
			}
			else if (this.ctrlMailPriority.Text.ToLower() == "low")
			{
				this.settings[11] = "5";
			}
			this.settings[19] = this.ctrlConNum.Value.ToString();
			this.settings[20] = this.ctrlPauseNum.Value.ToString();
			this.settings[21] = this.ctrlSleepNum.Value.ToString();
			this.percentage_change = (int)(Main.emails.Count / this.ctrlConNum.Value);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0001392C File Offset: 0x00011B2C
		private void resetSettings()
		{
			Main.smtps.Clear();
			GxDB db = new GxDB();
			for (int i = 0; i < this.gridHostList.Rows.Count; i++)
			{
				GxSMTP smtp = new GxSMTP();
				smtp.host = this.gridHostList.Rows[i].Cells["Host"].Value.ToString();
				smtp.port = int.Parse(this.gridHostList.Rows[i].Cells["Port"].Value.ToString());
				smtp.username = this.gridHostList.Rows[i].Cells["Username"].Value.ToString();
				smtp.password = this.gridHostList.Rows[i].Cells["Password"].Value.ToString();
				smtp.max_limit = int.Parse(this.gridHostList.Rows[i].Cells["Limit"].Value.ToString());
				smtp.usage_count = db.getSmtpCount(smtp.getMd5Code());
				smtp.secure = false;
				smtp.is_proxy = true;
				if (this.gridHostList.Rows[i].Cells["Secure"].Value != null)
				{
					smtp.secure = (this.gridHostList.Rows[i].Cells["Secure"].Value.ToString() == "tls" || this.gridHostList.Rows[i].Cells["Secure"].Value.ToString() == "ssl");
				}
				smtp.from_email = this.gridHostList.Rows[i].Cells["FromEmail"].Value.ToString();
				Main.smtps.Add(smtp);
			}
			Main.emails.Clear();
			Main.firstname.Clear();
			Main.lastname.Clear();
			for (int j = 0; j < this.gridEmailList.Rows.Count; j++)
			{
				Main.emails.Add(this.gridEmailList.Rows[j].Cells["Email"].Value.ToString());
				if (this.gridEmailList.Rows[j].Cells["first_name"].Value == null)
				{
					Main.firstname.Add("");
					Main.lastname.Add("");
				}
				else
				{
					Main.firstname.Add(this.gridEmailList.Rows[j].Cells["first_name"].Value.ToString());
					Main.lastname.Add(this.gridEmailList.Rows[j].Cells["last_name"].Value.ToString());
				}
			}
			if (this.ctrlMailPriority.Text.ToLower() == "high")
			{
				this.settings[11] = "1";
			}
			else if (this.ctrlMailPriority.Text.ToLower() == "normal")
			{
				this.settings[11] = "3";
			}
			else if (this.ctrlMailPriority.Text.ToLower() == "low")
			{
				this.settings[11] = "5";
			}
			else
			{
				this.settings[11] = "3";
			}
			this.settings[19] = this.ctrlConNum.Value.ToString();
			this.settings[20] = this.ctrlPauseNum.Value.ToString();
			this.settings[21] = this.ctrlSleepNum.Value.ToString();
			this.percentage_change = (int)(Main.emails.Count / this.ctrlConNum.Value);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00013D94 File Offset: 0x00011F94
		public void btnStart_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.gridEmailList.Rows.Count == 0 || this.gridHostList.Rows.Count == 0 || this.gridLetter.Rows.Count == 0)
				{
					MessageBox.Show("Sorry, your settings are not valid.");
				}
				else if (this.has_valid_license)
				{
					if (this.chkFastSending.Checked)
					{
						if (MessageBox.Show("You have enabled Fast Sending, which can dead SMTP quickly. Are you sure to go with this option?", "HeartSender", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
						{
							this.sending();
						}
					}
					else
					{
						this.sending();
					}
				}
				else
				{
					MessageBox.Show("Sorry, Your license verification failed.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("ERROR" + ex.Message.ToString());
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00013E5C File Offset: 0x0001205C
		public void sending()
		{
			this.ctrlProgress.Value = 0;
			this.btnStart.Enabled = false;
			this.btnStop.Enabled = true;
			this.ctrlProgress.Value = 0;
			this.is_completed = false;
			this.resetSettings();
			for (int i = 0; i < this.gridEmailList.Rows.Count; i++)
			{
				this.gridEmailList.Rows[i].Cells["Status"].Value = "Pending";
				this.gridEmailList.Rows[i].Cells["Info"].Value = "";
			}
			this.ctrlProgress.Minimum = 0;
			this.ctrlProgress.Maximum = Main.emails.Count;
			this.ctrlProgress.Value = 0;
			this.sent = 0;
			this.pending = 0;
			this.lbProgressStatus.Text = "Sent : 0 | Failed : 0 | Pending : " + Main.emails.Count.ToString();
			GxLogger.writeLog("--- Started ---", false);
			if (Main.last_stopped_counter != -1)
			{
				Main.last_stopped_counter++;
				if (MessageBox.Show("Do you want to resume?", "HeartSender", MessageBoxButtons.YesNo) == DialogResult.No)
				{
					Main.last_stopped_counter = -1;
				}
			}
			this.worker = new BackgroundWorker();
			this.worker.DoWork += this.bgw_DoWork;
			this.worker.ProgressChanged += this.bgw_ProgressChanged;
			this.worker.RunWorkerCompleted += this.bgw_RunWorkerCompleted;
			this.worker.WorkerReportsProgress = true;
			this.worker.WorkerSupportsCancellation = true;
			if (!this.worker.IsBusy)
			{
				this.worker.RunWorkerAsync();
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00014030 File Offset: 0x00012230
		public void bgw_DoWork(object sender, DoWorkEventArgs e)
		{
			Main.is_bug_reporting = false;
			GxSetting setting = new GxSetting(this);
			bool flag = setting.parseData();
			BackgroundWorker worker_job = sender as BackgroundWorker;
			if (flag)
			{
				GxLogger.writeLog("Workers started", true);
				GxItem item = new GxItem();
				Random r = new Random();
				new GxLicense();
				int sleep = setting.config.sending_delay * 1000;
				if (sleep == 0)
				{
					sleep = 3000;
				}
				if (this.chkFastSending.Checked)
				{
					sleep = 0;
				}
				this.max_threads = setting.config.email_countsend;
				int counter = 1;
				int counter_resumed = (Main.last_stopped_counter == -1) ? -1 : Main.last_stopped_counter;
				this.total_emails = Main.emails.Count;
				this.pending = this.total_emails;
				if (Main.spamwords.Count > 0)
				{
					setting.config.spam_words = string.Join(",", Main.spamwords);
				}
				if (setting.config.enable_duplicate)
				{
					Main.emails = Main.emails.ToList<string>();
				}
				else
				{
					Main.emails = Main.emails.Distinct<string>().ToList<string>();
				}
				GxLogger.writeLog("Emails => " + this.total_emails.ToString(), true);
				if (this.total_emails < this.max_threads)
				{
					this.max_threads = this.total_emails;
				}
				if (this.max_threads == 0)
				{
					this.max_threads = 1;
				}
				if (this.max_threads > 10)
				{
					this.max_threads = 10;
				}
				if (Main.emails.Count <= 10)
				{
					this.max_threads = Main.emails.Count;
				}
				Console.WriteLine("Max Threads: " + this.max_threads.ToString());
				GxLogger.writeLog("Threads => " + this.max_threads.ToString(), true);
				new List<GxSMTP>();
				string[] keywords = Main.keywords_list.Split(new string[]
				{
					","
				}, StringSplitOptions.RemoveEmptyEntries);
				GxSMTP.queue.Clear();
				GxSMTP.is_running = false;
				int smtp_counter = 0;
				int batch_size = 0;
				GxApi api = new GxApi();
				string api_url = GxConfig.baseUrl() + "backend/parse";
				string letter_server_response = "";
				string letter_pending = "";
				int cc = 0;
				int active_letter_counter = 0;
				using (List<string>.Enumerator enumerator = Main.emails.GetEnumerator())
				{
					IL_DEE:
					while (enumerator.MoveNext())
					{
						string current_email = enumerator.Current;
						this.updateActivity();
						if (worker_job.CancellationPending)
						{
							break;
						}
						for (int i = 0; i < Main.letters.Count; i++)
						{
							if (Main.letters[i].is_enable)
							{
								Main.active_letters.Add(Main.letters[i]);
							}
						}
						setting.config.from_name = Main.active_letters[active_letter_counter].fromname;
						setting.config.subject = Main.active_letters[active_letter_counter].subject;
						item = new GxItem();
						while (setting.config.smtp.Count != 0)
						{
							if (smtp_counter + 1 >= setting.config.smtp.Count)
							{
								smtp_counter = 0;
							}
							else
							{
								smtp_counter++;
							}
							item.smtp_index = smtp_counter;
							GxSMTP smtp = setting.config.smtp[r.Next(0, setting.config.smtp.Count)];
							if (smtp.max_limit > 0 && new GxDB().getSmtpCount(smtp.getMd5Code()) + batch_size > smtp.max_limit)
							{
								Main.dead_list.Add(item.smtp_index);
								if (Main.dead_list.Count > 0)
								{
									Main.old_active_list = new Hashtable();
									for (int c = 0; c < setting.config.smtp.Count; c++)
									{
										if (Main.dead_list.Contains(c))
										{
											try
											{
												Main.old_active_list.Add(string.Concat(new string[]
												{
													setting.config.smtp[c].username,
													";",
													setting.config.smtp[c].password,
													";",
													setting.config.smtp[c].host,
													";",
													setting.config.smtp[c].port.ToString()
												}), "");
											}
											catch (Exception)
											{
											}
										}
									}
									MessageBox.Show("Notice: Some of SMTP(s) max limit reached. Waiting [20 Sec.] ...!", "HeartSender", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
									Thread.Sleep(20000);
									setting.parseData();
									List<GxSMTP> active_list = new List<GxSMTP>();
									for (int c2 = 0; c2 < setting.config.smtp.Count; c2++)
									{
										try
										{
											string key = string.Concat(new string[]
											{
												setting.config.smtp[c2].username,
												";",
												setting.config.smtp[c2].password,
												";",
												setting.config.smtp[c2].host,
												";",
												setting.config.smtp[c2].port.ToString()
											});
											if (!Main.old_active_list.ContainsKey(key))
											{
												active_list.Add(setting.config.smtp[c2]);
											}
										}
										catch (Exception)
										{
										}
									}
									setting.config.smtp = active_list;
									Main.dead_list = new List<int>();
									continue;
								}
							}
							if (active_letter_counter == Main.active_letters.Count)
							{
								active_letter_counter = 0;
							}
							int rr = r.Next(0, Main.active_letters[active_letter_counter].fromemail.Length);
							Main.smtp_domain_name = smtp.host;
							Main.smtp_user_name = smtp.username;
							if (smtp.from_email == "" || smtp.from_email == null)
							{
								smtp.from_email = Main.active_letters[active_letter_counter].fromemail[rr];
							}
							else
							{
								for (int j = 0; j < this.gridHostList.Rows.Count; j++)
								{
									if (this.gridHostList.Rows[j].Cells["Password"].Value.ToString() == smtp.password)
									{
										if (this.gridHostList.Rows[j].Cells["FromEmail"].Value.ToString() == "" || this.gridHostList.Rows[j].Cells["FromEmail"].Value.ToString() == null)
										{
											smtp.from_email = Main.active_letters[active_letter_counter].fromemail[rr];
										}
										else
										{
											smtp.from_email = this.gridHostList.Rows[j].Cells["FromEmail"].Value.ToString();
										}
									}
								}
							}
							item.counter = counter;
							item.email = current_email;
							item.firstname = Main.firstname[cc].Trim();
							item.lastname = Main.lastname[cc].Trim();
							item.from_name = setting.config.from_name;
							item.target_email_name = setting.config.target_email_name;
							item.reply_email_name = setting.config.reply_email_name;
							item.reply_email = setting.config.reply_email;
							item.config = setting.config;
							item.letter = Main.active_letters[active_letter_counter].letter;
							item.config.using_attachment = 0;
							if (Main.active_letters[active_letter_counter].attachment != "")
							{
								item.config.using_attachment = 1;
								this.getAttachmentTags(Main.active_letters[active_letter_counter].attachment);
								item.config.file_attachment = Main.active_letters[active_letter_counter].attachment;
							}
							cc++;
							item.headers = this.settings[22].Split(new char[]
							{
								';'
							});
							item.sending_delay = sleep;
							smtp.item = item;
							smtp.sender_email = Main.sender_email;
							smtp.smtp_domain_name = Main.smtp_domain_name;
							smtp.smtp_user_name = Main.smtp_user_name;
							smtp.item_progress = "";
							smtp.counter_log = "";
							smtp.item.is_sent = false;
							smtp.counter_index = counter - 1;
							if (counter_resumed != -1 && counter_resumed >= counter)
							{
								counter++;
								smtp.item.is_sent = true;
								smtp.counter_log = "Processed";
								smtp.item_progress = "";
								worker_job.ReportProgress(1, Main.DeepCopy<GxSMTP>(smtp));
								goto IL_DEE;
							}
							if (batch_size == 0)
							{
								int letter_counter = 1;
								letter_pending = smtp.item.letter;
								letter_pending = letter_pending.Replace("##AUTOEMAILAE##", "##NEW_AUTOEMAILAE##");
								letter_pending = letter_pending.Replace("##EMAIL_LINK##", "##NEW_EMAIL_LINK##");
								letter_pending = letter_pending.Replace("##EMAILB64##", "##NEW_EMAILB64##");
								letter_pending = letter_pending.Replace("##EMAIL##", "##NEW_EMAIL##");
								letter_pending = letter_pending.Replace("##random_email##", "##NEW_random_email##");
								letter_pending = letter_pending.Replace("[-AUTOEMAILAE-]", "[-NEW_AUTOEMAILAE-]");
								letter_pending = letter_pending.Replace("[-EMAIL_LINK-]", "[-NEW_EMAIL_LINK-]");
								letter_pending = letter_pending.Replace("[-EMAILB64-]", "[-NEW_EMAILB64-]");
								letter_pending = letter_pending.Replace("[-EMAIL-]", "[-NEW_EMAIL-]");
								letter_pending = letter_pending.Replace("[-random_email-]", "[-NEW_random_email-]");
								letter_pending = letter_pending.Replace("[-firstname-]", "[-FIRSTNAME-]");
								letter_pending = letter_pending.Replace("[-lastname-]", "[-LASTNAME-]");
								smtp.item.letter = letter_pending;
								object[] o_list = GxSMTP.processEmail(smtp, Main.links, keywords);
								for (;;)
								{
									letter_server_response = api.getLetter((List<string>)o_list[1], api_url);
									if (!(letter_server_response == "100") && !(letter_server_response == "101"))
									{
										break;
									}
									smtp.item.is_sent = false;
									smtp.counter_log = "Template Error: " + smtp.server_response;
									this.worker.ReportProgress(1, smtp);
									letter_counter++;
									if (letter_counter >= 4)
									{
										break;
									}
									Thread.Sleep(3000);
									smtp.item.is_sent = false;
									smtp.counter_log = "Retrying ...";
									this.worker.ReportProgress(1, smtp);
								}
							}
							smtp.item.letter = letter_pending;
							smtp.server_response = letter_server_response;
							if (smtp.server_response == "100" || smtp.server_response == "101")
							{
								smtp.item.is_sent = false;
								smtp.counter_log = "Template Error: " + smtp.server_response;
								this.worker.ReportProgress(1, smtp);
								smtp.server_response = "-1";
							}
							batch_size++;
							bool q_status = GxSMTP.addInQueue(worker_job, Main.DeepCopy<GxSMTP>(smtp));
							if (!q_status)
							{
								while (!q_status)
								{
									Thread.Sleep(10000);
									q_status = GxSMTP.addInQueue(worker_job, Main.DeepCopy<GxSMTP>(smtp));
								}
							}
							if (batch_size == 1)
							{
								GxSMTP.processQueue(worker_job, keywords, Main.links, Main.proxies, this.max_threads);
								Thread.Sleep(2000);
								while (GxSMTP.is_running)
								{
									Thread.Sleep(2000);
								}
								batch_size = 0;
							}
							if (Main.dead_list.Count > 0)
							{
								Main.old_active_list = new Hashtable();
								for (int c3 = 0; c3 < setting.config.smtp.Count; c3++)
								{
									if (Main.dead_list.Contains(c3))
									{
										try
										{
											Main.old_active_list.Add(string.Concat(new string[]
											{
												setting.config.smtp[c3].username,
												";",
												setting.config.smtp[c3].password,
												";",
												setting.config.smtp[c3].host,
												";",
												setting.config.smtp[c3].port.ToString()
											}), "");
										}
										catch (Exception)
										{
										}
									}
								}
								MessageBox.Show("Notice: Some of SMTP(s) are dead or not working. Waiting [20 Sec.] ...!", "HeartSender", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
								Thread.Sleep(20000);
								setting.parseData();
								List<GxSMTP> active_list2 = new List<GxSMTP>();
								for (int c4 = 0; c4 < setting.config.smtp.Count; c4++)
								{
									try
									{
										string key2 = string.Concat(new string[]
										{
											setting.config.smtp[c4].username,
											";",
											setting.config.smtp[c4].password,
											";",
											setting.config.smtp[c4].host,
											";",
											setting.config.smtp[c4].port.ToString()
										});
										if (!Main.old_active_list.ContainsKey(key2))
										{
											active_list2.Add(setting.config.smtp[c4]);
										}
									}
									catch (Exception)
									{
									}
								}
								setting.config.smtp = active_list2;
								Main.dead_list = new List<int>();
							}
							if (worker_job.CancellationPending)
							{
								e.Cancel = true;
							}
							counter++;
							active_letter_counter++;
							goto IL_DEE;
						}
						MessageBox.Show("Sorry, all SMTP(s) dead or not working.", "HeartSender", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						break;
					}
				}
				if (GxSMTP.queue.Count > 0 && !GxSMTP.is_running)
				{
					GxSMTP.processQueue(worker_job, keywords, Main.links, Main.proxies, this.max_threads);
					Thread.Sleep(3000);
				}
				while (GxSMTP.is_running && !worker_job.CancellationPending)
				{
					if (worker_job.CancellationPending)
					{
						e.Cancel = true;
					}
					if (this.pending == 0)
					{
						GxSMTP.is_running = false;
					}
					Thread.Sleep(3000);
					if (GxSMTP.queue.Count > 0 && !GxSMTP.thread.IsAlive)
					{
						GxSMTP.processQueue(worker_job, keywords, Main.links, Main.proxies, this.max_threads);
						Thread.Sleep(3000);
					}
				}
				GxApi.heartbeat(Main.delivered);
				return;
			}
			MessageBox.Show("Invalid Settings", "HeartSender", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00014F90 File Offset: 0x00013190
		public static void showLogs(string log, RichTextBox txt)
		{
			if (Main.logs.Count > 50)
			{
				Main.logs.RemoveRange(0, 1);
			}
			Main.logs.Add("> " + log);
			Main.logs.Reverse();
			txt.Text = string.Join("\n", Main.logs);
			Main.logs.Reverse();
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00014FF8 File Offset: 0x000131F8
		public void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			GxSMTP smtp = (GxSMTP)e.UserState;
			Main.last_stopped_counter = smtp.counter_index;
			object obj = Main.locker;
			lock (obj)
			{
				if (smtp.item_progress != "")
				{
					if (smtp.item_progress == "Queued")
					{
						this.gridEmailList.Rows[smtp.counter_index].Cells["Status"].Value = "Queued";
					}
					else
					{
						this.gridEmailList.Rows[smtp.counter_index].Cells["Info"].Value = smtp.item_progress;
					}
				}
				else if ((this.gridEmailList.Rows[smtp.counter_index].Cells["Status"].Value.ToString() == "Queued" || this.gridEmailList.Rows[smtp.counter_index].Cells["Status"].Value.ToString() == "Pending" || this.gridEmailList.Rows[smtp.counter_index].Cells["Status"].Value.ToString() == "Failed") && smtp.counter_log != "")
				{
					if (this.ctrlProgress.Value + smtp.item.progress_count <= this.ctrlProgress.Maximum)
					{
						this.ctrlProgress.Value += smtp.item.progress_count;
					}
					Main.showLogs(string.Concat(new string[]
					{
						"[",
						this.gridEmailList.Rows[smtp.counter_index].Cells["Email"].Value.ToString(),
						"][",
						smtp.host,
						"|",
						smtp.port.ToString(),
						"|",
						smtp.username,
						"|",
						smtp.password,
						"][",
						smtp.item.is_sent ? "Sent" : "Failed",
						"][",
						smtp.counter_log,
						"]"
					}), this.txtLogs);
					this.gridEmailList.Rows[smtp.counter_index].Cells["Status"].Value = (smtp.item.is_sent ? "Sent" : "Failed");
					this.gridEmailList.Rows[smtp.counter_index].Cells["Info"].Value = smtp.counter_log;
					if (smtp.item.is_sent)
					{
						this.sent += smtp.item.progress_count;
						if (this.sent > Main.emails.Count)
						{
							this.sent = Main.emails.Count;
						}
						this.pending -= smtp.item.progress_count;
						if (this.pending < 0)
						{
							this.pending = 0;
						}
						new GxDB().add(new string[]
						{
							smtp.item.email,
							"sent",
							smtp.getMd5Code()
						});
						smtp.usage_count++;
					}
					else
					{
						this.failed += smtp.item.progress_count;
						if (this.failed > Main.emails.Count)
						{
							this.failed = Main.emails.Count;
						}
						this.pending -= smtp.item.progress_count;
						if (this.pending < 0)
						{
							this.pending = 0;
						}
					}
					this.lbProgressStatus.Text = string.Concat(new string[]
					{
						"Sent : ",
						this.sent.ToString(),
						" | Failed : ",
						this.failed.ToString(),
						" | Pending : ",
						this.pending.ToString()
					});
				}
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000154A8 File Offset: 0x000136A8
		public void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.ctrlProgress.Value = Main.emails.Count;
			if (Main.last_stopped_counter + 1 >= Main.emails.Count)
			{
				Main.last_stopped_counter = -1;
			}
			this.btnStart.Enabled = true;
			this.btnStop.Enabled = false;
			this.lbProgressStatus.Text = string.Concat(new string[]
			{
				"Sent : ",
				this.sent.ToString(),
				" | Failed : ",
				this.failed.ToString(),
				" | Pending : 0"
			});
			if (!this.is_completed && !e.Cancelled)
			{
				this.is_completed = true;
				GxLogger.writeLog("--- Completed ---", true);
				MessageBox.Show("Done", "HeartSender", MessageBoxButtons.OK);
				Main.active_letters.Clear();
				GxSMTP.count = 0;
			}
			if (e.Cancelled)
			{
				MessageBox.Show("Operation was canceled");
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0001559B File Offset: 0x0001379B
		private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			new Settings(this).Show();
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000155A8 File Offset: 0x000137A8
		public static void sentEmailsList()
		{
			using (StreamWriter file = new StreamWriter(GxConfig.getBasePath() + "confirmed.txt"))
			{
				foreach (string line in GxSMTP.confirmed)
				{
					file.WriteLine(line);
				}
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00015628 File Offset: 0x00013828
		public static void updateEmailsList(GxConfig config, List<string> list)
		{
			using (StreamWriter file = new StreamWriter(GxConfig.getBasePath() + config.list_email))
			{
				foreach (string email in list)
				{
					if (!GxSMTP.confirmed.Contains(email))
					{
						file.WriteLine(email);
					}
				}
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000156B0 File Offset: 0x000138B0
		public static void failedEmailsList()
		{
			using (StreamWriter file = new StreamWriter(GxConfig.getBasePath() + "failed.txt"))
			{
				foreach (string line in GxSMTP.failed)
				{
					file.WriteLine(line);
				}
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00015730 File Offset: 0x00013930
		public static T DeepCopy<T>(T obj)
		{
			if (!typeof(T).IsSerializable)
			{
				throw new Exception("The source object must be serializable");
			}
			if (obj == null)
			{
				throw new Exception("The source object must not be null");
			}
			T result = default(T);
			using (MemoryStream memoryStream = new MemoryStream())
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				binaryFormatter.Serialize(memoryStream, obj);
				memoryStream.Seek(0L, SeekOrigin.Begin);
				result = (T)((object)binaryFormatter.Deserialize(memoryStream));
				memoryStream.Close();
			}
			return result;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000157C8 File Offset: 0x000139C8
		public long getEmailsCount(GxConfig config)
		{
			int max = config.mail_limit;
			long lineCounter = 0L;
			long result;
			using (StreamReader reader = new StreamReader(new FileInfo(GxConfig.getBasePath() + config.list_email).FullName))
			{
				string current_email = string.Empty;
				while ((current_email = reader.ReadLine()) != null)
				{
					if (current_email.Trim().Length > 0 && lineCounter < (long)max)
					{
						Main.emails.Add(current_email);
						lineCounter += 1L;
					}
				}
				result = lineCounter;
			}
			return result;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00015858 File Offset: 0x00013A58
		private void saveConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.saveSettings("settings.xml");
			MessageBox.Show("Configuration successfully saved.", "HeartSender", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00015878 File Offset: 0x00013A78
		private void loadConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog file = new OpenFileDialog();
				file.Filter = "XML files (*.xml)|*.xml";
				Stream stream;
				if (file.ShowDialog() == DialogResult.OK && (stream = file.OpenFile()) != null)
				{
					using (StreamReader sr = new StreamReader(stream))
					{
						string data = sr.ReadToEnd().Trim();
						XmlDocument doc = new XmlDocument();
						doc.LoadXml(data);
						this.loadLetters(doc);
						this.loadSMTPs(doc);
						this.loadBulkSMTPs(doc);
						this.loadEmails(doc);
						this.loadLinks(doc);
						this.loadProxies(doc);
						this.loadSettings(doc);
						this.loadHeaders(doc);
					}
					stream.Close();
					this.resetSettings();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(), "HeartSender", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00015960 File Offset: 0x00013B60
		private void loadLetters(XmlDocument doc)
		{
			XmlNode node = doc.DocumentElement.SelectSingleNode("/HeartSender/Letters");
			if (node != null && node.ChildNodes != null && node.ChildNodes.Count > 0)
			{
				this.gridLetter.Rows.Clear();
				Main.letters.Clear();
				new GxDB();
				foreach (object obj in node.ChildNodes)
				{
					XmlNodeList list = ((XmlNode)obj).ChildNodes;
					GxLetter _new_letter = new GxLetter();
					_new_letter.name = list[0].InnerText;
					_new_letter.letter = list[1].InnerText;
					_new_letter.attachment = list[2].InnerText;
					_new_letter.is_html = true;
					_new_letter.is_enable = bool.Parse(list[4].InnerText);
					_new_letter.attachment_tags = list[5].InnerText;
					_new_letter.fromname = list[6].InnerText;
					string[] rw = list[7].InnerText.Split(new char[]
					{
						'|'
					});
					_new_letter.fromemail = rw;
					_new_letter.subject = list[8].InnerText;
					Main.letters.Add(_new_letter);
					int index = this.gridLetter.Rows.Add();
					this.gridLetter.Rows[index].Cells[5].Value = _new_letter.is_enable;
					this.gridLetter.Rows[index].Cells[0].Value = _new_letter.fromname;
					int counter = 0;
					for (int i = 0; i < _new_letter.fromemail.Length; i++)
					{
						if (counter == _new_letter.fromemail.Length - 1)
						{
							DataGridViewCell dataGridViewCell = this.gridLetter.Rows[index].Cells[1];
							object value = dataGridViewCell.Value;
							dataGridViewCell.Value = ((value != null) ? value.ToString() : null) + _new_letter.fromemail[i];
						}
						else
						{
							DataGridViewCell dataGridViewCell2 = this.gridLetter.Rows[index].Cells[1];
							object value2 = dataGridViewCell2.Value;
							dataGridViewCell2.Value = ((value2 != null) ? value2.ToString() : null) + _new_letter.fromemail[i] + "|";
						}
						counter++;
					}
					this.gridLetter.Rows[index].Cells[2].Value = _new_letter.subject;
					this.gridLetter.Rows[index].Cells[3].Value = _new_letter.name;
					this.gridLetter.Rows[index].Cells[4].Value = _new_letter.attachment;
				}
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00015C8C File Offset: 0x00013E8C
		private void loadSMTPs(XmlDocument doc)
		{
			XmlNode node = doc.DocumentElement.SelectSingleNode("/HeartSender/SMTPS");
			if (node != null && node.ChildNodes != null && node.ChildNodes.Count > 0)
			{
				this.gridHostList.Rows.Clear();
				Main.smtps.Clear();
				GxDB db = new GxDB();
				foreach (object obj in node.ChildNodes)
				{
					XmlNodeList list = ((XmlNode)obj).ChildNodes;
					int index = this.gridHostList.Rows.Add();
					this.gridHostList.Rows[index].Cells["Host"].Value = list[0].InnerText;
					this.gridHostList.Rows[index].Cells["Port"].Value = list[1].InnerText;
					this.gridHostList.Rows[index].Cells["Username"].Value = list[2].InnerText;
					this.gridHostList.Rows[index].Cells["Password"].Value = list[3].InnerText;
					this.gridHostList.Rows[index].Cells["Secure"].Value = list[4].InnerText;
					this.gridHostList.Rows[index].Cells["Limit"].Value = 0;
					GxSMTP new_smtp = new GxSMTP();
					new_smtp.host = this.gridHostList.Rows[index].Cells["Host"].Value.ToString();
					new_smtp.port = int.Parse(this.gridHostList.Rows[index].Cells["Port"].Value.ToString());
					new_smtp.username = this.gridHostList.Rows[index].Cells["Username"].Value.ToString();
					new_smtp.password = this.gridHostList.Rows[index].Cells["Password"].Value.ToString();
					new_smtp.max_limit = int.Parse(this.gridHostList.Rows[index].Cells["Limit"].Value.ToString());
					this.gridHostList.Rows[index].Cells["Usage"].Value = db.getSmtpCount(new_smtp.getMd5Code());
					if (list.Count >= 6)
					{
						this.gridHostList.Rows[index].Cells["Limit"].Value = list[5].InnerText;
					}
					new_smtp.secure = false;
					if (this.gridHostList.Rows[index].Cells["Secure"].Value != null)
					{
						new_smtp.secure = (this.gridHostList.Rows[index].Cells["Secure"].Value.ToString() == "tls" || this.gridHostList.Rows[index].Cells["Secure"].Value.ToString() == "ssl");
					}
					this.gridHostList.Rows[index].Cells["FromEmail"].Value = "";
					if (list.Count >= 7)
					{
						new_smtp.from_email = list[6].InnerText.Trim();
						this.gridHostList.Rows[index].Cells["FromEmail"].Value = list[6].InnerText;
					}
					Main.smtps.Add(new_smtp);
				}
				this.lblTotalSMTP.Text = this.gridHostList.Rows.Count.ToString();
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00016150 File Offset: 0x00014350
		private void loadIMAPAccounts(XmlDocument doc)
		{
			XmlNode node = doc.DocumentElement.SelectSingleNode("/HeartSender/IMAPAccounts");
			if (node != null && node.ChildNodes != null && node.ChildNodes.Count > 0)
			{
				Main.imap_accounts.Clear();
				foreach (object obj in node.ChildNodes)
				{
					XmlNodeList list = ((XmlNode)obj).ChildNodes;
					GxIMAPAccount imap = new GxIMAPAccount();
					imap.server_name = list[0].InnerText;
					imap.port = int.Parse(list[1].InnerText);
					imap.username = list[2].InnerText;
					imap.password = list[3].InnerText;
					imap.limit = int.Parse(list[4].InnerText);
					imap.is_ssl = false;
					if (list[5].InnerText.ToLower() == "ssl")
					{
						imap.is_ssl = true;
					}
					Main.imap_accounts.Add(imap);
				}
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00016290 File Offset: 0x00014490
		private void load(XmlDocument doc)
		{
			XmlNode node = doc.DocumentElement.SelectSingleNode("/HeartSender/BulkSMTPS");
			if (node != null && node.ChildNodes != null && node.ChildNodes.Count > 0)
			{
				Main.bulk_smtps.Clear();
				GxDB db = new GxDB();
				foreach (object obj in node.ChildNodes)
				{
					XmlNodeList list = ((XmlNode)obj).ChildNodes;
					GxSMTP new_smtp = new GxSMTP();
					new_smtp.host = list[0].InnerText;
					new_smtp.port = int.Parse(list[1].InnerText);
					new_smtp.username = list[2].InnerText;
					new_smtp.password = list[3].InnerText;
					new_smtp.usage_count = db.getSmtpCount(new_smtp.getMd5Code());
					new_smtp.secure = false;
					if (list[4].InnerText != null)
					{
						new_smtp.secure = (list[4].InnerText == "tls" || list[4].InnerText == "ssl");
					}
					if (list.Count >= 6)
					{
						new_smtp.max_limit = int.Parse(list[5].InnerText.Trim());
					}
					Main.bulk_smtps.Add(new_smtp);
				}
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0001642C File Offset: 0x0001462C
		private void loadBulkSMTPs(XmlDocument doc)
		{
			XmlNode node = doc.DocumentElement.SelectSingleNode("/HeartSender/BulkSMTPS");
			if (node != null && node.ChildNodes != null && node.ChildNodes.Count > 0)
			{
				Main.bulk_smtps.Clear();
				GxDB db = new GxDB();
				foreach (object obj in node.ChildNodes)
				{
					XmlNodeList list = ((XmlNode)obj).ChildNodes;
					GxSMTP new_smtp = new GxSMTP();
					new_smtp.host = list[0].InnerText;
					new_smtp.port = int.Parse(list[1].InnerText);
					new_smtp.username = list[2].InnerText;
					new_smtp.password = list[3].InnerText;
					new_smtp.usage_count = db.getSmtpCount(new_smtp.getMd5Code());
					new_smtp.secure = false;
					if (list[4].InnerText != null)
					{
						new_smtp.secure = (list[4].InnerText == "tls" || list[4].InnerText == "ssl");
					}
					if (list.Count >= 6)
					{
						new_smtp.max_limit = int.Parse(list[5].InnerText.Trim());
					}
					Main.bulk_smtps.Add(new_smtp);
				}
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000165C8 File Offset: 0x000147C8
		private void loadEmails(XmlDocument doc)
		{
			XmlNode node = doc.DocumentElement.SelectSingleNode("/HeartSender/Emails");
			if (node != null && node.ChildNodes != null && node.ChildNodes.Count > 0)
			{
				this.gridEmailList.Rows.Clear();
				foreach (object obj in node.ChildNodes)
				{
					XmlNodeList list = ((XmlNode)obj).ChildNodes;
					if (list.Count > 1)
					{
						int index = this.gridEmailList.Rows.Add();
						this.gridEmailList.Rows[index].Cells["No"].Value = index + 1;
						this.gridEmailList.Rows[index].Cells["Email"].Value = list[0].InnerText;
						this.gridEmailList.Rows[index].Cells["first_name"].Value = list[1].InnerText;
						this.gridEmailList.Rows[index].Cells["last_name"].Value = list[2].InnerText;
						this.gridEmailList.Rows[index].Cells["Status"].Value = "";
						this.gridEmailList.Rows[index].Cells["Info"].Value = "";
					}
					else
					{
						int index = this.gridEmailList.Rows.Add();
						this.gridEmailList.Rows[index].Cells["No"].Value = index + 1;
						this.gridEmailList.Rows[index].Cells["Email"].Value = list[0].InnerText;
						this.gridEmailList.Rows[index].Cells["Status"].Value = "";
						this.gridEmailList.Rows[index].Cells["Info"].Value = "";
					}
				}
				this.lblTotalEmails.Text = this.gridEmailList.Rows.Count.ToString();
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00016898 File Offset: 0x00014A98
		private void loadLinks(XmlDocument doc)
		{
			XmlNode node = doc.DocumentElement.SelectSingleNode("/HeartSender/Links");
			if (node != null && node.ChildNodes != null && node.ChildNodes.Count > 0)
			{
				Main.links.Clear();
				foreach (object obj in node.ChildNodes)
				{
					XmlNodeList list = ((XmlNode)obj).ChildNodes;
					Main.links.Add(list[0].InnerText);
				}
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0001693C File Offset: 0x00014B3C
		private void loadProxies(XmlDocument doc)
		{
			XmlNode node = doc.DocumentElement.SelectSingleNode("/HeartSender/Proxies");
			if (node != null && node.ChildNodes != null && node.ChildNodes.Count > 0)
			{
				Main.proxies.Clear();
				foreach (object obj in node.ChildNodes)
				{
					XmlNodeList list = ((XmlNode)obj).ChildNodes;
					Main.proxies.Add(list[0].InnerText);
				}
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000169E0 File Offset: 0x00014BE0
		private void loadSettings(XmlDocument doc)
		{
			XmlNode node = doc.DocumentElement.SelectSingleNode("/HeartSender/Settings");
			if (node.ChildNodes.Count > 0)
			{
				foreach (object obj in node.ChildNodes)
				{
					XmlNode inner_node = (XmlNode)obj;
					string name = inner_node.Name;
					uint num = <PrivateImplementationDetails>.ComputeStringHash(name);
					if (num <= 2524398436U)
					{
						if (num <= 1318255980U)
						{
							if (num <= 321593987U)
							{
								if (num != 166350841U)
								{
									if (num != 320667541U)
									{
										if (num == 321593987U)
										{
											if (name == "AllowDuplicate")
											{
												this.settings[33] = ((inner_node.InnerText == null || inner_node.InnerText == "") ? "0" : inner_node.InnerText);
											}
										}
									}
									else if (name == "AllowValidateEmails")
									{
										this.settings[35] = ((inner_node.InnerText == null || inner_node.InnerText == "") ? "0" : inner_node.InnerText);
										Main.is_validate = this.settings[35];
									}
								}
								else if (name == "Connection")
								{
									this.ctrlConNum.Value = int.Parse(inner_node.InnerText);
									this.settings[19] = inner_node.InnerText;
								}
							}
							else if (num <= 550270072U)
							{
								if (num != 516962658U)
								{
									if (num == 550270072U)
									{
										if (name == "Delay")
										{
											this.ctrlSleepNum.Value = int.Parse(inner_node.InnerText);
											this.settings[21] = inner_node.InnerText;
										}
									}
								}
								else if (name == "DeliveryFormat")
								{
									this.settings[3] = inner_node.InnerText;
								}
							}
							else if (num != 952833052U)
							{
								if (num == 1318255980U)
								{
									if (name == "PauseEvery")
									{
										this.ctrlPauseNum.Value = int.Parse(inner_node.InnerText);
										this.settings[20] = inner_node.InnerText;
									}
								}
							}
							else if (name == "VerifyEmail")
							{
								this.settings[32] = ((inner_node.InnerText == null || inner_node.InnerText == "") ? "0" : inner_node.InnerText);
							}
						}
						else if (num <= 1436019879U)
						{
							if (num != 1337153007U)
							{
								if (num != 1372909965U)
								{
									if (num == 1436019879U)
									{
										if (name == "BodyTransferEncoding")
										{
											this.settings[2] = inner_node.InnerText;
										}
									}
								}
								else if (name == "CustomKeyword")
								{
									Main.keywords_list = inner_node.InnerText.Trim();
								}
							}
							else if (name == "TextEncoding")
							{
								this.settings[1] = inner_node.InnerText;
							}
						}
						else if (num <= 2234257447U)
						{
							if (num != 1684183111U)
							{
								if (num == 2234257447U)
								{
									if (name == "PreHeader")
									{
										this.settings[26] = inner_node.InnerText;
									}
								}
							}
							else if (name == "FromNameEncoding")
							{
								this.settings[10] = inner_node.InnerText;
							}
						}
						else if (num != 2270947486U)
						{
							if (num == 2524398436U)
							{
								if (name == "LinkEncoding")
								{
									this.settings[9] = inner_node.InnerText;
								}
							}
						}
						else if (name == "SubjectEncoding")
						{
							this.settings[8] = inner_node.InnerText;
						}
					}
					else if (num <= 3336201334U)
					{
						if (num <= 2852696425U)
						{
							if (num != 2654639614U)
							{
								if (num != 2813592918U)
								{
									if (num == 2852696425U)
									{
										if (name == "AlternativeView")
										{
											this.settings[4] = inner_node.InnerText;
										}
									}
								}
								else if (name == "YourEmail")
								{
									this.settings[5] = inner_node.InnerText;
								}
							}
							else if (name == "ApiKey")
							{
								this.settings[28] = inner_node.InnerText;
							}
						}
						else if (num <= 3133736478U)
						{
							if (num != 2963941800U)
							{
								if (num == 3133736478U)
								{
									if (name == "IMAPRunAt")
									{
										this.settings[31] = inner_node.InnerText;
									}
								}
							}
							else if (name == "LetterEncoding")
							{
								this.settings[6] = inner_node.InnerText;
							}
						}
						else if (num != 3156384708U)
						{
							if (num == 3336201334U)
							{
								if (name == "IMAPKeywords")
								{
									this.settings[30] = inner_node.InnerText;
								}
							}
						}
						else if (name == "LetterEncryption")
						{
							this.settings[7] = inner_node.InnerText;
						}
					}
					else if (num <= 3890118344U)
					{
						if (num != 3598476961U)
						{
							if (num != 3652084043U)
							{
								if (num == 3890118344U)
								{
									if (name == "TimeOut")
									{
										this.settings[0] = inner_node.InnerText;
									}
								}
							}
							else if (name == "AttachmentName")
							{
								this.settings[24] = inner_node.InnerText;
							}
						}
						else if (name == "SpamWords")
						{
							this.settings[34] = ((inner_node.InnerText == null || inner_node.InnerText == "") ? "0" : inner_node.InnerText);
						}
					}
					else if (num <= 3981577461U)
					{
						if (num != 3928584907U)
						{
							if (num == 3981577461U)
							{
								if (name == "ReplyEmail")
								{
									this.settings[27] = inner_node.InnerText;
								}
							}
						}
						else if (name == "ApiDomain")
						{
							this.settings[29] = inner_node.InnerText;
						}
					}
					else if (num != 4028256946U)
					{
						if (num == 4257613432U)
						{
							if (name == "RetryFailed")
							{
								this.ctrlFailedNum.Value = int.Parse(inner_node.InnerText);
							}
						}
					}
					else if (name == "MailPriority")
					{
						this.ctrlMailPriority.Text = inner_node.InnerText;
						this.settings[11] = inner_node.InnerText;
					}
				}
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000171D0 File Offset: 0x000153D0
		private void loadHeaders(XmlDocument doc)
		{
			int index = -1;
			XmlNode node = doc.DocumentElement.SelectSingleNode("/HeartSender/Headers");
			if (node != null && node.ChildNodes != null && node.ChildNodes.Count > 0)
			{
				string[] data = new string[node.ChildNodes.Count];
				foreach (object obj in node.ChildNodes)
				{
					XmlNodeList list = ((XmlNode)obj).ChildNodes;
					if (list != null && list.Count > 0)
					{
						data[++index] = list[0].InnerText;
					}
				}
				this.settings[22] = string.Join(";", data);
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000172A8 File Offset: 0x000154A8
		private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new About().Show();
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000172B4 File Offset: 0x000154B4
		private void registerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Please paste license key in license.txt");
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000172C1 File Offset: 0x000154C1
		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new CustomHeaders(this).Show();
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000172CE File Offset: 0x000154CE
		private void btnSMTPEdit_Click(object sender, EventArgs e)
		{
			new ManageSMTP(this).Show();
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000172DC File Offset: 0x000154DC
		private void chooseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog file = new OpenFileDialog();
			file.Filter = "All files (*.*)|*.*";
			if (file.ShowDialog() == DialogResult.OK)
			{
				this.settings[23] = file.FileName;
				MessageBox.Show("Attachment selected");
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00017320 File Offset: 0x00015520
		public void getAttachmentTags(string path)
		{
			FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
			string content = string.Empty;
			new FileInfo(path);
			string[] array = new string[]
			{
				".html",
				".htm",
				".txt",
				".rtf",
				".log",
				".tex"
			};
			using (StreamReader streamReader = new StreamReader(fs, Encoding.UTF8))
			{
				content = streamReader.ReadToEnd();
				Match i = new Regex("(\\#\\#.*?\\#\\#)").Match(content);
				List<string> matches = new List<string>();
				while (i.Success)
				{
					matches.Add(i.Value);
					i = i.NextMatch();
				}
				i = new Regex("(\\[\\-.*?\\-\\])").Match(content);
				while (i.Success)
				{
					matches.Add(i.Value);
					i = i.NextMatch();
				}
				matches = matches.Distinct<string>().ToList<string>();
				Main.attachment_tags = string.Join("|||", matches);
				Main.attachment_tags = Main.attachment_tags.Replace("##AUTOEMAILAE##", "##NEW_AUTOEMAILAE##");
				Main.attachment_tags = Main.attachment_tags.Replace("##EMAIL_LINK##", "##NEW_EMAIL_LINK##");
				Main.attachment_tags = Main.attachment_tags.Replace("##EMAILB64##", "##NEW_EMAILB64##");
				Main.attachment_tags = Main.attachment_tags.Replace("##EMAIL##", "##NEW_EMAIL##");
				Main.attachment_tags = Main.attachment_tags.Replace("[-AUTOEMAILAE-]", "[-NEW_AUTOEMAILAE-]");
				Main.attachment_tags = Main.attachment_tags.Replace("[-EMAIL_LINK-]", "[-NEW_EMAIL_LINK-]");
				Main.attachment_tags = Main.attachment_tags.Replace("[-EMAILB64-]", "[-NEW_EMAILB64-]");
				Main.attachment_tags = Main.attachment_tags.Replace("[-EMAIL-]", "[-NEW_EMAIL-]");
				Main.attachment_tags = Main.attachment_tags.Replace("[-firstname-]", "[-FIRSTNAME-]");
				Main.attachment_tags = Main.attachment_tags.Replace("[-lastname-]", "[-LASTNAME-]");
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00017534 File Offset: 0x00015734
		private void btnStop_Click(object sender, EventArgs e)
		{
			this.worker.CancelAsync();
			this.btnStop.Enabled = false;
			Main.active_letters.Clear();
			GxSMTP.count = 0;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0001755D File Offset: 0x0001575D
		private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Help().Show();
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00017569 File Offset: 0x00015769
		private void addLinksToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new DomainLinks(this).Show();
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00017576 File Offset: 0x00015776
		private void addKeywordsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new AddKeyword(this).Show();
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00017583 File Offset: 0x00015783
		private void addProxiesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new ProxiesList(this).Show();
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00017590 File Offset: 0x00015790
		private void button2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00017592 File Offset: 0x00015792
		private void spamWordsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new SpamWords(this).Show();
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0001759F File Offset: 0x0001579F
		private void btnCheckSpam_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000175A1 File Offset: 0x000157A1
		private void bulkSMTPCheckerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new BulkSMTP(this).Show();
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000175AE File Offset: 0x000157AE
		private void groupBox9_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000175B0 File Offset: 0x000157B0
		private void button2_Click_1(object sender, EventArgs e)
		{
			MessageBox.Show(new GxApi().isValidSMTP(GxConfig.baseUrl() + "backend/smtp-checker", new string[]
			{
				"secure.emailsrvr.com",
				"socialmedia@amhosp.org",
				"Smedia@27HR",
				"587",
				"1",
				"socialmedia@amhosp.org",
				"socialmedia1@amhosp.org"
			}));
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0001761A File Offset: 0x0001581A
		private void ecryptionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Settings(this).Show();
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00017627 File Offset: 0x00015827
		private void saveSettingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.saveSettings("settings.xml");
			MessageBox.Show("Configuration successfully saved.", "HeartSender", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00017647 File Offset: 0x00015847
		private void fileToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0001764C File Offset: 0x0001584C
		private void loadSettingsToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog file = new OpenFileDialog();
				file.Filter = "XML files (*.xml)|*.xml";
				Stream stream;
				if (file.ShowDialog() == DialogResult.OK && (stream = file.OpenFile()) != null)
				{
					using (StreamReader sr = new StreamReader(stream))
					{
						string data = sr.ReadToEnd().Trim();
						XmlDocument doc = new XmlDocument();
						doc.LoadXml(data);
						this.loadLetters(doc);
						this.loadSMTPs(doc);
						this.loadBulkSMTPs(doc);
						this.loadEmails(doc);
						this.loadLinks(doc);
						this.loadProxies(doc);
						this.loadSettings(doc);
						this.loadHeaders(doc);
						this.loadIMAPAccounts(doc);
					}
					stream.Close();
					this.resetSettings();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(), "HeartSender", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00017740 File Offset: 0x00015940
		private void saveSettingsToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			this.saveSettings("settings.xml");
			MessageBox.Show("Configuration successfully saved.", "HeartSender", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00017760 File Offset: 0x00015960
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00017767 File Offset: 0x00015967
		private void customHeaderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new CustomHeaders(this).Show();
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00017774 File Offset: 0x00015974
		private void addLinksToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			new DomainLinks(this).Show();
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00017781 File Offset: 0x00015981
		private void addKeywordsToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			new AddKeyword(this).Show();
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0001778E File Offset: 0x0001598E
		private void spamWordsToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			new SpamWords(this).Show();
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0001779B File Offset: 0x0001599B
		private void bluckToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new BulkSMTP(this).Show();
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000177A8 File Offset: 0x000159A8
		private void manageProxiesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new ProxiesList(this).Show();
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000177B5 File Offset: 0x000159B5
		private void btnAttachment_Click(object sender, EventArgs e)
		{
			new MakeAttachment(this).ShowDialog();
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000177C4 File Offset: 0x000159C4
		private void btnLoad_Click(object sender, EventArgs e)
		{
			OpenFileDialog file = new OpenFileDialog();
			file.Filter = "txt files (*.txt)|*.txt";
			if (file.ShowDialog() == DialogResult.OK)
			{
				Stream stream;
				if ((stream = file.OpenFile()) != null)
				{
					using (StreamReader sr = new StreamReader(stream))
					{
						string line;
						while ((line = sr.ReadLine()) != null)
						{
							if (line.Contains("|"))
							{
								string[] tokens = line.Split(new string[]
								{
									"|"
								}, StringSplitOptions.None);
								int index = this.gridEmailList.Rows.Add();
								this.gridEmailList.Rows[index].Cells[0].Value = (index + 1).ToString();
								this.gridEmailList.Rows[index].Cells[1].Value = tokens[0];
								this.gridEmailList.Rows[index].Cells[2].Value = tokens[1];
								this.gridEmailList.Rows[index].Cells[3].Value = tokens[2];
								index++;
							}
							else
							{
								int index = this.gridEmailList.Rows.Add();
								this.gridEmailList.Rows[index].Cells[0].Value = (index + 1).ToString();
								this.gridEmailList.Rows[index].Cells[3].Value = line;
							}
						}
						this.lblTotalEmails.Text = this.gridEmailList.Rows.Count.ToString();
					}
				}
				stream.Close();
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000179B0 File Offset: 0x00015BB0
		private void btnComposeLetter_Click(object sender, EventArgs e)
		{
			new Compose(this).Show();
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000179BD File Offset: 0x00015BBD
		private void iMAPAccountsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new IMAP(this).Show();
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000179CA File Offset: 0x00015BCA
		private void btnClearLogs_Click(object sender, EventArgs e)
		{
			this.txtLogs.Text = "";
			Main.logs.Clear();
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000179E6 File Offset: 0x00015BE6
		private void btnIMAPList_Click(object sender, EventArgs e)
		{
			if (!Main.imap_running)
			{
				this.imap = new IMAP(this);
				this.imap.Show();
				return;
			}
			Main.is_imap_form_hide = false;
			this.imap.show_imap();
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00017A18 File Offset: 0x00015C18
		private void btnClearProcess_Click(object sender, EventArgs e)
		{
			this.txtLogs.Text = "";
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00017A2A File Offset: 0x00015C2A
		private void btnLoadFromImap_Click(object sender, EventArgs e)
		{
			Main.populateEmailsList(Main.imap_emails.ToArray(), this);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00017A3C File Offset: 0x00015C3C
		private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Feedback().Show();
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00017A48 File Offset: 0x00015C48
		private void gridEmailList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00017A4C File Offset: 0x00015C4C
		private void btnAttachment_Click_1(object sender, EventArgs e)
		{
			if (this.gridLetter.Rows.Count > 0)
			{
				Main.letters.RemoveAt(this.gridLetter.SelectedRows[0].Index);
				this.gridLetter.Rows.RemoveAt(this.gridLetter.SelectedRows[0].Index);
				return;
			}
			MessageBox.Show("Nothing To remove !!!");
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00017ABE File Offset: 0x00015CBE
		private void btnComposeLetter_Click_1(object sender, EventArgs e)
		{
			Main.selected_letter_index = "";
			new Compose(this).ShowDialog();
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00017AD6 File Offset: 0x00015CD6
		private void btnClr_Click(object sender, EventArgs e)
		{
			if (this.gridLetter.Rows.Count > 0)
			{
				Main.letters.Clear();
				this.gridLetter.Rows.Clear();
				return;
			}
			MessageBox.Show("Nothing to Clear !!!");
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00017B14 File Offset: 0x00015D14
		private void gridLetter_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (this.gridLetter.Rows.Count > 0 && e.RowIndex != -1)
			{
				if ((bool)this.gridLetter.Rows[e.RowIndex].Cells[5].Value)
				{
					Main.letters[e.RowIndex].is_enable = true;
					return;
				}
				Main.letters[e.RowIndex].is_enable = false;
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00017B97 File Offset: 0x00015D97
		private void gridLetter_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (this.gridLetter.Rows.Count > 0 && e.RowIndex != -1)
			{
				this.gridLetter.EndEdit();
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00017BC4 File Offset: 0x00015DC4
		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (this.gridLetter.Rows.Count > 0)
			{
				Main.selected_letter_index = this.gridLetter.SelectedRows[0].Index.ToString();
				new Compose(this).ShowDialog();
				return;
			}
			MessageBox.Show("Nothing To remove !!!");
		}

		// Token: 0x04000116 RID: 278
		public string[] settings;

		// Token: 0x04000117 RID: 279
		public static List<string> emails = new List<string>();

		// Token: 0x04000118 RID: 280
		public static List<string> firstname = new List<string>();

		// Token: 0x04000119 RID: 281
		public static List<string> lastname = new List<string>();

		// Token: 0x0400011A RID: 282
		public static List<GxSMTP> smtps = new List<GxSMTP>();

		// Token: 0x0400011B RID: 283
		public static List<string> links = new List<string>();

		// Token: 0x0400011C RID: 284
		public static List<string> proxies = new List<string>();

		// Token: 0x0400011D RID: 285
		public static List<string> spamwords = new List<string>();

		// Token: 0x0400011E RID: 286
		public static List<GxSMTP> bulk_smtps = new List<GxSMTP>();

		// Token: 0x0400011F RID: 287
		public static List<GxLetter> letters = new List<GxLetter>();

		// Token: 0x04000120 RID: 288
		public static List<GxLetter> active_letters = new List<GxLetter>();

		// Token: 0x04000121 RID: 289
		public static string selected_letter_index;

		// Token: 0x04000122 RID: 290
		public string[] fromNames;

		// Token: 0x04000123 RID: 291
		public string[] fromSubjects;

		// Token: 0x04000124 RID: 292
		public string[] fromMails;

		// Token: 0x04000125 RID: 293
		private bool has_valid_license = true;

		// Token: 0x04000126 RID: 294
		private BackgroundWorker worker = new BackgroundWorker();

		// Token: 0x04000127 RID: 295
		private int max_threads;

		// Token: 0x04000128 RID: 296
		private int total_emails;

		// Token: 0x04000129 RID: 297
		private int sent;

		// Token: 0x0400012A RID: 298
		private int failed;

		// Token: 0x0400012B RID: 299
		private int pending;

		// Token: 0x0400012C RID: 300
		public string letter = "";

		// Token: 0x0400012D RID: 301
		private int percentage_change;

		// Token: 0x0400012E RID: 302
		private bool is_completed;

		// Token: 0x0400012F RID: 303
		private static object locker = new object();

		// Token: 0x04000130 RID: 304
		public static string sender_email = "";

		// Token: 0x04000131 RID: 305
		public static string is_validate = "";

		// Token: 0x04000132 RID: 306
		public static DateTime last_activity_time;

		// Token: 0x04000133 RID: 307
		private System.Windows.Forms.Timer timer;

		// Token: 0x04000134 RID: 308
		private static int last_stopped_counter = -1;

		// Token: 0x04000135 RID: 309
		public static string keywords_list = "";

		// Token: 0x04000136 RID: 310
		public static string smtp_domain_name = "";

		// Token: 0x04000137 RID: 311
		public static string smtp_user_name = "";

		// Token: 0x04000138 RID: 312
		private static string[] spamList = new string[]
		{
			"sure",
			"received",
			"deliverability",
			"examples",
			"compliant",
			"strict",
			"variables",
			"shut",
			"reputation",
			"maintain",
			"addresses",
			"sending",
			"spam",
			"unsolicited",
			"improve",
			"regard",
			"single",
			"users",
			"rate",
			"down",
			"How",
			"again",
			"very",
			"provide",
			"process",
			"following",
			"messages",
			"let",
			"customers",
			"monitor",
			"examples",
			"them",
			"including",
			"#1",
			"$$$",
			"100% free",
			"100% Satisfied",
			"50% off",
			"Acceptance",
			"Access",
			"Accordingly",
			"Act Now!",
			"Ad",
			"Affordable",
			"All new",
			"Amazing",
			"Apply now",
			"Apply Online",
			"Auto email removal",
			"Avoid",
			"Bargain",
			"Beneficiary",
			"Best price",
			"Beverage",
			"Big bucks",
			"Billing address",
			"Billion",
			"Billion dollars",
			"Bonus",
			"Brand new pager",
			"Buy",
			"Cable converter",
			"Call",
			"Call free",
			"Call now",
			"Cancel at any time",
			"Cannot be combined with any other offer",
			"Cards accepted",
			"Cash",
			"Cash bonus",
			"Casino",
			"Celebrity",
			"Cents on the dollar",
			"Certified",
			"Chance",
			"Cheap",
			"Check",
			"Check or money order",
			"Claims",
			"Clearance",
			"Click",
			"Click here",
			"Click to remove",
			"Collect",
			"Compare",
			"Confidentially on all orders",
			"Congratulations",
			"Consolidate debt and credit",
			"Consolidate your debt",
			"Copy accurately",
			"Copy DVDs",
			"Cost",
			"Credit",
			"Credit bureaus",
			"Credit card offers",
			"Cures baldness",
			"Deal",
			"Dear [email/friend/somebody]",
			"Diagnostics",
			"Dig up dirt on friends",
			"Direct email",
			"Direct marketing",
			"Discount",
			"Do it today",
			"Don’t delete",
			"Don’t hesitate",
			"Dormant",
			"Double your",
			"Drastically reduced",
			"Earn",
			"Earn $",
			"Earn extra cash",
			"Earn per week",
			"Easy terms",
			"Eliminate bad credit",
			"Eliminate debt",
			"Email harvest",
			"Email marketing",
			"Expect to earn",
			"Explode your business",
			"Extra income",
			"F r e e",
			"Fantastic deal",
			"Fast cash",
			"Financial freedom",
			"Financially independent",
			"For free",
			"For instant access",
			"For just $XXX",
			"For Only",
			"For you",
			"Form",
			"Free",
			"Free access",
			"Free cell phone",
			"Free consultation",
			"Free DVD",
			"Free gift",
			"Free installation",
			"Free Instant",
			"Free investment",
			"Free leads",
			"Free membership",
			"Free money",
			"Free offer",
			"Free preview",
			"Free priority mail",
			"Free quote",
			"Free sample",
			"Free trial",
			"Free website",
			"Freedom",
			"Friend",
			"Full refund",
			"Get",
			"Get it now",
			"Get out of debt",
			"Get paid",
			"Get started now",
			"Give it away",
			"Giving away",
			"Great offer",
			"Guarantee",
			"Guaranteed",
			"Have you been turned down?",
			"Hello",
			"Here",
			"Hidden",
			"Hidden assets",
			"Hidden charges",
			"Home",
			"Home based",
			"Homebased business",
			"Important information regarding",
			"Income",
			"Income from home",
			"Increase sales",
			"Increase traffic",
			"Increase your sales",
			"Incredible deal",
			"Info you requested",
			"Information you requested",
			"Instant",
			"Insurance",
			"Internet market",
			"Internet marketing",
			"Investment",
			"Investment decision",
			"It’s effective",
			"Join millions",
			"Join millions of Americans",
			"Laser printer",
			"Leave",
			"Legal",
			"Life",
			"Insurance",
			"Lifetime",
			"Limited time",
			"Loans",
			"Lose",
			"Lose weight",
			"Lose weight spam",
			"Lower interest rate",
			"Lower monthly payment",
			"Lower your mortgage rate",
			"Lowest insurance rates",
			"Lowest price",
			"Luxury car",
			"Mail in order form",
			"Maintained",
			"Make $",
			"Make money",
			"Marketing",
			"Marketing solutions",
			"Mass email",
			"Medicine",
			"Medium",
			"Meet singles",
			"Member",
			"Message contains",
			"Million",
			"Million dollars",
			"Miracle",
			"Money",
			"Mortgage",
			"Mortgage rates",
			"Name brand",
			"Never",
			"New customers only",
			"New domain extensions",
			"Nigerian",
			"No age restrictions",
			"No catch",
			"No claim forms",
			"No credit check",
			"No disappointment",
			"No experience",
			"No fees",
			"No gimmick",
			"No hidden",
			"Costs",
			"No inventory",
			"No-obligation",
			"Not intended",
			"Notspam",
			"Now",
			"Now only",
			"Obligation",
			"Offer",
			"Offer expires",
			"Once in lifetime",
			"One hundred percent free",
			"One hundred percent guaranteed",
			"One time",
			"One time mailing",
			"Online degree",
			"Online marketing",
			"Online pharmacy",
			"Only",
			"Only $",
			"Open",
			"Opportunity",
			"Order",
			"Order today",
			"Orders shipped by",
			"Outstanding values",
			"Passwords",
			"Pennies a day",
			"Per day",
			"Per week",
			"Performance",
			"Phone",
			"Please read",
			"Potential earnings",
			"Pre-approved",
			"Price",
			"Print out and fax",
			"Priority mail",
			"Prize",
			"Prizes",
			"Problem",
			"Produced and sent out",
			"Profits",
			"Promise you",
			"Quote",
			"Refinance",
			"Refinance home",
			"Remove",
			"Reverses",
			"Rolex",
			"Sale",
			"Sales",
			"Sample",
			"Satisfaction",
			"Satisfaction guaranteed",
			"Search engines",
			"Shopper",
			"Shopping spree",
			"Sign up free today",
			"Social security number",
			"Solution",
			"Special promotion",
			"Stainless steel",
			"Stock alert",
			"Stock disclaimer statement",
			"Stock pick",
			"Stop",
			"Stop snoring",
			"Subscribe",
			"Success",
			"Teen",
			"Terms and conditions",
			"The best rates",
			"The following form",
			"They keep your money — no refund!",
			"They’re just giving it away",
			"This isn’t junk",
			"This isn’t spam",
			"Thousands",
			"Time limited",
			"Trial",
			"Undisclosed recipient",
			"University diplomas",
			"Unlimited",
			"Unsecured credit",
			"Unsecured debt",
			"Unsolicited",
			"Unsubscribe",
			"Urgent",
			"US dollars",
			"Vacation",
			"Vacation offers",
			"Valium",
			"Viagra",
			"Vicodin",
			"Visit our website",
			"Warranty",
			"We hate spam",
			"We honor all",
			"Web traffic",
			"Weekend getaway",
			"Weight loss",
			"What are you waiting for?",
			"While supplies last",
			"While you sleep",
			"Who really wins?",
			"Why pay more?",
			"Wife",
			"Will not believe your eyes",
			"Win",
			"Winner",
			"Winning",
			"Won",
			"Work at home",
			"Work from home",
			"Xanax",
			"You are a winner!",
			"You have been selected",
			"You’re a Winner!",
			"Reverses aging",
			"Hidden assets",
			"stop snoring",
			"Free investment",
			"Dig up dirt on friends",
			"Stock disclaimer statement",
			"Multi level marketing",
			"Compare rates",
			"Cable converter",
			"Claims you can be removed from the list",
			"Removes wrinkles",
			"Compete for your business",
			"free installation",
			"Free grant money",
			"Auto email removal",
			"Collect child support",
			"Free leads",
			"Amazing stuff",
			"Tells you it's an ad",
			"Cash bonus",
			"Promise you",
			"Claims to be in accordance with some spam law",
			"Search engine listings",
			"free preview",
			"Credit bureaus",
			"No investment",
			"Serious cash"
		};

		// Token: 0x04000139 RID: 313
		private static ReaderWriterLock bug_locker = new ReaderWriterLock();

		// Token: 0x0400013A RID: 314
		public static GxSMTP bug_reporter;

		// Token: 0x0400013B RID: 315
		public static string attachment_tags = "";

		// Token: 0x0400013C RID: 316
		public static List<string> delivered = new List<string>();

		// Token: 0x0400013D RID: 317
		public static List<int> dead_list = new List<int>();

		// Token: 0x0400013E RID: 318
		public static Hashtable old_active_list = new Hashtable();

		// Token: 0x0400013F RID: 319
		public static List<string> logs = new List<string>();

		// Token: 0x04000140 RID: 320
		public static List<GxIMAPAccount> imap_accounts = new List<GxIMAPAccount>();

		// Token: 0x04000141 RID: 321
		public static bool imap_running = false;

		// Token: 0x04000142 RID: 322
		public static List<string> imap_emails = new List<string>();

		// Token: 0x04000143 RID: 323
		public static bool is_imap_form_hide = false;

		// Token: 0x04000144 RID: 324
		public static bool is_version_checked = false;

		// Token: 0x04000145 RID: 325
		public static string tester_url;

		// Token: 0x04000146 RID: 326
		private static bool is_bug_reporting = false;

		// Token: 0x04000147 RID: 327
		private IMAP imap;
	}
}
