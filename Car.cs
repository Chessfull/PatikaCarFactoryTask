using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaCarFactoryTask
{
    public class Car
    {
        public DateTime ProductionDate { get; set; }
        public Guid SerialNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int DoorCount { get; set; }

        // ▼ Constructor ▼
        public Car()
        {
            SerialNumber = Guid.NewGuid(); // -> Creating unique serial number with Guid type
            ProductionDate = DateTime.Now; // -> Automatic production date
        }




    }
}
