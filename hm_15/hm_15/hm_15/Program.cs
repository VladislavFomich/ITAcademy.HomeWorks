using System;
using System.Collections.Generic;
using System.Text.Json;

namespace hm_15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Motorcycles> motorcycles = new List<Motorcycles>();
            Motorcycles honda = new Motorcycles();
            motorcycles.Add(honda);
            string json = JsonSerializer.Serialize(honda);
            honda.id = Guid.NewGuid();
            honda.Name = "HONDA";
            honda.Model = "CB500x";
            honda.Year = 2020;
            honda.Odometer = 0;
            honda.CreateMotorcycle();
            honda.GetMotorCycleByID();
            honda.GetMotorcycles();
            honda.UpdateMotorycle();
            honda.DeleteMotorcycle();

        }
    }
}
