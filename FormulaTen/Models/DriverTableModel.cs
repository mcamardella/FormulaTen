using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaTen.Models
{
    public class DriverTableModel
    {
        [JsonProperty("season")]
        public string Season { get; set; }

        [JsonProperty("Drivers")]
        public List<DriverModel> Drivers { get; set; }
    }
}
