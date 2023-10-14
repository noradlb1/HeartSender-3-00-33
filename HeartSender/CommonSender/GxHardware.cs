using System;
using System.Globalization;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic;

namespace CommonSender
{
	// Token: 0x02000006 RID: 6
	public class GxHardware
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00003300 File Offset: 0x00001500
		// (set) Token: 0x06000025 RID: 37 RVA: 0x00003308 File Offset: 0x00001508
		public string LastID { get; set; }

		// Token: 0x06000026 RID: 38 RVA: 0x00003314 File Offset: 0x00001514
		public string Generate()
		{
			string[] strArray = new string[]
			{
				this.GetProperties(GxHardware.WMI_CLASSES.MOTHERBOARD),
				this.GetProperties(GxHardware.WMI_CLASSES.BIOS),
				this.GetProperties(GxHardware.WMI_CLASSES.CPU)
			};
			this.LastID = this.GetHash(string.Join(string.Empty, strArray));
			return this.LastID;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003370 File Offset: 0x00001570
		public string GetProperties(string[] wmiData)
		{
			StringBuilder stringBuilder = new StringBuilder();
			checked
			{
				using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", this.GenerateQuery(wmiData)))
				{
					using (ManagementObjectCollection objectCollection = managementObjectSearcher.Get())
					{
						try
						{
							foreach (ManagementBaseObject managementBaseObject in objectCollection)
							{
								ManagementObject current = (ManagementObject)managementBaseObject;
								using (current)
								{
									int num = wmiData.Length - 1;
									for (int index = 1; index <= num; index++)
									{
										stringBuilder.Append(RuntimeHelpers.GetObjectValue(current[wmiData[index]]));
									}
								}
							}
						}
						finally
						{
							ManagementObjectCollection.ManagementObjectEnumerator enumerator = null;
						}
					}
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003450 File Offset: 0x00001650
		private string GenerateQuery(string[] wmiData)
		{
			StringBuilder stringBuilder = new StringBuilder();
			string empty = string.Empty;
			stringBuilder.Append("SELECT ");
			checked
			{
				int num = wmiData.Length - 1;
				for (int index = 0; index <= num; index++)
				{
					if (index == 0)
					{
						empty = wmiData[index];
					}
					else
					{
						stringBuilder.Append((index < wmiData.Length - 1) ? string.Format("{0}, ", wmiData[index]) : string.Format("{0} ", wmiData[index]));
					}
				}
				stringBuilder.Append(string.Format("FROM {0}", empty));
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000034D4 File Offset: 0x000016D4
		private string GetHash(string data)
		{
			string hexString;
			using (SHA1CryptoServiceProvider cryptoServiceProvider = new SHA1CryptoServiceProvider())
			{
				hexString = this.GetHexString(cryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(data)));
			}
			return hexString;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000351C File Offset: 0x0000171C
		private string GetHexString(byte[] bt)
		{
			StringBuilder stringBuilder = new StringBuilder();
			checked
			{
				int num = bt.Count<byte>() - 1;
				for (int index = 0; index <= num; index++)
				{
					byte b = bt[index];
					int num2 = (int)(b & 15);
					int num3 = (int)(unchecked((byte)((uint)b >> 4)) & 15);
					if (num3 > 9)
					{
						StringBuilder stringBuilder2 = stringBuilder;
						string str = Strings.ChrW(num3 - 10 + 65).ToString(CultureInfo.InvariantCulture);
						stringBuilder2.Append(str);
					}
					else
					{
						stringBuilder.Append(num3.ToString(CultureInfo.InvariantCulture));
					}
					if (num2 > 9)
					{
						StringBuilder stringBuilder3 = stringBuilder;
						string str2 = Strings.ChrW(num2 - 10 + 65).ToString(CultureInfo.InvariantCulture);
						stringBuilder3.Append(str2);
					}
					else
					{
						stringBuilder.Append(num2.ToString(CultureInfo.InvariantCulture));
					}
					if (index + 1 != bt.Count<byte>() && (index + 1) % 2 == 0)
					{
						stringBuilder.Append("-");
					}
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000035FE File Offset: 0x000017FE
		public string getMotherboard()
		{
			return this.GetProperties(GxHardware.WMI_CLASSES.MOTHERBOARD);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000360B File Offset: 0x0000180B
		public string getBIOS()
		{
			return this.GetProperties(GxHardware.WMI_CLASSES.BIOS);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003618 File Offset: 0x00001818
		public string getCPU()
		{
			return this.GetProperties(GxHardware.WMI_CLASSES.CPU);
		}

		// Token: 0x02000024 RID: 36
		protected class WMI_CLASSES
		{
			// Token: 0x04000220 RID: 544
			public static readonly string[] MOTHERBOARD = new string[]
			{
				"Win32_BaseBoard",
				"Name",
				"Manufacturer",
				"Version"
			};

			// Token: 0x04000221 RID: 545
			public static readonly string[] GPU = new string[]
			{
				"Win32_VideoController",
				"Name",
				"DeviceID",
				"DriverVersion"
			};

			// Token: 0x04000222 RID: 546
			public static readonly string[] CDROM = new string[]
			{
				"Win32_CDROMDrive",
				"Name",
				"Manufacturer",
				"DeviceID"
			};

			// Token: 0x04000223 RID: 547
			public static readonly string[] CPU = new string[]
			{
				"Win32_Processor",
				"Name",
				"Manufacturer",
				"ProcessorId"
			};

			// Token: 0x04000224 RID: 548
			public static readonly string[] HDD = new string[]
			{
				"Win32_DiskDrive",
				"Name",
				"Manufacturer",
				"Model"
			};

			// Token: 0x04000225 RID: 549
			public static readonly string[] BIOS = new string[]
			{
				"Win32_BIOS",
				"Name",
				"Manufacturer",
				"Version"
			};
		}
	}
}
