using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PimenovaTS.Sprint1.Task3.V13.Lib
{
    public class DataService : ISprint1Task3V13
    {
        public double MultiplyOfDigits(double number)
        {
            double a = Math.Round(number / 100);
            double b = Math.Round((number % 100) / 10);
            double c = number % 10;

            return a * b * c;
        }
    }
}
