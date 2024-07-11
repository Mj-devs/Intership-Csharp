using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro___Day_1
{
    public class Food
    {
        public void  Breakfast()
         {
            string protein = "Eggs and sausages";
            string carbohydrate = "Yam";
            string beverage = "Milo";
            Console.WriteLine("Breakfast Menu is: ");
            Console.WriteLine("For protein, we have " + protein);
            Console.WriteLine("For Carbs, we have " + carbohydrate);
            Console.WriteLine("For Drink, we have " + beverage);
         }
        public static void Lunch()
        {
            string proteinz = "Meat and Chicken";
            string vitamins = "Vegetables";
            string starch = "Eba";
        }
    }
}
