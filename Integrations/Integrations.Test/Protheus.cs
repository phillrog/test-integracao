using Integrations.Protheus.Responses;
using Newtonsoft.Json;
using System;
using System.IO;
using Xunit;

namespace Integrations.Test
{
	public class Protheus
	{
		private const string jsonNumeroFatura = @"Responses\NumeroFatura.json";
		private const string jsonNumeroFatura2 = @"Responses\NumeroFatura2.json";

		[Fact]
		public void DeveCarregarNumeroFatura()
		{
			using (StreamReader r = new StreamReader(jsonNumeroFatura))
			{
				string json = r.ReadToEnd();
				Assert.NotNull(json);
			}
		}

		[Fact]
		public void DeveCarregarNumeroFatura2()
		{
			using (StreamReader r = new StreamReader(jsonNumeroFatura2))
			{
				string json = r.ReadToEnd();
				Assert.NotNull(json);
			}
		}

		[Fact]
		public void DeveDeserializarResponseJsonNumeroFatura()
		{
			using (StreamReader r = new StreamReader(jsonNumeroFatura))
			{
				string json = r.ReadToEnd();
				var objeto = JsonConvert.DeserializeObject<InvoiceStatusResponse>(json);

				Assert.NotNull(objeto);
				Assert.True(objeto.Invoices.Count > 0);
			}
		}

		[Fact]
		public void DeveDeserializarValorAcessoriosResponseJsonNumeroFatura()
		{
			using (StreamReader r = new StreamReader(jsonNumeroFatura))
			{
				string json = r.ReadToEnd();
				var objeto = JsonConvert.DeserializeObject<InvoiceStatusResponse>(json);

				var valAcessorios = objeto.Invoices[0].FittingsValues;
				Assert.True(valAcessorios.Count > 0);
				Assert.True(valAcessorios[0].Description.Length > 3);
			}
		}

		[Fact]
		public void DeveDeserializarCTEResponseJsonNumeroFatura()
		{
			using (StreamReader r = new StreamReader(jsonNumeroFatura2))
			{
				string json = r.ReadToEnd();
				var objeto = JsonConvert.DeserializeObject<InvoiceStatusResponse>(json);

				var freights = objeto.Invoices[0].Freights;
				Assert.True(freights.Count > 0);
				Assert.True(freights[0].Key.Length > 10);
			}
		}

		[Fact]
		public void DeveDeserializarOsNovosCamposDoResponseJsonNumeroFatura()
		{
			using (StreamReader r = new StreamReader(jsonNumeroFatura2))
			{
				string json = r.ReadToEnd();
				var objeto = JsonConvert.DeserializeObject<InvoiceStatusResponse>(json);
				var invoice = objeto.Invoices[0];
				var unitCode = invoice.UnitCode;
				var due = new DateTime(
						int.Parse(invoice.Due.Substring(0, 4)),
						int.Parse(invoice.Due.Substring(4, 2)),
						int.Parse(invoice.Due.Substring(6, 2)));
				var freights = invoice.Freights;
				Assert.True(Int32.Parse(unitCode) > 0);
				Assert.Equal(due, new DateTime(2020, 4, 14));
				Assert.True(freights.Count > 0);
				Assert.True(freights[0].Status.Length > 0);
				Assert.True(freights[0].Key.Length > 10);
			}
		}
	}
}
