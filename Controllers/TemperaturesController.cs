using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemperatureDataAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TemperatureDataAPI.Controllers
{
    [Route("api/[controller]")]
    public class TemperaturesController : ControllerBase
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /*
        // GET api/<controller>/5
        [HttpGet("{id}&{query}")]
        public ActionResult Get(int id, string query)
        {            
            return new JsonResult(query);
        }
        */

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
