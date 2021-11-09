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
            measureList.Add("uk-gallon", 4500);
            measureList.Add("uk-pint", 570);
            measureList.Add("uk-cup", 280);
            measureList.Add("uk-fluid ounce", 28);
            measureList.Add("uk-tablespoon", 15);
            measureList.Add("uk-teaspoon", 5);
            measureList.Add("us-gallon", 3800);
            measureList.Add("us-quart", 950);
            measureList.Add("us-pint", 470);
            measureList.Add("us-cup", 240);
            measureList.Add("us-fluidounce", 30);
        }


        public static void Calculate(string i, string j, double amount)
        {
            double sum = measureList[i] * amount / measureList[j];
            //Console.WriteLine("Att konvertera {0} st {1} till {2} resulterar i {3} st {4}", amount, i, j, amount);
            Console.WriteLine(sum);
          
        }



    }
}
