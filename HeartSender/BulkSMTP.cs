using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CommonSender;
using Microsoft.VisualBasic;

namespace HeartSender
{
	// Token: 0x02000012 RID: 18
	public partial class BulkSMTP : Form
	{
		// Token: 0x06000081 RID: 129 RVA: 0x00009354 File Offset: 0x00007554
		public BulkSMTP(Main _main)
		{
			this.InitializeComponent();
			this.main = _main;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00009370 File Offset: 0x00007570
		private void btnAllSMTPChecker_Click(object sender, EventArgs e)
		{
			Rectangle screensize = Screen.PrimaryScreen.Bounds;
			string input = Interaction.InputBox("Your Email:", "Input Your Email to Check SMTP:", "", screensize.Width / 2 - 200, screensize.Height / 2);
			if (input == "" && input.Split(new char[]
			{
				'@'
			}).Length != 2)
			{
				MessageBox.Show("Please enter valid email address.", "HeartSender");
				return;
			}
			this.btnAllSMTPChecker.Enabled = false;
			GxApi api = new GxApi();
			for (int index = 0; index < this.gridSMTPs.Rows.Count; index++)
			{
				if (this.gridSMTPs.Rows[index].Cells["Host"].Value.ToString().Trim().Length != 0 && int.Parse(this.gridSMTPs.Rows[index].Cells["Port"].Value.ToString()) > 0 && this.gridSMTPs.Rows[index].Cells["Username"].Value.ToString().Trim().Length != 0 && this.gridSMTPs.Rows[index].Cells["Password"].Value.ToString().Trim().Length != 0)
				{
					GxSMTP new_smtp = new GxSMTP();
					new_smtp.host = this.gridSMTPs.Rows[index].Cells["Host"].Value.ToString().Trim();
					new_smtp.port = int.Parse(this.gridSMTPs.Rows[index].Cells["Port"].Value.ToString().Trim());
					new_smtp.username = this.gridSMTPs.Rows[index].Cells["Username"].Value.ToString().Trim();
					new_smtp.password = this.gridSMTPs.Rows[index].Cells["Password"].Value.ToString().Trim();
					new_smtp.secure = false;
					if (this.gridSMTPs.Rows[index].Cells["Secure"].Value != null)
					{
						new_smtp.secure = (bool)this.gridSMTPs.Rows[index].Cells["Secure"].Value;
					}
					this.gridSMTPs.Rows[index].Cells["Status"].Value = api.isValidSMTP(GxConfig.baseUrl() + "backend/smtp-checker", new string[]
					{
						new_smtp.host.Trim(),
						new_smtp.username.Trim(),
						new_smtp.password.Trim(),
						new_smtp.port.ToString().Trim(),
						new_smtp.secure ? "1" : "0",
						"sender@oneskyrocket.com",
						input.Trim()
					});
				}
			}
			this.btnAllSMTPChecker.Enabled = true;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000096F8 File Offset: 0x000078F8
		private void BulkSMTP_FormClosing(object sender, FormClosingEventArgs e)
		{
			Main.bulk_smtps.Clear();
			for (int index = 0; index < this.gridSMTPs.Rows.Count; index++)
			{
				try
				{
					if (this.gridSMTPs.Rows[index] == null || (this.gridSMTPs.Rows[index].Cells["Host"].Value.ToString().Trim().Length != 0 && int.Parse(this.gridSMTPs.Rows[index].Cells["Port"].Value.ToString()) > 0 && this.gridSMTPs.Rows[index].Cells["Username"].Value.ToString().Trim().Length != 0 && this.gridSMTPs.Rows[index].Cells["Password"].Value.ToString().Trim().Length != 0))
					{
						GxSMTP new_smtp = new GxSMTP();
						new_smtp.host = this.gridSMTPs.Rows[index].Cells["Host"].Value.ToString().Trim();
						new_smtp.port = int.Parse(this.gridSMTPs.Rows[index].Cells["Port"].Value.ToString().Trim());
						new_smtp.username = this.gridSMTPs.Rows[index].Cells["Username"].Value.ToString().Trim();
						new_smtp.password = this.gridSMTPs.Rows[index].Cells["Password"].Value.ToString().Trim();
						new_smtp.secure = false;
						if (this.gridSMTPs.Rows[index].Cells["Secure"].Value != null)
						{
							new_smtp.secure = (bool)this.gridSMTPs.Rows[index].Cells["Secure"].Value;
						}
						Main.bulk_smtps.Add(new_smtp);
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000998C File Offset: 0x00007B8C
		private void BulkSMTP_Load(object sender, EventArgs e)
		{
			if (Main.bulk_smtps.Count > 0)
			{
				foreach (GxSMTP smtp in Main.bulk_smtps)
				{
					int index = this.gridSMTPs.Rows.Add();
					this.gridSMTPs.Rows[index].Cells["Host"].Value = smtp.host;
					this.gridSMTPs.Rows[index].Cells["Port"].Value = smtp.port.ToString();
					this.gridSMTPs.Rows[index].Cells["Username"].Value = smtp.username;
					this.gridSMTPs.Rows[index].Cells["Password"].Value = smtp.password;
					this.gridSMTPs.Rows[index].Cells["Secure"].Value = smtp.secure;
					this.gridSMTPs.Rows[index].Cells["Status"].Value = "";
				}
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00009B18 File Offset: 0x00007D18
		private void gridSMTPs_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			e.Control.KeyPress -= this.Port_KeyPress;
			if (this.gridSMTPs.CurrentCell.ColumnIndex == 1)
			{
				TextBox tb = e.Control as TextBox;
				if (tb != null)
				{
					tb.KeyPress += this.Port_KeyPress;
				}
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00009B70 File Offset: 0x00007D70
		private void Port_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00009B94 File Offset: 0x00007D94
		private void gridSMTPs_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				if (this.gridSMTPs.HitTest(e.X, e.Y) != null)
				{
					this.selected_index = this.gridSMTPs.HitTest(e.X, e.Y).RowIndex;
				}
				ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
				contextMenuStrip.Items.Add("Add SMTP");
				contextMenuStrip.Items.Add("Add in Library");
				contextMenuStrip.Items.Add("Remove SMTP");
				contextMenuStrip.Show(this.gridSMTPs, new Point(e.X, e.Y));
				contextMenuStrip.ItemClicked += this.contexMenu_ItemClicked;
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00009C54 File Offset: 0x00007E54
		private void contexMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			ToolStripItem item = e.ClickedItem;
			if (this.gridSMTPs.Rows.Count > 0)
			{
				if (item.Text == "Add in Library" && this.selected_index >= 0)
				{
					GxSMTP new_smtp = new GxSMTP();
					new_smtp.host = this.gridSMTPs.Rows[this.selected_index].Cells["Host"].Value.ToString().Trim();
					new_smtp.port = int.Parse(this.gridSMTPs.Rows[this.selected_index].Cells["Port"].Value.ToString().Trim());
					new_smtp.username = this.gridSMTPs.Rows[this.selected_index].Cells["Username"].Value.ToString().Trim();
					new_smtp.password = this.gridSMTPs.Rows[this.selected_index].Cells["Password"].Value.ToString().Trim();
					new_smtp.secure = false;
					if (this.gridSMTPs.Rows[this.selected_index].Cells["Secure"].Value != null)
					{
						new_smtp.secure = (bool)this.gridSMTPs.Rows[this.selected_index].Cells["Secure"].Value;
					}
					Main.smtps.Add(new_smtp);
					this.main.populateSMTPs();
				}
				else if (item.Text == "Remove SMTP" && this.selected_index >= 0)
				{
					this.gridSMTPs.Rows.RemoveAt(this.selected_index);
				}
			}
			if (item.Text == "Add SMTP")
			{
				int index = this.gridSMTPs.Rows.Add();
				this.gridSMTPs.Rows[index].Cells["Host"].Value = "";
				this.gridSMTPs.Rows[index].Cells["Port"].Value = "";
				this.gridSMTPs.Rows[index].Cells["Username"].Value = "";
				this.gridSMTPs.Rows[index].Cells["Password"].Value = "";
				this.gridSMTPs.Rows[index].Cells["Secure"].Value = false;
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00009F3C File Offset: 0x0000813C
		private void btnImport_Click(object sender, EventArgs e)
		{
			OpenFileDialog file = new OpenFileDialog();
			file.Filter = "txt files (*.txt)|*.txt";
			Stream stream;
			if (file.ShowDialog() == DialogResult.OK && (stream = file.OpenFile()) != null)
			{
				using (StreamReader sr = new StreamReader(stream))
				{
					string[] smtps = sr.ReadToEnd().Split(new string[]
					{
						"\r\n",
						"\r",
						"\n"
					}, StringSplitOptions.None);
					this.loadSMTPData(smtps);
				}
				stream.Close();
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00009FC8 File Offset: 0x000081C8
		public void loadSMTPData(string[] data)
		{
			try
			{
				Main.bulk_smtps.Clear();
				this.gridSMTPs.Rows.Clear();
				for (int i = 0; i < data.Length; i++)
				{
					string[] tokens = data[i].Split(new string[]
					{
						"|"
					}, StringSplitOptions.None);
					int index = this.gridSMTPs.Rows.Add();
					this.gridSMTPs.Rows[index].Cells["Host"].Value = tokens[0];
					this.gridSMTPs.Rows[index].Cells["Port"].Value = tokens[1];
					this.gridSMTPs.Rows[index].Cells["Username"].Value = tokens[2];
					this.gridSMTPs.Rows[index].Cells["Password"].Value = tokens[3];
					this.gridSMTPs.Rows[index].Cells["Secure"].Value = (tokens[4] == "ssl" || tokens[4] == "tls");
					this.gridSMTPs.Rows[index].Cells["Status"].Value = "";
					GxSMTP new_smtp = new GxSMTP();
					new_smtp.host = this.gridSMTPs.Rows[index].Cells["Host"].Value.ToString();
					new_smtp.port = int.Parse(this.gridSMTPs.Rows[index].Cells["Port"].Value.ToString());
					new_smtp.username = this.gridSMTPs.Rows[index].Cells["Username"].Value.ToString();
					new_smtp.password = this.gridSMTPs.Rows[index].Cells["Password"].Value.ToString();
					new_smtp.secure = false;
					if (this.gridSMTPs.Rows[index].Cells["Secure"].Value != null)
					{
						new_smtp.secure = (bool)this.gridSMTPs.Rows[index].Cells["Secure"].Value;
					}
					Main.bulk_smtps.Add(new_smtp);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Sorry, Invalid file format.");
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000A2AC File Offset: 0x000084AC
		private void btnClear_Click(object sender, EventArgs e)
		{
			this.gridSMTPs.Rows.Clear();
		}

		// Token: 0x0400009F RID: 159
		public Main main;

		// Token: 0x040000A0 RID: 160
		private int selected_index = -1;
	}
}
