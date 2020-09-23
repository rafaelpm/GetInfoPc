using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace GetSerialNumber
{
    class Program{

        static void Main(string[] args)
        {
            string cpuInfo = string.Empty;
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                foreach(PropertyData pdc in mo.Properties)
                {
                    Console.WriteLine(pdc.Name+": "+pdc.Value);
                }
                //cpuInfo = mo.Properties["processorID"].Value.ToString();
                break;
            }
        }
    }
}
