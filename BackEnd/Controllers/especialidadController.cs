using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.Context;
using BackEnd.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Controllers
{
    [Route("especialidad")]
    [ApiController]
    public class especialidadController : ControllerBase
    {

        private readonly AppDbContext context;

        public especialidadController(AppDbContext context)
        {
            this.context = context;
        }
        // GET: api/especialidad
        [HttpGet]
        public IEnumerable<fespecialidad> Get()
        {
            return context.fespecialidad.ToList();
        }

        // GET: api/especialidad/5
        [HttpGet("{id}", Name = "GetEspecialidad")]
        public fespecialidad Get(String id)
        {
            var fespecialidad = context.fespecialidad.FirstOrDefault(p => p.id == id);
            return fespecialidad;
        }

        // POST: api/especialidad
        [HttpPost]
        public ActionResult Post([FromBody] fespecialidad fespecialidad)
        {
            try
            {
                context.fespecialidad.Add(fespecialidad);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest();
            }
        }

        // PUT: api/especialidad/5
        [HttpPut("{id}")]
        public ActionResult Put(String id, [FromBody] fespecialidad fespecialidad)
        {
            if (fespecialidad.id == id)
            {
                context.Entry(fespecialidad).State = EntityState.Modified;
                context.SaveChanges();
                return Ok();
            }
            else
                return BadRequest();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(String id)
        {
            var fespecialidad = context.fespecialidad.FirstOrDefault(p => p.id == id);
            if (fespecialidad != null)
            {
                context.fespecialidad.Remove(fespecialidad);
                context.SaveChanges();
                return Ok();
            }
            else
                return BadRequest();
        }
    }
}
