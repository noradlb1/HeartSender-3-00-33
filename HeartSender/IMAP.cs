using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using CommonSender;
using MailKit.Net.Imap;

namespace HeartSender
{
	// Token: 0x02000018 RID: 24
	public partial class IMAP : Form
	{
		// Token: 0x060000B0 RID: 176 RVA: 0x0000E5EC File Offset: 0x0000C7EC
		public IMAP(Main main)
		{
			this._main = main;
			this.imap = new GxIMAP(this._main, this);
			this.InitializeComponent();
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000E620 File Offset: 0x0000C820
		private void btnCheckIP_Click(object sender, EventArgs e)
		{
			using (ImapClient c = new ImapClient())
			{
				try
				{
					c.Connect(this.txtImap.Text, (int)Convert.ToInt16(this.ntbPort.Value), this.rbSSL.Checked, default(CancellationToken));
					c.AuthenticationMechanisms.Remove("XOAUTH2");
					c.Authenticate(this.txtUsername.Text, this.txtPassword.Text, default(CancellationToken));
					MessageBox.Show("Account Ok!", "HeartSender", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				catch (Exception ex)
				{
					MessageBox.Show("hello");
					MessageBox.Show(ex.Message.ToString(), "HeartSender", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000E700 File Offset: 0x0000C900
		private void btnAddSMTP_Click(object sender, EventArgs e)
		{
			if (this.txtImap.Text.Trim().Length == 0 || this.txtUsername.Text.Trim().Length == 0 || this.txtPassword.Text.Trim().Length == 0)
			{
				MessageBox.Show("Please enter complete detail.", "HeartSender", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			GxIMAPAccount account = new GxIMAPAccount();
			account.server_name = this.txtImap.Text.Trim();
			account.username = this.txtUsername.Text.Trim();
			account.password = this.txtPassword.Text.Trim();
			account.limit = int.Parse(this.txtLimit.Text.Trim());
			account.port = int.Parse(this.ntbPort.Value.ToString());
			account.is_ssl = this.rbSSL.Checked;
			Main.imap_accounts.Add(account);
			int index = this.gridIMAPAccounts.Rows.Add();
			this.gridIMAPAccounts.Rows[index].Cells["UserName"].Value = account.username;
			this.gridIMAPAccounts.Rows[index].Cells["Password"].Value = account.password;
			this.gridIMAPAccounts.Rows[index].Cells["Port"].Value = account.port.ToString();
			this.gridIMAPAccounts.Rows[index].Cells["Limit"].Value = account.limit.ToString();
			this.gridIMAPAccounts.Rows[index].Cells["SSL"].Value = (account.is_ssl ? "SSL" : "None");
			this.gridIMAPAccounts.Rows[index].Cells["IMAPServer"].Value = account.server_name;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000E930 File Offset: 0x0000CB30
		private void btnSave_Click(object sender, EventArgs e)
		{
			if (this.gridIMAPAccounts.Rows.Count == 0)
			{
				MessageBox.Show("Sorry, no IMAP account(s) added.", "HeartSender", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			this.btnStart.Enabled = false;
			this.btnStop.Enabled = true;
			this.btnClear.Enabled = false;
			this.btnRmDpl.Enabled = false;
			this.btnRemove.Enabled = false;
			this.btnSave.Enabled = false;
			this.btnClose.Enabled = true;
			Main.imap_running = true;
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

		// Token: 0x060000B4 RID: 180 RVA: 0x0000EA32 File Offset: 0x0000CC32
		public void show_imap()
		{
			base.Visible = true;
			this.flag = 1;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000EA44 File Offset: 0x0000CC44
		private void IMAP_Load(object sender, EventArgs e)
		{
			if (Main.imap_accounts.Count > 0)
			{
				foreach (GxIMAPAccount imap in Main.imap_accounts)
				{
					int index = this.gridIMAPAccounts.Rows.Add();
					this.gridIMAPAccounts.Rows[index].Cells["IMAPServer"].Value = imap.server_name;
					this.gridIMAPAccounts.Rows[index].Cells["Port"].Value = imap.port.ToString();
					this.gridIMAPAccounts.Rows[index].Cells["Username"].Value = imap.username;
					this.gridIMAPAccounts.Rows[index].Cells["Password"].Value = imap.password;
					this.gridIMAPAccounts.Rows[index].Cells["SSL"].Value = (imap.is_ssl ? "SSL" : "None");
					this.gridIMAPAccounts.Rows[index].Cells["Limit"].Value = imap.limit;
				}
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000EBE0 File Offset: 0x0000CDE0
		private void btnClear_Click(object sender, EventArgs e)
		{
			this.gridIMAPAccounts.Rows.Clear();
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000EBF4 File Offset: 0x0000CDF4
		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (this.gridIMAPAccounts.SelectedRows.Count > 0)
			{
				using (IEnumerator enumerator = this.gridIMAPAccounts.SelectedRows.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						DataGridViewRow row = (DataGridViewRow)obj;
						this.gridIMAPAccounts.Rows.RemoveAt(row.Index);
					}
					return;
				}
			}
			MessageBox.Show("Please Select Atleast One Row to Delete.", "HeartSender", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000EC88 File Offset: 0x0000CE88
		public void btnStart_Click(object sender, EventArgs e)
		{
			if (this.gridIMAPAccounts.Rows.Count == 0)
			{
				MessageBox.Show("Sorry, no IMAP account(s) added.", "HeartSender", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			this.flag = 2;
			this.btnStart.Enabled = false;
			this.btnStop.Enabled = true;
			this.btnClear.Enabled = false;
			this.btnRmDpl.Enabled = false;
			this.btnRemove.Enabled = false;
			this.btnSave.Enabled = false;
			this.btnClose.Enabled = true;
			Main.imap_running = true;
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

		// Token: 0x060000B9 RID: 185 RVA: 0x0000ED94 File Offset: 0x0000CF94
		public void bgw_DoWork(object sender, DoWorkEventArgs e)
		{
			BackgroundWorker worker_job = sender as BackgroundWorker;
			foreach (GxIMAPAccount account in Main.imap_accounts)
			{
				if (worker_job.CancellationPending)
				{
					break;
				}
				this.getIMAPEmails(account, worker_job, this.imap);
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000EE00 File Offset: 0x0000D000
		public void removeDuplicatesInGrid(GxIMAP imap)
		{
			string[] emails = imap.emails.Distinct<string>().ToList<string>().ToArray();
			Main.emails.Clear();
			this.gridIMAPEmails.Rows.Clear();
			foreach (string text in emails)
			{
				Console.WriteLine(text.Trim().ToLower());
				string formated_email = text.Replace("\\r\\n", "").Replace("\\r", "").Replace("\\n", "").Trim().ToLower();
				int index = this.gridIMAPEmails.Rows.Add();
				this.gridIMAPEmails.Rows[index].Cells["Email"].Value = formated_email;
				Main.emails.Add(formated_email);
			}
			this._main.gridEmailList.Rows.Clear();
			Main.populateEmailsList(emails, this._main);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000EF03 File Offset: 0x0000D103
		public void getIMAPEmails(GxIMAPAccount account, BackgroundWorker worker, GxIMAP imap)
		{
			imap.execute(account, worker);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000EF10 File Offset: 0x0000D110
		public void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			string email = (string)e.UserState;
			try
			{
				if (!Main.is_imap_form_hide && this.flag == 0)
				{
					Main.is_imap_form_hide = true;
					base.Hide();
				}
				else if (!Main.is_imap_form_hide && this.flag == 1)
				{
					Main.is_imap_form_hide = true;
				}
				int index = this.gridIMAPEmails.Rows.Add();
				int index2 = this._main.gridEmailList.Rows.Add();
				this.gridIMAPEmails.Rows[index].Cells["Email"].Value = email.Trim().ToLower();
				this._main.gridEmailList.Rows[index2].Cells[1].Value = email.Trim().ToLower();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000EFFC File Offset: 0x0000D1FC
		public void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.btnStart.Enabled = true;
			this.btnStop.Enabled = false;
			this.btnClear.Enabled = true;
			this.btnRmDpl.Enabled = true;
			this.btnRemove.Enabled = true;
			this.btnSave.Enabled = true;
			this.btnClose.Enabled = true;
			Main.imap_running = false;
			this.removeDuplicatesInGrid(this.imap);
			if (!IMAP.is_auto_script)
			{
				IMAP.is_auto_script = false;
				if (!e.Cancelled)
				{
					MessageBox.Show("Done", "HeartSender", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				if (e.Cancelled)
				{
					MessageBox.Show("Operation was canceled", "HeartSender", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			}
			else
			{
				IMAP.is_auto_script = false;
				base.Close();
				this._main.btnStart_Click(sender, e);
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000F0CC File Offset: 0x0000D2CC
		private void btnStop_Click(object sender, EventArgs e)
		{
			this.worker.CancelAsync();
			this.btnStop.Enabled = false;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000F0E5 File Offset: 0x0000D2E5
		private void btnRmDpl_Click(object sender, EventArgs e)
		{
			this.removeDuplicatesInGrid(this.imap);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000F0F3 File Offset: 0x0000D2F3
		private void IMAP_FormClosing(object sender, FormClosingEventArgs e)
		{
			Main.imap_running = false;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000F0FC File Offset: 0x0000D2FC
		private void btnImport_Click(object sender, EventArgs e)
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
					this.loadIMAPData(smtps);
				}
				stream.Close();
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000F188 File Offset: 0x0000D388
		public void loadIMAPData(string[] data)
		{
			try
			{
				Main.imap_accounts.Clear();
				new GxDB();
				foreach (string line in data)
				{
					string[] tokens = line.Split(new char[]
					{
						'|'
					});
					if (line.Length >= 5)
					{
						int index = this.gridIMAPAccounts.Rows.Add();
						this.gridIMAPAccounts.Rows[index].Cells["IMAPServer"].Value = tokens[0];
						this.gridIMAPAccounts.Rows[index].Cells["UserName"].Value = tokens[1];
						this.gridIMAPAccounts.Rows[index].Cells["Password"].Value = tokens[2];
						this.gridIMAPAccounts.Rows[index].Cells["Port"].Value = tokens[3];
						this.gridIMAPAccounts.Rows[index].Cells["SSL"].Value = tokens[4];
						this.gridIMAPAccounts.Rows[index].Cells["Limit"].Value = tokens[5];
						GxIMAPAccount account = new GxIMAPAccount();
						account.server_name = this.gridIMAPAccounts.Rows[index].Cells["IMAPServer"].Value.ToString();
						account.username = this.gridIMAPAccounts.Rows[index].Cells["UserName"].Value.ToString();
						account.password = this.gridIMAPAccounts.Rows[index].Cells["Password"].Value.ToString();
						account.limit = int.Parse(this.gridIMAPAccounts.Rows[index].Cells["Limit"].Value.ToString());
						account.port = int.Parse(this.gridIMAPAccounts.Rows[index].Cells["Port"].Value.ToString());
						account.is_ssl = (this.gridIMAPAccounts.Rows[index].Cells["SSL"].Value.ToString() == "ssl");
						Main.imap_accounts.Add(account);
					}
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Sorry, Invalid file format.");
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000F464 File Offset: 0x0000D664
		private void btnClose_Click(object sender, EventArgs e)
		{
			Main.is_imap_form_hide = true;
			base.Hide();
		}

		// Token: 0x040000DF RID: 223
		private BackgroundWorker worker = new BackgroundWorker();

		// Token: 0x040000E0 RID: 224
		private Main _main;

		// Token: 0x040000E1 RID: 225
		private GxIMAP imap;

		// Token: 0x040000E2 RID: 226
		public static bool is_auto_script;

		// Token: 0x040000E3 RID: 227
		private int flag;
	}
}
