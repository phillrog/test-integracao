using Newtonsoft.Json;
using System.Collections.Generic;

namespace Integrations.Protheus.Responses
{
	public class InvoiceStatusResourceResponse
	{
		[JsonProperty("E1_FILDEB")]
		public string UnitCode { get; set; }

		[JsonProperty("E1_PREFIXO")]
		public string Prefix { get; set; }

		[JsonProperty("E1_NUM")]
		public string Number { get; set; }

		[JsonProperty("E1_TIPO")]
		public string Type { get; set; }

		[JsonProperty("E1_PARCELA")]
		public string Portion { get; set; }

		[JsonProperty("CNPJ")]
		public string Document { get; set; }

		[JsonProperty("E1_EMISSAO")]
		public string EmissionDate { get; set; }

		[JsonProperty("E1_VENCTO")]
		public string Due { get; set; }

		[JsonProperty("E1_VENCREA")]
		public string DueDate { get; set; }

		[JsonProperty("E1_VALOR")]
		public decimal Value { get; set; }

		[JsonProperty("E1_ACRESC")]
		public decimal Increase { get; set; }

		[JsonProperty("E1_DECRESC")]
		public decimal Decrease { get; set; }

		[JsonProperty("E1_JUROS")]
		public decimal Interest { get; set; }

		[JsonProperty("E1_MULTA")]
		public decimal FineValue { get; set; }

		[JsonProperty("E1_SALDO")]
		public string Balance { get; set; }

		[JsonProperty("E1_BAIXA")]
		public string PaydayDate { get; set; }

		[JsonProperty("E1_SITUACA")]
		public string Situation { get; set; }

		[JsonProperty("E1_ZZTPOPE")]
		public string OperationTYpe { get; set; }

		[JsonProperty("E1_ZZSTCAR")]
		public string SituationNotarysOffice { get; set; }

		[JsonProperty("ST_PERIODO")]
		public string Term { get; set; }

		[JsonProperty("ST_TITULO")]
		public string Title { get; set; }

		[JsonProperty("ST_CARTEIRA")]
		public string Wallet { get; set; }

		[JsonProperty("ST_CARTORIO")]
		public string Registry { get; set; }

		[JsonProperty("ST_RENEGOCIACAO")]
		public string TitleInRenegotiation { get; set; }

		[JsonProperty("VALACESSORIOS")]
		public List<FittingsValuesResponse> FittingsValues { get; set; }

		[JsonProperty("CTE")]
		public List<CteInvoiceStatusResponse> Freights { get; set; }
	}
}
