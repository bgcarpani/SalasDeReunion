using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalasDeReunion.Models;

namespace SalasDeReunion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeleccionDeSalaController : ControllerBase
    {
        // GET: api/SeleccionDeSala
        [HttpGet]
        public IEnumerable<object> Get()
        {
            var context = new SalasDeReunionContext();
            var salas = context.Salas.ToList();
            return salas;
        }

        // GET: api/SeleccionDeSala/5
        [HttpGet("{capacidad}", Name = "GetSeleccion")]
        public object Get(int capacidad, bool proyector, bool pizarra, bool accesoInet)
        {
            var context = new SalasDeReunionContext();
            var salas = context.Salas.Where(s => (s.Proyector == proyector) && (s.Pizarra==pizarra) && (s.AccesoInet==accesoInet) && (s.Capacidad >= capacidad)).ToList();
            return salas;
        }

        // POST: api/SeleccionDeSala
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/SeleccionDeSala/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
