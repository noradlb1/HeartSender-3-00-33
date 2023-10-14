using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;

namespace CommonSender
{
	// Token: 0x0200000A RID: 10
	[Serializable]
	public class GxLicense
	{
		// Token: 0x06000035 RID: 53 RVA: 0x000039C3 File Offset: 0x00001BC3
		public GxLicense()
		{
			this.license_path = GxConfig.getBasePath() + "license.txt";
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003A01 File Offset: 0x00001C01
		public string getVersion()
		{
			return this.license_verison;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003A09 File Offset: 0x00001C09
		public string getContactEmail()
		{
			return this.contact_email;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003A11 File Offset: 0x00001C11
		public string getLicenseToken()
		{
			return File.ReadAllText(this.license_path).Trim();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003A24 File Offset: 0x00001C24
		public string[] validLicense()
		{
			if (!File.Exists(this.license_path))
			{
				GxLogger.writeLog("License File => Doesn't exist", true);
				return new string[]
				{
					"404",
					"Sorry, couldn't find license token."
				};
			}
			string license = File.ReadAllText(this.license_path).Trim();
			if (this.validate(license))
			{
				return new string[]
				{
					"200",
					"License validated!!!"
				};
			}
			return new string[]
			{
				"404",
				GxLicense.message
			};
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003AA8 File Offset: 0x00001CA8
		public void SetSystemTimeZone(string timeZoneId)
		{
			Process process = Process.Start(new ProcessStartInfo
			{
				FileName = "tzutil.exe",
				Arguments = "/s \"" + timeZoneId + "\"",
				UseShellExecute = false,
				CreateNoWindow = true
			});
			if (process != null)
			{
				process.WaitForExit();
				TimeZoneInfo.ClearCachedData();
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003B00 File Offset: 0x00001D00
		private bool validate(string key)
		{
			this.SetSystemTimeZone("GMT Standard Time");
			long time = TimeZone.CurrentTimeZone.ToLocalTime(DateTime.Now).ToUnixTimeSeconds();
			string request_code = this.getUniqCode(time.ToString());
			string response = this.doGetCall(key, request_code);
			if (response != "-1" && response != "-2" && response != "-3")
			{
				long num = this.codeToInt(response);
				time = Math.Abs(num - time) + 1L;
				if (num != 0L && time <= 432000L && time >= 0L)
				{
					GxLogger.writeLog("License => Success", true);
					return true;
				}
				GxLicense.message = "Sorry, your license is not valid!";
			}
			else if (response == "-1")
			{
				GxLicense.message = " Your License Locked\n Reason: Multipal Devices.\n Contact With Seller For Reset ";
			}
			else if (response == "-2")
			{
				GxLicense.message = "Sorry, your request is incorrect.";
			}
			else if (response == "-3")
			{
				GxLicense.message = "You are using older version. Please upgrade!";
			}
			GxLogger.writeLog("License => Failed", true);
			return false;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003C04 File Offset: 0x00001E04
		public string getMacAddress()
		{
			string macAddress = string.Empty;
			long maxSpeed = -1L;
			foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
			{
				string tempMac = nic.GetPhysicalAddress().ToString();
				if (nic.Speed > maxSpeed && !string.IsNullOrEmpty(tempMac) && tempMac.Length >= 12)
				{
					maxSpeed = nic.Speed;
					macAddress = tempMac;
				}
			}
			GxLogger.writeLog("C => " + macAddress, true);
			return macAddress;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003C7C File Offset: 0x00001E7C
		public string doGetCall(string token, string code)
		{
			string result2;
			try
			{
				GxHardware hardware = new GxHardware();
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string.Concat(new string[]
				{
					GxConfig.baseUrl(),
					"api/validate?t=",
					GxConfig.toBase64(this.getMacAddress()),
					"&k=",
					token,
					"&c=",
					code,
					"&ss=hv3&p1=",
					GxConfig.toBase64(hardware.getMotherboard()),
					"&p2=",
					GxConfig.toBase64(hardware.getBIOS()),
					"&p3=",
					GxConfig.toBase64(hardware.getCPU()),
					"&v=",
					GxLogger.getVersionNumber()
				}));
				httpWebRequest.Method = "GET";
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				Encoding enc = Encoding.GetEncoding("utf-8");
				string result = new StreamReader(httpWebResponse.GetResponseStream(), enc).ReadToEnd();
				GxLogger.writeLog("Response => " + result, true);
				httpWebResponse.Close();
				result2 = result;
			}
			catch (Exception)
			{
				result2 = "404";
			}
			return result2;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003D9C File Offset: 0x00001F9C
		public string getUniqCode(string time)
		{
			time = GxConfig.strEncode(time);
			List<string> groups = (from Match m in Regex.Matches(time.Trim(), "[\\s\\S]{1,4}")
			select m.Value).ToList<string>();
			char[] chars = (groups[2] + groups[0] + groups[3] + groups[1]).ToCharArray();
			int num = new Random().Next(1, 9);
			int indx = 0;
			foreach (char c in chars)
			{
				if (indx % 2 == 0)
				{
					chars[indx] = (char)((int)c + num);
				}
				else
				{
					chars[indx] = (char)((int)c - num);
				}
				indx++;
			}
			string uniq_code = GxConfig.strEncode(string.Join<char>("", chars) + GxConfig.strEncode(num.ToString()) + "gL" + GxConfig.strEncode(num.ToString()).Length.ToString());
			groups.Clear();
			string final_code;
			if (uniq_code.Length % 2 == 0)
			{
				final_code = uniq_code.PadRight(36, '=');
				groups = (from Match m in Regex.Matches(final_code.Trim(), "[\\s\\S]{0," + (final_code.Length / 6).ToString() + "}")
				select m.Value).ToList<string>();
				final_code = string.Concat(new string[]
				{
					groups[3],
					groups[0],
					groups[4],
					uniq_code.Length.ToString().PadLeft(2, '0'),
					groups[1],
					groups[2],
					groups[5]
				});
			}
			else
			{
				final_code = uniq_code.PadRight(25, '=');
				groups = (from Match m in Regex.Matches(final_code.Trim(), "[\\s\\S]{1," + (final_code.Length / 5).ToString() + "}")
				select m.Value).ToList<string>();
				final_code = string.Concat(new string[]
				{
					groups[2],
					groups[0],
					groups[3],
					uniq_code.Length.ToString().PadLeft(2, '0'),
					groups[1],
					groups[4]
				});
			}
			return final_code;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00004054 File Offset: 0x00002254
		public long codeToInt(string code)
		{
			if (code.Length < 25)
			{
				return 0L;
			}
			string len;
			string uniq_code;
			List<string> groups;
			if (code.Length % 2 == 0)
			{
				len = code.Substring(18, 2);
				uniq_code = code.Substring(0, 18) + code.Substring(20);
				groups = (from Match m in Regex.Matches(uniq_code.Trim(), "[\\s\\S]{1,6}")
				select m.Value).ToList<string>();
				uniq_code = string.Concat(new string[]
				{
					groups[1],
					groups[3],
					groups[4],
					groups[0],
					groups[2],
					groups[5]
				});
			}
			else
			{
				len = code.Substring(15, 2);
				uniq_code = code.Substring(0, 15) + code.Substring(17);
				groups = (from Match m in Regex.Matches(uniq_code.Trim(), "[\\s\\S]{1,5}")
				select m.Value).ToList<string>();
				uniq_code = string.Concat(new string[]
				{
					groups[1],
					groups[3],
					groups[0],
					groups[2],
					groups[4]
				});
			}
			uniq_code = uniq_code.Substring(0, int.Parse(len));
			uniq_code = GxConfig.strDecode(uniq_code);
			string[] tokens = uniq_code.Split(new string[]
			{
				"gL"
			}, StringSplitOptions.None);
			len = tokens[1];
			int random_number = int.Parse(GxConfig.strDecode(tokens[0].Substring(tokens[0].Length - int.Parse(len))));
			uniq_code = tokens[0].Substring(0, tokens[0].Length - int.Parse(len));
			char[] chars = uniq_code.ToCharArray();
			for (int i = 0; i < chars.Length; i++)
			{
				if (i % 2 == 0)
				{
					chars[i] = (char)((int)chars[i] - random_number);
				}
				else
				{
					chars[i] = (char)((int)chars[i] + random_number);
				}
			}
			uniq_code = string.Join<char>("", chars);
			groups.Clear();
			groups = (from Match m in Regex.Matches(uniq_code.Trim(), "[\\s\\S]{1,4}")
			select m.Value).ToList<string>();
			uniq_code = groups[1] + groups[3] + groups[0] + groups[2];
			uniq_code = GxConfig.strDecode(uniq_code);
			long num = 0L;
			if (long.TryParse(uniq_code, out num))
			{
				return long.Parse(uniq_code);
			}
			return 0L;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00004310 File Offset: 0x00002510
		public bool checkProxy(string code)
		{
			bool result;
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://api.heartsender.com/api/check?t=" + GxConfig.toBase64(code));
				httpWebRequest.Method = "GET";
				HttpWebResponse webresponse = (HttpWebResponse)httpWebRequest.GetResponse();
				Encoding enc = Encoding.GetEncoding("utf-8");
				string text = new StreamReader(webresponse.GetResponseStream(), enc).ReadToEnd();
				webresponse.Close();
				result = (text.Trim() == "1");
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0400005C RID: 92
		private string license_path = "";

		// Token: 0x0400005D RID: 93
		private string license_verison = "1.0";

		// Token: 0x0400005E RID: 94
		private string contact_email = "softwarecodertools@gmail.com";

		// Token: 0x0400005F RID: 95
		public static string message = "";
	}
}
