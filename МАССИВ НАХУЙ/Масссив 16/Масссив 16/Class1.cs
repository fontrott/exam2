using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Масссив_16
{
    internal class Class1
    {
        public double PositivePro<T>(List<T> number)
        {
            double positive = 0;
            foreach (T num in number)
            {
                dynamic dnum = num;
                if (dnum > 0) positive++;
            }
            double positivePro = (positive / number.Count) * 100;
            return positivePro;
        }
        public double NegativePro<T>(List<T> number)
        {
            double negative = 0;
            foreach (T num in number)
            {
                dynamic dnum = num;
                if (dnum < 0) negative++;
            }
            double negativePro = (negative / number.Count) * 100;
            return negativePro;
        }
        public double NulPro<T>(List<T> number)
        {
            double nul = 0;
            foreach (T num in number)
            {
                dynamic dnum = num;
                if (dnum == 0) nul++;
            }
            double nulPro = (nul / number.Count) * 100;
            return nulPro;
        }
    }
}
