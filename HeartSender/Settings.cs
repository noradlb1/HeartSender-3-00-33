using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CommonSender;

namespace HeartSender
{
	// Token: 0x0200001E RID: 30
	public partial class Settings : Form
	{
		// Token: 0x06000151 RID: 337 RVA: 0x0002037C File Offset: 0x0001E57C
		public Settings(Main _main)
		{
			this.InitializeComponent();
			this.main = _main;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00020394 File Offset: 0x0001E594
		private void btnOk_Click(object sender, EventArgs e)
		{
			this.main.settings[0] = this.ctrlTimeout.Value.ToString();
			this.main.settings[1] = this.ctrlTextEncoding.Text;
			this.main.settings[2] = this.ctrlBodyTransfer.Text;
			this.main.settings[3] = this.ctrlDeliveryFormat.Text;
			this.main.settings[4] = this.ctrlAlternativeView.Text;
			this.main.settings[5] = this.txtYourEmail.Text;
			this.main.settings[24] = this.txtAttachmentName.Text;
			this.main.settings[26] = this.ctrlPreHeader.Text;
			this.main.settings[27] = this.txtReplyEmail.Text;
			this.main.settings[28] = this.txtApiKey.Text;
			this.main.settings[29] = this.txtScriptDomain.Text;
			this.main.settings[30] = this.txtIMAPList.Text;
			this.main.settings[31] = this.ctrlIMAPRun.Value.ToString();
			this.main.settings[32] = (this.chkEmailMX.Checked ? "1" : "0");
			this.main.settings[33] = (this.chkAllowDuplicate.Checked ? "1" : "0");
			this.main.settings[35] = (this.chkAllowValidate.Checked ? "1" : "0");
			Main.is_validate = this.main.settings[35];
			Main.sender_email = this.txtYourEmail.Text;
			if (this.ctrlLetterEncoding.Text.ToLower() == "no")
			{
				this.main.settings[6] = "0";
			}
			else if (this.ctrlLetterEncoding.Text.ToLower() == "base64")
			{
				this.main.settings[6] = "1";
			}
			else if (this.ctrlLetterEncoding.Text.ToLower() == "quarted printed")
			{
				this.main.settings[6] = "2";
			}
			if (this.ctrlLetterEncryption.Text.ToLower() == "no")
			{
				this.main.settings[7] = "0";
			}
			else if (this.ctrlLetterEncryption.Text.ToLower() == "zerofont")
			{
				this.main.settings[7] = "1";
			}
			else if (this.ctrlLetterEncryption.Text.ToLower() == "unicode")
			{
				this.main.settings[7] = "2";
			}
			else if (this.ctrlLetterEncryption.Text.ToLower() == "dfn")
			{
				this.main.settings[7] = "3";
			}
			else if (this.ctrlLetterEncryption.Text.ToLower() == "ascii chars")
			{
				this.main.settings[7] = "4";
			}
			else if (this.ctrlLetterEncryption.Text.ToLower() == "zerofont2")
			{
				this.main.settings[7] = "5";
			}
			else if (this.ctrlLetterEncryption.Text.ToLower().Trim() == "max zero")
			{
				this.main.settings[7] = "6";
			}
			else if (this.ctrlLetterEncryption.Text.ToLower().Trim() == "punny code")
			{
				this.main.settings[7] = "7";
			}
			else if (this.ctrlLetterEncryption.Text.ToLower().Trim() == "small font")
			{
				this.main.settings[7] = "8";
			}
			else if (this.ctrlLetterEncryption.Text.ToLower().Trim() == "dev encryption")
			{
				this.main.settings[7] = "9";
			}
			else if (this.ctrlLetterEncryption.Text.ToLower().Trim() == "cap code")
			{
				this.main.settings[7] = "10";
			}
			else if (this.ctrlLetterEncryption.Text.ToLower().Trim() == "max2")
			{
				this.main.settings[7] = "11";
			}
			else if (this.ctrlLetterEncryption.Text.ToLower().Trim() == "max3")
			{
				this.main.settings[7] = "12";
			}
			else if (this.ctrlLetterEncryption.Text.ToLower().Trim() == "caret code")
			{
				this.main.settings[7] = "13";
			}
			else if (this.ctrlLetterEncryption.Text.ToLower().Trim() == "maxcaret")
			{
				this.main.settings[7] = "14";
			}
			else if (this.ctrlLetterEncryption.Text.ToLower().Trim() == "arabcode")
			{
				this.main.settings[7] = "15";
			}
			else if (this.ctrlLetterEncryption.Text.ToLower().Trim() == "fancycode")
			{
				this.main.settings[7] = "16";
			}
			else if (this.ctrlLetterEncryption.Text.ToLower().Trim() == "softcode")
			{
				this.main.settings[7] = "17";
			}
			else if (this.ctrlLetterEncryption.Text.ToLower().Trim() == "shortmixer")
			{
				this.main.settings[7] = "18";
			}
			else if (this.ctrlLetterEncryption.Text == "ShortMixer2")
			{
				this.main.settings[7] = "19";
			}
			else if (this.ctrlLetterEncryption.Text == "Covider")
			{
				this.main.settings[7] = "20";
			}
			else if (this.ctrlLetterEncryption.Text == "Fontr")
			{
				this.main.settings[7] = "21";
			}
			else if (this.ctrlLetterEncryption.Text == "SuperFontr")
			{
				this.main.settings[7] = "22";
			}
			else if (this.ctrlLetterEncryption.Text == "MasterInboxer")
			{
				this.main.settings[7] = "23";
			}
			else if (this.ctrlLetterEncryption.Text == "Shipr")
			{
				this.main.settings[7] = "24";
			}
			else if (this.ctrlLetterEncryption.Text == "Stylor")
			{
				this.main.settings[7] = "25";
			}
			if (this.ctrlSubjectEncoding.Text.ToLower() == "normal")
			{
				this.main.settings[8] = "0";
			}
			else if (this.ctrlSubjectEncoding.Text.ToLower() == "base64")
			{
				this.main.settings[8] = "1";
			}
			else if (this.ctrlSubjectEncoding.Text.ToLower() == "punny code")
			{
				this.main.settings[8] = "2";
			}
			else if (this.ctrlSubjectEncoding.Text.ToLower() == "cap code")
			{
				this.main.settings[8] = "3";
			}
			else if (this.ctrlSubjectEncoding.Text.ToLower() == "caret code")
			{
				this.main.settings[8] = "4";
			}
			if (this.ctrlLinkEncoding.Text.ToLower() == "normal")
			{
				this.main.settings[9] = "0";
			}
			else if (this.ctrlLinkEncoding.Text.ToLower() == "unicode")
			{
				this.main.settings[9] = "1";
			}
			else if (this.ctrlLinkEncoding.Text.ToLower() == "url encode")
			{
				this.main.settings[9] = "2";
			}
			this.main.settings[10] = this.ctrlFromNameEncoding.Text;
			if (this.ctrlFromNameEncoding.Text.ToLower() == "no")
			{
				this.main.settings[10] = "0";
			}
			else if (this.ctrlFromNameEncoding.Text.ToLower() == "yes")
			{
				this.main.settings[10] = "1";
			}
			else if (this.ctrlFromNameEncoding.Text.ToLower() == "cap code")
			{
				this.main.settings[10] = "2";
			}
			else if (this.ctrlFromNameEncoding.Text.ToLower() == "caret code")
			{
				this.main.settings[10] = "3";
			}
			base.Close();
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00020DBD File Offset: 0x0001EFBD
		private void btnDone_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00020DC8 File Offset: 0x0001EFC8
		private void Settings_Load(object sender, EventArgs e)
		{
			if (this.main.settings[0] != "")
			{
				this.ctrlTimeout.Value = int.Parse(this.main.settings[0]);
			}
			if (this.main.settings[1] != "")
			{
				this.ctrlTextEncoding.Text = this.main.settings[1];
			}
			if (this.main.settings[0] != "")
			{
				this.ctrlBodyTransfer.Text = this.main.settings[2];
			}
			if (this.main.settings[0] != "")
			{
				this.ctrlDeliveryFormat.Text = this.main.settings[3];
			}
			if (this.main.settings[0] != "")
			{
				this.ctrlAlternativeView.Text = this.main.settings[4];
			}
			if (this.main.settings[0] != "")
			{
				this.txtYourEmail.Text = this.main.settings[5];
			}
			if (this.main.settings[6] == "0")
			{
				this.ctrlLetterEncoding.Text = "No";
			}
			else if (this.main.settings[6] == "1")
			{
				this.ctrlLetterEncoding.Text = "Base64";
			}
			else if (this.main.settings[6] == "2")
			{
				this.ctrlLetterEncoding.Text = "Quarted Printed";
			}
			if (this.main.settings[7] == "0")
			{
				this.ctrlLetterEncryption.Text = "No";
			}
			else if (this.main.settings[7] == "1")
			{
				this.ctrlLetterEncryption.Text = "Zerofont";
			}
			else if (this.main.settings[7] == "2")
			{
				this.ctrlLetterEncryption.Text = "Unicode";
			}
			else if (this.main.settings[7] == "3")
			{
				this.ctrlLetterEncryption.Text = "DFN";
			}
			else if (this.main.settings[7] == "4")
			{
				this.ctrlLetterEncryption.Text = "ASCII Chars";
			}
			else if (this.main.settings[7] == "5")
			{
				this.ctrlLetterEncryption.Text = "Zerofont2";
			}
			else if (this.main.settings[7] == "6")
			{
				this.ctrlLetterEncryption.Text = "Max Zero";
			}
			else if (this.main.settings[7] == "7")
			{
				this.ctrlLetterEncryption.Text = "Punny Code";
			}
			else if (this.main.settings[7] == "8")
			{
				this.ctrlLetterEncryption.Text = "Small Font";
			}
			else if (this.main.settings[7] == "9")
			{
				this.ctrlLetterEncryption.Text = "Dev Encryption";
			}
			else if (this.main.settings[7] == "10")
			{
				this.ctrlLetterEncryption.Text = "Cap Code";
			}
			else if (this.main.settings[7] == "11")
			{
				this.ctrlLetterEncryption.Text = "Max2";
			}
			else if (this.main.settings[7] == "12")
			{
				this.ctrlLetterEncryption.Text = "Max3";
			}
			else if (this.main.settings[7] == "13")
			{
				this.ctrlLetterEncryption.Text = "Caret Code";
			}
			else if (this.main.settings[7] == "14")
			{
				this.ctrlLetterEncryption.Text = "MaxCaret";
			}
			else if (this.main.settings[7] == "15")
			{
				this.ctrlLetterEncryption.Text = "ArabCode";
			}
			else if (this.main.settings[7] == "16")
			{
				this.ctrlLetterEncryption.Text = "FancyCode";
			}
			else if (this.main.settings[7] == "17")
			{
				this.ctrlLetterEncryption.Text = "SoftCode";
			}
			else if (this.main.settings[7] == "18")
			{
				this.ctrlLetterEncryption.Text = "ShortMixer";
			}
			else if (this.main.settings[7] == "19")
			{
				this.ctrlLetterEncryption.Text = "ShortMixer2";
			}
			else if (this.main.settings[7] == "20")
			{
				this.ctrlLetterEncryption.Text = "Covider";
			}
			else if (this.main.settings[7] == "21")
			{
				this.ctrlLetterEncryption.Text = "Fontr";
			}
			else if (this.main.settings[7] == "22")
			{
				this.ctrlLetterEncryption.Text = "SuperFontr";
			}
			else if (this.main.settings[7] == "23")
			{
				this.ctrlLetterEncryption.Text = "MasterInboxer";
			}
			else if (this.main.settings[7] == "24")
			{
				this.ctrlLetterEncryption.Text = "Shipr";
			}
			else if (this.main.settings[7] == "25")
			{
				this.ctrlLetterEncryption.Text = "Stylor";
			}
			if (this.main.settings[8] == "0")
			{
				this.ctrlSubjectEncoding.Text = "Normal";
			}
			else if (this.main.settings[8] == "1")
			{
				this.ctrlSubjectEncoding.Text = "Base64";
			}
			else if (this.main.settings[8] == "2")
			{
				this.ctrlSubjectEncoding.Text = "Punny Code";
			}
			else if (this.main.settings[8] == "3")
			{
				this.ctrlSubjectEncoding.Text = "Cap Code";
			}
			else if (this.main.settings[8] == "4")
			{
				this.ctrlSubjectEncoding.Text = "Caret Code";
			}
			if (this.main.settings[9] == "0")
			{
				this.ctrlLinkEncoding.Text = "Normal";
			}
			else if (this.main.settings[9] == "1")
			{
				this.ctrlLinkEncoding.Text = "Unicode";
			}
			else if (this.main.settings[9] == "2")
			{
				this.ctrlLinkEncoding.Text = "Url Encode";
			}
			if (this.main.settings[10] == "0")
			{
				this.ctrlFromNameEncoding.Text = "No";
			}
			else if (this.ctrlFromNameEncoding.Text.ToLower() == "1")
			{
				this.ctrlFromNameEncoding.Text = "Yes";
			}
			else if (this.ctrlFromNameEncoding.Text.ToLower() == "2")
			{
				this.ctrlFromNameEncoding.Text = "Cap Code";
			}
			else if (this.ctrlFromNameEncoding.Text.ToLower() == "3")
			{
				this.ctrlFromNameEncoding.Text = "Caret Code";
			}
			this.txtAttachmentName.Text = this.main.settings[24];
			this.ctrlPreHeader.Text = this.main.settings[26];
			this.txtReplyEmail.Text = this.main.settings[27];
			this.txtApiKey.Text = this.main.settings[28];
			this.txtScriptDomain.Text = this.main.settings[29];
			this.txtIMAPList.Text = this.main.settings[30];
			if (this.main.settings[31] != "")
			{
				this.ctrlIMAPRun.Value = int.Parse(this.main.settings[31]);
			}
			if (this.main.settings[32] != "")
			{
				this.chkEmailMX.Checked = (int.Parse(this.main.settings[32]) == 1);
			}
			if (this.main.settings[33] != "")
			{
				this.chkAllowDuplicate.Checked = (int.Parse(this.main.settings[33]) == 1);
			}
			if (this.main.settings[35] != "")
			{
				this.chkAllowValidate.Checked = (int.Parse(this.main.settings[35]) == 1);
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000217B8 File Offset: 0x0001F9B8
		private void btnTokenReset_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Do you want to reset token? \nIt will revoke access on old device!", "HeartSender", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				string new_token = new GxApi().doResetToken();
				if (new_token.Trim().ToLower() != "101")
				{
					StreamWriter streamWriter = new StreamWriter("license.txt", false);
					streamWriter.Write(new_token);
					streamWriter.Close();
					MessageBox.Show("Token successfully updated!", "HeartSender", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					Application.Exit();
					return;
				}
				MessageBox.Show("Sorry, You are not allowed. \n\rto perform this action!.", "HeartSender", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x040001E3 RID: 483
		private Main main;
	}
}
