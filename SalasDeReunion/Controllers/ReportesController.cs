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
    public class ReportesController : ControllerBase
    {

        // GET: api/Reportes/5
        [HttpGet(Name = "GetReportes")]
        public object Get(DateTime horainicio, DateTime horafin)
        {
           
            if (horainicio == DateTime.MinValue)
            {
                horainicio = DateTime.Today.AddYears(-1);
            }
            if (horafin == DateTime.MinValue)
            {
                horafin = DateTime.Today;
            }
            var context = new SalasDeReunionContext();
            var reservas = context.Reservas.Where(s => s.HoraInicio >= horainicio && s.HoraFin <= horafin).ToList();
            return reservas;
        }

        // POST: api/Reportes
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Reportes/5
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
