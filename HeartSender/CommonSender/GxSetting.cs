using System;
using HeartSender;

namespace CommonSender
{
	// Token: 0x0200000C RID: 12
	[Serializable]
	public class GxSetting
	{
		// Token: 0x06000048 RID: 72 RVA: 0x000043D7 File Offset: 0x000025D7
		public GxSetting(Main _main)
		{
			this.main = _main;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000043E6 File Offset: 0x000025E6
		public bool parseData()
		{
			return this.toGxConfig();
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000043F0 File Offset: 0x000025F0
		public bool toGxConfig()
		{
			this.config = new GxConfig();
			this.main.settings[23].Split(new char[]
			{
				'/'
			});
			this.config.priority = int.Parse(this.main.settings[11]);
			this.config.user_random = 0;
			this.config.using_tag = 1;
			this.config.using_attachment = ((this.main.settings[23] != "") ? 1 : 0);
			this.config.name_attachment = this.main.settings[24];
			this.config.email_countsend = int.Parse(this.main.settings[19]);
			this.config.sending_delay = int.Parse(this.main.settings[21]);
			this.config.masking = 0;
			this.config.date = "America/Adak";
			this.config.letter_encrypt = int.Parse(this.main.settings[7]);
			this.config.letter_encode = int.Parse(this.main.settings[6]);
			this.config.subject_encode = int.Parse(this.main.settings[8]);
			this.config.link_encode = int.Parse(this.main.settings[9]);
			this.config.image_encode = 0;
			this.config.list_email = "";
			this.config.letter = "";
			this.config.file_attachment = this.main.settings[23];
			this.config.target_email_name = "";
			this.config.use_reply_email = 0;
			this.config.reply_email = "";
			this.config.reply_email_name = "";
			this.config.from_name = this.main.settings[16];
			this.config.subject = this.main.settings[17];
			this.config.confirmed_email = 1;
			this.config.failed_email = 1;
			this.config.mail_limit = 0;
			this.config.fromname_encode = int.Parse(this.main.settings[10]);
			this.config.remove_email = 1;
			this.main.settings[32] = ((this.main.settings[32].ToString().Length == 0) ? "0" : this.main.settings[32]);
			this.config.verify_email = int.Parse(this.main.settings[32]);
			this.config.smtp = Main.smtps;
			this.config.links = Main.links;
			this.config.text_encoding = this.main.settings[1];
			this.config.btencoding = this.main.settings[2];
			this.config.preheader = this.main.settings[26];
			this.config.replyEmail = this.main.settings[27];
			this.config.api_key = this.main.settings[28];
			this.config.api_domain = this.main.settings[29];
			this.config.imap_keywords = this.main.settings[30];
			this.main.settings[31] = ((this.main.settings[31].ToString().Length == 0) ? "10" : this.main.settings[31]);
			this.config.imap_time = double.Parse(this.main.settings[31]);
			this.main.settings[33] = ((this.main.settings[33].ToString().Length == 0) ? "0" : this.main.settings[33]);
			this.config.enable_duplicate = (this.main.settings[33] == "1");
			this.main.settings[35] = ((this.main.settings[35].ToString().Length == 0) ? "0" : this.main.settings[35]);
			this.config.enable_validate_email = (this.main.settings[35] == "1");
			return this.config.validate();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000048C0 File Offset: 0x00002AC0
		public void sendEmail(int i)
		{
			Console.WriteLine("Email Sent: " + i.ToString());
		}

		// Token: 0x04000060 RID: 96
		public GxConfig config;

		// Token: 0x04000061 RID: 97
		public Main main;
	}
}
