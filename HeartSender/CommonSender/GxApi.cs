using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using HeartSender;

namespace CommonSender
{
	// Token: 0x02000003 RID: 3
	public class GxApi
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
		public string doResetToken()
		{
			string result;
			try
			{
				GxLicense license = new GxLicense();
				license.SetSystemTimeZone("GMT Standard Time");
				string request_code = license.getUniqCode(TimeZone.CurrentTimeZone.ToLocalTime(DateTime.Now).ToUnixTimeSeconds().ToString());
				string token = string.Concat(new string[]
				{
					license.getLicenseToken(),
					"-=:::::=-",
					request_code,
					"-=:::::=-",
					license.getMacAddress()
				});
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create(GxConfig.baseUrl() + "backend/reset-token");
				string postData = "data=" + GxConfig.toBase64(token);
				byte[] data = Encoding.UTF8.GetBytes(postData);
				request.Method = "POST";
				request.ContentType = "application/x-www-form-urlencoded; charset=utf-8";
				request.ContentLength = (long)data.Length;
				using (Stream stream = request.GetRequestStream())
				{
					stream.Write(data, 0, data.Length);
				}
				HttpWebResponse webresponse = (HttpWebResponse)request.GetResponse();
				Encoding enc = Encoding.GetEncoding("utf-8");
				object obj = new StreamReader(webresponse.GetResponseStream(), enc).ReadToEnd();
				webresponse.Close();
				result = obj.ToString().Trim().Replace(" ", "+");
			}
			catch (Exception)
			{
				result = "101";
			}
			return result;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000021EC File Offset: 0x000003EC
		public string getHeaders()
		{
			string result;
			try
			{
				GxLicense license = new GxLicense();
				license.SetSystemTimeZone("GMT Standard Time");
				string request_code = license.getUniqCode(TimeZone.CurrentTimeZone.ToLocalTime(DateTime.Now).ToUnixTimeSeconds().ToString());
				string token = string.Concat(new string[]
				{
					license.getLicenseToken(),
					"-=:::::=-",
					request_code,
					"-=:::::=-",
					license.getMacAddress()
				});
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create(GxConfig.baseUrl() + "backend/get-headers");
				string postData = "data=" + GxConfig.toBase64(token);
				byte[] data = Encoding.UTF8.GetBytes(postData);
				request.Method = "POST";
				request.ContentType = "application/x-www-form-urlencoded; charset=utf-8";
				request.ContentLength = (long)data.Length;
				using (Stream stream = request.GetRequestStream())
				{
					stream.Write(data, 0, data.Length);
				}
				HttpWebResponse webresponse = (HttpWebResponse)request.GetResponse();
				Encoding enc = Encoding.GetEncoding("utf-8");
				object obj = new StreamReader(webresponse.GetResponseStream(), enc).ReadToEnd();
				webresponse.Close();
				result = obj.ToString().Trim().Replace(" ", "+");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				result = "101";
			}
			return result;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002388 File Offset: 0x00000588
		public string getLetter(List<string> parameters, string api_url)
		{
			string result;
			try
			{
				GxLicense license = new GxLicense();
				license.SetSystemTimeZone("GMT Standard Time");
				string request_code = license.getUniqCode(TimeZone.CurrentTimeZone.ToLocalTime(DateTime.Now).ToUnixTimeSeconds().ToString());
				string token = string.Concat(new string[]
				{
					license.getLicenseToken(),
					"-=:::::=-",
					request_code,
					"-=:::::=-",
					license.getMacAddress(),
					"-=:::::=-",
					GxConfig.solutionName(),
					"-=:::::=-",
					GxLogger.getVersionNumber(),
					"{[--:::--]}",
					parameters[0],
					"{[--:::--]}",
					parameters[1],
					"{[--:::--]}",
					parameters[2],
					"{[--:::--]}",
					parameters[3],
					"{[--:::--]}",
					parameters[4],
					"{[--:::--]}",
					parameters[5],
					"{[--:::--]}",
					parameters[6],
					"{[--:::--]}",
					parameters[7],
					"{[--:::--]}",
					parameters[8],
					"{[--:::--]}",
					parameters[9],
					"{[--:::--]}",
					parameters[10],
					"{[--:::--]}",
					parameters[11],
					"{[--:::--]}",
					parameters[12],
					"{[--:::--]}",
					parameters[13],
					"{[--:::--]}",
					parameters[14],
					"{[--:::--]}",
					parameters[15],
					"{[--:::--]}",
					parameters[16],
					"{[--:::--]}",
					parameters[17],
					"{[--:::--]}",
					parameters[18],
					"{[--:::--]}",
					parameters[19]
				});
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create(api_url);
				string postData = "data=" + GxConfig.toBase64(token);
				byte[] data = Encoding.UTF8.GetBytes(postData);
				request.Method = "POST";
				request.ContentType = "application/x-www-form-urlencoded; charset=utf-8";
				request.ContentLength = (long)data.Length;
				using (Stream stream = request.GetRequestStream())
				{
					stream.Write(data, 0, data.Length);
				}
				HttpWebResponse webresponse = (HttpWebResponse)request.GetResponse();
				Encoding enc = Encoding.GetEncoding("utf-8");
				object obj = new StreamReader(webresponse.GetResponseStream(), enc).ReadToEnd();
				webresponse.Close();
				result = obj.ToString().Trim().Replace(" ", "+");
			}
			catch (Exception)
			{
				result = "101";
			}
			return result;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000026C8 File Offset: 0x000008C8
		public string[] parseResponse(string response)
		{
			response = GxConfig.strDecode(response);
			return response.Split(new string[]
			{
				"{[--:::--]}"
			}, StringSplitOptions.None);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000026E8 File Offset: 0x000008E8
		public int isValidIPAddress(string api_url)
		{
			int result;
			try
			{
				string user_ip_address = new WebClient().DownloadString("http://ipinfo.io/ip");
				GxLicense license = new GxLicense();
				license.SetSystemTimeZone("GMT Standard Time");
				string request_code = license.getUniqCode(TimeZone.CurrentTimeZone.ToLocalTime(DateTime.Now).ToUnixTimeSeconds().ToString());
				string token = string.Concat(new string[]
				{
					license.getLicenseToken(),
					"-=:::::=-",
					request_code,
					"-=:::::=-",
					license.getMacAddress(),
					"-=:::::=-",
					GxConfig.solutionName(),
					"{[--:::--]}",
					user_ip_address.Trim()
				});
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create(api_url);
				string postData = "data=" + GxConfig.toBase64(token);
				byte[] data = Encoding.ASCII.GetBytes(postData);
				request.Method = "POST";
				request.ContentType = "application/x-www-form-urlencoded";
				request.ContentLength = (long)data.Length;
				using (Stream stream = request.GetRequestStream())
				{
					stream.Write(data, 0, data.Length);
				}
				HttpWebResponse webresponse = (HttpWebResponse)request.GetResponse();
				Encoding enc = Encoding.GetEncoding("utf-8");
				object obj = new StreamReader(webresponse.GetResponseStream(), enc).ReadToEnd();
				webresponse.Close();
				result = int.Parse(obj.ToString().Trim());
			}
			catch (Exception)
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002894 File Offset: 0x00000A94
		public bool isValidProxy(string api_url, string proxy_name)
		{
			bool result;
			try
			{
				GxLicense license = new GxLicense();
				license.SetSystemTimeZone("GMT Standard Time");
				string request_code = license.getUniqCode(TimeZone.CurrentTimeZone.ToLocalTime(DateTime.Now).ToUnixTimeSeconds().ToString());
				string token = string.Concat(new string[]
				{
					license.getLicenseToken(),
					"-=:::::=-",
					request_code,
					"-=:::::=-",
					license.getMacAddress(),
					"-=:::::=-",
					GxConfig.solutionName(),
					"{[--:::--]}",
					proxy_name.Trim()
				});
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create(api_url);
				string postData = "data=" + GxConfig.toBase64(token);
				byte[] data = Encoding.ASCII.GetBytes(postData);
				request.Method = "POST";
				request.ContentType = "application/x-www-form-urlencoded";
				request.ContentLength = (long)data.Length;
				using (Stream stream = request.GetRequestStream())
				{
					stream.Write(data, 0, data.Length);
				}
				HttpWebResponse webresponse = (HttpWebResponse)request.GetResponse();
				Encoding enc = Encoding.GetEncoding("utf-8");
				object obj = new StreamReader(webresponse.GetResponseStream(), enc).ReadToEnd();
				webresponse.Close();
				result = (obj.ToString().Trim() == "1");
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002A30 File Offset: 0x00000C30
		public string isValidSMTP(string api_url, string[] req_params)
		{
			string result;
			try
			{
				string parameters = string.Concat(new string[]
				{
					"host=",
					GxApi.Base64Encode(req_params[0].Trim()),
					"&port=587&username=",
					GxApi.Base64Encode(req_params[1].Trim()),
					"&password=",
					GxApi.Base64Encode(req_params[2].Trim()),
					"&fromemail=",
					req_params[5].Trim(),
					"&toemail=",
					req_params[6].Trim(),
					"&type=GMass"
				});
				string html = string.Empty;
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(Main.tester_url + "?" + parameters);
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
			catch (Exception ex)
			{
				result = ex.Message.ToString();
			}
			return result;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002B7C File Offset: 0x00000D7C
		public static string Base64Encode(string plainText)
		{
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText));
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002B90 File Offset: 0x00000D90
		public static string getAnnouncementMessage(string api_url)
		{
			string result;
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(GxConfig.baseUrl() + api_url + "?t=1");
				httpWebRequest.Method = "GET";
				HttpWebResponse webresponse = (HttpWebResponse)httpWebRequest.GetResponse();
				Encoding enc = Encoding.GetEncoding("utf-8");
				object obj = new StreamReader(webresponse.GetResponseStream(), enc).ReadToEnd();
				webresponse.Close();
				result = obj.ToString().Trim();
			}
			catch (Exception)
			{
				result = "-1";
			}
			return result;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002C18 File Offset: 0x00000E18
		public static void heartbeat(List<string> emails)
		{
			GxApi.<heartbeat>d__9 <heartbeat>d__;
			<heartbeat>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<heartbeat>d__.emails = emails;
			<heartbeat>d__.<>1__state = -1;
			<heartbeat>d__.<>t__builder.Start<GxApi.<heartbeat>d__9>(ref <heartbeat>d__);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002C50 File Offset: 0x00000E50
		public static bool checkWebsite(string URL)
		{
			bool result;
			try
			{
				new WebClient().DownloadString(URL);
				result = true;
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002C84 File Offset: 0x00000E84
		public static bool checkWebsiteUrls(string html)
		{
			MatchCollection matchCollection = Regex.Matches(html, "href=\"(.*?)\"");
			bool is_valid = true;
			using (IEnumerator enumerator = matchCollection.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!GxApi.checkWebsite(((Match)enumerator.Current).Value.ToString().Replace("href=", "").Replace('"', ' ').Trim()))
					{
						is_valid = false;
						break;
					}
				}
			}
			return is_valid;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002D10 File Offset: 0x00000F10
		public static bool isIPAddressBlocked(string user_ip_address)
		{
			bool result;
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://mxtoolbox.com/api/v1/Lookup?command=blacklist&argument=" + user_ip_address + "&resultIndex=3&disableRhsbl=true&format=2");
				httpWebRequest.Method = "GET";
				httpWebRequest.ContentType = "application/json; charset=utf-8";
				httpWebRequest.Accept = "application/json, text/javascript, */*; q=0.01";
				httpWebRequest.UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.88 Safari/537.36";
				httpWebRequest.Headers.Add("authority", "mxtoolbox.com");
				httpWebRequest.Headers.Add("sec-ch-ua", "'Google Chrome';v='87', ' Not; A Brand';v='99', 'Chromium';v='87'");
				httpWebRequest.Headers.Add("tempauthorization", "e7bf25b3-3517-423e-81d2-6763b7d64c1b");
				httpWebRequest.Headers.Add("x-requested-with", "XMLHttpRequest");
				httpWebRequest.Headers.Add("sec-ch-ua-mobile", "?0");
				httpWebRequest.Headers.Add("sec-fetch-site", "same-origin");
				httpWebRequest.Headers.Add("sec-fetch-mode", "cors");
				httpWebRequest.Headers.Add("sec-fetch-dest", "empty");
				httpWebRequest.Headers.Add("accept-language", "en-GB,en-US;q=0.9,en;q=0.8");
				httpWebRequest.Headers.Add("cookie", "HttpOnly; HttpOnly; MxVisitorUID=c7b0b167-0043-44e6-b175-cfcfd805c108; _ga=GA1.2.576370148.1608533744; _gid=GA1.2.1308585345.1608533744; _mxt_u={'UserId':'00000000-0000-0000-0000-000000000000','UserName':null,'FirstName':null,'IsAdmin':false,'IsPaidUser':false,'IsLoggedIn':false,'MxVisitorUid':'c7b0b167-0043-44e6-b175-cfcfd805c108','TempAuthKey':'e7bf25b3-3517-423e-81d2-6763b7d64c1b','IsPastDue':false,'BouncedEmailOn':null,'NumDomainHealthMonitors':0,'NumDisabledMonitors':0,'XID':null,'AGID':'00000000-0000-0000-0000-000000000000','Membership':{'MemberType':'Anonymous'},'CognitoSub':'00000000-0000-0000-0000-000000000000'}; _mxt_s=anon; _vwo_uuid_v2=D2C6B01984CAD7E23A3C937260AD50B3E|daf9da3d584534e58df4f6febaa1b6b6; _vis_opt_s=1%7C; _vis_opt_test_cookie=1; _vwo_uuid=D2C6B01984CAD7E23A3C937260AD50B3E; _vwo_ds=3%241608533744%3A56.4500904%3A%3A; _cio=55fa4094-6931-f314-3b3c-a8c6001d6f43; _ce.s=v11.rlc~1608533745974; ki_r=; _uetsid=8c26d2c0435911eb95a6db55f3e6e132; _uetvid=8c26fa90435911eb925bf94fd4baf7cf; _vwo_sn=0%3A3; _gaexp=GAX1.2.ch5SscYGQFO5_7d636aDPg.18705.1; _mx_vtc=AB-546=Control; ki_t=1608533745689%3B1608533745689%3B1608533770924%3B1%3B3; ASP.NET_SessionId=z4eivkqd54t5v5dk5s2vq0sc; _gat=1");
				HttpWebResponse webresponse = (HttpWebResponse)httpWebRequest.GetResponse();
				Encoding enc = Encoding.GetEncoding("utf-8");
				string text = new StreamReader(webresponse.GetResponseStream(), enc).ReadToEnd();
				webresponse.Close();
				result = text.Contains("We notice you are on a blacklist");
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002E94 File Offset: 0x00001094
		public string submitFeedabck(string message)
		{
			string result;
			try
			{
				string token = new GxLicense().getLicenseToken() + "-=:::::=-" + message;
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create(GxConfig.baseUrl() + "backend/send-feedback");
				string postData = "data=" + GxConfig.toBase64(token);
				byte[] data = Encoding.UTF8.GetBytes(postData);
				request.Method = "POST";
				request.ContentType = "application/x-www-form-urlencoded; charset=utf-8";
				request.ContentLength = (long)data.Length;
				using (Stream stream = request.GetRequestStream())
				{
					stream.Write(data, 0, data.Length);
				}
				HttpWebResponse webresponse = (HttpWebResponse)request.GetResponse();
				Encoding enc = Encoding.GetEncoding("utf-8");
				object obj = new StreamReader(webresponse.GetResponseStream(), enc).ReadToEnd();
				webresponse.Close();
				result = obj.ToString().Trim().Replace(" ", "+");
			}
			catch (Exception)
			{
				result = "101";
			}
			return result;
		}
	}
}
