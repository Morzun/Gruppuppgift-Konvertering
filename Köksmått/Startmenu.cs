using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Köksmått
{
    class Startmenu
    {
        public static void StartProgram()
        {
            int menu = 0;
            bool isInvalidInput = false;

            do
            {
                Console.WriteLine("Hej och välkommen till denna konverterare för köksmått!");
                Console.WriteLine("Tryck 1 för att konvertera svenska mått.");
                Console.WriteLine("Tryck 2 för att konvertera brittiska mått");
                Console.WriteLine("Tryck 3 för att konvertera amerikanska mått.");
                Console.WriteLine("Tryck 4 för att avsluta programmet.");

                try
                {
                    menu = int.Parse(Console.ReadLine());
                    isInvalidInput = false;
                    break;
                }

                catch
                {
                    Console.WriteLine("Det var inte en korrekt input, försök igen..");
                    isInvalidInput = true;
                }

            } while (isInvalidInput);

            switch (menu)
            {
                case 1:
                    Swedish.SwedishMeasurments();
                    break;

                case 2:
                    //BrittishMeasurments();
                    break;

                case 3:
                    American.AmericanMeasurments();
                    break;
                case 4:
                    break;
            }
        }


    }

    }

