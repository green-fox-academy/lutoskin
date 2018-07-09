using Frontend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Services
{
    public class HomeService
    {
        public int Sum(Number number)
        {
            int sum = 0;
            for (int i = 1; i <= number.Until; i++)
            {
                sum += i;
            }
            return sum;
        }

        public int Factorial(Number number)
        {
            int factorial = 1;
            for (int i = 1; i <= number.Until; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        public int ArraySum(ArrayModel array)
        {
            int summa = array.Numbers.Sum();
            return summa;
        }

        public int ArrayMultiply(ArrayModel array)
        {
            int result = 1;
            for (int i = 0; i < array.Numbers.Count(); i++)
            {
                result *= array.Numbers[i];
            }
            return result;
        }

        public int[] ArrayDouble(ArrayModel array)
        {
            int[] result = new int[array.Numbers.Count()];
            for (int i = 0; i < array.Numbers.Count(); i++)
            {
                result[i] = array.Numbers[i] * 2;
            }
            return result;
        }
    }
}
