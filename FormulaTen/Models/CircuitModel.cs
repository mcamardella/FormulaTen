using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaTen.Models
{
    public class CircuitModel
    {
        [JsonProperty("circuitId")]
        public string CircuitId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("circuitName")]
        public string CircuitName { get; set; }

        [JsonProperty("Location")]
        public Location Location { get; set; }
    }
}
