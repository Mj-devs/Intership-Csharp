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
        Console.WriteLine ("Your 2nd dice number is " + diceNum2);

        // Operations on Randomnized numbers.
        Random AddRandoms = new Random();
            int num1 = AddRandoms.Next(1,101);
            int num2 = AddRandoms.Next(1, 5);
            Console.WriteLine ("Randomized No1 is " + num1);
            Console.WriteLine ("Randomized No2 is " + num2);
            Console.WriteLine ("Additon of Randomize is " + (num1 + num2));
            Console.WriteLine ("Subtraction of Randomize is " + (num1 - num2));
            Console.WriteLine ("Divison of Randomize is " + num1 / num2);
            Console.WriteLine ("Multiplication of Randomize is " + num1 * num2);

        //Formatting strings.
            decimal money = 1200;
            string hourlymoney = money.ToString("c"); //formatting to currency
            Console.WriteLine ("From September, my hourly income will be " + hourlymoney);
            double increase = 1.2;
            string moneyincrese = increase.ToString("p0"); //formatting to percent
            Console.WriteLine ("That is a " + moneyincrese + " increase.");
            decimal income = 864000;
            string monthlyincome = income.ToString("n0"); //formatting to thousands
            Console.WriteLine("Making that a total of " + monthlyincome + " per month");


        } 
    }
}
