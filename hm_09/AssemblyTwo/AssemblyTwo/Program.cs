using System;
using AssemblyOne;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle newBike = new Motorcycle();
            //Internal
            //newBike._maxSpeed = 300;
            newBike.MaxSpeed = 300;
            //Ptivate
            //newBike.MaxSpeedPublicPrivate = 100;
            //Protected
            //newBike.MaxSpeedPublicProtected = 150;
            //Protected Internal
            //newBike.StartEnginePI();
            //Private Protected
            // newBike.StartEnginePP();
        }
    }

    internal class SportBike : Motorcycle
    {
        void StartEngine()
        {
            SportBike honda = new SportBike();
            honda.MaxSpeedPublicProtected = 100;
        }
    }
}
