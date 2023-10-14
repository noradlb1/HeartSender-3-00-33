using System;
using System.Windows.Forms;

namespace HeartSender
{
	// Token: 0x0200001C RID: 28
	internal static class Program
	{
		// Token: 0x06000142 RID: 322 RVA: 0x0001E402 File Offset: 0x0001C602
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Main());
		}
	}
}
