using Newtonsoft.Json;

namespace Integrations.Protheus.Responses
{
	public class FittingsValuesResponse
	{
		[JsonProperty("CODVAL")]
		public long Code { get; set; }

		[JsonProperty("DESC")]
		public string Description { get; set; }

		[JsonProperty("VALMOV")]
		public decimal Value { get; set; }
	}
}
