using App.Core.Entities;
using App.Infrastructure.Contexts;
using App.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.UnitOfWork
{
    public class UnitOfWork
    {
        public UnitOfWork()
        {
            this.context = new UsuarioDbContext();
        }
        private readonly UsuarioDbContext context;

        private GenericRepository<Usuario> usuariosRepository;
        public GenericRepository<Usuario> UsuariosRepository
        {
            get
            {
                if (this.usuariosRepository == null)
                {
                    this.usuariosRepository = new GenericRepository<Usuario>(this.context);
                }
                return this.usuariosRepository;
            }
        }
        
        public async Task SaveChangesAsync()
        {
            await this.context.SaveChangesAsync();
        }
    }
}
