using System;

namespace RatDetector
{
	// Token: 0x02000004 RID: 4
	internal class RATVector
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002880 File Offset: 0x00000A80
		public RATVector(string name, string find, string alt)
		{
			this.m_name = name;
			this.m_find = find;
			this.m_alt = alt;
		}

		// Token: 0x0400000A RID: 10
		public string m_name;

		// Token: 0x0400000B RID: 11
		public string m_find;

		// Token: 0x0400000C RID: 12
		public string m_alt;
	}
}
