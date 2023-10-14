using System;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Win32;

namespace CommonSender
{
	// Token: 0x02000005 RID: 5
	[Serializable]
	public class GxDB
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00003155 File Offset: 0x00001355
		private RegistryKey getConnection()
		{
			if (GxDB.registry == null)
			{
				GxDB.registry = Registry.CurrentUser.CreateSubKey("SOFTWARE\\HeartSender");
			}
			return GxDB.registry;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003178 File Offset: 0x00001378
		public void add(string[] param)
		{
			try
			{
				GxDB.registry = this.getConnection();
				string unique_key = "HS_SMTP_" + param[2];
				int counter = 1;
				if (GxDB.registry.GetValue(unique_key) != null)
				{
					counter = int.Parse(GxDB.registry.GetValue(unique_key).ToString());
					counter++;
				}
				GxDB.registry.SetValue(unique_key, counter.ToString().Trim().ToLower());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message.ToString());
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003208 File Offset: 0x00001408
		public int getSmtpCount(string code)
		{
			try
			{
				GxDB.registry = this.getConnection();
				string unique_key = "HS_SMTP_" + code;
				if (GxDB.registry.GetValue(unique_key) != null)
				{
					return int.Parse(GxDB.registry.GetValue(unique_key).ToString());
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message.ToString());
			}
			return 0;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003278 File Offset: 0x00001478
		public static string createMD5(string input)
		{
			string result;
			using (MD5 md5 = MD5.Create())
			{
				byte[] inputBytes = Encoding.ASCII.GetBytes(input);
				byte[] hashBytes = md5.ComputeHash(inputBytes);
				StringBuilder sb = new StringBuilder();
				for (int i = 0; i < hashBytes.Length; i++)
				{
					sb.Append(hashBytes[i].ToString("X2"));
				}
				result = sb.ToString();
			}
			return result;
		}

		// Token: 0x0400003A RID: 58
		public static RegistryKey registry;
	}
}
