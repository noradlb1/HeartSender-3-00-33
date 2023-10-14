using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Zoople;

namespace HeartSender
{
	// Token: 0x02000011 RID: 17
	public partial class MakeAttachment : Form
	{
		// Token: 0x06000075 RID: 117 RVA: 0x00007BBC File Offset: 0x00005DBC
		public MakeAttachment(Main _main)
		{
			this.InitializeComponent();
			this.main = _main;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00007BD4 File Offset: 0x00005DD4
		public string getTag(string tags)
		{
			uint num = <PrivateImplementationDetails>.ComputeStringHash(tags);
			if (num <= 2178810002U)
			{
				if (num <= 954982755U)
				{
					if (num <= 798629776U)
					{
						if (num <= 380769896U)
						{
							if (num <= 142096228U)
							{
								if (num != 9815237U)
								{
									if (num == 142096228U)
									{
										if (tags == "SHOW Minutes IN LETTER")
										{
											return "[-Minutes-]";
										}
									}
								}
								else if (tags == "SHOW email Links")
								{
									return "[-EMAIL_LINK-]";
								}
							}
							else if (num != 208221322U)
							{
								if (num == 380769896U)
								{
									if (tags == "SHOW RANDOM COUNTRIES IN LETTER")
									{
										return "[-RANDOM_COUNTRY-]";
									}
								}
							}
							else if (tags == "SHOW RANDOM FAKE BUSINESS EMAIL")
							{
								return "[-BUSINESS_EMAIL-]";
							}
						}
						else if (num <= 477180410U)
						{
							if (num != 425682520U)
							{
								if (num == 477180410U)
								{
									if (tags == "SHOW HOURS IN LETTER")
									{
										return "[-Hours-]";
									}
								}
							}
							else if (tags == "SHOW RANDOM COMPANY ADDRESS")
							{
								return "[-COMPANY_ADDRESS-]";
							}
						}
						else if (num != 599410144U)
						{
							if (num != 682463588U)
							{
								if (num == 798629776U)
								{
									if (tags == "Random character 3")
									{
										return "[-CHAR3-]";
									}
								}
							}
							else if (tags == "ANDROID BROWSER NAMES")
							{
								return "[-ANDROID_BROWSER-]";
							}
						}
						else if (tags == "SHOW SMTP DOMAIN")
						{
							return "[-SMTPDOMAIN-]";
						}
					}
					else if (num <= 882517871U)
					{
						if (num <= 832185014U)
						{
							if (num != 815407395U)
							{
								if (num == 832185014U)
								{
									if (tags == "Random character 1")
									{
										return "[-CHAR1-]";
									}
								}
							}
							else if (tags == "Random character 2")
							{
								return "[-CHAR2-]";
							}
						}
						else if (num != 865740252U)
						{
							if (num == 882517871U)
							{
								if (tags == "Random character 6")
								{
									return "[-CHAR6-]";
								}
							}
						}
						else if (tags == "Random character 7")
						{
							return "[-CHAR7-]";
						}
					}
					else if (num <= 916073109U)
					{
						if (num != 899295490U)
						{
							if (num == 916073109U)
							{
								if (tags == "Random character 4")
								{
									return "[-CHAR4-]";
								}
							}
						}
						else if (tags == "Random character 5")
						{
							return "[-CHAR5-]";
						}
					}
					else if (num != 921251648U)
					{
						if (num != 935620465U)
						{
							if (num == 954982755U)
							{
								if (tags == "SHOW RANDOM FAKE VIN_NUMBER")
								{
									return "[-VIN_NUMBER-]";
								}
							}
						}
						else if (tags == "SHOW LONG TIME IN LETTER ( MINS , SECOND , HOURS )")
						{
							return "[-LongTime-]";
						}
					}
					else if (tags == "Show SMTP DOMAIN")
					{
						return "[-DOMAINSENDER-]";
					}
				}
				else if (num <= 1697680983U)
				{
					if (num <= 1245972048U)
					{
						if (num <= 983183585U)
						{
							if (num != 966405966U)
							{
								if (num == 983183585U)
								{
									if (tags == "Random character 8")
									{
										return "[-CHAR8-]";
									}
								}
							}
							else if (tags == "Random character 9")
							{
								return "[-CHAR9-]";
							}
						}
						else if (num != 1158682790U)
						{
							if (num == 1245972048U)
							{
								if (tags == "Random characters and numbers with 32 characters length")
								{
									return "[-RNDHEX-]";
								}
							}
						}
						else if (tags == "SHOW SHORT DATE IN LETTER ( MONTH )")
						{
							return "[-ShortDate-]";
						}
					}
					else if (num <= 1534479279U)
					{
						if (num != 1323977229U)
						{
							if (num == 1534479279U)
							{
								if (tags == "Random character ( Change 10 to any digit to 99 for more letters )")
								{
									return "[-random_letter_10-]";
								}
							}
						}
						else if (tags == "APPLE APPS NAMES")
						{
							return "[-APPLE_APPS-]";
						}
					}
					else if (num != 1616367583U)
					{
						if (num != 1654922709U)
						{
							if (num == 1697680983U)
							{
								if (tags == "SHOW SMTP USER")
								{
									return "[-SMTPUSER-]";
								}
							}
						}
						else if (tags == "SHOW SECOND IN LETTER")
						{
							return "[-Seconds-]";
						}
					}
					else if (tags == "APPLE PHONE NAMES")
					{
						return "[-APPLE_PHONE-]";
					}
				}
				else if (num <= 1827782049U)
				{
					if (num <= 1771029214U)
					{
						if (num != 1760852080U)
						{
							if (num == 1771029214U)
							{
								if (tags == "SHOW RANDOM FAKE CREDIT CARDS")
								{
									return "[-FAKE_CARD-]";
								}
							}
						}
						else if (tags == "SHOW DATE")
						{
							return "[-DATE-]";
						}
					}
					else if (num != 1791837371U)
					{
						if (num == 1827782049U)
						{
							if (tags == "SHOW RANDOM FAKE EMAILS ADDRESS")
							{
								return "[-FAKE_MAIL-]";
							}
						}
					}
					else if (tags == "APPLE DEVICE NAMES")
					{
						return "[-APPLE_MACBOOK-]";
					}
				}
				else if (num <= 1978089014U)
				{
					if (num != 1966868728U)
					{
						if (num == 1978089014U)
						{
							if (tags == "RANDOME IP")
							{
								return "[-IP-]";
							}
						}
					}
					else if (tags == "RECEIVER EMAIL")
					{
						return "[-EMAIL-]";
					}
				}
				else if (num != 2095558975U)
				{
					if (num != 2161790371U)
					{
						if (num == 2178810002U)
						{
							if (tags == "Current date with Japanese format yyyy mm dd H:mm:ss")
							{
								return "[-DATEJP-]";
							}
						}
					}
					else if (tags == "SHOW RANDOM CITY IN LETTER")
					{
						return "[-City-]";
					}
				}
				else if (tags == "SHOW DATE & TIME")
				{
					return "[-DATETIME-]";
				}
			}
			else if (num <= 3143582274U)
			{
				if (num <= 2607253235U)
				{
					if (num <= 2312175186U)
					{
						if (num <= 2289759917U)
						{
							if (num != 2264641669U)
							{
								if (num == 2289759917U)
								{
									if (tags == "show random letternumber 10")
									{
										return "[-random_letternumber_10-]";
									}
								}
							}
							else if (tags == "SHOW RANDOM FAKE JOB TITLE")
							{
								return "[-JOB_TITLE-]";
							}
						}
						else if (num != 2291494120U)
						{
							if (num == 2312175186U)
							{
								if (tags == "Random number ( Change 10 to any digit to 99 for more numbers )")
								{
									return "[-random_number_10-]";
								}
							}
						}
						else if (tags == "Random number 10")
						{
							return "[-NUMBER10-]";
						}
					}
					else if (num <= 2525556958U)
					{
						if (num != 2407019101U)
						{
							if (num == 2525556958U)
							{
								if (tags == "RANDOM EMAIL ADDRESS SHOW IN LETTER")
								{
									return "[-random_email-]";
								}
							}
						}
						else if (tags == "SHOW RANDOM COMPANY IN LETTER")
						{
							return "[-Company-]";
						}
					}
					else if (num != 2580614739U)
					{
						if (num != 2582359869U)
						{
							if (num == 2607253235U)
							{
								if (tags == "show random letternumberlow 10")
								{
									return "[-random_letternumberlow_10-]";
								}
							}
						}
						else if (tags == "show random letterupp 10")
						{
							return "[-random_letterupp_10-]";
						}
					}
					else if (tags == "SHOW RANDOM FAKE INSTITUTE")
					{
						return "[-INSTITUTE-]";
					}
				}
				else if (num <= 2759757832U)
				{
					if (num <= 2652877070U)
					{
						if (num != 2611239154U)
						{
							if (num == 2652877070U)
							{
								if (tags == "SHOW RECEIVER EMAIL NAME ( LIKE ITS GRAB FIRST NAME BEFORE @ )")
								{
									return "[-UNAME-]";
								}
							}
						}
						else if (tags == "Random character 10")
						{
							return "[-CHAR10-]";
						}
					}
					else if (num != 2750626256U)
					{
						if (num == 2759757832U)
						{
							if (tags == "SHOW DOMAIN NAME ( AFTER @ LIKE GMAIL.COM ETC )")
							{
								return "[-UDOMAIN-]";
							}
						}
					}
					else if (tags == "SHOW EMAIL ADDRESS IN BASE64 ( MOST USE FULL TAG )")
					{
						return "[-EMAILB64-]";
					}
				}
				else if (num <= 2952207237U)
				{
					if (num != 2817830811U)
					{
						if (num == 2952207237U)
						{
							if (tags == "THIS TAG USE FOR RANDOM ROTATES LINKS")
							{
								return "[-LINK-]";
							}
						}
					}
					else if (tags == "SHOW return Random characters")
					{
						return "[-RND-]";
					}
				}
				else if (num != 3071100530U)
				{
					if (num != 3092694639U)
					{
						if (num == 3143582274U)
						{
							if (tags == "SHOW RANDOM FAKE PHONE NUMBERS")
							{
								return "[-FAKE_PHONE-]";
							}
						}
					}
					else if (tags == "SHOW RANDOM number & character MIX")
					{
						return "[-RANDOM-]";
					}
				}
				else if (tags == "show random  letternumberupp 10")
				{
					return "[-random_letternumberupp_10-]";
				}
			}
			else if (num <= 3418789121U)
			{
				if (num <= 3251012931U)
				{
					if (num <= 3155645179U)
					{
						if (num != 3152179189U)
						{
							if (num == 3155645179U)
							{
								if (tags == "SHOW LONG DATE IN LETTER ( DAY , YEAR , MONTH )")
								{
									return "[-LongDate-]";
								}
							}
						}
						else if (tags == "SHOW SENDER EMAIL")
						{
							return "[-Sender_Email-]";
						}
					}
					else if (num != 3234235312U)
					{
						if (num == 3251012931U)
						{
							if (tags == "Random number 8")
							{
								return "[-NUMBER8-]";
							}
						}
					}
					else if (tags == "Random number 9")
					{
						return "[-NUMBER9-]";
					}
				}
				else if (num <= 3368456264U)
				{
					if (num != 3341798916U)
					{
						if (num == 3368456264U)
						{
							if (tags == "Random number 1")
							{
								return "[-NUMBER1-]";
							}
						}
					}
					else if (tags == "SHOW TIME IN LETTER")
					{
						return "[-TIME-]";
					}
				}
				else if (num != 3402011502U)
				{
					if (num != 3416950758U)
					{
						if (num == 3418789121U)
						{
							if (tags == "Random number 2")
							{
								return "[-NUMBER2-]";
							}
						}
					}
					else if (tags == "ANDROID DEVICE NAMES")
					{
						return "[-ANDROID_OS-]";
					}
				}
				else if (tags == "Random number 3")
				{
					return "[-NUMBER3-]";
				}
			}
			else if (num <= 3469121978U)
			{
				if (num <= 3435566740U)
				{
					if (num != 3433372152U)
					{
						if (num == 3435566740U)
						{
							if (tags == "Random number 5")
							{
								return "[-NUMBER5-]";
							}
						}
					}
					else if (tags == "show random letter low 10")
					{
						return "[-random_letterlow_10-]";
					}
				}
				else if (num != 3452344359U)
				{
					if (num == 3469121978U)
					{
						if (tags == "Random number 7")
						{
							return "[-NUMBER7-]";
						}
					}
				}
				else if (tags == "Random number 4")
				{
					return "[-NUMBER4-]";
				}
			}
			else if (num <= 3669144448U)
			{
				if (num != 3485899597U)
				{
					if (num == 3669144448U)
					{
						if (tags == "SHOW RANDOM FAKE ADDRESS")
						{
							return "[-FAKE_ADDRESS-]";
						}
					}
				}
				else if (tags == "Random number 6")
				{
					return "[-NUMBER6-]";
				}
			}
			else if (num != 3711958188U)
			{
				if (num != 3748317239U)
				{
					if (num == 3863334000U)
					{
						if (tags == "SHOW RANDOM FAKE NAMES")
						{
							return "[-FAKE_NAME-]";
						}
					}
				}
				else if (tags == "SHOW Main Domain")
				{
					return "[-ROOTDOMAIN-]";
				}
			}
			else if (tags == "SHOW RANDOM FAKE DATE OF BIRTH")
			{
				return "[-FAKE_DOB-]";
			}
			return "0";
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000884C File Offset: 0x00006A4C
		private void cbTags_SelectedIndexChanged(object sender, EventArgs e)
		{
			string rs = this.getTag(this.cbTags.SelectedItem.ToString());
			this.ctrlHTMLEditor.InsertAtCursor(rs, HTMLEditControl.ed_InsertType.ed_InsertAfterSelection);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000887D File Offset: 0x00006A7D
		private void Attachment_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000887F File Offset: 0x00006A7F
		private void ctrlHTMLEditor_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00008884 File Offset: 0x00006A84
		private void btnImport_Click(object sender, EventArgs e)
		{
			OpenFileDialog file = new OpenFileDialog();
			file.Filter = "All files (*.*)|*.*";
			if (file.ShowDialog() == DialogResult.OK)
			{
				this.main.settings[23] = file.FileName;
				this.getAttachmentTags();
				MessageBox.Show("Attachment selected");
				base.Close();
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000088D8 File Offset: 0x00006AD8
		public void getAttachmentTags()
		{
			FileStream fs = new FileStream(this.main.settings[23], FileMode.Open, FileAccess.Read, FileShare.Read);
			string content = string.Empty;
			new FileInfo(this.main.settings[23]);
			string[] array = new string[]
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
				Match i = new Regex("(\\#\\#.*?\\#\\#)").Match(content);
				List<string> matches = new List<string>();
				while (i.Success)
				{
					matches.Add(i.Value);
					i = i.NextMatch();
				}
				i = new Regex("(\\[\\-.*?\\-\\])").Match(content);
				while (i.Success)
				{
					matches.Add(i.Value);
					i = i.NextMatch();
				}
				matches = matches.Distinct<string>().ToList<string>();
				Main.attachment_tags = string.Join("|||", matches);
				Main.attachment_tags = Main.attachment_tags.Replace("##AUTOEMAILAE##", "##NEW_AUTOEMAILAE##");
				Main.attachment_tags = Main.attachment_tags.Replace("##EMAIL_LINK##", "##NEW_EMAIL_LINK##");
				Main.attachment_tags = Main.attachment_tags.Replace("##EMAILB64##", "##NEW_EMAILB64##");
				Main.attachment_tags = Main.attachment_tags.Replace("##EMAIL##", "##NEW_EMAIL##");
				Main.attachment_tags = Main.attachment_tags.Replace("[-AUTOEMAILAE-]", "[-NEW_AUTOEMAILAE-]");
				Main.attachment_tags = Main.attachment_tags.Replace("[-EMAIL_LINK-]", "[-NEW_EMAIL_LINK-]");
				Main.attachment_tags = Main.attachment_tags.Replace("[-EMAILB64-]", "[-NEW_EMAILB64-]");
				Main.attachment_tags = Main.attachment_tags.Replace("[-EMAIL-]", "[-NEW_EMAIL-]");
				Main.attachment_tags = Main.attachment_tags.Replace("[-firstname-]", "[-FIRSTNAME-]");
				Main.attachment_tags = Main.attachment_tags.Replace("[-lastname-]", "[-LASTNAME-]");
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00008B08 File Offset: 0x00006D08
		private void button1_Click(object sender, EventArgs e)
		{
			this.saveFileDialog1.Filter = "Html|*.html";
			this.saveFileDialog1.Title = "Save Your Letter";
			this.saveFileDialog1.ShowDialog();
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00008B38 File Offset: 0x00006D38
		private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
			File.WriteAllText(this.saveFileDialog1.FileName, this.ctrlHTMLEditor.DocumentHTML.Replace("\n", Environment.NewLine));
			this.main.settings[23] = this.saveFileDialog1.FileName;
			this.getAttachmentTags();
			MessageBox.Show("Your Letter Save Successfully");
			base.Close();
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00008B9F File Offset: 0x00006D9F
		private void label11_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000097 RID: 151
		private Main main;
	}
}
