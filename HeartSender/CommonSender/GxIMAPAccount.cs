using System;

namespace CommonSender
{
	// Token: 0x02000008 RID: 8
	[Serializable]
	public class GxIMAPAccount
	{
		// Token: 0x0400003F RID: 63
		public string server_name;

		// Token: 0x04000040 RID: 64
		public string username;

		// Token: 0x04000041 RID: 65
		public string password;

		// Token: 0x04000042 RID: 66
		public int port;

		// Token: 0x04000043 RID: 67
		public int limit;

		// Token: 0x04000044 RID: 68
		public bool is_ssl;
	}
}
