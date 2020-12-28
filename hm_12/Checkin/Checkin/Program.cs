using System;

namespace Checkin
{
    class Program
    {
        static void Main(string[] args)
        {
            Registration registration = new Registration();
            registration.Greeting();

            registration.Adressname();
            registration.Process();
            Inspection inspection = new Inspection();
            inspection.Inspector();
            PassportControl passportControl = new PassportControl();
            passportControl.Over();
        }
    }
}
