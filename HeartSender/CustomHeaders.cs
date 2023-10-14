using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HeartSender
{
	// Token: 0x02000014 RID: 20
	public partial class CustomHeaders : Form
	{
		// Token: 0x06000099 RID: 153 RVA: 0x0000D18D File Offset: 0x0000B38D
		public CustomHeaders(Main _main)
		{
			this.InitializeComponent();
			this.main = _main;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000D1A4 File Offset: 0x0000B3A4
		private void btnImport_Click(object sender, EventArgs e)
		{
			OpenFileDialog file = new OpenFileDialog();
			file.Filter = "txt files (*.txt)|*.txt";
			Stream stream;
			if (file.ShowDialog() == DialogResult.OK && (stream = file.OpenFile()) != null)
			{
				using (StreamReader sr = new StreamReader(stream))
				{
					string[] data = sr.ReadToEnd().Split(new string[]
					{
						"\r\n",
						"\r",
						"\n"
					}, StringSplitOptions.RemoveEmptyEntries);
					this.loadData(data);
				}
				stream.Close();
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000D230 File Offset: 0x0000B430
		private void loadData(string[] rows)
		{
			try
			{
				if (rows.Length != 0)
				{
					this.gridHeaders.Rows.Clear();
					foreach (string line in rows)
					{
						if (line.Trim().Length >= 1)
						{
							string[] row = line.Split(new char[]
							{
								'|'
							});
							int index = this.gridHeaders.Rows.Add();
							this.gridHeaders.Rows[index].Cells["Key"].Value = row[0];
							this.gridHeaders.Rows[index].Cells["Value"].Value = row[1];
						}
					}
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Sorry, Invalid file format.");
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000D314 File Offset: 0x0000B514
		private void btnOk_Click(object sender, EventArgs e)
		{
			this.main.settings[22] = this.getHeaders();
			base.Close();
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000D330 File Offset: 0x0000B530
		private string getHeaders()
		{
			string[] headers = new string[this.gridHeaders.Rows.Count];
			for (int i = 0; i < this.gridHeaders.Rows.Count - 1; i++)
			{
				if (!(this.gridHeaders.Rows[i].Cells["Key"].Value.ToString() == ""))
				{
					headers[i] = this.gridHeaders.Rows[i].Cells["Key"].Value.ToString() + "|" + this.gridHeaders.Rows[i].Cells["Value"].Value.ToString();
				}
			}
			return string.Join(";", headers);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000D418 File Offset: 0x0000B618
		private void btnAdd_Click(object sender, EventArgs e)
		{
			this.gridHeaders.Rows.Add(new object[]
			{
				"",
				""
			});
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000D444 File Offset: 0x0000B644
		private void btnDel_Click(object sender, EventArgs e)
		{
			if (this.gridHeaders.SelectedRows.Count > 0)
			{
				using (IEnumerator enumerator = this.gridHeaders.SelectedRows.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						DataGridViewRow row = (DataGridViewRow)obj;
						this.gridHeaders.Rows.RemoveAt(row.Index);
					}
					return;
				}
			}
			MessageBox.Show("Please select atleast one row to delete.");
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000D4D0 File Offset: 0x0000B6D0
		private void CustomHeaders_Load(object sender, EventArgs e)
		{
			if (this.main.settings[22].Length > 0)
			{
				this.gridHeaders.Rows.Clear();
				foreach (string line in this.main.settings[22].Split(new char[]
				{
					';'
				}))
				{
					if (line.Trim().Length >= 1)
					{
						string[] row = line.Split(new char[]
						{
							'|'
						});
						int index = this.gridHeaders.Rows.Add();
						this.gridHeaders.Rows[index].Cells["Key"].Value = row[0];
						this.gridHeaders.Rows[index].Cells["Value"].Value = row[1];
					}
				}
			}
		}

		// Token: 0x040000C6 RID: 198
		public Main main;
	}
}
