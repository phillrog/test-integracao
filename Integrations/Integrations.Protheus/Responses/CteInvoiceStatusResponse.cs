using Newtonsoft.Json;

namespace Integrations.Protheus.Responses
{
	public class CteInvoiceStatusResponse
	{
		[JsonProperty("DT6_FILDOC")]
		public string UnitOrigin { get; set; }

		[JsonProperty("DT6_DOC")]
		public string Number { get; set; }

		[JsonProperty("DT6_SERIE")]
		public string Serie { get; set; }

		[JsonProperty("DT6_ZZSTAT")]
		public string Status { get; set; }

		[JsonProperty("DT6_CHAVE")]
		public string Key { get; set; }
	}
}
