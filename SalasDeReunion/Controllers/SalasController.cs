using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalasDeReunion.Models;

namespace SalasDeReunion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalasController : ControllerBase
    {
        // GET: api/Salas
        [HttpGet]
        public IEnumerable<object> Get()
        {
            var context = new SalasDeReunionContext();
            var salas = context.Salas.ToList();
            return salas;
        }

        // GET: api/Salas/5
        [HttpGet("{id}", Name = "GetSala")]
        public object Get(int id)
        {
            var context = new SalasDeReunionContext();
            var salas = context.Salas.Where(s=>s.SalaId==id).ToList();
            return salas;
        }

        // POST: api/Salas
        [HttpPost]
        public void Post([FromBody] Salas salas)
        {
            var context = new SalasDeReunionContext();
            context.Salas.Add(salas);
            context.SaveChanges();
        }

        // PUT: api/Salas/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, Salas sala)
        {
            if (id != sala.SalaId)
            {
                return BadRequest();
            }
            var context = new SalasDeReunionContext();
            context.Entry(sala).State = EntityState.Modified;

            try
            {
                context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                bool SalasExists(int id) =>
                context.Salas.Any(e => e.SalaId == id);
                if (!SalasExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var context = new SalasDeReunionContext();
            var sala =  context.Salas.Find(id);
            if (sala == null)
            {
                return NotFound();
            }

            context.Salas.Remove(sala);
             context.SaveChanges();

            return Ok(sala);
        }
    }
}
