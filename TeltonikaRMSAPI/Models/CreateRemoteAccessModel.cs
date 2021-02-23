namespace TeltonikaRMSAPI.Classes.CreateRemoteAccessModel
{
    public class Data    {
        public int device_id { get; set; } 
        public string name { get; set; } 
        public string destination_ip { get; set; } 
        public int destination_port { get; set; } 
        public bool rms_access { get; set; } 
        public int src_port { get; set; } 
        public string protocol { get; set; } 
        public bool credentials_required { get; set; } 
    }

    public class Root    {
        public Data data { get; set; } 
    }



}