using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TeltonikaRemote
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var cl = new TeltonikaRMSAPI.Devices();
            cl.token = "Example Token";
            switch (args[0])
            {
                case "1":
                    Console.WriteLine("Get all devices");
                    var list = new List<int>();
                    var te = await cl.GetDevices();
                    foreach (var dev in te.data)
                    {
                        list.Add(dev.id);
                        Console.WriteLine(String.Format("Devicename : {0} and DeviceID {1}",dev.name,dev.id));
                    }
                    break;
                case "2":
                    Console.WriteLine("Get current live link");
                    Console.WriteLine("What is the device ID");
                    var devid = Console.ReadLine();
                    Console.WriteLine("What is the name of the RMS Access service");
                    var rmsname = Console.ReadLine();
                    var id = Int32.Parse(devid);
                    var RMSEndpoints = await cl.GetAllConfiguredRMSEndpoints(id);
                    foreach (var RMSEndpoint in RMSEndpoints.data)
                    {
                        if (RMSEndpoint.name == rmsname)
                        {
                            Console.WriteLine(String.Format("The access id is {0}",RMSEndpoint.id));
                            //await cl.CreateRemoteAccessLink(rms.id, 100);
                            var tod = await cl.GetLiveLink(RMSEndpoint.id);
                            foreach (var link in tod.data)
                            {
                                Console.WriteLine(link.url);
                            }
                        }
                    }
                    break;
                case "3":
                    Console.WriteLine("Create a live link");
                    Console.WriteLine("What is the access id");
                    var devid1 = Console.ReadLine();
                    var id1 = Int32.Parse(devid1);
                    Console.WriteLine("How many seconds should it live");
                    var dura = Console.ReadLine();
                    var dur1 = Int32.Parse(dura);
                    await cl.CreateRemoteAccessLink(id1, dur1);
                    Console.WriteLine("Created!");
                    break;
                    
            }
        }
    }
}