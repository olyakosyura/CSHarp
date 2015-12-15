using System;
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
            return Math.Cos(x)*x-2;  //функция для подсчета интеграла
        }



        // функция подсчета интеграла        
        static double CalcIntegral(double a, double b, int n)
        {
            int i;
            double result, h, x;
            h = (b - a) / n;            // шаг
            result = 0;
            x = a;
            for (i = 0; i < n -1 ; i++)
            { 
                result = f(x)+ result;
                    x = x + h;
            }
            result = h * result;
            return result;
       
        }
        static void Main(string[] args)
        {
            double integral;
Double a,b, n;
Console.WriteLine('Input a,b and n');
a=Console.ReadLine();
b=Convert.ToDouble(Console.ReadLine());
n=Console.ReadLine();
            integral = CalcIntegral(a,b,n);  // считаем интеграл от 0 до 1.количество разбиений 500
            Console.WriteLine(integral);
            Console.ReadLine();

        }
    }
}
