using App.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Contexts
{
    public class UsuarioDbContext : DbContext
    {
        public UsuarioDbContext()
            : base("BDMyRestFulApp")
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
