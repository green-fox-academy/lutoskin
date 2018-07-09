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
    }
}
