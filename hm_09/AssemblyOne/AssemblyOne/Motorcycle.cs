using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    public class Motorcycle
    {
       internal ushort _maxSpeed;
       public ushort MaxSpeed { get; set; }          
       private ushort MaxSpeedPrivate;
       protected ushort MaxSpeedPublicProtected;
           
      protected internal void StartEnginePI()
      {

      }

      private protected void StartEnginePP()
      {

      }

        void StartEngine()
        {
            Motorcycle oldBike = new Motorcycle();
            oldBike.MaxSpeedPrivate = 100;
        }       
    }    
}
