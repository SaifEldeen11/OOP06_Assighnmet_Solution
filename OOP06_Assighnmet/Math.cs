using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP06_Assighnmet
{
    internal class Maths
    {

        public static int Add(int x, int y)
        {
            return x + y;
        }
        static public int Subtract(int x, int y)
        {
            return x - y;
        }
       static public int Multiply(int x, int y)
        { 
           return x * y;
        }
       static public int Divide(int x, int y)
        {
            if (y != 0)
                return x / y;
            else
                return -1; // or throw an exception 
        }
    }
}
