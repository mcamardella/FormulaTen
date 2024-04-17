using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaTen.Models
{
    class RootPilotiModel
    {
        [JsonProperty("MRData")]
        public MRDataPilotiModel MRData { get; set; }
    }
}
