using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using CommonSender;

namespace HeartSender
{
	// Token: 0x0200001D RID: 29
	public partial class ProxiesList : Form
	{
		// Token: 0x06000143 RID: 323 RVA: 0x0001E419 File Offset: 0x0001C619
		public ProxiesList(Main _main)
		{
			this.InitializeComponent();
			this.main = _main;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0001E430 File Offset: 0x0001C630
		private void ProxiesList_Load(object sender, EventArgs e)
		{
			if (Main.proxies.Count > 0)
			{
				this.gridProxies.Rows.Clear();
				foreach (string proxy in Main.proxies)
				{
					if (!(proxy.Trim() == ""))
					{
						string[] tokens = proxy.Split(new string[]
						{
							"|||"
						}, StringSplitOptions.None);
						if (tokens.Length > 4)
						{
							int index = this.gridProxies.Rows.Add();
							this.gridProxies.Rows[index].Cells["Host"].Value = tokens[0].Trim();
							this.gridProxies.Rows[index].Cells["Port"].Value = tokens[1].Trim();
							this.gridProxies.Rows[index].Cells["Username"].Value = tokens[2].Trim();
							this.gridProxies.Rows[index].Cells["Password"].Value = tokens[3].Trim();
							this.gridProxies.Rows[index].Cells["ProxyType"].Value = tokens[4].Trim();
						}
					}
				}
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0001E5D8 File Offset: 0x0001C7D8
		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (this.gridProxies.SelectedRows.Count > 0)
			{
				using (IEnumerator enumerator = this.gridProxies.SelectedRows.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						DataGridViewRow row = (DataGridViewRow)obj;
						this.gridProxies.Rows.RemoveAt(row.Index);
					}
					return;
				}
			}
			MessageBox.Show("Please select atleast one row to delete.");
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0001E664 File Offset: 0x0001C864
		private void btnClear_Click(object sender, EventArgs e)
		{
			this.gridProxies.Rows.Clear();
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0001E678 File Offset: 0x0001C878
		private void btnDone_Click(object sender, EventArgs e)
		{
			Main.proxies.Clear();
			for (int index = 0; index < this.gridProxies.Rows.Count; index++)
			{
				if (!(this.gridProxies.Rows[index].Cells["Host"].Value.ToString() == "") && this.gridProxies.Rows[index].Cells["Port"].Value.ToString().Trim().Length != 0)
				{
					string[] tokens = new string[]
					{
						this.gridProxies.Rows[index].Cells["Host"].Value.ToString().Trim(),
						this.gridProxies.Rows[index].Cells["Port"].Value.ToString().Trim(),
						this.gridProxies.Rows[index].Cells["Username"].Value.ToString().Trim(),
						this.gridProxies.Rows[index].Cells["Password"].Value.ToString().Trim(),
						this.gridProxies.Rows[index].Cells["ProxyType"].Value.ToString().Trim()
					};
					Main.proxies.Add(string.Join("|||", tokens));
				}
			}
			base.Close();
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0001E840 File Offset: 0x0001CA40
		private void btnAddSMTP_Click(object sender, EventArgs e)
		{
			if (this.txtHost.Text.Trim().Length == 0 || this.ctrlNumPort.Value <= 0m || this.cmbType.Text.Trim().Length == 0)
			{
				MessageBox.Show("Please enter valid details for Proxy.");
				return;
			}
			int index = this.gridProxies.Rows.Add();
			this.gridProxies.Rows[index].Cells["Host"].Value = this.txtHost.Text;
			this.gridProxies.Rows[index].Cells["Port"].Value = this.ctrlNumPort.Value.ToString();
			this.gridProxies.Rows[index].Cells["Username"].Value = this.txtUsername.Text;
			this.gridProxies.Rows[index].Cells["Password"].Value = this.txtPassword.Text;
			this.gridProxies.Rows[index].Cells["ProxyType"].Value = this.cmbType.Text;
			string[] tokens = new string[]
			{
				this.gridProxies.Rows[index].Cells["Host"].Value.ToString().Trim(),
				this.gridProxies.Rows[index].Cells["Port"].Value.ToString().Trim(),
				this.gridProxies.Rows[index].Cells["Username"].Value.ToString().Trim(),
				this.gridProxies.Rows[index].Cells["Password"].Value.ToString().Trim(),
				this.gridProxies.Rows[index].Cells["ProxyType"].Value.ToString().Trim()
			};
			Main.proxies.Add(string.Join("|||", tokens));
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0001EAC0 File Offset: 0x0001CCC0
		private void btnCheck_Click(object sender, EventArgs e)
		{
			GxLicense gxLicense = new GxLicense();
			string type = "s5";
			if (this.cmbType.Text == "Http" || this.cmbType.Text == "Https")
			{
				type = "h";
			}
			else if (this.cmbType.Text == "Sock4")
			{
				type = "s4";
			}
			if (gxLicense.checkProxy(string.Concat(new string[]
			{
				this.txtHost.Text.Trim(),
				":",
				this.ctrlNumPort.Value.ToString().Trim(),
				":",
				type.Trim()
			})))
			{
				MessageBox.Show("Connection Ok!", "HeartSender", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			MessageBox.Show("Sorry, there is some problem with the Proxy. Couldn't connect.", "HeartSender", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0001EBAC File Offset: 0x0001CDAC
		private void btnProxyChecker_Click(object sender, EventArgs e)
		{
			try
			{
				WebProxy myProxy = new WebProxy(this.txtHost.Text + ":" + int.Parse(this.ctrlNumPort.Value.ToString()).ToString());
				if ((this.txtPassword.Text != "" && this.txtUsername.Text != "") || (this.txtUsername.Text != null && this.txtPassword.Text != null))
				{
					ICredentials credentials = new NetworkCredential(this.txtUsername.Text, this.txtPassword.Text);
					myProxy = new WebProxy(this.txtHost.Text + ":" + int.Parse(this.ctrlNumPort.Value.ToString()).ToString(), true, null, credentials);
				}
				else
				{
					myProxy = new WebProxy(this.txtHost.Text + ":" + int.Parse(this.ctrlNumPort.Value.ToString()).ToString());
				}
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.microsoft.com");
				httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/29.0.1547.2 Safari/537.36";
				httpWebRequest.Timeout = 10000;
				httpWebRequest.Proxy = myProxy;
				MessageBox.Show(((HttpWebResponse)httpWebRequest.GetResponse()).StatusDescription);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0001ED44 File Offset: 0x0001CF44
		private void btnBulkTest_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < this.gridProxies.Rows.Count; i++)
			{
				try
				{
					WebProxy myProxy;
					if ((this.gridProxies.Rows[i].Cells[2].Value.ToString() != "" && this.gridProxies.Rows[i].Cells[3].Value.ToString() != "") || (this.gridProxies.Rows[i].Cells[2].Value.ToString() != null && this.gridProxies.Rows[i].Cells[3].Value.ToString() != null))
					{
						ICredentials credentials = new NetworkCredential(this.gridProxies.Rows[i].Cells[2].Value.ToString(), this.gridProxies.Rows[i].Cells[3].Value.ToString());
						myProxy = new WebProxy(this.gridProxies.Rows[i].Cells[0].Value.ToString() + ":" + int.Parse(this.gridProxies.Rows[i].Cells[1].Value.ToString()).ToString(), true, null, credentials);
					}
					else
					{
						myProxy = new WebProxy(this.gridProxies.Rows[i].Cells[0].Value.ToString() + ":" + int.Parse(this.gridProxies.Rows[i].Cells[1].Value.ToString()).ToString());
					}
					HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.microsoft.com");
					httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/29.0.1547.2 Safari/537.36";
					httpWebRequest.Timeout = 5000;
					httpWebRequest.Proxy = myProxy;
					HttpWebResponse myWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
					this.gridProxies.Rows[i].Cells[5].Value = myWebResponse.StatusDescription;
				}
				catch (Exception ex)
				{
					this.gridProxies.Rows[i].Cells[5].Value = ex.Message;
				}
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0001F004 File Offset: 0x0001D204
		private void btnClean_Click(object sender, EventArgs e)
		{
			foreach (object obj in ((IEnumerable)this.gridProxies.Rows))
			{
				DataGridViewRow item = (DataGridViewRow)obj;
				if (!item.Cells[5].Value.ToString().Contains("OK"))
				{
					this.gridProxies.Rows.Remove(item);
				}
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0001F090 File Offset: 0x0001D290
		private void btnImport_Click(object sender, EventArgs e)
		{
			OpenFileDialog file = new OpenFileDialog();
			file.Filter = "txt files (*.txt)|*.txt";
			Stream stream;
			if (file.ShowDialog() == DialogResult.OK && (stream = file.OpenFile()) != null)
			{
				using (StreamReader sr = new StreamReader(stream))
				{
					string[] data = sr.ReadToEnd().Split(new string[]
					{
						"\r\n",
						"\r",
						"\n"
					}, StringSplitOptions.RemoveEmptyEntries);
					this.loadData(data);
				}
				stream.Close();
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0001F11C File Offset: 0x0001D31C
		private void loadData(string[] rows)
		{
			try
			{
				if (rows.Length != 0)
				{
					this.gridProxies.Rows.Clear();
					foreach (string line in rows)
					{
						if (line.Trim().Length >= 1)
						{
							string[] row = line.Split(new char[]
							{
								'|'
							});
							if (row.Length >= 5)
							{
								int index = this.gridProxies.Rows.Add();
								this.gridProxies.Rows[index].Cells[0].Value = row[0];
								this.gridProxies.Rows[index].Cells[1].Value = row[1];
								this.gridProxies.Rows[index].Cells[2].Value = row[2];
								this.gridProxies.Rows[index].Cells[3].Value = row[3];
								this.gridProxies.Rows[index].Cells[4].Value = row[4];
							}
						}
					}
					Main.proxies.Clear();
					string[] tokens = new string[5];
					for (int i = 0; i < this.gridProxies.Rows.Count; i++)
					{
						try
						{
							tokens[0] = this.gridProxies.Rows[i].Cells[0].Value.ToString().Trim();
							tokens[1] = this.gridProxies.Rows[i].Cells[1].Value.ToString().Trim();
							tokens[2] = this.gridProxies.Rows[i].Cells[2].Value.ToString().Trim();
							tokens[3] = this.gridProxies.Rows[i].Cells[3].Value.ToString().Trim();
							tokens[4] = this.gridProxies.Rows[i].Cells[4].Value.ToString().Trim();
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message, "HeartSender", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						}
					}
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Sorry, Invalid file format.", "HeartSender", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x040001C6 RID: 454
		public Main main;
	}
}
