using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KorotchenkoDM.Sprint2.Task4.V14.Lib
{
    public class DataService : ISprint2Task4V14
    {
        public double Calculate(double x, double y)
        {
            double z = x * 3 < Math.Sqrt(y) + 20 ? (Math.Pow(2 + 1 / Math.Pow(x, 2), y)) : ((Math.Pow(y, 2) - Math.Pow(Math.Cos(x), 2) + 10) / (Math.Pow(x, 2) - Math.Pow(Math.Sin(y), 2) + 12));
            return Math.Round(z, 3);
        }
    }
}
