using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaTen.Models
{
    class RootGareModel
    {
        [JsonProperty("MRData")]
        public MRDataGareModel MRData { get; set; }
    }
}
