using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemperatureDataAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.IO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TemperatureDataAPI.Controllers
{
    [Route("api/[controller]")]
    public class TemperaturesController : ControllerBase
    {
        // GET: api/<controller>
        [HttpGet]
        public Temperature Get()
        {
            return getData();
        }

        private Temperature getData()
        {
            string line;
            Temperature temp = new Temperature();
            StreamReader file = new StreamReader(Startup.file_path);
            line = file.ReadLine();
            file.Close();
            string[] paramet = line.Split('~');
            temp.pressure = float.Parse(paramet[0]);
            temp.seaLevelPressure = float.Parse(paramet[1]);
            temp.calculatedAltitude = float.Parse(paramet[2]);
            temp.temperature = float.Parse(paramet[3]);

            return temp;
        }
        
        // GET api/<controller>/5
        [HttpGet("{field}")]
        public ActionResult<string> Get(int field)
        {
            string line;
            Temperature temp = new Temperature();
            StreamReader file = new StreamReader(Startup.file_path);
            line = file.ReadLine();
            file.Close();
            string[] paramet = line.Split('~');
            temp.pressure = float.Parse(paramet[0]);
            temp.seaLevelPressure = float.Parse(paramet[1]);
            temp.calculatedAltitude = float.Parse(paramet[2]);
            temp.temperature = float.Parse(paramet[3]);

            switch (field)
            {
                case 1: return "Pressure is: " + temp.pressure;
                case 2: return "Sea Level Pressure is: " + temp.seaLevelPressure;
                case 3: return "Calculated Altitude is: " + temp.calculatedAltitude;
                case 4: return "Temperature is: " + temp.temperature;
                default: return "Temperature Object Returns: " + "Pressure: " +
                        temp.pressure + " Sea Level Pressure: " +
                        temp.seaLevelPressure + " Calculated Altitude: " +
                        temp.calculatedAltitude + " Temperature is: " +
                        temp.temperature ;
            }
        }
        

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
