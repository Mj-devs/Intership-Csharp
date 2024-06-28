using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
# nullable enable

namespace Intro___Day_1.Data_Types.numbers_data_types
{
    public  class Numbers
    {
        Decimal balance = 56m;
        Single floatBalance = 56f;
        bool isTrue = true;
   public static void justRandom()
    {
        int sum = 3 + 4;
            decimal firstNum = 6m;
            decimal secondNum = 7m;
            float floatFirstNumber = 5f;
            float secondFirstNumber = 11f;
            int intNum = 4;
            secondNum = (decimal)floatFirstNumber;
            floatFirstNumber = (float)firstNum;
            Console.WriteLine($"{ floatFirstNumber} is of type {floatFirstNumber.GetType()}");
            floatFirstNumber = (float)45.786m;
            Console.WriteLine($"{ floatFirstNumber} is of type {floatFirstNumber.GetType()}");
            float addfloatToDecimal = floatFirstNumber + intNum;
            Console.WriteLine($"{ secondNum} is of type {secondNum.GetType()}");

            bool isTrue = true;
            bool isFalse = false;
    }

    }
    //parse
    //ConvertTo

}
