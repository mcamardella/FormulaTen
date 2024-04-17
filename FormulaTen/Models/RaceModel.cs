using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaTen.Models
{
    public class RaceModel
    {
        [JsonProperty("season")]
        public string Season { get; set; }

        [JsonProperty("round")]
        public string Round { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("raceName")]
        public string RaceName { get; set; }

        [JsonProperty("Circuit")]
        public CircuitModel Circuit { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }
}
