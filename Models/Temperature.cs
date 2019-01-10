using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemperatureDataAPI.Models
{
    public class Temperature
    {
        public int id { set; get; }
        public float pressure { set; get; }
        public float seaLevelPressure { set; get; }
        public float calculatedAltitude { set; get; }
        public float temperature { set; get; }
        public Temperature()
        {
            id++;
        }
    }
}
