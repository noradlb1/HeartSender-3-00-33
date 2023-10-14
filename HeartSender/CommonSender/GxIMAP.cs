using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using HeartSender;
using MailKit;
using MailKit.Net.Imap;
using MimeKit;

namespace CommonSender
{
	// Token: 0x02000007 RID: 7
	[Serializable]
	public class GxIMAP
	{
		// Token: 0x0600002F RID: 47 RVA: 0x0000362D File Offset: 0x0000182D
		public GxIMAP(Main m, IMAP p)
		{
			this._main = m;
			this._imap = p;
			this.emails = new List<string>();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000365C File Offset: 0x0000185C
		public void execute(GxIMAPAccount account, BackgroundWorker worker_job)
		{
			Main.imap_emails.Clear();
			using (ImapClient c = new ImapClient())
			{
				try
				{
					c.Connect(account.server_name, account.port, account.is_ssl, default(CancellationToken));
					c.AuthenticationMechanisms.Remove("XOAUTH2");
					c.Authenticate(account.username, account.password, default(CancellationToken));
					IMailFolder inbox = c.Inbox;
					inbox.Open(FolderAccess.ReadWrite, default(CancellationToken));
					IEnumerable<IMessageSummary> enumerable = inbox.Fetch(0, account.limit - 1, MessageSummaryItems.Flags | MessageSummaryItems.Size | MessageSummaryItems.UniqueId, default(CancellationToken));
					int counter = 0;
					foreach (IMessageSummary summary in enumerable)
					{
						MimeMessage i = c.Inbox.GetMessage(summary.UniqueId, default(CancellationToken), null);
						string[] array = new string[9];
						array[0] = i.Subject;
						array[1] = "\n";
						int num = 2;
						InternetAddressList bcc = i.Bcc;
						array[num] = ((bcc != null) ? bcc.ToString() : null);
						array[3] = "\n";
						int num2 = 4;
						MimeEntity body = i.Body;
						array[num2] = ((body != null) ? body.ToString() : null);
						array[5] = "\n";
						int num3 = 6;
						InternetAddressList from = i.From;
						array[num3] = ((from != null) ? from.ToString() : null);
						array[7] = "\n";
						int num4 = 8;
						InternetAddressList to = i.To;
						array[num4] = ((to != null) ? to.ToString() : null);
						string wholeMessage = string.Concat(array);
						string[] array2 = this.removeDuplicates(this.extractEmails(wholeMessage));
						new DataGridViewRow();
						foreach (string email in array2)
						{
							if (counter > account.limit)
							{
								break;
							}
							this.emails.Add(email);
							Main.imap_emails.Add(email);
							worker_job.ReportProgress(1, email);
							counter++;
						}
						if (counter > account.limit)
						{
							break;
						}
					}
				}
				catch (Exception e)
				{
					Console.WriteLine("ERROR :: " + e.Message.ToString());
				}
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000038B4 File Offset: 0x00001AB4
		public string[] extractEmails(string data)
		{
			MatchCollection matchCollection = new Regex("\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*", RegexOptions.IgnoreCase).Matches(data);
			StringBuilder sb = new StringBuilder();
			foreach (object obj in matchCollection)
			{
				Match emailMatch = (Match)obj;
				sb.AppendLine(emailMatch.Value);
			}
			return sb.ToString().Split(new char[]
			{
				'\n'
			});
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000393C File Offset: 0x00001B3C
		public string[] removeDuplicates(string[] s)
		{
			HashSet<string> hashSet = new HashSet<string>(s);
			string[] result = new string[hashSet.Count];
			hashSet.CopyTo(result);
			return (from e in result
			where !string.IsNullOrEmpty(e)
			select e).ToArray<string>();
		}

		// Token: 0x0400003C RID: 60
		private Main _main;

		// Token: 0x0400003D RID: 61
		private IMAP _imap;

		// Token: 0x0400003E RID: 62
		public List<string> emails = new List<string>();
	}
}
