using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryShipmentManagement.Logging
{
    public static class Logger
    {
        private static readonly string logFilePath = "A:\\Inventory Shipment Management\\InventoryShipmentManagementV2\\Logging\\LogData.txt";

        public static void Log(string message)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine($"{DateTime.Now}: {message}");
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions if needed 

            }
        }
    }
}
