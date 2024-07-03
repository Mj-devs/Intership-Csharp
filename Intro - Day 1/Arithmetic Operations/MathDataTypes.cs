using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro___Day_1.Arithmetic_Operations
{
   public class MathDataTypes
    { 
       public static void Nos () {
        int myFirstNum = 9;
        
        double FinalNum = Math.Sqrt(myFirstNum);
            Console.WriteLine(FinalNum);

        //number randominzation of a dice.
        Random Numberz = new Random();
            int diceNum1 = Numberz.Next(1, 7);
            int diceNum2 = Numberz.Next(1, 7);
        Console.WriteLine ("Your 1st dice number is " + diceNum1);
        Console.WriteLine ("Your  2nd dice number is " + diceNum2);

        // Operations on Randomnized numbers.
        Random AddRandoms = new Random();
            int num1 = AddRandoms.Next(1,101);
            int num2 = AddRandoms.Next(1, 5);
            Console.WriteLine(num1);
            Console.WriteLine (num2);
            Console.WriteLine (num1 + num2);
        } 
    }
}
