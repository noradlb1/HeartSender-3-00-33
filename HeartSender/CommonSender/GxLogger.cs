using System;

namespace CommonSender
{
	// Token: 0x0200000B RID: 11
	[Serializable]
	public class GxLogger
	{
		// Token: 0x06000042 RID: 66 RVA: 0x000043A4 File Offset: 0x000025A4
		public static string getVersionNumber()
		{
			return "3.00.33";
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000043AB File Offset: 0x000025AB
		public void toLogger(string[] parameters, bool append = false)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000043AD File Offset: 0x000025AD
		public static void writeLog(string str, bool is_append = true)
		{
			GxConfig.getBasePath() + "data.log";
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000043C1 File Offset: 0x000025C1
		public static string getName()
		{
			return "HeartSenderV3";
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000043C8 File Offset: 0x000025C8
		public static string getBaseUrl()
		{
			return "http://mrcodertools.com/web/";
		}
	}
}
