namespace HeartSender
{
	// Token: 0x02000019 RID: 25
	public partial class ImportEmail : global::System.Windows.Forms.Form
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x000111C9 File Offset: 0x0000F3C9
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000111E8 File Offset: 0x0000F3E8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::HeartSender.ImportEmail));
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.txtEmailList = new global::System.Windows.Forms.RichTextBox();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.btnImport = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.btnRmDpl = new global::System.Windows.Forms.Button();
			this.lblCount = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.ctrlProgress = new global::System.Windows.Forms.ProgressBar();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.txtEmailList);
			this.groupBox1.Location = new global::System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(360, 281);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Add Email";
			this.txtEmailList.Location = new global::System.Drawing.Point(6, 19);
			this.txtEmailList.Name = "txtEmailList";
			this.txtEmailList.Size = new global::System.Drawing.Size(348, 256);
			this.txtEmailList.TabIndex = 0;
			this.txtEmailList.Text = "";
			this.groupBox2.Controls.Add(this.btnImport);
			this.groupBox2.Controls.Add(this.btnAdd);
			this.groupBox2.Controls.Add(this.btnRmDpl);
			this.groupBox2.Controls.Add(this.lblCount);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new global::System.Drawing.Point(12, 316);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(360, 57);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.btnImport.Image = (global::System.Drawing.Image)resources.GetObject("btnImport.Image");
			this.btnImport.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnImport.Location = new global::System.Drawing.Point(196, 14);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new global::System.Drawing.Size(75, 34);
			this.btnImport.TabIndex = 4;
			this.btnImport.Text = "Import";
			this.btnImport.UseVisualStyleBackColor = true;
			this.btnImport.Click += new global::System.EventHandler(this.btnImport_Click);
			this.btnAdd.Image = (global::System.Drawing.Image)resources.GetObject("btnAdd.Image");
			this.btnAdd.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdd.Location = new global::System.Drawing.Point(277, 14);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new global::System.Drawing.Size(75, 34);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new global::System.EventHandler(this.btnAdd_Click);
			this.btnRmDpl.Image = (global::System.Drawing.Image)resources.GetObject("btnRmDpl.Image");
			this.btnRmDpl.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRmDpl.Location = new global::System.Drawing.Point(110, 14);
			this.btnRmDpl.Name = "btnRmDpl";
			this.btnRmDpl.Size = new global::System.Drawing.Size(79, 34);
			this.btnRmDpl.TabIndex = 2;
			this.btnRmDpl.Text = "  Rm Dpl";
			this.btnRmDpl.UseVisualStyleBackColor = true;
			this.btnRmDpl.Click += new global::System.EventHandler(this.btnRmDpl_Click);
			this.lblCount.AutoSize = true;
			this.lblCount.Location = new global::System.Drawing.Point(74, 25);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new global::System.Drawing.Size(13, 13);
			this.lblCount.TabIndex = 1;
			this.lblCount.Text = "0";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(8, 25);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(68, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Total Lines : ";
			this.ctrlProgress.Location = new global::System.Drawing.Point(12, 296);
			this.ctrlProgress.Name = "ctrlProgress";
			this.ctrlProgress.Size = new global::System.Drawing.Size(360, 23);
			this.ctrlProgress.TabIndex = 1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(385, 379);
			base.Controls.Add(this.ctrlProgress);
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.groupBox1);
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ImportEmail";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Email";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400010C RID: 268
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400010D RID: 269
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x0400010E RID: 270
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x0400010F RID: 271
		private global::System.Windows.Forms.RichTextBox txtEmailList;

		// Token: 0x04000110 RID: 272
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000111 RID: 273
		private global::System.Windows.Forms.Label lblCount;

		// Token: 0x04000112 RID: 274
		private global::System.Windows.Forms.Button btnImport;

		// Token: 0x04000113 RID: 275
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000114 RID: 276
		private global::System.Windows.Forms.Button btnRmDpl;

		// Token: 0x04000115 RID: 277
		private global::System.Windows.Forms.ProgressBar ctrlProgress;
	}
}
