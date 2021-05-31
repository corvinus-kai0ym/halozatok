using HajosTeszt.Italok;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HajosTeszt.Controllers
{
    [Route("api/italok")]
    [ApiController]
    public class ItalController : ControllerBase
    {
        // GET: api/italok
        [HttpGet]
        public IEnumerable<ital.Ital> Get()
        {
            ital.mysqlcorvinusContext context = new ital.mysqlcorvinusContext();

            return context.Itals.ToList();
        }

        // GET api/italok/{id}
        [HttpGet("{id}")]
        public ital.Ital Get(string id)
        {
            ital.mysqlcorvinusContext context = new ital.mysqlcorvinusContext();
            var keresettItal = (from x in context.Itals
                                where x.ItalNev == id
                                select x).FirstOrDefault();
            return keresettItal;
        }

        // POST api/italok
        [HttpPost]
        public void Post([FromBody] ital.Ital ÚjItal)
        {
            ital.mysqlcorvinusContext context = new ital.mysqlcorvinusContext();
            context.Itals.Add(ÚjItal);
            context.SaveChanges();
        }

        // PUT api/italok/count
        [HttpPut("{id}")]
        public int italSzam()
        {
            ital.mysqlcorvinusContext context = new ital.mysqlcorvinusContext();
            int italSzam = context.Itals.Count();
            return italSzam;
        }

        // DELETE api/italok/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            ital.mysqlcorvinusContext context = new ital.mysqlcorvinusContext();
            var törlendőItal = (from x in context.Itals
                                where x.ItalNev == id
                                select x).FirstOrDefault();
            context.Remove(törlendőItal);
            context.SaveChanges();
        }
    }
}
