using System.Collections.Generic;

namespace TeltonikaRMSAPI.Classes.GetRMSLinkModel
{
    public class Datum    {
        public int id { get; set; } 
        public int start_time { get; set; } 
        public int end_time { get; set; } 
        public int? input_data { get; set; } 
        public int? output_data { get; set; } 
        public object username { get; set; } 
        public string email { get; set; } 
        public int company_id { get; set; } 
        public string company_name { get; set; } 
        public string url { get; set; } 
        public int ttl { get; set; } 
    }

    public class Filters    {
        public List<string> active { get; set; } 
    }

    public class Sorters    {
        public string id { get; set; } 
    }

    public class Meta    {
        public Filters filters { get; set; } 
        public Sorters sorters { get; set; } 
        public int total { get; set; } 
    }

    public class Root    {
        public bool success { get; set; } 
        public List<Datum> data { get; set; } 
        public Meta meta { get; set; } 
    }

}