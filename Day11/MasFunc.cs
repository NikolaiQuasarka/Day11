using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11
{
    public class FuncMas
    {
        public double[] mas;

        public FuncMas(int lenght)
        {
            mas = new double[lenght];
        }

        public FuncMas(int lenght, double x)
        {
            mas = new double[lenght];
            for (int i = 0; i < lenght; i++)
            {
                mas[i] = TaylorSeriesSinhTerm(i, x);
            }
        }
        private static double TaylorSeriesSinhTerm(int lenght, double x)
        {
            return Math.Pow(x, 2 * lenght + 1) / Factorial(2 * lenght + 1);
        }
        private static double Factorial(int n)
        {
            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public int NumbersLower
        {
            get { 
            return mas.Where(x => x< 0.9).Count();
            }
        }

        public double Sum()
        {
            int p1 = Array.FindIndex(mas, x => x > 0);
            int p2 = Array.FindLastIndex(mas, x => x > 0);

            double sum = 0;
            for (int i = p1+1; i < p2; i++)
            {
                sum += mas[i];
            }
            return sum;
        }

    }
}
