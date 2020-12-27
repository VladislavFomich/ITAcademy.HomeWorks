using System;
using System.Collections.Generic;
using System.Text;

namespace hm_15
{
  public interface IRepository
    {
        void CreateMotorcycle();
        void GetMotorCycleByID();
        void GetMotorcycles();
        void UpdateMotorycle();
        void DeleteMotorcycle();
    }

    [Serializable]
   public class Motorcycles : IRepository
    {
        public Guid id { get; set; }
        public string Name { get; set;}
        public string Model { get; set; }
        public int Year { get; set; }
        public int Odometer { get; set; }


        public void CreateMotorcycle()
        {
            Console.WriteLine($"Создали мотоцикл") ;
        }
        public void GetMotorCycleByID()
        {
            Console.WriteLine($"Индитификационный номер {id}");
        }
        public void GetMotorcycles()
        {
            Console.WriteLine($"{Name}, {Model}, {Year}, {Odometer}");
        }
        public void UpdateMotorycle() 
        {
            Odometer = +5000;
            Console.WriteLine($"Ездим. Значение одометра равно {Odometer}");
        }
        public void DeleteMotorcycle()
        {
            Console.WriteLine("Заканчиваем поездку");
        }
    }
}
