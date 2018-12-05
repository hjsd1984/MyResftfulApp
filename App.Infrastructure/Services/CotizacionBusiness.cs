using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static App.Core.Entities.Enums;

namespace App.Infrastructure.Services
{
    public static class CotizacionBusiness
    {
        public static HttpResponseMessage Obtener(string moneda)
        {
            MetodoCotizacion metodo;
            HttpResponseMessage resultado;

            switch (moneda)
            {
                case nameof(TiposDeMoneda.Dolar):
                    metodo = new MetodoCotizacion(new CotizacionWebApi());
                    resultado = metodo.ObtenerCotizacion(moneda);
                    break;
                case nameof(TiposDeMoneda.Peso):
                case nameof(TiposDeMoneda.Real):
                default:
                    metodo = new MetodoCotizacion(new CotizacionOtra());
                    resultado = metodo.ObtenerCotizacion(moneda);
                    break;
            }
            return resultado;
        }
    }
}
