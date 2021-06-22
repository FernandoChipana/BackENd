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
    [Route("clientes")]
    [ApiController]
    public class clientesController : ControllerBase
    {
        private readonly AppDbContext context;

        public clientesController(AppDbContext context)
        {
            this.context = context;
        }
       
        [HttpGet]
        public IEnumerable<fmclinic> Get()
        {
            return context.fmclinic.ToList();
        }

       
        [HttpGet("{codc}", Name = "GetClientes")]
        public fmclinic Get(int codc)
        {
            var fclientes = context.fmclinic.FirstOrDefault(p => p.codc == codc);
            return fclientes;
        }

       
        [HttpPost]
        public ActionResult Post([FromBody] fmclinic fclientes)
        {

            try
            {
                context.fmclinic.Add(fclientes);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest();
            }
        }

      
        [HttpPut("{codc}")]
        public ActionResult Put(int codc, [FromBody] fmclinic fclientes)
        {

            if (fclientes.codc == codc)
            {
                context.Entry(fclientes).State = EntityState.Modified;
                context.SaveChanges();
                return Ok();
            }
            else
                return BadRequest();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{codc}")]
        public ActionResult Delete(int codc)
        {
            var fclientes = context.fmclinic.FirstOrDefault(p => p.codc == codc);
            if (fclientes != null)
            {
                context.fmclinic.Remove(fclientes);
                context.SaveChanges();
                return Ok();
            }
            else
                return BadRequest();
        }
    }
}
