using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace SImpleSystemSpecs
{
    public class gpu
    {
       
      
            public string Name { get; set; }
            public string MemorySize { get; set; }
            public string DriverVersion { get; set; }

            public gpu()
            {
                var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
                var results = searcher.Get();

                foreach (var result in results)
                {
                    Name = result["Name"].ToString();
                const int KB_IN_GB = 1024 * 1024;
                long math1 = Int64.Parse(result["AdapterRAM"].ToString()) / KB_IN_GB;
                MemorySize = math1.ToString() + " MB";
                DriverVersion = result["DriverVersion"].ToString();
                }
            }
        }
    }



