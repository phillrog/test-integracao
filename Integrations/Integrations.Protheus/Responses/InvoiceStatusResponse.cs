using Newtonsoft.Json;
using System.Collections.Generic;

namespace Integrations.Protheus.Responses
{
	public class InvoiceStatusResponse
	{
		[JsonProperty("FATURAS")]
		public List<InvoiceStatusResourceResponse> Invoices { get; set; }

		[JsonProperty("COUNT")]
		public long Count { get; set; }
	}
}
