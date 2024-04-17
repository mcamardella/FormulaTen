using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaTen.Models
{
    public class RaceTableModel
    {
        [JsonProperty("season")]
        public string Season { get; set; }

        [JsonProperty("Races")]
        public List<RaceModel> Races { get; set; }
    }
}
