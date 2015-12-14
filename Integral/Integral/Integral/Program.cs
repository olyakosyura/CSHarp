﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integral
{
    class Program
    {
        static double f(double x)
        {
            return Math.Cos(x) * x - 2;
        }
        static double CalcIntegral(double a, double b, int n)
        {
            int i;
            double result, h, x;
            h = (b - a) / n;
            result = 0;
            x = a;
            for (i = 0; i < n - 1; i++)
            { 
                result = f(x)+ result;
                    x = x + h;
            }
            return result*h;
        
        }
        static void Main(string[] args)
        {
            double integral;
            integral = CalcIntegral(0,1,500);
            Console.WriteLine(integral);
            Console.ReadLine();

        }
    }
}