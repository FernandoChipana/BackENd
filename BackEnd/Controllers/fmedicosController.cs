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
    [Route("fmedicos")]
    [ApiController]
    public class fmedicosController : ControllerBase
    {
        private readonly AppDbContext context;

        public fmedicosController(AppDbContext context)
        {
            this.context = context;
        }
        // GET: api/fmedicos
        [HttpGet]
        public IEnumerable<fmedicos> Get()
        {
            return context.FMEDICOS.ToList();
        }

        // GET: api/fmedicos/5
       [HttpGet("{cmp}", Name = "Get")]
        public fmedicos Get(String cmp)
        {
            var fmedicos = context.FMEDICOS.FirstOrDefault(p=>p.cmp==cmp);
            return fmedicos;
        }

        // POST: api/fmedicos
        [HttpPost]
        public ActionResult Post([FromBody] fmedicos fmedicos)
        {
            try
            {
                context.FMEDICOS.Add(fmedicos);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest();
            }
            
        }

        // PUT: api/fmedicos/5
        [HttpPut("{cmp}")]
        public ActionResult Put(String cmp, [FromBody] fmedicos fmedicos)
        {
            
                if (fmedicos.cmp==cmp)
                {
                    context.Entry(fmedicos).State = EntityState.Modified;
                    context.SaveChanges();
                    return Ok();
                }
                else
                    return BadRequest();
            
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("/delete/{cmp}")]
        public ActionResult Delete(String cmp)
        {
            var fmedicos = context.FMEDICOS.FirstOrDefault(p => p.cmp == cmp);
            if (fmedicos!= null)
            {
                context.FMEDICOS.Remove(fmedicos);
                context.SaveChanges();
                return Ok();
            }
            else
                return BadRequest();
        }
    }
    
    
}
