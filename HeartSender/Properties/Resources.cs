using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace HeartSender.Properties
{
	// Token: 0x02000020 RID: 32
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x0600015D RID: 349 RVA: 0x00023974 File Offset: 0x00021B74
		internal Resources()
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600015E RID: 350 RVA: 0x0002397C File Offset: 0x00021B7C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("HeartSender.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600015F RID: 351 RVA: 0x000239A8 File Offset: 0x00021BA8
		// (set) Token: 0x06000160 RID: 352 RVA: 0x000239AF File Offset: 0x00021BAF
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x04000219 RID: 537
		private static ResourceManager resourceMan;

		// Token: 0x0400021A RID: 538
		private static CultureInfo resourceCulture;
	}
}
