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
    [Route("turnos")]
    [ApiController]
    
    public class turnosController : ControllerBase
    {
        private readonly AppDbContext context;
        public turnosController(AppDbContext context)
        {
            this.context = context;
        }
        // GET: api/turnos
        [HttpGet]
        public IEnumerable<turnos> Get()
        {
            return context.turnos.ToList();
        }

        // GET: api/turnos/5
        [HttpGet("{id}", Name = "GetTurnos")]
        public turnos Get(String id)
        {
            var turnos = context.turnos.FirstOrDefault(p => p.id == id);
            return turnos;
        }

        // POST: api/turnos
        [HttpPost]
        public ActionResult Post([FromBody] turnos turnos)
        {
            try
            {
                context.turnos.Add(turnos);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest();
            }
        }

        // PUT: api/turnos/5
        [HttpPut("{id}")]
        public ActionResult Put(String id, [FromBody] turnos turnos)
        {
            if (turnos.id == id)
            {
                context.Entry(turnos).State = EntityState.Modified;
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
            var turnos = context.turnos.FirstOrDefault(p => p.id == id);
            if (turnos != null)
            {
                context.turnos.Remove(turnos);
                context.SaveChanges();
                return Ok();
            }
            else
                return BadRequest();
        }
    }
}
