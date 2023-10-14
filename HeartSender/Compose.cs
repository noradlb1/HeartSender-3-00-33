using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CommonSender;

namespace HeartSender
{
	// Token: 0x02000013 RID: 19
	public partial class Compose : Form
	{
		// Token: 0x0600008E RID: 142 RVA: 0x0000A967 File Offset: 0x00008B67
		public Compose(Main _main)
		{
			this.main = _main;
			this.InitializeComponent();
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000A994 File Offset: 0x00008B94
		private void btnDone_Click(object sender, EventArgs e)
		{
			GxLetter newLetter = new GxLetter();
			if (!(this.tbLetterName.Text != "") || !(this.txtMessage.Text != "") || !(this.txtFromEmail.Text != "") || !(this.txtFromName.Text != "") || !(this.txtSubject.Text != ""))
			{
				MessageBox.Show("Please Fill All Required Field.", "Heart Sender", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			if (Main.selected_letter_index != "")
			{
				string letter;
				if (this.isHtml.Checked)
				{
					letter = this.txtMessage.Text;
					letter = letter.Replace("\n", "<br>");
				}
				else
				{
					letter = this.txtMessage.Text;
				}
				Main.letters[int.Parse(Main.selected_letter_index)].letter = letter;
				if (this.attachment_path != "")
				{
					Main.letters[int.Parse(Main.selected_letter_index)].attachment = this.attachment_path;
					Main.letters[int.Parse(Main.selected_letter_index)].attachment_tags = this.attachment_tags;
				}
				else
				{
					Main.letters[int.Parse(Main.selected_letter_index)].attachment = Main.letters[int.Parse(Main.selected_letter_index)].attachment;
					Main.letters[int.Parse(Main.selected_letter_index)].attachment_tags = Main.letters[int.Parse(Main.selected_letter_index)].attachment_tags;
				}
				Main.letters[int.Parse(Main.selected_letter_index)].is_enable = false;
				Main.letters[int.Parse(Main.selected_letter_index)].is_html = true;
				Main.letters[int.Parse(Main.selected_letter_index)].fromemail = this.txtFromEmail.Lines;
				Main.letters[int.Parse(Main.selected_letter_index)].fromname = this.txtFromName.Text;
				Main.letters[int.Parse(Main.selected_letter_index)].subject = this.txtSubject.Text;
				this.tbLetterName.Text = "";
				this.txtMessage.Text = "";
				this.txtSubject.Text = "";
				this.txtFromName.Text = "";
				this.txtFromEmail.Text = "";
				MessageBox.Show("Letter Update !", "Heart Sender", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				this.main.gridLetter.Rows.Clear();
				int counter = 0;
				for (int i = 0; i < Main.letters.Count; i++)
				{
					int indx = this.main.gridLetter.Rows.Add();
					this.main.gridLetter.Rows[indx].Cells[5].Value = Main.letters[i].is_enable;
					for (int j = 0; j < Main.letters[i].fromemail.Length; j++)
					{
						if (counter == Main.letters[i].fromemail.Length - 1)
						{
							DataGridViewCell dataGridViewCell = this.main.gridLetter.Rows[indx].Cells[1];
							object value = dataGridViewCell.Value;
							dataGridViewCell.Value = ((value != null) ? value.ToString() : null) + Main.letters[i].fromemail[j];
						}
						else
						{
							DataGridViewCell dataGridViewCell2 = this.main.gridLetter.Rows[indx].Cells[1];
							object value2 = dataGridViewCell2.Value;
							dataGridViewCell2.Value = ((value2 != null) ? value2.ToString() : null) + Main.letters[i].fromemail[j] + "|";
						}
						counter++;
					}
					this.main.gridLetter.Rows[indx].Cells[0].Value = Main.letters[i].fromname;
					this.main.gridLetter.Rows[indx].Cells[2].Value = Main.letters[i].subject;
					this.main.gridLetter.Rows[indx].Cells[3].Value = Main.letters[i].name;
					this.main.gridLetter.Rows[indx].Cells[4].Value = Main.letters[i].attachment;
				}
				this.main.gridLetter.ClearSelection();
				base.Close();
				return;
			}
			string letter2;
			if (this.isHtml.Checked)
			{
				letter2 = this.txtMessage.Text;
				letter2 = letter2.Replace("\n", "<br>");
			}
			else
			{
				letter2 = this.txtMessage.Text;
			}
			newLetter.letter = letter2;
			newLetter.attachment = this.attachment_path;
			newLetter.is_enable = false;
			newLetter.is_html = true;
			newLetter.attachment_tags = this.attachment_tags;
			newLetter.name = this.tbLetterName.Text;
			newLetter.fromemail = this.txtFromEmail.Lines;
			newLetter.fromname = this.txtFromName.Text;
			newLetter.subject = this.txtSubject.Text;
			this.tbLetterName.Text = "";
			this.txtMessage.Text = "";
			this.txtSubject.Text = "";
			this.txtFromName.Text = "";
			this.txtFromEmail.Text = "";
			Main.letters.Add(newLetter);
			MessageBox.Show("Letter Saved!", "Heart Sender", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			this.main.gridLetter.Rows.Clear();
			int counter2 = 0;
			for (int k = 0; k < Main.letters.Count; k++)
			{
				int indx2 = this.main.gridLetter.Rows.Add();
				this.main.gridLetter.Rows[indx2].Cells[5].Value = Main.letters[k].is_enable;
				for (int l = 0; l < Main.letters[k].fromemail.Length; l++)
				{
					if (counter2 == Main.letters[k].fromemail.Length - 1)
					{
						DataGridViewCell dataGridViewCell3 = this.main.gridLetter.Rows[indx2].Cells[1];
						object value3 = dataGridViewCell3.Value;
						dataGridViewCell3.Value = ((value3 != null) ? value3.ToString() : null) + Main.letters[k].fromemail[l];
					}
					else
					{
						DataGridViewCell dataGridViewCell4 = this.main.gridLetter.Rows[indx2].Cells[1];
						object value4 = dataGridViewCell4.Value;
						dataGridViewCell4.Value = ((value4 != null) ? value4.ToString() : null) + Main.letters[k].fromemail[l] + "|";
					}
					counter2++;
				}
				this.main.gridLetter.Rows[indx2].Cells[0].Value = Main.letters[k].fromname;
				this.main.gridLetter.Rows[indx2].Cells[2].Value = Main.letters[k].subject;
				this.main.gridLetter.Rows[indx2].Cells[3].Value = Main.letters[k].name;
				this.main.gridLetter.Rows[indx2].Cells[4].Value = Main.letters[k].attachment;
			}
			this.main.gridLetter.ClearSelection();
			base.Close();
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000B25C File Offset: 0x0000945C
		private void btnSpam_Click(object sender, EventArgs e)
		{
			if (!(this.txtMessage.Text != ""))
			{
				MessageBox.Show("Please add a message.", "Heart Sender", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			List<string> spams = new List<string>();
			foreach (string words in Main.spamwords)
			{
				if (this.txtMessage.Text.ToLower().Contains(words.ToLower()))
				{
					spams.Add(words);
				}
			}
			if (spams.Count > 0)
			{
				MessageBox.Show("There are " + spams.Count.ToString() + " words found in your letter which can effect delivery in inbox.\n\r\n\rWords: " + string.Join(", ", spams), "Heart Sender", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			MessageBox.Show("Your letter looks safe!", "Heart Sender", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000B354 File Offset: 0x00009554
		private void btnClear_Click(object sender, EventArgs e)
		{
			this.txtMessage.Text = "";
			this.attachment_path = "";
			this.tbLetterName.Text = "";
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000B384 File Offset: 0x00009584
		private void btnAttachment_Click(object sender, EventArgs e)
		{
			string empty = string.Empty;
			string filePath = string.Empty;
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.InitialDirectory = "c:\\";
				openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
				openFileDialog.FilterIndex = 2;
				openFileDialog.RestoreDirectory = true;
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					filePath = openFileDialog.FileName;
					this.attachment_path = filePath;
					this.getAttachmentTags(filePath);
					MessageBox.Show("Attachment selected", "Heart Sender", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000B414 File Offset: 0x00009614
		public void getAttachmentTags(string path)
		{
			if (path != "")
			{
				FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
				string content = string.Empty;
				new FileInfo(path);
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
					matches = matches.Distinct<string>().ToList<string>();
					Main.attachment_tags = string.Join("|||", matches);
				}
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000B504 File Offset: 0x00009704
		private void cbTags_SelectedIndexChanged(object sender, EventArgs e)
		{
			string rs = this.getTag(this.cbTags.SelectedItem.ToString());
			this.txtMessage.SelectedText = rs;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000B534 File Offset: 0x00009734
		public string getTag(string tags)
		{
			uint num = <PrivateImplementationDetails>.ComputeStringHash(tags);
			if (num <= 1856994934U)
			{
				if (num <= 927549595U)
				{
					if (num <= 528594361U)
					{
						if (num <= 138316714U)
						{
							if (num != 70888982U)
							{
								if (num != 84369102U)
								{
									if (num == 138316714U)
									{
										if (tags == "Random 5 Character")
										{
											return "[-CHAR5-]";
										}
									}
								}
								else if (tags == "Random 1 Number")
								{
									return "[-NUMBER1-]";
								}
							}
							else if (tags == "Random 9 Number")
							{
								return "[-NUMBER9-]";
							}
						}
						else if (num != 220110469U)
						{
							if (num != 352883625U)
							{
								if (num == 528594361U)
								{
									if (tags == "Random Text And Number")
									{
										return "[-RANDOM-]";
									}
								}
							}
							else if (tags == "Generate random email like : res*****@yahoo.com")
							{
								return "[-random_email-]";
							}
						}
						else if (tags == "Random Android Browser")
						{
							return "[-ANDROID_BROWSER-]";
						}
					}
					else if (num <= 687302710U)
					{
						if (num != 572342798U)
						{
							if (num != 671425049U)
							{
								if (num == 687302710U)
								{
									if (tags == "Random 1 Character")
									{
										return "[-CHAR1-]";
									}
								}
							}
							else if (tags == "Get ShortDate")
							{
								return "[-ShortDate-]";
							}
						}
						else if (tags == "Random Apple Macbook Device")
						{
							return "[-APPLE_MACBOOK-]";
						}
					}
					else if (num <= 727937444U)
					{
						if (num != 721651727U)
						{
							if (num == 727937444U)
							{
								if (tags == "Random Apple Phone Device")
								{
									return "[-APPLE_PHONE-]";
								}
							}
						}
						else if (tags == "Random 4 Number")
						{
							return "[-NUMBER4-]";
						}
					}
					else if (num != 737017495U)
					{
						if (num == 927549595U)
						{
							if (tags == "Random 2 Character")
							{
								return "[-CHAR2-]";
							}
						}
					}
					else if (tags == "Random Links")
					{
						return "[-LINK-]";
					}
				}
				else if (num <= 1487337871U)
				{
					if (num <= 1200076072U)
					{
						if (num != 969122775U)
						{
							if (num != 1171454981U)
							{
								if (num == 1200076072U)
								{
									if (tags == "Random 3 Character")
									{
										return "[-CHAR3-]";
									}
								}
							}
							else if (tags == "Random 2 Number")
							{
								return "[-NUMBER2-]";
							}
						}
						else if (tags == "Generate 10 random number and letter lowercase")
						{
							return "[-random_letternumberupp_10-]";
						}
					}
					else if (num <= 1298132702U)
					{
						if (num != 1257357016U)
						{
							if (num == 1298132702U)
							{
								if (tags == "Random 9 Character")
								{
									return "[-CHAR9-]";
								}
							}
						}
						else if (tags == "Random 10 Character")
						{
							return "[-CHAR10-]";
						}
					}
					else if (num != 1392698177U)
					{
						if (num == 1487337871U)
						{
							if (tags == "Random 6 Character")
							{
								return "[-CHAR6-]";
							}
						}
					}
					else if (tags == "Random 6 Number")
					{
						return "[-NUMBER6-]";
					}
				}
				else if (num <= 1608134759U)
				{
					if (num != 1499851973U)
					{
						if (num != 1601880176U)
						{
							if (num == 1608134759U)
							{
								if (tags == "Generate 10 random letter lowercase")
								{
									return "[-random_letterlow_10-]";
								}
							}
						}
						else if (tags == "Generate 10 random number and letter mix uppercase or lowercase")
						{
							return "[-random_letternumber_10-]";
						}
					}
					else if (tags == "Get A Fake Address")
					{
						return "[-FAKE_ADDRESS-]";
					}
				}
				else if (num <= 1832458871U)
				{
					if (num != 1827730522U)
					{
						if (num == 1832458871U)
						{
							if (tags == "Random IP")
							{
								return "[-IP-]";
							}
						}
					}
					else if (tags == "Get Seconds")
					{
						return "[-Seconds-]";
					}
				}
				else if (num != 1836224267U)
				{
					if (num == 1856994934U)
					{
						if (tags == "Random Apple Phone Apps")
						{
							return "[-APPLE_APPS-]";
						}
					}
				}
				else if (tags == "Generate random country")
				{
					return "[-random_country[-";
				}
			}
			else if (num <= 2879972057U)
			{
				if (num <= 2402423998U)
				{
					if (num <= 2120000260U)
					{
						if (num != 1921189494U)
						{
							if (num != 2002527739U)
							{
								if (num == 2120000260U)
								{
									if (tags == "Get Hours")
									{
										return "[-Hours-]";
									}
								}
							}
							else if (tags == "Random 8 Number")
							{
								return "[-NUMBER8-]";
							}
						}
						else if (tags == "Generate 10 random letter UPPERCASE")
						{
							return "[-random_letterupp_10-]";
						}
					}
					else if (num <= 2257345696U)
					{
						if (num != 2252477129U)
						{
							if (num == 2257345696U)
							{
								if (tags == "Generate 10 random letter mix UPPERCASE or lowercase")
								{
									return "[-random_letter_10-]";
								}
							}
						}
						else if (tags == "Get Date")
						{
							return "[-DATE-]";
						}
					}
					else if (num != 2335241892U)
					{
						if (num == 2402423998U)
						{
							if (tags == "Get Minutes")
							{
								return "[-Minutes-]";
							}
						}
					}
					else if (tags == "Random COMPANY Name")
					{
						return "[-Company-]";
					}
				}
				else if (num <= 2578218975U)
				{
					if (num != 2468026842U)
					{
						if (num != 2530673958U)
						{
							if (num == 2578218975U)
							{
								if (tags == "Get Domain From Email")
								{
									return "[-UDOMAIN-]";
								}
							}
						}
						else if (tags == "Generate 10 random number and letter UPPERCASE")
						{
							return "[-random_letternumberlow_10-]";
						}
					}
					else if (tags == "Get LongTime")
					{
						return "[-LongTime-]";
					}
				}
				else if (num <= 2689035828U)
				{
					if (num != 2687262073U)
					{
						if (num == 2689035828U)
						{
							if (tags == "Get TIME")
							{
								return "[-TIME-]";
							}
						}
					}
					else if (tags == "Random 8 Character")
					{
						return "[-CHAR8-]";
					}
				}
				else if (num != 2691232500U)
				{
					if (num == 2879972057U)
					{
						if (tags == "Random Android OS")
						{
							return "[-ANDROID_OS-]";
						}
					}
				}
				else if (tags == "Get A Fake Name")
				{
					return "[-FAKE_NAME-]";
				}
			}
			else if (num <= 3708054824U)
			{
				if (num <= 3349237708U)
				{
					if (num != 3079500599U)
					{
						if (num != 3342834058U)
						{
							if (num == 3349237708U)
							{
								if (tags == "Random 7 Character")
								{
									return "[-CHAR7-]";
								}
							}
						}
						else if (tags == "Random 5 Number")
						{
							return "[-NUMBER5-]";
						}
					}
					else if (tags == "Get LongDate")
					{
						return "[-LongDate-]";
					}
				}
				else if (num <= 3548513208U)
				{
					if (num != 3517014213U)
					{
						if (num == 3548513208U)
						{
							if (tags == "Get Email Target")
							{
								return "[-EMAIL-]";
							}
						}
					}
					else if (tags == "Email in base64")
					{
						return "[-EMAILB64-]";
					}
				}
				else if (num != 3684117060U)
				{
					if (num == 3708054824U)
					{
						if (tags == "Random 10 Number")
						{
							return "[-NUMBER10-]";
						}
					}
				}
				else if (tags == "Random 7 Number")
				{
					return "[-NUMBER7-]";
				}
			}
			else if (num <= 4034752144U)
			{
				if (num != 3749664423U)
				{
					if (num != 3888636418U)
					{
						if (num == 4034752144U)
						{
							if (tags == "Get A Fake Mail")
							{
								return "[-FAKE_MAIL-]";
							}
						}
					}
					else if (tags == "Get A Fake Card Number")
					{
						return "[-FAKE_CARD-]";
					}
				}
				else if (tags == "Get Username From Email")
				{
					return "[-UNAME-]";
				}
			}
			else if (num <= 4094119920U)
			{
				if (num != 4066831544U)
				{
					if (num == 4094119920U)
					{
						if (tags == "Get A Fake DOB")
						{
							return "[-FAKE_DOB-]";
						}
					}
				}
				else if (tags == "Random 3 Number")
				{
					return "[-NUMBER3-]";
				}
			}
			else if (num != 4169526901U)
			{
				if (num == 4256803182U)
				{
					if (tags == "Get A Fake Phone Number")
					{
						return "[-FAKE_PHONE-]";
					}
				}
			}
			else if (tags == "Random 4 Character")
			{
				return "[-CHAR4-]";
			}
			return "0";
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000BEA4 File Offset: 0x0000A0A4
		private void Compose_Load(object sender, EventArgs e)
		{
			if (Main.selected_letter_index.Length > 0)
			{
				this.tbLetterName.Text = Main.letters[int.Parse(Main.selected_letter_index)].name;
				this.txtFromEmail.Lines = Main.letters[int.Parse(Main.selected_letter_index)].fromemail;
				this.txtFromName.Text = Main.letters[int.Parse(Main.selected_letter_index)].fromname.ToString();
				this.txtSubject.Text = Main.letters[int.Parse(Main.selected_letter_index)].subject.ToString();
				this.txtMessage.Text = Main.letters[int.Parse(Main.selected_letter_index)].letter.ToString();
			}
		}

		// Token: 0x040000AD RID: 173
		private Main main;

		// Token: 0x040000AE RID: 174
		public string attachment_tags = "";

		// Token: 0x040000AF RID: 175
		public string attachment_path = "";
	}
}
