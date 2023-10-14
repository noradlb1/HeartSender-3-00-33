using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CommonSender
{
	// Token: 0x02000004 RID: 4
	[Serializable]
	public class GxConfig
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002FB0 File Offset: 0x000011B0
		public GxConfig()
		{
			this.is_valid = false;
			this.smtp = new List<GxSMTP>();
			this.links = new List<string>();
			this.socks = new List<string>();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00003022 File Offset: 0x00001222
		public bool validate()
		{
			return this.hasSmtp();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000302F File Offset: 0x0000122F
		public bool hasEmailList()
		{
			return !(this.list_email == "") && this.list_email != null && File.Exists(GxConfig.getBasePath() + this.list_email);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003065 File Offset: 0x00001265
		public bool hasEmailTemplate()
		{
			return !(this.letter == "") && this.letter != null && File.Exists(GxConfig.getBasePath() + this.letter);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000309B File Offset: 0x0000129B
		public bool hasSmtp()
		{
			return this.smtp.Count != 0;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000030AD File Offset: 0x000012AD
		public bool hasFromName()
		{
			return !(this.from_name == "") && this.from_name != null;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000030CC File Offset: 0x000012CC
		public bool hasSubject()
		{
			return !(this.subject == "") && this.subject != null;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000030EB File Offset: 0x000012EB
		public static string getBasePath()
		{
			return "";
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000030F2 File Offset: 0x000012F2
		public static string strTruncate(string value, int maxLength)
		{
			if (string.IsNullOrEmpty(value))
			{
				return value;
			}
			if (value.Length > maxLength)
			{
				return value.Substring(0, maxLength);
			}
			return value;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003111 File Offset: 0x00001311
		public static string baseUrl()
		{
			return GxLogger.getBaseUrl();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003118 File Offset: 0x00001318
		public static string solutionName()
		{
			return GxLogger.getName();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000311F File Offset: 0x0000131F
		public static string toBase64(string str)
		{
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(str));
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003131 File Offset: 0x00001331
		public static string strEncode(string str)
		{
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(str));
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003143 File Offset: 0x00001343
		public static string strDecode(string str)
		{
			return Encoding.UTF8.GetString(Convert.FromBase64String(str));
		}

		// Token: 0x0400000A RID: 10
		public int priority;

		// Token: 0x0400000B RID: 11
		public int user_random;

		// Token: 0x0400000C RID: 12
		public int using_tag;

		// Token: 0x0400000D RID: 13
		public int using_attachment;

		// Token: 0x0400000E RID: 14
		public string name_attachment;

		// Token: 0x0400000F RID: 15
		public int email_countsend;

		// Token: 0x04000010 RID: 16
		public int sending_delay;

		// Token: 0x04000011 RID: 17
		public int masking;

		// Token: 0x04000012 RID: 18
		public string date;

		// Token: 0x04000013 RID: 19
		public int letter_encrypt;

		// Token: 0x04000014 RID: 20
		public int letter_encode;

		// Token: 0x04000015 RID: 21
		public int subject_encode;

		// Token: 0x04000016 RID: 22
		public int link_encode;

		// Token: 0x04000017 RID: 23
		public int image_encode;

		// Token: 0x04000018 RID: 24
		public string list_email;

		// Token: 0x04000019 RID: 25
		public string letter;

		// Token: 0x0400001A RID: 26
		public string file_attachment;

		// Token: 0x0400001B RID: 27
		public string target_email_name;

		// Token: 0x0400001C RID: 28
		public int use_reply_email;

		// Token: 0x0400001D RID: 29
		public string reply_email;

		// Token: 0x0400001E RID: 30
		public string reply_email_name;

		// Token: 0x0400001F RID: 31
		public string from_name;

		// Token: 0x04000020 RID: 32
		public string subject;

		// Token: 0x04000021 RID: 33
		public string from_email;

		// Token: 0x04000022 RID: 34
		public string spam_words;

		// Token: 0x04000023 RID: 35
		public List<GxSMTP> smtp;

		// Token: 0x04000024 RID: 36
		public List<string> links;

		// Token: 0x04000025 RID: 37
		public List<string> socks;

		// Token: 0x04000026 RID: 38
		public List<string> shells;

		// Token: 0x04000027 RID: 39
		public bool is_valid;

		// Token: 0x04000028 RID: 40
		public string template;

		// Token: 0x04000029 RID: 41
		public int confirmed_email;

		// Token: 0x0400002A RID: 42
		public int failed_email;

		// Token: 0x0400002B RID: 43
		public int mail_limit;

		// Token: 0x0400002C RID: 44
		public int fromname_encode;

		// Token: 0x0400002D RID: 45
		public int remove_email;

		// Token: 0x0400002E RID: 46
		public int verify_email;

		// Token: 0x0400002F RID: 47
		public string text_encoding;

		// Token: 0x04000030 RID: 48
		public string btencoding;

		// Token: 0x04000031 RID: 49
		public string smtpdf;

		// Token: 0x04000032 RID: 50
		public string preheader;

		// Token: 0x04000033 RID: 51
		public string replyEmail;

		// Token: 0x04000034 RID: 52
		public string api_key = "";

		// Token: 0x04000035 RID: 53
		public string api_domain = "";

		// Token: 0x04000036 RID: 54
		public string imap_keywords = "";

		// Token: 0x04000037 RID: 55
		public double imap_time = 60.0;

		// Token: 0x04000038 RID: 56
		public bool enable_duplicate;

		// Token: 0x04000039 RID: 57
		public bool enable_validate_email = true;
	}
}
