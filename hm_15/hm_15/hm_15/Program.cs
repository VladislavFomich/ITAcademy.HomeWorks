using System;
using System.Collections.Generic;
using System.Text.Json;
using Serilog;

namespace hm_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                 .MinimumLevel.Debug()
                 .WriteTo.Console()
                 .WriteTo.File("logs\\myapp.txt", rollingInterval: RollingInterval.Day)
                 .CreateLogger();
            Log.Information("namespace hm_15");
            
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
            Log.Debug("Создан мотоцикл");           
            honda.GetMotorCycleByID();
            honda.GetMotorcycles();
            Log.Debug("Получили данные");
            honda.UpdateMotorycle();
            Log.Debug("Обновили");
            honda.DeleteMotorcycle();
            Log.Debug("Удалили");
        }
    }
}
