using App.Core.Entities;

namespace App.Infrastructure.Migrations
{
    using Core.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<App.Infrastructure.Contexts.UsuarioDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(App.Infrastructure.Contexts.UsuarioDbContext context)
        {
            context.Usuarios.AddOrUpdate(
                new Usuario() { Nombre = "Javier", Apellido = "Delgado", Email = "javier.delgado@gmail.com", Password = "123" },
                new Usuario() { Nombre = "María", Apellido = "Urdaneta", Email = "murdaneta@gmail.com", Password = "741urdaneta" },
                new Usuario() { Nombre = "Pedro", Apellido = "García", Email = "pedro.garcia@hotmail.com", Password = "qwerty" }
                );
        }
    }
}
