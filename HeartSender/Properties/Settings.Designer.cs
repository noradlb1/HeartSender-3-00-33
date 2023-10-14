using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace HeartSender.Properties
{
	// Token: 0x02000021 RID: 33
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000161 RID: 353 RVA: 0x000239B7 File Offset: 0x00021BB7
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x0400021B RID: 539
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
