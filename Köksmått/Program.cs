using System;

namespace Köksmått
{
    class Program
    {

        static void Main(string[] args)
        {

            Measurements.InitializeMeasurements();
            Startmenu.StartProgram();
            Measurements.header();
        }
    }
}