using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
# nullable enable

namespace Intro___Day_1.Data_Types.numbers_data_types
{
    internal class NumbersTypeConversion
    {
        public static void TypeConversion()
        {
            float FirstNum = 12f;
            float SecondNum = 12f;
            decimal DecfirstNum = 3.6m;
            int addFirstNum = 10;
            int addSecNum = 10;

            int finalsum = addFirstNum + addSecNum;

            //SecondNum = (float)finalsum;
            //Console.WriteLine($"{SecondNum} is of type {SecondNum.GetType()}");
            DecfirstNum = (decimal)finalsum;
            Console.WriteLine($"{DecfirstNum} is of type {DecfirstNum.GetType()}");
            finalsum = (int)SecondNum;
            Console.WriteLine($"{finalsum} is of type {finalsum.GetType()}");
        }
    }
}
