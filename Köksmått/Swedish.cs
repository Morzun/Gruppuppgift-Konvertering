using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Köksmått
{
    class Swedish
    {


        public static void SwedishMeasurments()
        {
            Measurements.header();

            int menu = 0;
            bool isInvalidInput = false;
            string choice = "0";
            string choice2 = "0";
            double quantity = 0;

            do
            {
                Measurements.header();
                Console.WriteLine("Var vänlig och välj vilket mått det är du vill konvertera!");
                Console.WriteLine("Tryck 1 för att konvertera liter.");
                Console.WriteLine("Tryck 2 för att konvertera deciliter.");
                Console.WriteLine("Tryck 3 för att konvertera centiliter.");
                Console.WriteLine("Tryck 4 för att konvertera en matsked.");
                Console.WriteLine("Tryck 5 för att konvertera en tesked.");
                Console.WriteLine("Tryck 6 för att konvertera ett kryddmått.");
                Console.WriteLine("Tryck 7 för att återgå till startmenyn..");



                try
                {
                    menu = int.Parse(Console.ReadLine());
                    isInvalidInput = false;
                    break;
                }

                catch
                {
                    Measurements.header();
                    Console.WriteLine("Det var inte en korrekt input, försök igen..");
                    isInvalidInput = true;
                }

            } while (isInvalidInput);

            switch (menu)
            {
                case 1:
                    choice = "liter";
                    break;

                case 2:
                    choice = "deciliter";
                    break;

                case 3:
                    choice = "centiliter";
                    break;
                case 4:
                    choice = "matsked";
                    break;
                case 5:
                    choice = "tesked";
                    break;
                case 6:
                    choice = "kryddmått";
                    break;
                case 7:
                    Startmenu.StartProgram();
                    break;

            }
            Measurements.header();
            Console.WriteLine("Hur många {0} vill du konvertera?", choice);
            quantity = double.Parse(Console.ReadLine());

            int menu2 = 0;
            bool isInvalidInput2 = false;

            do
            {
                Measurements.header();
                Console.WriteLine("Du valde {0}, välj nu vad du vill konvertera till", choice);
                Console.WriteLine("Tryck 1 för att konvertera till liter.");
                Console.WriteLine("Tryck 2 för att konvertera till deciliter");
                Console.WriteLine("Tryck 3 för att konvertera till centiliter.");
                Console.WriteLine("Tryck 4 för att konvertera till matsked.");
                Console.WriteLine("Tryck 5 för att konvertera till tesked");
                Console.WriteLine("Tryck 6 för att konvertera till kryddmått.");
                Console.WriteLine("Tryck 7 för att konvertera till UK-gallon.");
                Console.WriteLine("Tryck 8 för att konvertera till UK-pint");
                Console.WriteLine("Tryck 9 för att konvertera till UK-cup.");
                Console.WriteLine("Tryck 10 för att konvertera till UK-fluid ounce.");
                Console.WriteLine("Tryck 11 för att konvertera till UK-tablespoon");
                Console.WriteLine("Tryck 12 för att konvertera till UK-teaspoon.");
                Console.WriteLine("Tryck 13 för att konvertera till US-gallon.");
                Console.WriteLine("Tryck 14 för att konvertera till US-quart");
                Console.WriteLine("Tryck 15 för att konvertera till US-pint.");
                Console.WriteLine("Tryck 16 för att konvertera till US-cup.");
                Console.WriteLine("Tryck 17 för att konvertera till US-fluid ounce.");

                try
                {
                    menu2 = int.Parse(Console.ReadLine());
                    isInvalidInput2 = false;
                    break;
                }

                catch
                {
                    Console.WriteLine("Det var inte en korrekt input, försök igen..");
                    isInvalidInput2 = true;
                }

            } while (isInvalidInput2);

            switch (menu2)
            {
                case 1:
                    choice2 = "liter";
                    Measurements.Calculate(choice, choice2, quantity);
                    break;

                case 2:
                    choice2 = "deciliter";
                    Measurements.Calculate(choice, choice2, quantity);
                    break;

                case 3:
                    choice2 = "centiliter";
                    Measurements.Calculate(choice, choice2, quantity);
                    break;
                case 4:
                    choice2 = "matsked";
                    Measurements.Calculate(choice, choice2, quantity);
                    break;
                case 5:
                    choice2 = "tesked";
                    Measurements.Calculate(choice, choice2, quantity);
                    break;
                case 6:
                    choice2 = "kryddmått";
                    Measurements.Calculate(choice, choice2, quantity);
                    break;
                case 7:
                    choice2 = "ukgallon";
                    Measurements.Calculate(choice, choice2, quantity);
                    break;
                case 8:
                    choice2 = "ukpint";
                    Measurements.Calculate(choice, choice2, quantity);
                    break;
                case 9:
                    choice2 = "ukcup";
                    Measurements.Calculate(choice, choice2, quantity);
                    break;
                case 10:
                    choice2 = "ukfluidounce";
                    Measurements.Calculate(choice, choice2, quantity);
                    break;
                case 11:
                    choice2 = "uktablespoon";
                    Measurements.Calculate(choice, choice2, quantity);
                    break;
                case 12:
                    choice2 = "ukteaspoon";
                    Measurements.Calculate(choice, choice2, quantity);
                    break;
                case 13:
                    choice2 = "usgallon";
                    Measurements.Calculate(choice, choice2, quantity);
                    break;
                case 14:
                    choice2 = "usquart";
                    Measurements.Calculate(choice, choice2, quantity);
                    break;
                case 15:
                    choice2 = "uspint";
                    Measurements.Calculate(choice, choice2, quantity);
                    break;
                case 16:
                    choice2 = "uscup";
                    Measurements.Calculate(choice, choice2, quantity);
                    break;
                case 17:
                    choice2 = "usfluidounce";
                    Measurements.Calculate(choice, choice2, quantity);
                    break;

            }


        }
        

    }
}

