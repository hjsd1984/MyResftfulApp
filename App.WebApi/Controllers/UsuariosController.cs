using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using App.Core.Entities;
using App.Infrastructure.Contexts;
using App.Infrastructure.UnitOfWork;

namespace App.WebApi.Controllers
{
    public class UsuariosController : ApiController
    {
        private readonly UnitOfWork uow = new UnitOfWork();
        
        public IQueryable<Usuario> GetUsuarios()
        {
            return uow.UsuariosRepository.Queryable();
        }

        [HttpGet]
        [ResponseType(typeof(Usuario))]
        public async Task<IHttpActionResult> GetUsuario(int? id)
        {
            if (id == null)
                return BadRequest();
            
            var usuario = await uow.UsuariosRepository.FindAsync(id);

            if (usuario == null)
                return NotFound();

            return Ok(usuario);
        }
        
        [HttpPut]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutUsuario(int id, Usuario usuario)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            if (id != usuario.Id)
                return BadRequest();
            
            uow.UsuariosRepository.Update(usuario);
            await uow.SaveChangesAsync();
            
            return StatusCode(HttpStatusCode.NoContent);
        }

        [HttpPost]
        [ResponseType(typeof(Usuario))]
        public async Task<IHttpActionResult> PostUsuario(Usuario usuario)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            uow.UsuariosRepository.Create(usuario);
            await uow.SaveChangesAsync();

            return Ok(usuario);
        }
        
        [HttpDelete]
        [ResponseType(typeof(Usuario))]
        public async Task<IHttpActionResult> DeleteUsuario(int? id)
        {
            if (id == null)
                return BadRequest();

            Usuario usuario = await uow.UsuariosRepository.FindAsync(id);

            if (usuario == null)
                return NotFound();

            uow.UsuariosRepository.Delete(usuario);
            await uow.SaveChangesAsync();

            return Ok(usuario);
        }
        
    }
}