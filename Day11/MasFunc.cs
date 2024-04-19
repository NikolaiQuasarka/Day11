using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Day11
{
    public class FuncMas<T> where T: IComparable<double>
    {
        public int CompareTo(double n)
        {
            if (n is IComparable<double> s) return s.CompareTo(n);
            else throw new Exception("efwf");
        }

        public T[] mas;
        List<Type> types = new List<Type>() { typeof(int),typeof(double),typeof(decimal)};
        public FuncMas(int lenght)
        {
            foreach (var type in types)
                if (typeof(T) == type)
                    mas = new T[lenght];
                else throw new Exception("Только int, double и decimal");
        }

        public FuncMas(int lenght, T x)
        {
            foreach (var type in types)
                if (typeof(T) == type)
                {
                    mas = new T[lenght];
                    for (int i = 0; i < lenght; i++)
                    {
                        mas[i] = (T)Convert.ChangeType(TaylorSeriesSinhTerm(i, x), typeof(T));
                    }
                    break;
                }
            else throw new Exception("Только int, double и decimal");
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
            return mas.Where(x =>x.CompareTo(0.9)==1).Count(); 
            }
        }

        public double Sum()
        {
            int p1 = Array.FindIndex(mas, x => x.CompareTo(0)>0);
            int p2 = Array.FindLastIndex(mas, x => x.CompareTo(0) > 0);

            double sum = 0;
            for (int i = p1+1; i < p2; i++)
            {
                sum += mas[i];
            }
            return sum;
        }

    }
}
