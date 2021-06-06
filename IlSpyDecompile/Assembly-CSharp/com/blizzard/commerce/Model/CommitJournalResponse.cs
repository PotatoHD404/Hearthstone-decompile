using System;
using System.Text;

namespace com.blizzard.commerce.Model
{
	[Serializable]
	public class CommitJournalResponse
	{
		public Journal journal;

		public RpcError error;

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("class CommitJournalResponse {\n");
			stringBuilder.Append("  journal: ").Append(journal).Append("\n");
			stringBuilder.Append("  error: ").Append(error).Append("\n");
			stringBuilder.Append("}\n");
			return stringBuilder.ToString();
		}
	}
}
