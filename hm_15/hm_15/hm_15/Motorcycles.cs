using System;
using System.Collections.Generic;
using System.Text;

namespace hm_15
{
    interface IRepository<T> : IDisposable
    {
        public void CreateMotorcycle(T item) { }
        public void GetMotorCycleByID(int id) { }
        public void GetMotorcycles(string Name, string Model, int Year) { }       
        public void UpdateMotorycle(T item) { }
        public void DeleteMotorcycle(int id) { }
    }
    class Motorcycles 
    {
        public Guid id { get; set; }
        public string Name { get; set;}
        public string Model { get; set; }
        public int Year { get; set; }
        public int Odometer { get; set; }
       
        
    }
}
