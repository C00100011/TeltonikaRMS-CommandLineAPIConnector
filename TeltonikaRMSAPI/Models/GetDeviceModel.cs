using System.Collections.Generic;

namespace TeltonikaRMSAPI.Classes.GetDeviceModel
{
        public class Datum    {
        public int id { get; set; } 
        public int company_id { get; set; } 
        public string model { get; set; } 
        public string original_model { get; set; } 
        public string name { get; set; } 
        public string description { get; set; } 
        public string serial { get; set; } 
        public string mac { get; set; } 
        public string wlan_mac { get; set; } 
        public int mqtt { get; set; } 
        public int dynamic_monitoring { get; set; } 
        public int static_monitoring { get; set; } 
        public int io_monitoring { get; set; } 
        public int gps_monitoring { get; set; } 
        public int hotspot_monitoring { get; set; } 
        public int speedtest_monitoring { get; set; } 
        public int wireless_monitoring { get; set; } 
        public string last_connection_at { get; set; } 
        public string activation_status { get; set; } 
        public int is_facelift { get; set; } 
        public string created_at { get; set; } 
        public string updated_at { get; set; } 
        public int status { get; set; } 
        public int credit_enabled { get; set; } 
        public int credit_activated { get; set; } 
        public string credit_expire_date { get; set; } 
        public int monitoring_enabled { get; set; } 
        public int auto_extend_credit { get; set; } 
        public string company_name { get; set; } 
        public int temperature { get; set; } 
        public int signal { get; set; } 
        public string firmware { get; set; } 
        public string bootloader_version { get; set; } 
        public string cell_id { get; set; } 
        public string connection_type { get; set; } 
        public string connection_state { get; set; } 
        public object connection_uptime { get; set; } 
        public string iccid { get; set; } 
        public string lac { get; set; } 
        public string mcc { get; set; } 
        public string mnc { get; set; } 
        public int sim_slot { get; set; } 
        public string sim_state { get; set; } 
        public string pin_state { get; set; } 
        public string @operator { get; set; } 
        public string operator_number { get; set; } 
        public int router_uptime { get; set; } 
        public string wan_state { get; set; } 
        public string wan_ip { get; set; } 
        public string mobile_ip { get; set; } 
        public string network_state { get; set; } 
        public int sent { get; set; } 
        public long received { get; set; } 
        public object rscp { get; set; } 
        public object ecio { get; set; } 
        public object rsrp { get; set; } 
        public object sinr { get; set; } 
        public object rsrq { get; set; } 
        public string imei { get; set; } 
        public string batch_number { get; set; } 
        public string product_code { get; set; } 
        public string modem_manufacturer { get; set; } 
        public string modem_model { get; set; } 
        public string modem_firmware { get; set; } 
        public string hardware_revision { get; set; } 
        public string imsi { get; set; } 
        public object digital_input { get; set; } 
        public object digital_isolated_input { get; set; } 
        public object analog_input { get; set; } 
        public object open_collector_output { get; set; } 
        public object relay_output { get; set; } 
        public object oc_output_cfg { get; set; } 
        public object relay_output_cfg { get; set; } 
        public object fix_status { get; set; } 
        public object satellites { get; set; } 
        public object latitude { get; set; } 
        public object longitude { get; set; } 
        public object speed { get; set; } 
        public object course { get; set; } 
        public object gps_time { get; set; } 
        public object accuracy { get; set; } 
        public double user_set_latitude { get; set; } 
        public double user_set_longitude { get; set; } 
        public double cell_tower_latitude { get; set; } 
        public double cell_tower_longitude { get; set; } 
        public int cell_tower_accuracy { get; set; } 
        public string last_update_at { get; set; } 
        public string credit_type { get; set; } 
        public List<object> tags { get; set; } 
    }

    public class Sorters    {
        public string id { get; set; } 
    }

    public class Meta    {
        public Sorters sorters { get; set; } 
        public int total { get; set; } 
    }

    public class Root    {
        public bool success { get; set; } 
        public List<Datum> data { get; set; } 
        public Meta meta { get; set; } 
    }


}