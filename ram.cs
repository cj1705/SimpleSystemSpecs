using System;
using System.Collections.Generic;
using System.Management;
using System.Windows.Forms;

public class ram
{
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public string Capacity { get; set; }
    public string Speed { get; set; }
    public static Dictionary<string, string> Codes = new Dictionary<string, string>
    {

        {"AD", "Adesto Technologies"},
        {"C8", "Micron Technology"},
        {"D5", "Hynix Semiconductor"},
        {"2C", "Micron Technology"},
        {"7F", "Spansion Inc."},
        {"20", "STMicroelectronics"},
        {"1F", "Cypress Semiconductor"},
        {"BF", "SST Semiconductor"},
        {"EF", "Winbond"},
        {"98", "Intel Corporation"},
        {"DA", "Renesas Electronics Corporation"},
        {"1C", "Inotera Memories"},
        {"B0", "Samsung Semiconductor"},
        {"62", "Hewlett Packard Enterprise"},
        {"C2", "SanDisk Corporation"},
        {"9D", "Toshiba America Electronic Components"},
        {"CE", "Powerchip Semiconductor Corporation"},
        {"F2", "Elpida Memory"},
        {"A6", "Rambus Inc."},
        {"23", "Nanya Technology Corporation"},
        {"A3", "PMC-Sierra Inc."},
        {"07", "Numonyx Corporation"},
        {"B5", "Fujitsu"},
        {"B8", "Zentel Electronics Corporation"},
        {"85", "National Semiconductor Corporation"},
        {"CB", "Silicon Storage Technology, Inc."},
        {"5C", "Qimonda"},
        {"B6", "Promos Technologies Inc."},
        {"45", "Kingston Technology Company"},
        {"38", "On Semiconductor"},
        {"0B", "Everspin Technologies"},
        {"F8", "Micron Semiconductor Asia Operations"},
        {"A9", "Nanya Technology Corporation"},
        {"18", "Toshiba Corporation"},
        {"A2", "Silicon Integrated Systems Corporation"},
        {"69", "IDT"},
        {"D2", "Micron Technology"},
        {"95", "Texas Instruments"},
        {"4F", "NXP Semiconductors"},
        {"C4", "Cato"},
        {"5B", "Hynix Semiconductor"},
        {"C0", "Super Talent"},
        {"92", "Hewlett Packard"},
        {"9C", "NXP Semiconductors"},
        {"96", "Toshiba Corporation"},
        {"9E", "Kingston Technology Company"},
        {"25", "Cypress Semiconductor"},
        {"AB", "SK Hynix"},
        {"88", "Elpida Memory"},
        {"F3", "Atmel Corporation"},
        {"B3", "NXP Semiconductors"},
        {"AA", "Micron Technology"},
        {"8C", "Netlist Inc."},
        {"BA", "Advantest Corporation"},
        {"D9", "NXP Semiconductors"},
        {"6B", "SanDisk Corporation"},
        {"04", "Samsung Semiconductor"},
        {"0D", "Integrated Silicon Solution, Inc."},
        {"09", "Intel Corporation"},
        {"CD", "G Skill Intl"}
    };

    public ram()
    {

        // Use a ManagementObjectSearcher to get information about the system's RAM
        ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");

        foreach (ManagementObject mo in searcher.Get())
        {

            // Get the manufacturer and model of the RAM
           
                string code = mo["Manufacturer"].ToString().Substring(mo["Manufacturer"].ToString().Length - 2);
                  if (Codes.ContainsKey(code)){

                    this.Manufacturer = Codes[code];
                    }
                    else
                    {
                    this.Manufacturer = mo["Manufacturer"].ToString();
                    
             
                
               
                
            }

            this.Model = mo["PartNumber"].ToString();

            // Get the capacity and speed of the RAM
            const int KB_IN_GB = 1024 * 1024;
            long math1 = Int64.Parse(mo["Capacity"].ToString()) / KB_IN_GB;

            this.Speed = mo["Speed"].ToString();
             searcher = new ManagementObjectSearcher("SELECT Capacity FROM Win32_PhysicalMemory");
            int memorySticks = 0;
            foreach (ManagementObject obj in searcher.Get())
            {
                memorySticks++;
            }
            this.Capacity = math1.ToString() + "MB " + $"(x{memorySticks})";

        }
    }

}
