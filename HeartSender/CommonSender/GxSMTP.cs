using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using ARSoft.Tools.Net;
using ARSoft.Tools.Net.Dns;
using EASendMail;
using HeartSender;
using Microsoft.Win32;
using Newtonsoft.Json;

namespace CommonSender
{
	// Token: 0x0200000D RID: 13
	[Serializable]
	public class GxSMTP
	{
		// Token: 0x0600004C RID: 76 RVA: 0x000048D8 File Offset: 0x00002AD8
		public bool isValid()
		{
			return this.host != "" && this.username != "" && this.port > 0 && this.from_email != "" && this.password != "";
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000493C File Offset: 0x00002B3C
		public string getMd5Code()
		{
			return GxDB.createMD5(string.Concat(new string[]
			{
				this.host,
				"|",
				this.port.ToString(),
				"|",
				this.username,
				"|",
				this.password
			}));
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000499C File Offset: 0x00002B9C
		public void sendBugReport()
		{
			try
			{
				this.item.time = DateTime.Now.ToString("hh:mm:ss tt");
				if (this.proxy_host == "")
				{
					if (this.host.Contains("office365") || this.port == 465)
					{
						this.sendEmailViaProxy(this.item, false);
					}
					else
					{
						this.sendEmail(this.item);
					}
				}
				else
				{
					this.sendEmailViaProxy(this.item, true);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00004A38 File Offset: 0x00002C38
		public AlternateView parseLetterHTML(string html)
		{
			MatchCollection matchCollection = Regex.Matches(html, "src=\"(.*?)\"");
			int counter = 1;
			AlternateView AV = AlternateView.CreateAlternateViewFromString(html, null, "text/html");
			List<LinkedResource> resources = new List<LinkedResource>();
			foreach (object obj in matchCollection)
			{
				Match i = (Match)obj;
				string[] tokens = i.Value.ToString().Split(new string[]
				{
					"file:///"
				}, StringSplitOptions.RemoveEmptyEntries);
				if (tokens.Length != 1)
				{
					tokens[1] = tokens[1].Replace('"', ' ').Trim();
					tokens[1] = Regex.Unescape(tokens[1]);
					tokens[1] = tokens[1].Replace("%5C", "\\");
					tokens[1] = new Uri(tokens[1]).LocalPath;
					LinkedResource resource = new LinkedResource(tokens[1], "image/jpeg");
					resource.ContentId = "Image" + counter.ToString();
					html = html.Replace(i.Value.ToString(), "src='cid:" + resource.ContentId + "'");
					resources.Add(resource);
					counter++;
				}
			}
			AV = AlternateView.CreateAlternateViewFromString(html, null, "text/html");
			for (int j = 0; j < resources.Count; j++)
			{
				AV.LinkedResources.Add(resources[j]);
			}
			return AV;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00004BBC File Offset: 0x00002DBC
		public void sendEmail(GxItem item)
		{
			try
			{
				MailMessage mail = new MailMessage();
				System.Net.Mail.SmtpClient SmtpServer = new System.Net.Mail.SmtpClient(this.host);
				mail.From = new System.Net.Mail.MailAddress(this.from_email, item.from_name);
				if (item.config.use_reply_email == 1)
				{
					mail.From = new System.Net.Mail.MailAddress(item.reply_email, item.reply_email_name);
				}
				System.Net.Mail.MailAddress to = new System.Net.Mail.MailAddress(item.email);
				if (item.config.target_email_name != "")
				{
					to = new System.Net.Mail.MailAddress(item.email, item.target_email_name);
				}
				mail.To.Add(to);
				if (item.config.replyEmail != "")
				{
					mail.Sender = new System.Net.Mail.MailAddress(item.config.replyEmail);
					mail.ReplyToList.Add(new System.Net.Mail.MailAddress(item.config.replyEmail));
				}
				mail.Subject = item.subject;
				mail.IsBodyHtml = true;
				mail.AlternateViews.Add(this.parseLetterHTML(item.message));
				SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
				SmtpServer.Timeout = 50000;
				item.config.text_encoding = ((item.config.text_encoding == "" || item.config.text_encoding == null) ? "UTF8" : item.config.text_encoding);
				string text = item.config.text_encoding;
				uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
				if (num <= 990459521U)
				{
					if (num != 433860734U)
					{
						if (num != 961465920U)
						{
							if (num == 990459521U)
							{
								if (text == "BigEndianUnicode")
								{
									mail.BodyEncoding = Encoding.BigEndianUnicode;
									goto IL_2A6;
								}
							}
						}
						else if (text == "Unicode")
						{
							mail.BodyEncoding = Encoding.Unicode;
							goto IL_2A6;
						}
					}
					else if (text == "Default")
					{
						mail.BodyEncoding = Encoding.Default;
						goto IL_2A6;
					}
				}
				else if (num <= 3081098251U)
				{
					if (num != 3030765394U)
					{
						if (num == 3081098251U)
						{
							if (text == "UTF7")
							{
								mail.BodyEncoding = Encoding.UTF7;
								goto IL_2A6;
							}
						}
					}
					else if (text == "UTF8")
					{
						mail.BodyEncoding = Encoding.UTF8;
						goto IL_2A6;
					}
				}
				else if (num != 3164024976U)
				{
					if (num == 3407269119U)
					{
						if (text == "UTF32")
						{
							mail.BodyEncoding = Encoding.UTF32;
							goto IL_2A6;
						}
					}
				}
				else if (text == "ASCII")
				{
					mail.BodyEncoding = Encoding.ASCII;
					goto IL_2A6;
				}
				mail.BodyEncoding = Encoding.ASCII;
				IL_2A6:
				mail.SubjectEncoding = mail.BodyEncoding;
				item.config.btencoding = ((item.config.btencoding == "" || item.config.btencoding == null) ? "QuotedPrintable" : item.config.btencoding);
				text = item.config.btencoding;
				if (!(text == "Base64"))
				{
					if (!(text == "EightBit"))
					{
						if (!(text == "QuotedPrintable"))
						{
							if (!(text == "SevenBit"))
							{
								if (!(text == "Unknown"))
								{
									mail.BodyTransferEncoding = TransferEncoding.QuotedPrintable;
								}
								else
								{
									mail.BodyTransferEncoding = TransferEncoding.Unknown;
								}
							}
							else
							{
								mail.BodyTransferEncoding = TransferEncoding.SevenBit;
							}
						}
						else
						{
							mail.BodyTransferEncoding = TransferEncoding.QuotedPrintable;
						}
					}
					else
					{
						mail.BodyTransferEncoding = TransferEncoding.EightBit;
					}
				}
				else
				{
					mail.BodyTransferEncoding = TransferEncoding.Base64;
				}
				item.config.smtpdf = ((item.config.smtpdf == "" || item.config.smtpdf == null) ? "International" : item.config.smtpdf);
				text = item.config.smtpdf;
				if (!(text == "International"))
				{
					if (text == "SevenBit")
					{
						SmtpServer.DeliveryFormat = SmtpDeliveryFormat.SevenBit;
					}
				}
				else
				{
					SmtpServer.DeliveryFormat = SmtpDeliveryFormat.International;
				}
				if (this.headers.Length != 0)
				{
					foreach (string header in this.headers)
					{
						if (header.Trim().Length > 1)
						{
							string[] row = header.Split(new char[]
							{
								'|'
							});
							mail.Headers.Add(row[0].Trim(), row[1].Trim());
						}
					}
				}
				if (item.config.priority == 1)
				{
					mail.Priority = System.Net.Mail.MailPriority.High;
				}
				else if (item.config.priority == 3)
				{
					mail.Priority = System.Net.Mail.MailPriority.Normal;
				}
				else if (item.config.priority == 5)
				{
					mail.Priority = System.Net.Mail.MailPriority.Low;
				}
				else
				{
					mail.Priority = System.Net.Mail.MailPriority.Normal;
				}
				mail.Headers.Add("X-Complaints-To", "abuse@postmarkapp.com");
				mail.Headers.Add("X-Job", "189260_5424745");
				mail.Headers.Add("X-PM-Message-Id", "eca85980-0902-4b12-8221-8a7525184875");
				mail.Headers.Add("X-dkim-options", "20200609100822pm;d=sistematdc.com");
				mail.Headers.Add("MIME-Version", "1.0");
				mail.Headers.Add("Content-Type", "text/plain; charset=UTF-8");
				mail.Headers.Add("Content-Transfer-Encoding", "quoted-printable");
				if (item.config.using_attachment == 1)
				{
					object obj = GxSMTP.locker;
					lock (obj)
					{
						string attachmentPath = item.config.file_attachment;
						if (File.Exists(attachmentPath))
						{
							FileStream fs = new FileStream(attachmentPath, FileMode.Open, FileAccess.Read, FileShare.Read);
							string content = string.Empty;
							FileInfo fi = new FileInfo(attachmentPath);
							string[] extensions = new string[]
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
							}
							System.Net.Mail.Attachment attachment;
							if (extensions.Contains(fi.Extension.ToLower()))
							{
								if (this.attachment_parameters != "")
								{
									string[] parameters = this.attachment_parameters.Split(new string[]
									{
										"|||"
									}, StringSplitOptions.None);
									for (int i = 0; i < parameters.Length; i++)
									{
										string[] tags = parameters[i].Split(new string[]
										{
											"==="
										}, StringSplitOptions.None);
										if (tags.Length == 2 && tags[0] != tags[1])
										{
											content = content.Replace(tags[0], tags[1]);
										}
									}
								}
								MemoryStream memoryStream = new MemoryStream();
								StreamWriter streamWriter = new StreamWriter(memoryStream);
								streamWriter.Write(content);
								streamWriter.Flush();
								memoryStream.Position = 0L;
								attachment = new System.Net.Mail.Attachment(memoryStream, Path.GetFileName(attachmentPath));
							}
							else
							{
								attachment = new System.Net.Mail.Attachment(attachmentPath);
							}
							if (this.item.attachment == "" || this.item.attachment == null)
							{
								attachment.Name = Path.GetFileName(attachmentPath);
							}
							else
							{
								attachment.Name = this.item.attachment;
							}
							mail.Attachments.Add(attachment);
						}
					}
				}
				SmtpServer.Port = this.port;
				SmtpServer.Credentials = new NetworkCredential(this.username, this.password);
				ServicePointManager.SecurityProtocol = SecurityProtocolType.SystemDefault;
				if (this.secure)
				{
					SmtpServer.EnableSsl = true;
					ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
				}
				SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
				SmtpServer.Send(mail);
				item.is_sent = true;
				this.counter_log = "Success";
				this.item_progress = "";
			}
			catch (Exception ex)
			{
				item.is_sent = false;
				this.counter_log = "Error1: " + ex.StackTrace.ToString();
				this.item_progress = "";
			}
			GxSMTP.counter--;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000053E8 File Offset: 0x000035E8
		public void sendEmailViaProxy(GxItem item, bool is_proxy = true)
		{
			try
			{
				SmtpMail mail = new SmtpMail(this.EA_license);
				mail.From = new EASendMail.MailAddress(item.from_name, this.from_email);
				if (item.config.use_reply_email == 1)
				{
					mail.From = new EASendMail.MailAddress(item.reply_email_name, item.reply_email);
				}
				EASendMail.MailAddress to = new EASendMail.MailAddress(item.email);
				if (item.config.target_email_name != "")
				{
					to = new EASendMail.MailAddress(item.target_email_name, item.email);
				}
				mail.To.Add(to);
				if (item.config.replyEmail != "")
				{
					mail.ReplyTo = item.config.replyEmail;
				}
				mail.Subject = item.subject;
				mail.HtmlBody = item.message;
				SmtpServer server = new SmtpServer(this.host);
				if (this.port == 465)
				{
					server.Port = 465;
					server.ConnectType = SmtpConnectType.ConnectSSLAuto;
				}
				else
				{
					server.ConnectType = SmtpConnectType.ConnectTryTLS;
				}
				if (is_proxy)
				{
					server.SocksProxyServer = this.proxy_host;
					server.SocksProxyPort = this.proxy_port;
					if (this.proxy_type == "Sock5")
					{
						server.ProxyProtocol = SocksProxyProtocol.Socks5;
					}
					else if (this.proxy_type == "Sock4")
					{
						server.ProxyProtocol = SocksProxyProtocol.Socks4;
					}
					else
					{
						server.ProxyProtocol = SocksProxyProtocol.Http;
					}
					if (this.proxy_username != "")
					{
						server.SocksProxyUser = this.proxy_username;
						server.SocksProxyPassword = this.proxy_password;
					}
				}
				server.User = this.username;
				server.Password = this.password;
				if (this.headers.Length != 0)
				{
					foreach (string header in this.headers)
					{
						if (header.Trim().Length > 1)
						{
							string[] row = header.Split(new char[]
							{
								'|'
							});
							mail.Headers.Add(row[0].Trim(), row[1].Trim());
						}
					}
				}
				if (item.config.priority == 1)
				{
					mail.Priority = EASendMail.MailPriority.High;
				}
				else if (item.config.priority == 3)
				{
					mail.Priority = EASendMail.MailPriority.Normal;
				}
				else if (item.config.priority == 5)
				{
					mail.Priority = EASendMail.MailPriority.Low;
				}
				else
				{
					mail.Priority = EASendMail.MailPriority.Normal;
				}
				if (item.config.using_attachment == 1)
				{
					object obj = GxSMTP.locker;
					lock (obj)
					{
						string attachmentPath = item.config.file_attachment;
						if (File.Exists(attachmentPath))
						{
							FileStream fs = new FileStream(attachmentPath, FileMode.Open, FileAccess.Read, FileShare.Read);
							string content = string.Empty;
							FileInfo fi = new FileInfo(attachmentPath);
							EASendMail.Attachment attachment;
							if (new string[]
							{
								".html",
								".htm",
								".txt",
								".rtf",
								".log",
								".tex"
							}.Contains(fi.Extension.ToLower()))
							{
								using (StreamReader streamReader = new StreamReader(fs, Encoding.UTF8))
								{
									content = streamReader.ReadToEnd();
								}
								if (this.attachment_parameters != "")
								{
									string[] parameters = this.attachment_parameters.Split(new string[]
									{
										"|||"
									}, StringSplitOptions.None);
									for (int i = 0; i < parameters.Length; i++)
									{
										string[] tags = parameters[i].Split(new string[]
										{
											"==="
										}, StringSplitOptions.None);
										if (tags.Length == 2 && tags[0] != tags[1])
										{
											content = content.Replace(tags[0], tags[1]);
										}
									}
								}
								byte[] bytes = Encoding.ASCII.GetBytes(content);
								attachment = mail.AddAttachment(attachmentPath, bytes);
							}
							else
							{
								attachment = mail.AddAttachment(attachmentPath);
							}
							if (this.item.attachment == "" || this.item.attachment == null)
							{
								attachment.Name = Path.GetFileName(attachmentPath);
							}
							else
							{
								attachment.Name = this.item.attachment;
							}
						}
					}
				}
				new EASendMail.SmtpClient().SendMail(server, mail);
				item.is_sent = true;
				this.counter_log = "Success";
				this.item_progress = "";
			}
			catch (Exception ex)
			{
				item.is_sent = false;
				this.counter_log = "Error: " + ex.Message;
				this.item_progress = "";
			}
			GxSMTP.counter--;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000058BC File Offset: 0x00003ABC
		public void sendDirect(GxItem item)
		{
			try
			{
				SmtpMail mail = new SmtpMail(this.EA_license);
				mail.From = new EASendMail.MailAddress(item.from_name, this.from_email);
				if (item.config.use_reply_email == 1)
				{
					mail.From = new EASendMail.MailAddress(item.reply_email_name, item.reply_email);
				}
				EASendMail.MailAddress to = new EASendMail.MailAddress(item.email);
				if (item.config.target_email_name != "")
				{
					to = new EASendMail.MailAddress(item.target_email_name, item.email);
				}
				mail.To.Add(to);
				if (item.config.replyEmail != "")
				{
					mail.ReplyTo = item.config.replyEmail;
				}
				mail.Subject = item.subject;
				mail.HtmlBody = item.message;
				SmtpServer server = new SmtpServer("");
				if (this.headers.Length != 0)
				{
					foreach (string header in this.headers)
					{
						if (header.Trim().Length > 1)
						{
							string[] row = header.Split(new char[]
							{
								'|'
							});
							mail.Headers.Add(row[0].Trim(), row[1].Trim());
						}
					}
				}
				if (item.config.priority == 1)
				{
					mail.Priority = EASendMail.MailPriority.High;
				}
				else if (item.config.priority == 3)
				{
					mail.Priority = EASendMail.MailPriority.Normal;
				}
				else if (item.config.priority == 5)
				{
					mail.Priority = EASendMail.MailPriority.Low;
				}
				else
				{
					mail.Priority = EASendMail.MailPriority.Normal;
				}
				if (item.config.using_attachment == 1)
				{
					object obj = GxSMTP.locker;
					lock (obj)
					{
						string attachmentPath = item.config.file_attachment;
						if (File.Exists(attachmentPath))
						{
							FileStream fs = new FileStream(attachmentPath, FileMode.Open, FileAccess.Read, FileShare.Read);
							string content = string.Empty;
							FileInfo fi = new FileInfo(attachmentPath);
							EASendMail.Attachment attachment;
							if (new string[]
							{
								".html",
								".htm",
								".txt",
								".rtf",
								".log",
								".tex"
							}.Contains(fi.Extension.ToLower()))
							{
								using (StreamReader streamReader = new StreamReader(fs, Encoding.UTF8))
								{
									content = streamReader.ReadToEnd();
								}
								if (this.attachment_parameters != "")
								{
									string[] parameters = this.attachment_parameters.Split(new string[]
									{
										"|||"
									}, StringSplitOptions.None);
									for (int i = 0; i < parameters.Length; i++)
									{
										string[] tags = parameters[i].Split(new string[]
										{
											"==="
										}, StringSplitOptions.None);
										if (tags.Length == 2 && tags[0] != tags[1])
										{
											content = content.Replace(tags[0], tags[1]);
										}
									}
								}
								byte[] bytes = Encoding.ASCII.GetBytes(content);
								attachment = mail.AddAttachment(attachmentPath, bytes);
							}
							else
							{
								attachment = mail.AddAttachment(attachmentPath);
							}
							if (this.item.attachment == "" || this.item.attachment == null)
							{
								attachment.Name = Path.GetFileName(attachmentPath);
							}
							else
							{
								attachment.Name = this.item.attachment;
							}
						}
					}
				}
				new EASendMail.SmtpClient().SendMail(server, mail);
				item.is_sent = true;
				this.counter_log = "Success";
				this.item_progress = "";
			}
			catch (Exception ex)
			{
				item.is_sent = false;
				this.counter_log = "Error: " + ex.Message;
				this.item_progress = "";
			}
			GxSMTP.counter--;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00005CD0 File Offset: 0x00003ED0
		public static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
		{
			GxItem gxitem = (GxItem)e.UserState;
			if (e.Cancelled)
			{
				gxitem.is_sent = false;
			}
			else if (e.Error != null)
			{
				gxitem.is_sent = false;
				GxSMTP.failed.Add(gxitem.email);
			}
			else
			{
				gxitem.is_sent = true;
				GxSMTP.confirmed.Add(gxitem.email);
			}
			GxSMTP.counter--;
			if (GxSMTP.counter < 0)
			{
				GxSMTP.counter = 0;
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00005D4C File Offset: 0x00003F4C
		public static void sendingInThread(GxSMTP smtp, int delay)
		{
			if (GxSMTP.IsValidEmail(smtp.item.email))
			{
				smtp.item.time = DateTime.Now.ToString("hh:mm:ss tt");
				if (smtp.proxy_host == "" && smtp.host.Trim().ToLower() != "direct")
				{
					if (smtp.host.Contains("office365") || smtp.port == 465)
					{
						smtp.sendEmailViaProxy(smtp.item, false);
					}
					else
					{
						smtp.sendEmail(smtp.item);
					}
				}
				else if (smtp.host.Trim().ToLower() != "direct")
				{
					smtp.sendEmailViaProxy(smtp.item, true);
				}
				else
				{
					smtp.sendDirect(smtp.item);
				}
				Thread.Sleep(delay * 1000);
				GxSMTP.counter++;
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00005E44 File Offset: 0x00004044
		public static bool bulkSend(List<GxSMTP> list, int delay, GxLogger _logger, DoWorkEventArgs e, BackgroundWorker worker)
		{
			GxSMTP.max_counter = list.Count;
			GxSMTP.counter = 0;
			Parallel.ForEach<GxSMTP>(list, delegate(GxSMTP smtp)
			{
				GxSMTP.sendingInThread(smtp, delay);
			});
			for (;;)
			{
				IL_31:
				int iteration = 0;
				while (GxSMTP.counter > 0)
				{
					Thread.Sleep(3000);
					if (iteration > 20)
					{
						GxSMTP.counter = 0;
						break;
					}
					iteration++;
				}
				for (int i = 0; i < GxSMTP.max_counter; i++)
				{
					if (!list[i].item.is_sent && list[i].retry_count < 4)
					{
						list[i].retry_count++;
						GxSMTP.sendingInThread(list[i], delay);
						goto IL_31;
					}
					worker.ReportProgress(1, list[i]);
				}
				break;
			}
			return true;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00005F14 File Offset: 0x00004114
		public static bool bulkSend(List<GxSMTP> list, int delay, GxLogger _logger)
		{
			GxSMTP.logger = _logger;
			GxSMTP.max_counter = list.Count;
			Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
			GxSMTP.counter = 0;
			Parallel.ForEach<GxSMTP>(list, delegate(GxSMTP smtp)
			{
				if (GxSMTP.IsValidEmail(smtp.item.email))
				{
					smtp.item.time = DateTime.Now.ToString("hh:mm:ss tt");
					if (smtp.proxy_host == "")
					{
						if (smtp.host.Contains("office365") || smtp.port == 465)
						{
							smtp.sendEmailViaProxy(smtp.item, false);
						}
						else
						{
							smtp.sendEmail(smtp.item);
						}
					}
					else
					{
						smtp.sendEmailViaProxy(smtp.item, true);
					}
					Thread.Sleep(delay * 1000);
					GxSMTP.counter++;
				}
			});
			int iteration = 0;
			while (GxSMTP.counter > 0)
			{
				Thread.Sleep(3000);
				if (iteration > 100)
				{
					GxSMTP.counter = 0;
					break;
				}
				iteration++;
			}
			for (int i = 0; i < GxSMTP.max_counter; i++)
			{
				list[i].item.log = list[i].item.log + "|||" + (list[i].item.is_sent ? "1" : "0");
				string[] tokens = list[i].item.log.Split(new string[]
				{
					"|||"
				}, StringSplitOptions.None);
				GxSMTP.logger.toLogger(tokens, true);
			}
			return true;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00006024 File Offset: 0x00004224
		private string getMimeType(string fileName)
		{
			string mimeType = "application/unknown";
			string ext = Path.GetExtension(fileName).ToLower();
			RegistryKey regKey = Registry.ClassesRoot.OpenSubKey(ext);
			if (regKey != null && regKey.GetValue("Content Type") != null)
			{
				mimeType = regKey.GetValue("Content Type").ToString();
			}
			return mimeType;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00006074 File Offset: 0x00004274
		private static bool IsValidEmail(string email)
		{
			if (Main.is_validate == "1")
			{
				try
				{
					GxSMTP.tokens = email.Trim().ToLower().Split(new char[]
					{
						'@'
					});
					GxSMTP.status = GxSMTP.getDNSType(GxSMTP.tokens[1]);
					if (GxSMTP.status.Contains("outlook"))
					{
						if (GxSMTP.outValidator(email) == "Deliverable")
						{
							return true;
						}
						return false;
					}
					else
					{
						if (GxSMTP.checking(GxSMTP.status, email) == "Valid")
						{
							return true;
						}
						return false;
					}
				}
				catch
				{
					return false;
				}
			}
			bool result;
			try
			{
				if (new System.Net.Mail.MailAddress(email).Address == email)
				{
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00006154 File Offset: 0x00004354
		public static bool addInQueue(BackgroundWorker worker, GxSMTP _smtp)
		{
			if (GxSMTP.queue.Count >= 500)
			{
				return false;
			}
			GxSMTP.queue.Enqueue(_smtp);
			_smtp.counter_log = "";
			_smtp.item_progress = "Queued";
			worker.ReportProgress(1, _smtp);
			return true;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00006194 File Offset: 0x00004394
		public static void processQueue(BackgroundWorker worker, string[] keywords, List<string> links, List<string> proxies, int max_threads)
		{
			if (GxSMTP.queue.Count <= max_threads)
			{
				max_threads = GxSMTP.queue.Count;
			}
			int current_threads_count = 0;
			Action <>9__1;
			GxSMTP.thread = new Thread(delegate()
			{
				while (GxSMTP.queue.Count > 0)
				{
					GxSMTP.is_running = true;
					int current_threads_count;
					if (current_threads_count < max_threads && GxSMTP.queue.Count > 0)
					{
						current_threads_count = current_threads_count;
						current_threads_count++;
						Action action;
						if ((action = <>9__1) == null)
						{
							action = (<>9__1 = delegate()
							{
								if (GxSMTP.queue.Count > 0)
								{
									try
									{
										GxSMTP q_smtp = GxSMTP.queue.Dequeue();
										if (GxSMTP.IsValidEmail(q_smtp.item.email))
										{
											q_smtp.item.progress_count = 1;
											q_smtp.counter_log = "";
											q_smtp.item_progress = "Preparing letter ...";
											worker.ReportProgress(1, q_smtp);
											q_smtp.item.time = DateTime.Now.ToString("hh:mm:ss tt");
											object[] o_list = GxSMTP.processEmail(q_smtp, links, keywords);
											q_smtp = (GxSMTP)o_list[0];
											q_smtp = GxSMTP.sendNow(q_smtp, (List<string>)o_list[1], worker, proxies);
											if (!q_smtp.item.is_sent)
											{
												q_smtp.item.progress_count = 0;
												while (!q_smtp.item.is_sent && q_smtp.retry_count < 3)
												{
													q_smtp.counter_log = "";
													q_smtp.item_progress = "Retrying(" + (q_smtp.retry_count + 1).ToString() + ") ...";
													worker.ReportProgress(1, q_smtp);
													Thread.Sleep(2000);
													q_smtp.retry_count++;
													q_smtp = GxSMTP.sendNow(q_smtp, (List<string>)o_list[1], worker, proxies);
												}
												if (!q_smtp.item.is_sent)
												{
													q_smtp.item.progress_count = 1;
													q_smtp.item_progress = "";
													worker.ReportProgress(1, q_smtp);
													if (!Main.dead_list.Contains(q_smtp.item.smtp_index))
													{
														Main.dead_list.Add(q_smtp.item.smtp_index);
													}
												}
												else
												{
													q_smtp.item.progress_count = 1;
													Main.delivered.Add(q_smtp.item.email);
													worker.ReportProgress(1, q_smtp);
												}
											}
											else
											{
												q_smtp.item.progress_count = 1;
												Main.delivered.Add(q_smtp.item.email);
												worker.ReportProgress(1, q_smtp);
											}
										}
										else
										{
											q_smtp.item.progress_count = 1;
											q_smtp.item.is_sent = false;
											q_smtp.counter_log = "Invalid Email Address";
											q_smtp.item_progress = q_smtp.counter_log;
											worker.ReportProgress(1, q_smtp);
										}
									}
									catch (Exception ex)
									{
										Console.WriteLine("Error:: " + ex.Message.ToString());
									}
								}
								int current_threads_count2 = current_threads_count;
								current_threads_count = current_threads_count2 - 1;
								if (GxSMTP.queue.Count == 0 && current_threads_count <= 0)
								{
									GxSMTP.is_running = false;
								}
							});
						}
						new Task(action).Start();
					}
					else
					{
						Console.WriteLine("Queue Waiting ...");
						Thread.Sleep(5000);
					}
				}
			});
			GxSMTP.thread.Start();
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00006214 File Offset: 0x00004414
		public static GxSMTP sendNow(GxSMTP q_smtp, List<string> tokens, BackgroundWorker worker, List<string> proxies)
		{
			string response = q_smtp.server_response;
			GxApi api = new GxApi();
			if (response == "-1")
			{
				string api_url = GxConfig.baseUrl() + "backend/parse";
				response = api.getLetter(tokens, api_url);
			}
			if (response == "100" || response == "101")
			{
				q_smtp.item.is_sent = false;
				q_smtp.counter_log = "Template Error: " + response;
				worker.ReportProgress(1, q_smtp);
			}
			else
			{
				q_smtp.counter_log = "";
				q_smtp.item_progress = "Letter Ready!";
				worker.ReportProgress(1, q_smtp);
				string[] response_data = api.parseResponse(response);
				q_smtp.item.message = WebUtility.HtmlDecode(response_data[0]);
				string[] e_tokens = q_smtp.item.email.Split(new char[]
				{
					'@'
				});
				string email_link;
				if (e_tokens.Length > 1)
				{
					string[] d_tokens = e_tokens[1].Split(new char[]
					{
						'.'
					});
					email_link = e_tokens[0] + "-" + d_tokens[0];
				}
				else
				{
					email_link = e_tokens[0];
				}
				q_smtp.item.message = q_smtp.item.message.Replace("##NEW_AUTOEMAILAE##", q_smtp.item.email);
				q_smtp.item.message = q_smtp.item.message.Replace("##NEW_EMAIL_LINK##", email_link);
				q_smtp.item.message = q_smtp.item.message.Replace("##NEW_EMAILB64##", GxConfig.toBase64(q_smtp.item.email));
				q_smtp.item.message = q_smtp.item.message.Replace("##NEW_EMAIL##", q_smtp.item.email);
				q_smtp.item.message = q_smtp.item.message.Replace("[-NEW_AUTOEMAILAE-]", q_smtp.item.email);
				q_smtp.item.message = q_smtp.item.message.Replace("[-NEW_EMAIL_LINK-]", email_link);
				q_smtp.item.message = q_smtp.item.message.Replace("[-NEW_EMAILB64-]", GxConfig.toBase64(q_smtp.item.email));
				q_smtp.item.message = q_smtp.item.message.Replace("[-NEW_EMAIL-]", q_smtp.item.email);
				q_smtp.item.message = q_smtp.item.message.Replace("[-FIRSTNAME-]", q_smtp.item.firstname);
				q_smtp.item.message = q_smtp.item.message.Replace("[-LASTNAME-]", q_smtp.item.lastname);
				q_smtp.item.message = q_smtp.item.message.Replace("[-MDOMAIN-]", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(q_smtp.item.email.Split(new char[]
				{
					'@'
				})[1]));
				if (q_smtp.item.config.preheader != "")
				{
					q_smtp.item.message = "<style>.preheader { display:none !important; visibility:hidden; opacity:0; color:transparent; height:0; width:0; }</style><span class='preheader' style='color:transparent; display:none !important; height:0; opacity:0; visibility:hidden; width:0'>" + q_smtp.item.config.preheader + "</span>" + q_smtp.item.message;
				}
				q_smtp.item.subject = response_data[1];
				q_smtp.item.subject = q_smtp.item.subject.Replace("##NEW_AUTOEMAILAE##", q_smtp.item.email);
				q_smtp.item.subject = q_smtp.item.subject.Replace("##NEW_EMAIL_LINK##", email_link);
				q_smtp.item.subject = q_smtp.item.subject.Replace("##NEW_EMAILB64##", GxConfig.toBase64(q_smtp.item.email));
				q_smtp.item.subject = q_smtp.item.subject.Replace("##NEW_EMAIL##", q_smtp.item.email);
				q_smtp.item.subject = q_smtp.item.subject.Replace("[-NEW_AUTOEMAILAE-]", q_smtp.item.email);
				q_smtp.item.subject = q_smtp.item.subject.Replace("[-NEW_EMAIL_LINK-]", email_link);
				q_smtp.item.subject = q_smtp.item.subject.Replace("[-NEW_EMAILB64-]", GxConfig.toBase64(q_smtp.item.email));
				q_smtp.item.subject = q_smtp.item.subject.Replace("[-NEW_EMAIL-]", q_smtp.item.email);
				q_smtp.item.subject = q_smtp.item.subject.Replace("[-FIRSTNAME-]", q_smtp.item.firstname);
				q_smtp.item.subject = q_smtp.item.subject.Replace("[-LASTNAME-]", q_smtp.item.lastname);
				q_smtp.item.subject = q_smtp.item.subject.Replace("[-MDOMAIN-]", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(q_smtp.item.email.Split(new char[]
				{
					'@'
				})[1]));
				if (q_smtp.item.config.using_attachment == 1)
				{
					q_smtp.item.attachment = response_data[2];
				}
				q_smtp.item.from_name = response_data[3];
				q_smtp.item.from_name = q_smtp.item.from_name.Replace("##NEW_AUTOEMAILAE##", q_smtp.item.email);
				q_smtp.item.from_name = q_smtp.item.from_name.Replace("##NEW_EMAIL_LINK##", email_link);
				q_smtp.item.from_name = q_smtp.item.from_name.Replace("##NEW_EMAILB64##", GxConfig.toBase64(q_smtp.item.email));
				q_smtp.item.from_name = q_smtp.item.from_name.Replace("##NEW_EMAIL##", q_smtp.item.email);
				q_smtp.item.from_name = q_smtp.item.from_name.Replace("[-NEW_AUTOEMAILAE-]", q_smtp.item.email);
				q_smtp.item.from_name = q_smtp.item.from_name.Replace("[-NEW_EMAIL_LINK-]", email_link);
				q_smtp.item.from_name = q_smtp.item.from_name.Replace("[-NEW_EMAILB64-]", GxConfig.toBase64(q_smtp.item.email));
				q_smtp.item.from_name = q_smtp.item.from_name.Replace("[-NEW_EMAIL-]", q_smtp.item.email);
				q_smtp.item.from_name = q_smtp.item.from_name.Replace("[-FIRSTNAME-]", q_smtp.item.firstname);
				q_smtp.item.from_name = q_smtp.item.from_name.Replace("[-LASTNAME-]", q_smtp.item.lastname);
				q_smtp.item.from_name = q_smtp.item.from_name.Replace("[-MDOMAIN-]", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(q_smtp.item.email.Split(new char[]
				{
					'@'
				})[1]));
				q_smtp.item.reply_email = response_data[4];
				q_smtp.item.target_email_name = response_data[5];
				q_smtp.item.reply_email_name = response_data[6];
				q_smtp.item.from_email = response_data[7];
				q_smtp.from_email = response_data[7];
				q_smtp.headers = q_smtp.item.headers;
				q_smtp.attachment_parameters = response_data[8];
				string[] attachment_tokens = q_smtp.attachment_parameters.Split(new string[]
				{
					"|||"
				}, StringSplitOptions.None);
				int indexer = 0;
				string[] array = attachment_tokens;
				for (int i = 0; i < array.Length; i++)
				{
					string[] inner_attachment_token = array[i].Split(new string[]
					{
						"==="
					}, StringSplitOptions.None);
					if (inner_attachment_token[1] == "##NEW_AUTOEMAILAE##" || inner_attachment_token[1] == "[-NEW_AUTOEMAILAE-]" || inner_attachment_token[1] == "[-NEW_EMAIL-]" || inner_attachment_token[1] == "##NEW_EMAIL##")
					{
						inner_attachment_token[1] = q_smtp.item.email;
					}
					if (inner_attachment_token[1] == "##NEW_EMAIL_LINK##")
					{
						inner_attachment_token[1] = email_link;
					}
					if (inner_attachment_token[1] == "##NEW_EMAILB64##" || inner_attachment_token[1] == "[-NEW_EMAILB64-]")
					{
						inner_attachment_token[1] = GxConfig.toBase64(q_smtp.item.email);
					}
					if (inner_attachment_token[1] == "[-FIRSTNAME-]")
					{
						inner_attachment_token[1] = q_smtp.item.firstname;
					}
					if (inner_attachment_token[1] == "[-LASTNAME-]")
					{
						inner_attachment_token[1] = q_smtp.item.lastname;
					}
					if (inner_attachment_token[1] == "[-MDOMAIN-]")
					{
						inner_attachment_token[1] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(q_smtp.item.email.Split(new char[]
						{
							'@'
						})[1]);
					}
					inner_attachment_token[0] = inner_attachment_token[0].Replace("NEW_", "");
					attachment_tokens[indexer] = string.Join("===", inner_attachment_token);
					indexer++;
				}
				q_smtp.attachment_parameters = string.Join("|||", attachment_tokens);
				if (proxies.Count > 0)
				{
					if (GxSMTP.proxy_counter >= proxies.Count)
					{
						GxSMTP.proxy_counter = 0;
					}
					string[] p_tokens = proxies[GxSMTP.proxy_counter++].Split(new string[]
					{
						"|||"
					}, StringSplitOptions.None);
					q_smtp.proxy_host = p_tokens[0];
					q_smtp.proxy_port = int.Parse(p_tokens[1]);
					q_smtp.proxy_username = p_tokens[2];
					q_smtp.proxy_password = p_tokens[3];
					if (p_tokens.Length > 4)
					{
						q_smtp.proxy_type = p_tokens[4];
					}
				}
				q_smtp.item.log = string.Concat(new string[]
				{
					DateTime.Now.ToString("hh:mm:ss tt"),
					"|||",
					q_smtp.item.from_name,
					"|||",
					q_smtp.from_email,
					"|||",
					q_smtp.item.email,
					"|||",
					q_smtp.item.subject
				});
				q_smtp.counter_log = "";
				q_smtp.item_progress = "Success";
				worker.ReportProgress(1, q_smtp);
				if (q_smtp.proxy_host == "")
				{
					if (q_smtp.host.Contains("office365") || q_smtp.port == 465)
					{
						q_smtp.sendEmailViaProxy(q_smtp.item, false);
					}
					else
					{
						q_smtp.sendEmail(q_smtp.item);
					}
				}
				else
				{
					q_smtp.sendEmailViaProxy(q_smtp.item, true);
				}
				if (q_smtp.item.is_sent)
				{
					q_smtp.counter_log = "Success";
				}
				worker.ReportProgress(1, q_smtp);
				Thread.Sleep(q_smtp.item.sending_delay);
			}
			return q_smtp;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00006D48 File Offset: 0x00004F48
		public static object[] processEmail(GxSMTP q_smtp, List<string> links, string[] keywords)
		{
			List<string> token = new List<string>();
			token.Add(q_smtp.item.email);
			token.Add(WebUtility.HtmlEncode(q_smtp.item.letter));
			token.Add(q_smtp.item.config.letter_encrypt.ToString());
			token.Add(q_smtp.item.config.subject);
			token.Add(q_smtp.item.config.subject_encode.ToString());
			token.Add(q_smtp.item.config.name_attachment.ToString());
			token.Add(q_smtp.item.from_name);
			token.Add(q_smtp.item.config.fromname_encode.ToString());
			token.Add(q_smtp.item.reply_email);
			token.Add(q_smtp.item.target_email_name);
			token.Add(q_smtp.item.reply_email_name);
			if (links.Count > 0)
			{
				token.Add(string.Join("####", links));
			}
			else
			{
				token.Add("");
			}
			if (keywords.Length != 0)
			{
				token.Add(string.Join(",", keywords));
			}
			else
			{
				token.Add("");
			}
			token.Add(q_smtp.item.config.api_key);
			token.Add(q_smtp.item.config.api_domain);
			token.Add(q_smtp.from_email);
			token.Add(q_smtp.sender_email);
			token.Add(q_smtp.smtp_domain_name);
			token.Add(q_smtp.smtp_user_name);
			if (q_smtp.item.config.using_attachment == 1)
			{
				token.Add(Main.attachment_tags);
			}
			else
			{
				token.Add("");
			}
			return new object[]
			{
				q_smtp,
				token
			};
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00006F28 File Offset: 0x00005128
		public static string checking(string mx, string email)
		{
			string result;
			try
			{
				string html = string.Empty;
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://7x8yg.com/web/leads/validation?email=" + email + "&user=usamajony@gmail.com");
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
				result = html;
			}
			catch (Exception)
			{
				result = "Invalid";
			}
			return result;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00006FE8 File Offset: 0x000051E8
		private static byte[] BytesFromString(string str)
		{
			return Encoding.ASCII.GetBytes(str);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00006FF5 File Offset: 0x000051F5
		private static int GetResponseCode(string ResponseString)
		{
			return int.Parse(ResponseString.Substring(0, 3));
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00007004 File Offset: 0x00005204
		public static string getDNSType(string domain)
		{
			string result;
			try
			{
				DomainName exchangeDomainName = new DnsStubResolver().Resolve(domain, RecordType.Mx, RecordClass.INet)[0].ExchangeDomainName;
				result = ((exchangeDomainName != null) ? exchangeDomainName.ToString() : null);
			}
			catch (Exception ex)
			{
				result = ex.Message;
			}
			return result;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00007054 File Offset: 0x00005254
		public static string outValidator(string s)
		{
			string result;
			try
			{
				s = GxSMTP.strEncode(s);
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(GxSMTP.getRandomStr(s));
				httpWebRequest.Method = "GET";
				httpWebRequest.UserAgent = GxSMTP.getAgent();
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				Encoding enc = Encoding.GetEncoding("utf-8");
				new StreamReader(httpWebResponse.GetResponseStream(), enc);
				httpWebResponse.Close();
				result = ((httpWebResponse.StatusCode == HttpStatusCode.OK) ? "Deliverable" : "Undeliverable");
			}
			catch (Exception)
			{
				if (GxSMTP.GetValidEm(GxSMTP.strDecode(s)))
				{
					result = "Deliverable";
				}
				else
				{
					result = "Undeliverable";
				}
			}
			return result;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00007104 File Offset: 0x00005304
		public static string strEncode(string str)
		{
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(str));
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00007116 File Offset: 0x00005316
		public static string getRandomStr(string s)
		{
			s = GxSMTP.strDecode("aHR0cHM6Ly9vdXRsb29rLm9mZmljZTM2NS5jb20vYXV0b2Rpc2NvdmVyL2F1dG9kaXNjb3Zlci5qc29uL3YxLjAv") + GxSMTP.strDecode(s) + GxSMTP.strDecode("P1Byb3RvY29sPUF1dG9kaXNjb3ZlcnYx");
			return s;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000713A File Offset: 0x0000533A
		public static string strDecode(string str)
		{
			return Encoding.UTF8.GetString(Convert.FromBase64String(str));
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000714C File Offset: 0x0000534C
		public static string getAgent()
		{
			string[] agents = new string[]
			{
				"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0.3440.106 Safari/537.36",
				"Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/46.0.2490.86 Safari/537.36",
				"Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:62.0) Gecko/20100101 Firefox/62.0",
				"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.140 Safari/537.36 Edge/17.17134"
			};
			Random r = new Random();
			return agents[r.Next(0, agents.Length)];
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00007194 File Offset: 0x00005394
		private static bool GetValidEm(string email)
		{
			string html = "";
			bool result;
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://verify.gmass.co/verify?email=" + email + "&key=" + GxSMTP.getApi());
				httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip;
				httpWebRequest.Proxy = null;
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
				if (JsonConvert.DeserializeObject<GxVerifier.EmailResult>(html).Status == "Valid")
				{
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00007278 File Offset: 0x00005478
		private static string getApi()
		{
			int num = new Random().Next(1, 20);
			if (num == 1)
			{
				return "ab389b2d-9dc2-4282-8c6c-9d1663ce8cbb";
			}
			if (num == 2)
			{
				return "b25e9509-d944-4893-9cb0-b5d332923603";
			}
			if (num == 3)
			{
				return "2f5f775a-a3a3-45ed-b90a-4a733e4cf64d";
			}
			if (num == 4)
			{
				return "bf40983a-cf28-4eae-aa77-fd50048984d1";
			}
			if (num == 5)
			{
				return "37bf3ec0-4103-414a-bec3-8c908d32dcab";
			}
			if (num == 6)
			{
				return "c216a526-64ce-4dea-8429-5906a5805475";
			}
			if (num == 7)
			{
				return "4f353683-b255-41a9-bc9e-e65749647c70";
			}
			if (num == 8)
			{
				return "bc0887a1-f714-434f-8cf5-ade63ef4ea98";
			}
			if (num == 9)
			{
				return "82fd7012-cad9-410a-be64-5ba3bacb796b";
			}
			if (num == 10)
			{
				return "d0c2464f-71cd-494b-956e-f423f28f80ec";
			}
			if (num == 11)
			{
				return "067e4f97-fd3e-4940-8f66-72605e193ff4";
			}
			if (num == 12)
			{
				return "c586a29c-4338-461d-b833-bf4a154d3730";
			}
			if (num == 13)
			{
				return "5d97e5f5-fa3d-47ff-ad26-873c0a9150e2";
			}
			if (num == 14)
			{
				return "505a4af1-5f8d-40bb-a237-5db87e8ba325";
			}
			if (num == 15)
			{
				return "dd2ed6df-c999-4ed9-9655-43f9ad92c5a8";
			}
			if (num == 16)
			{
				return "f085030f-33e7-43a3-9a05-c305aafd5d38";
			}
			if (num == 17)
			{
				return "fe36ee82-45be-42e0-97a8-4a7a22a706e0";
			}
			if (num == 18)
			{
				return "7f22863f-8c99-4d5a-b76c-ff34a5356354";
			}
			if (num == 19)
			{
				return "4c05bb92-65b4-4fd9-b499-aa556d12acd2";
			}
			if (num == 20)
			{
				return "fc44c4ea-dcdf-4dca-961f-c06561c2c40a";
			}
			return "067e4f97-fd3e-4940-8f66-72605e193ff4";
		}

		// Token: 0x04000062 RID: 98
		public string host;

		// Token: 0x04000063 RID: 99
		public string username;

		// Token: 0x04000064 RID: 100
		public int port;

		// Token: 0x04000065 RID: 101
		public bool secure;

		// Token: 0x04000066 RID: 102
		public string from_email;

		// Token: 0x04000067 RID: 103
		public string password;

		// Token: 0x04000068 RID: 104
		public bool is_proxy;

		// Token: 0x04000069 RID: 105
		public GxItem item;

		// Token: 0x0400006A RID: 106
		public static int counter = 0;

		// Token: 0x0400006B RID: 107
		private static GxLogger logger;

		// Token: 0x0400006C RID: 108
		public static int max_counter = 0;

		// Token: 0x0400006D RID: 109
		public static List<string> confirmed = new List<string>();

		// Token: 0x0400006E RID: 110
		public static List<string> failed = new List<string>();

		// Token: 0x0400006F RID: 111
		private static object locker = new object();

		// Token: 0x04000070 RID: 112
		public string[] headers;

		// Token: 0x04000071 RID: 113
		public int counter_index;

		// Token: 0x04000072 RID: 114
		public string counter_log = "";

		// Token: 0x04000073 RID: 115
		public string proxy_host = "";

		// Token: 0x04000074 RID: 116
		public int proxy_port;

		// Token: 0x04000075 RID: 117
		public string proxy_username = "";

		// Token: 0x04000076 RID: 118
		public string proxy_password = "";

		// Token: 0x04000077 RID: 119
		public string proxy_type = "Sock5";

		// Token: 0x04000078 RID: 120
		public bool imap = true;

		// Token: 0x04000079 RID: 121
		private string EA_license = "ES-D1508812687-00796-43EDA8441T7A552E-FV3A13A8DF3826B7";

		// Token: 0x0400007A RID: 122
		private string EA_IMAP_license = "EG-C1508812802-00331-52A23AA637527764-FF1A3TBCF28AAVBA";

		// Token: 0x0400007B RID: 123
		private int retry_count = 1;

		// Token: 0x0400007C RID: 124
		public static Queue<GxSMTP> queue = new Queue<GxSMTP>();

		// Token: 0x0400007D RID: 125
		public string item_progress = "";

		// Token: 0x0400007E RID: 126
		public static bool is_running = false;

		// Token: 0x0400007F RID: 127
		public static Thread thread;

		// Token: 0x04000080 RID: 128
		public static int url_counter = 0;

		// Token: 0x04000081 RID: 129
		public static int keyword_counter = 0;

		// Token: 0x04000082 RID: 130
		public static int proxy_counter = 0;

		// Token: 0x04000083 RID: 131
		private string attachment_parameters = "";

		// Token: 0x04000084 RID: 132
		public int max_limit;

		// Token: 0x04000085 RID: 133
		public int usage_count;

		// Token: 0x04000086 RID: 134
		public string server_response = "";

		// Token: 0x04000087 RID: 135
		public string[] server_headers;

		// Token: 0x04000088 RID: 136
		public static int count = 0;

		// Token: 0x04000089 RID: 137
		public static string status = string.Empty;

		// Token: 0x0400008A RID: 138
		public static string[] tokens;

		// Token: 0x0400008B RID: 139
		public string sender_email;

		// Token: 0x0400008C RID: 140
		public string smtp_domain_name;

		// Token: 0x0400008D RID: 141
		public string smtp_user_name;
	}
}
