using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KorotchenkoDM.Sprint2.Task7.V9.Lib
{
    public class DataService : ISprint2Task7V9
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (((x >= 0) && (x <= Math.PI)) && ((y <= Math.Sin(x)) && (y <= 0.5)))
                return true;
            else
                return false;
        }
    }
}
