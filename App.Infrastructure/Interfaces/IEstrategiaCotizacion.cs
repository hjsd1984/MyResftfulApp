using App.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Interfaces
{
    public interface IEstrategiaCotizacion
    {
        HttpResponseMessage ObtenerCotizacion(string moneda);
    }
}