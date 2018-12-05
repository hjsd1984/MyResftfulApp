using App.Core.Entities;
using App.Infrastructure.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Services
{
    public class CotizacionWebApi : IEstrategiaCotizacion
    {
        private string urlApi = ConfigurationManager.AppSettings["ApiRestCotizacionMonedas"].ToString();

        public HttpResponseMessage ObtenerCotizacion(string moneda)
        {
            HttpRequestMessage solicitud = new HttpRequestMessage();

            var cliente = new HttpClient { BaseAddress = new Uri(urlApi) };
            cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = cliente.GetAsync("Principal/Dolar").Result;

            if (response.IsSuccessStatusCode)
            {
                var datosCotizacion = response.Content.ReadAsStringAsync();
                var objeto = JsonConvert.DeserializeObject(datosCotizacion.Result);

                var respuesta = solicitud.CreateResponse(HttpStatusCode.OK);
                respuesta.Content = new StringContent(objeto.ToString(), Encoding.UTF8, "application/json");
                return respuesta;
                
            }
            else
            {
                return solicitud.CreateResponse(HttpStatusCode.NotFound);
            }
            
        } 
        
    }
}
