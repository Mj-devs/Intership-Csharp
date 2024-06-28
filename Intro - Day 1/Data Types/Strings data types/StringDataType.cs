using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro___Day_1.Data_Types.Strings_data_types
{
    internal class StringDataType
    {
       decimal myNum = 56.78m;

        public void TestStrings()
        {
            int num = 56;
          
            string MyName = "Oluwapelumi Sunday";
            string firstName = MyName.Substring(0,10);
            string lastName = MyName.Substring(12,6);
            string[] splittedName = MyName.Split(' ');
            string[] lowerName = splittedName.Where(x => x.StartsWith("g")).Take(1).ToArray();
            //Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine(splittedName[0] + " " + splittedName[0]);
            Console.WriteLine($"Lower Value of {MyName} is {lowerName}");
        }

    }
}
