using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace SImpleSystemSpecs
{
    public class cpu
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string MaxClockSpeed { get; set; }
        public string NumberOfCores { get; set; }
        public string L2CacheSize { get; set; }
        public string L3CacheSize { get; set; }
        public string LogicalProcessors { get; set; }

        public cpu()
        {
            // Create a new ManagementObjectSearcher to search for the
            // CPU information.
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");

            // Iterate over the search results and set the properties
            // of this CpuInfo instance.
            foreach (ManagementObject obj in searcher.Get())
            {
                this.Name = obj["Name"] as string;
                this.Manufacturer = obj["Manufacturer"] as string;
                this.MaxClockSpeed = obj["MaxClockSpeed"] as string;
                this.L2CacheSize = obj["L2CacheSize"] as string;
                this.L3CacheSize = obj["L3CacheSize"] as string;
            }
            int coreCount = 0;
            foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_Processor").Get())
            {
                coreCount += int.Parse(item["NumberOfCores"].ToString());
            }
            NumberOfCores = coreCount.ToString();
            foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_ComputerSystem").Get())
            {
                LogicalProcessors = item["NumberOfLogicalProcessors"].ToString();
            }
            searcher = new ManagementObjectSearcher("SELECT L2CacheSize, L3CacheSize FROM Win32_Processor");
            var results = searcher.Get();

            foreach (var result in results)
            {
                this.L2CacheSize = result["L2CacheSize"].ToString() + "MB";
               this.L3CacheSize = result["L3CacheSize"].ToString() + "MB";
            }

            }
    }
}
