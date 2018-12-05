using App.Core.Entities;
using App.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Services
{
    public class MetodoCotizacion
    {
        private readonly IEstrategiaCotizacion _estrategiaCotizacion;

        public MetodoCotizacion(IEstrategiaCotizacion estrategiaCotizacion)
        {
            _estrategiaCotizacion = estrategiaCotizacion;
        }

        public HttpResponseMessage ObtenerCotizacion(string moneda)
        {
            return _estrategiaCotizacion.ObtenerCotizacion(moneda);
        }
    }
}
