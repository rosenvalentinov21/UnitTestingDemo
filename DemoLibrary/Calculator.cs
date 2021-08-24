using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public static class Calculator
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static double Subtract(double x, double y)
        {
            return x - y;
        }

        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        public static double Powered(double x , double n)
        {
            for (int i = 1; i < n; i++)
            {
                x *= x;
            }
            return x;
        }

        public static double SQRT(double x , double root)
        {
            return Math.Pow(x, 1 / root);
        }

        public static double Divide(double x, double y)
        {
            if (y != 0)
            {
                return x / y; 
            }
            else
            {
                // Custom business logic for divide by zero
                return 0;
            }
        }


        public static double CircleRadius(double r)
        {
            return r * Math.PI;
        }
    }
}
