using App.Core.Entities;
using App.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Services
{
    public class CotizacionOtra : IEstrategiaCotizacion
    {

        public HttpResponseMessage ObtenerCotizacion(string moneda)
        {
            HttpRequestMessage solicitud = new HttpRequestMessage();
            return solicitud.CreateResponse(HttpStatusCode.Unauthorized);
        }


    }
}
