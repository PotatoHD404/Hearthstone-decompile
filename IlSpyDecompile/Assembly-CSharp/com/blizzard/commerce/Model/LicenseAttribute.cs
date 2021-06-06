using System;
using System.Text;

namespace com.blizzard.commerce.Model
{
	[Serializable]
	public class LicenseAttribute
	{
		public string value;

		public string key;

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("class LicenseAttribute {\n");
			stringBuilder.Append("  value: ").Append(value).Append("\n");
			stringBuilder.Append("  key: ").Append(key).Append("\n");
			stringBuilder.Append("}\n");
			return stringBuilder.ToString();
		}
	}
}
