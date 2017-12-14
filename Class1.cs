using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace Cummins_Final_Project
{
    public class FaultData
    {
        public string FaultCode { get; set; }
        public string TimeSummary { get; set; }
        public string RunTime { get; set; }
        public string ESN   { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public string Detected { get; set; }
    }

    //[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public class ItemInfo
    {

        [JsonProperty("ID")]
        public int ID { get; set; }

        [JsonProperty("ParentID")]
        public int ParentID { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("question")]
        public string Question { get; set; }

        //[JsonProperty("children")]
        //public string children { get; set; }

    }




        


}
