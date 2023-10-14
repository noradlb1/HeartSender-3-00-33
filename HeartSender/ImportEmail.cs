using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HeartSender
{
	// Token: 0x02000019 RID: 25
	public partial class ImportEmail : Form
	{
		// Token: 0x060000C6 RID: 198 RVA: 0x00010D46 File Offset: 0x0000EF46
		public ImportEmail(Main _main)
		{
			this.InitializeComponent();
			this.main = _main;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00010D66 File Offset: 0x0000EF66
		private void btnAdd_Click(object sender, EventArgs e)
		{
			this.getEmails();
			Main.populateEmailsList(this.emails, this.main);
			base.Close();
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00010D88 File Offset: 0x0000EF88
		private void btnImport_Click(object sender, EventArgs e)
		{
			OpenFileDialog file = new OpenFileDialog();
			file.Filter = "txt files (*.txt)|*.txt|CSV (*.csv)|*.csv";
			if (file.ShowDialog() == DialogResult.OK)
			{
				this.stream = file.OpenFile();
				if (this.stream != null)
				{
					string[] tokens = file.FileName.Split(new char[]
					{
						'.'
					});
					this.file_type = tokens[tokens.Length - 1];
					this.ctrlProgress.Minimum = 0;
					this.ctrlProgress.Maximum = 100;
					this.ctrlProgress.Value = 0;
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
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00010E88 File Offset: 0x0000F088
		public void bgw_DoWork(object sender, DoWorkEventArgs e)
		{
			BackgroundWorker worker_job = sender as BackgroundWorker;
			using (StreamReader sr = new StreamReader(this.stream))
			{
				string s = string.Empty;
				int counter = 0;
				List<string> list = new List<string>();
				while ((s = sr.ReadLine()) != null && counter < 300000)
				{
					if (this.file_type.ToLower().Trim() == "csv")
					{
						string[] tokens = s.Trim().ToLower().Split(new char[]
						{
							';'
						});
						tokens = tokens[0].Trim().ToLower().Split(new char[]
						{
							','
						});
						list.Add(tokens[0].Trim().ToLower());
					}
					else
					{
						list.Add(s.Trim().ToLower());
					}
					int counter2 = counter;
					counter = counter2 + 1;
				}
				worker_job.ReportProgress(10);
				try
				{
					base.Invoke(new MethodInvoker(delegate()
					{
						this.txtEmailList.Clear();
						this.txtEmailList.Text = string.Join("\n", list.ToArray());
						this.lblCount.Text = ((counter < 0) ? "0" : counter.ToString());
					}));
					worker_job.ReportProgress(90);
				}
				catch (Exception)
				{
					MessageBox.Show("Sorry, Invalid file format.");
				}
			}
			this.stream.Close();
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00011008 File Offset: 0x0000F208
		public void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			if (this.ctrlProgress.Value + e.ProgressPercentage <= this.ctrlProgress.Maximum)
			{
				this.ctrlProgress.Value += e.ProgressPercentage;
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00011041 File Offset: 0x0000F241
		public void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.ctrlProgress.Value = this.ctrlProgress.Maximum;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0001105C File Offset: 0x0000F25C
		public void loadData()
		{
			try
			{
				this.txtEmailList.Clear();
				int counter = 0;
				foreach (string email in this.emails)
				{
					RichTextBox richTextBox = this.txtEmailList;
					richTextBox.Text += email;
					RichTextBox richTextBox2 = this.txtEmailList;
					richTextBox2.Text += "\n";
					counter++;
				}
				this.txtEmailList.Text = this.txtEmailList.Text.Trim();
				this.lblCount.Text = ((counter < 0) ? "0" : counter.ToString());
			}
			catch (Exception)
			{
				MessageBox.Show("Sorry, Invalid file format.");
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00011120 File Offset: 0x0000F320
		public string[] removeDuplicates(string[] myList)
		{
			ArrayList newList = new ArrayList();
			foreach (string str in myList)
			{
				if (!newList.Contains(str))
				{
					newList.Add(str);
				}
			}
			return (string[])newList.ToArray(typeof(string));
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0001116D File Offset: 0x0000F36D
		private void btnRmDpl_Click(object sender, EventArgs e)
		{
			this.getEmails();
			this.emails = this.removeDuplicates(this.emails);
			this.loadData();
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0001118D File Offset: 0x0000F38D
		private void getEmails()
		{
			this.emails = this.txtEmailList.Text.Trim().Split(new string[]
			{
				"\r\n",
				"\r",
				"\n"
			}, StringSplitOptions.None);
		}

		// Token: 0x04000107 RID: 263
		private string[] emails;

		// Token: 0x04000108 RID: 264
		private Main main;

		// Token: 0x04000109 RID: 265
		private BackgroundWorker worker = new BackgroundWorker();

		// Token: 0x0400010A RID: 266
		private Stream stream;

		// Token: 0x0400010B RID: 267
		private string file_type;
	}
}
