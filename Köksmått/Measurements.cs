using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Köksmått
{
    class Measurements

    {

        public static Dictionary<string, double> measureList = new Dictionary<string, double>();

        public static void InitializeMeasurements()
        {
            measureList.Add("liter", 1000);
            measureList.Add("deciliter", 100);
            measureList.Add("centiliter", 10);
            measureList.Add("matsked", 15);
            measureList.Add("tesked", 5);
            measureList.Add("kryddmått", 1);
            measureList.Add("ukgallon", 4500);
            measureList.Add("ukpint", 570);
            measureList.Add("ukcup", 280);
            measureList.Add("ukfluid ounce", 28);
            measureList.Add("uktablespoon", 15);
            measureList.Add("ukteaspoon", 5);
            measureList.Add("usgallon", 3800);
            measureList.Add("usquart", 950);
            measureList.Add("uspint", 470);
            measureList.Add("uscup", 240);
            measureList.Add("usfluid ounce", 30);
        }


        public static void Calculate(string i, string j, double amount)
        {
            double sum = measureList[i] * amount / measureList[j];
            //Console.WriteLine("Att konvertera {0} st {1} till {2} resulterar i {3} st {4}", amount, i, j, amount);
            
            Console.WriteLine(sum + " " + j);

            RunAgain();
            
          
        }

        public static void header() //metoden för headline
        {
            Console.Clear();
            Console.WriteLine("Kökskonverteraren");
            Console.WriteLine("--------------------------\n");

        }

        public static void RunAgain()
        {
            int menu = 0;
            Console.WriteLine("Tryck 1 för att göra en till konvertering.. OBS, raderar all text.");
            Console.WriteLine("Tryck 2 för att avsluta programmet..");

            menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Startmenu.StartProgram();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
                  
            }
        }

    }
}
