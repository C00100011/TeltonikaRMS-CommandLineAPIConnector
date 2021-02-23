using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TeltonikaRMSAPI.Classes.GetDeviceModel;

namespace TeltonikaRMSAPI
{
    public class Devices
    {
        public string token;
        public async Task<TeltonikaRMSAPI.Classes.GetDeviceModel.Root> GetDevices()
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization 
                = new AuthenticationHeaderValue("Bearer", token);
            var result = await client.GetAsync("https://rms.teltonika-networks.com/api/devices?limit=10");
            var resultAsString = result.Content.ReadAsStringAsync().Result;
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(resultAsString);
            return myDeserializedClass;

        }

        public async Task<Classes.GetActiveRMSEndpoints.Root> GetAllConfiguredRMSEndpoints(int device_id)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization 
                = new AuthenticationHeaderValue("Bearer", token);
            var result = await client.GetAsync(String.Format("https://rms.teltonika-networks.com/api/devices/remote-access?device_id={0}",device_id));
            var resultAsString = result.Content.ReadAsStringAsync().Result;
            TeltonikaRMSAPI.Classes.GetActiveRMSEndpoints.Root myDeserializedClass = JsonConvert.DeserializeObject<TeltonikaRMSAPI.Classes.GetActiveRMSEndpoints.Root>(resultAsString);
            return myDeserializedClass;
        }

        public async Task CreateRemoteAccessLink(int accessid, int duration)
        {
            var durationpayload = new TeltonikaRMSAPI.Classes.PostDeviceLink.Root();
            durationpayload.duration = duration;
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization 
                = new AuthenticationHeaderValue("Bearer", token);
            var json = JsonConvert.SerializeObject(durationpayload);
            var content = new StringContent(json.ToString(), Encoding.UTF8, "application/json");
            var result = await client.PostAsync(String.Format("https://rms.teltonika-networks.com/api/devices/connect/{0}",accessid),content);
            var resultAsString = result.Content.ReadAsStringAsync().Result;
        }

        public async Task<Classes.GetRMSLinkModel.Root> GetLiveLink(int accessid)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization 
                = new AuthenticationHeaderValue("Bearer", token);
            var result = await client.GetAsync(String.Format("https://rms.teltonika-networks.com/api/devices/connect/{0}/sessions?active=true",accessid));
            var resultAsString = result.Content.ReadAsStringAsync().Result;
            TeltonikaRMSAPI.Classes.GetRMSLinkModel.Root myDeserializedClass = JsonConvert.DeserializeObject<TeltonikaRMSAPI.Classes.GetRMSLinkModel.Root>(resultAsString);
            return myDeserializedClass;
        }
    }
}