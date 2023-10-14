using System;

namespace CommonSender
{
	// Token: 0x02000009 RID: 9
	[Serializable]
	public class GxItem
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00003993 File Offset: 0x00001B93
		public GxItem()
		{
			this.log = "";
			this.reply_email_name = "";
			this.target_email_name = "";
		}

		// Token: 0x04000045 RID: 69
		public string email;

		// Token: 0x04000046 RID: 70
		public string firstname;

		// Token: 0x04000047 RID: 71
		public string lastname;

		// Token: 0x04000048 RID: 72
		public string subject;

		// Token: 0x04000049 RID: 73
		public string from_name;

		// Token: 0x0400004A RID: 74
		public string message;

		// Token: 0x0400004B RID: 75
		public string attachment;

		// Token: 0x0400004C RID: 76
		public int counter;

		// Token: 0x0400004D RID: 77
		public GxConfig config;

		// Token: 0x0400004E RID: 78
		public string log;

		// Token: 0x0400004F RID: 79
		public string time;

		// Token: 0x04000050 RID: 80
		public bool is_sent;

		// Token: 0x04000051 RID: 81
		public string reply_email_name;

		// Token: 0x04000052 RID: 82
		public string target_email_name;

		// Token: 0x04000053 RID: 83
		public string reply_email;

		// Token: 0x04000054 RID: 84
		public string from_email;

		// Token: 0x04000055 RID: 85
		public string shell_url;

		// Token: 0x04000056 RID: 86
		public string letter;

		// Token: 0x04000057 RID: 87
		public string[] headers;

		// Token: 0x04000058 RID: 88
		public int smtp_index = -1;

		// Token: 0x04000059 RID: 89
		public bool error_handling;

		// Token: 0x0400005A RID: 90
		public int progress_count;

		// Token: 0x0400005B RID: 91
		public int sending_delay;
	}
}
