using System;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CommonSender
{
	// Token: 0x0200000E RID: 14
	public class GxVerifier
	{
		// Token: 0x0600006A RID: 106 RVA: 0x00007468 File Offset: 0x00005668
		public int execute(string email)
		{
			int result;
			try
			{
				string url = "https://gsuite.tools/verify-email?email=" + email + "&mail_from=info%40mail.com";
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
				httpWebRequest.Headers["authority"] = "gsuite.tools";
				httpWebRequest.Headers["upgrade-insecure-requests"] = "1";
				httpWebRequest.UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/76.0.3809.100 Safari/537.36";
				httpWebRequest.Headers["sec-fetch-mode"] = "navigate";
				httpWebRequest.Headers["sec-fetch-user"] = "?1";
				httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3";
				httpWebRequest.Headers["sec-fetch-site"] = "same-origin";
				httpWebRequest.Referer = url;
				httpWebRequest.Headers["accept-language"] = "en-GB,en-US;q=0.9,en;q=0.8";
				httpWebRequest.Headers["cookie"] = "cf_clearance=a47a86a8dc98c39b75f7506c898fb9a15005302e-1580807948-0-150; __cfduid=d8190450e0926775d83446c249b058aae1580807948; _ga=GA1.2.1765737347.1580807951; _gid=GA1.2.1561512301.1580807951; _gat=1; cookieconsent_dismissed=yes";
				httpWebRequest.Method = "GET";
				HttpWebResponse webresponse = (HttpWebResponse)httpWebRequest.GetResponse();
				Encoding enc = Encoding.GetEncoding("utf-8");
				string input = new StreamReader(webresponse.GetResponseStream(), enc).ReadToEnd();
				webresponse.Close();
				result = (Regex.IsMatch(input, "\\&\\#10003\\;\\s+VALID\\s+EMAIL\\s+ADDRESS\\s+\\&\\#10003\\;|250.*recipient\\s+ok", RegexOptions.IgnoreCase) ? 1 : 0);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				result = -1;
			}
			return result;
		}

		// Token: 0x0200002A RID: 42
		public class EmailResult
		{
			// Token: 0x17000005 RID: 5
			// (get) Token: 0x0600017B RID: 379 RVA: 0x000241F8 File Offset: 0x000223F8
			// (set) Token: 0x0600017C RID: 380 RVA: 0x00024200 File Offset: 0x00022400
			public string Success { get; set; }

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x0600017D RID: 381 RVA: 0x00024209 File Offset: 0x00022409
			// (set) Token: 0x0600017E RID: 382 RVA: 0x00024211 File Offset: 0x00022411
			public string Email { get; set; }

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600017F RID: 383 RVA: 0x0002421A File Offset: 0x0002241A
			// (set) Token: 0x06000180 RID: 384 RVA: 0x00024222 File Offset: 0x00022422
			public string Valid { get; set; }

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000181 RID: 385 RVA: 0x0002422B File Offset: 0x0002242B
			// (set) Token: 0x06000182 RID: 386 RVA: 0x00024233 File Offset: 0x00022433
			public string Status { get; set; }

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000183 RID: 387 RVA: 0x0002423C File Offset: 0x0002243C
			// (set) Token: 0x06000184 RID: 388 RVA: 0x00024244 File Offset: 0x00022444
			public string SMTPResult { get; set; }

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000185 RID: 389 RVA: 0x0002424D File Offset: 0x0002244D
			// (set) Token: 0x06000186 RID: 390 RVA: 0x00024255 File Offset: 0x00022455
			public string SMTPCode { get; set; }

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000187 RID: 391 RVA: 0x0002425E File Offset: 0x0002245E
			// (set) Token: 0x06000188 RID: 392 RVA: 0x00024266 File Offset: 0x00022466
			public string Transaction { get; set; }
		}

		// Token: 0x0200002B RID: 43
		public class EmailVal
		{
			// Token: 0x1700000C RID: 12
			// (get) Token: 0x0600018A RID: 394 RVA: 0x00024277 File Offset: 0x00022477
			// (set) Token: 0x0600018B RID: 395 RVA: 0x0002427F File Offset: 0x0002247F
			public bool smtp_check { get; set; }
		}
	}
}
