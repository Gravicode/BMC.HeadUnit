using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace TestOBD2
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Start OBD2");
            var port = ConfigurationManager.AppSettings["Port"];
            OBD2 obd2 = new OBD2(port);
            obd2.Connect();
            while (true)
            {
                Console.WriteLine("SAMPLE TIME:"+DateTime.Now.ToString());
                Console.WriteLine($"Ambient Air Temp = {obd2.GetAmbientAirTemp()}");
                Console.WriteLine($"Battery Voltage = {obd2.GetBatteryVoltage()}");
                Console.WriteLine($"Engine Coolant Temp = {obd2.GetEngineCoolantTemp()}");
                Console.WriteLine($"Fuel Level = {obd2.GetFuelLevel()}");
                Console.WriteLine($"Intake Air Temp = {obd2.GetIntakeAirTemp()}");
                Console.WriteLine($"Protocol Type = {obd2.GetOBDProtocolType()}");
                Console.WriteLine($"RPM = {obd2.GetRPM()}");
                Console.WriteLine($"Throttle Position = {obd2.GetThrottlePosition()}");
                Console.WriteLine($"Vehicle Fuel Type = {obd2.GetVehicleFuelType()}");
                Console.WriteLine($"Vehicle Speed = {obd2.GetVehicleSpeed()}");
                Console.WriteLine($"VIN = {obd2.GetVIN()}");
                Thread.Sleep(2000);
            }
        }
    }
}
