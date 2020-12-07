using System;


namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle newBike = new Motorcycle();
            newBike._maxSpeed = 300;
            newBike.MaxSpeed = 300;
            //Ptivate
            //newBike.MaxSpeedPrivate = 100;
            //Protected
            //newBike.MaxSpeedPublicProtected = 150;
            newBike.StartEnginePI();
            //Private Protected
            //newBike.StartEnginePP();
        }
    }

    internal class SportBike : Motorcycle
    {
        void StartEngine()
        {
            SportBike honda = new SportBike();
            honda.StartEnginePP();
        }
    }
}
