using System.Collections.Generic;

namespace TeltonikaRMSAPI.Classes.GetActiveRMSEndpoints
{
    public class Datum    {
        public int id { get; set; } 
        public int device_id { get; set; } 
        public string name { get; set; } 
        public string destination_ip { get; set; } 
        public string destination_port { get; set; } 
        public string protocol { get; set; } 
        public int company_id { get; set; } 
        public int is_main { get; set; } 
        public int credentials_required { get; set; } 
        public int mqtt { get; set; } 
        public string device_name { get; set; } 
        public string device_description { get; set; } 
        public string device_model { get; set; } 
        public string company_name { get; set; } 
        public string created_at { get; set; } 
        public List<object> tags { get; set; } 
    }

    public class Sorters    {
        public string id { get; set; } 
    }

    public class Filters    {
        public List<string> device_id { get; set; } 
    }

    public class Meta    {
        public Sorters sorters { get; set; } 
        public Filters filters { get; set; } 
        public int total { get; set; } 
    }

    public class Root    {
        public bool success { get; set; } 
        public List<Datum> data { get; set; } 
        public Meta meta { get; set; } 
    }

}