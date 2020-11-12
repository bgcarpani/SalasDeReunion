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
    public class ReservasController : ControllerBase
    {
        // GET: api/Reservas
        [HttpGet]
        public IEnumerable<object> Get()
        {
            var context = new SalasDeReunionContext();
            var reservas = context.Reservas.ToList();
            return reservas;
        }

        // GET: api/Reservas/5
        [HttpGet("{id}", Name = "GetReserva")]
        public object Get(int id)
        {
            var context = new SalasDeReunionContext();
            var reservas = context.Reservas.Where(r=>r.ReservasId==id).ToList();
            return reservas;
        }

        // POST: api/Reservas
        [HttpPost]
        public void Post([FromBody] Reservas reserva)
        {
            var context = new SalasDeReunionContext();
            context.Reservas.Add(reserva);
            context.SaveChanges();
        }

        // PUT: api/Reservas/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, Reservas reserva)
        {

            if (id != reserva.ReservasId)
            {
                return BadRequest();
            }
            var context = new SalasDeReunionContext();
            context.Entry(reserva).State = EntityState.Modified;

            try
            {
                context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                bool ReservaExists(int id) =>
                context.Reservas.Any(e => e.ReservasId == id);
                if (!ReservaExists(id))
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
            var reserva = context.Reservas.Find(id);
            if (reserva == null)
            {
                return NotFound();
            }

            context.Reservas.Remove(reserva);
            context.SaveChanges();

            return Ok(reserva);
        }
    }
}
