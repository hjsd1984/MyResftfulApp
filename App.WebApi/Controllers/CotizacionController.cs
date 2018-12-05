using App.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static App.Core.Entities.Enums;

namespace App.WebApi.Controllers
{
    public class CotizacionController : ApiController
    {
        
        [HttpGet]
        [Route("MyResftfullApp/Cotizacion/{moneda}")]
        public HttpResponseMessage Get(string moneda)
        {
            return CotizacionBusiness.Obtener(moneda);
        }
        
    }
}
