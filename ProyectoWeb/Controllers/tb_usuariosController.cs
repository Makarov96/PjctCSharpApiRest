using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ProyectoWeb;

namespace ProyectoWeb.Controllers
{
    public class tb_usuariosController : ApiController
    {
        private proyectoEntities db = new proyectoEntities();

        // GET: api/tb_usuarios
        public IQueryable<tb_usuarios> Gettb_usuarios()
        {
            return db.tb_usuarios;
        }

        // GET: api/tb_usuarios/5
        [ResponseType(typeof(tb_usuarios))]
        public IHttpActionResult Gettb_usuarios(int id)
        {
            tb_usuarios tb_usuarios = db.tb_usuarios.Find(id);
            if (tb_usuarios == null)
            {
                return NotFound();
            }

            return Ok(tb_usuarios);
        }

        // PUT: api/tb_usuarios/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttb_usuarios(int id, tb_usuarios tb_usuarios)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tb_usuarios.id_usuario)
            {
                return BadRequest();
            }

            db.Entry(tb_usuarios).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tb_usuariosExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/tb_usuarios
        [ResponseType(typeof(tb_usuarios))]
        public IHttpActionResult Posttb_usuarios(tb_usuarios tb_usuarios)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tb_usuarios.Add(tb_usuarios);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tb_usuarios.id_usuario }, tb_usuarios);
        }

        // DELETE: api/tb_usuarios/5
        [ResponseType(typeof(tb_usuarios))]
        public IHttpActionResult Deletetb_usuarios(int id)
        {
            tb_usuarios tb_usuarios = db.tb_usuarios.Find(id);
            if (tb_usuarios == null)
            {
                return NotFound();
            }

            db.tb_usuarios.Remove(tb_usuarios);
            db.SaveChanges();

            return Ok(tb_usuarios);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tb_usuariosExists(int id)
        {
            return db.tb_usuarios.Count(e => e.id_usuario == id) > 0;
        }
    }
}