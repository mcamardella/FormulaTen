using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FormulaTen.Models
{
    class MRDataGareModel
    {
        [JsonProperty("xmlns")]
        public string Xmlns { get; set; }

        [JsonProperty("series")]
        public string Series { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("limit")]
        public string Limit { get; set; }

        [JsonProperty("offset")]
        public string Offset { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("RaceTable")]
        public RaceTableModel RaceTable { get; set; }
    }
}
