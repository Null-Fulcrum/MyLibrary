using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.ClassHelper
{
    class RentClass
    {
        public static double Debt(double bookCost, DateTime startDate)
        {

            double sum = 0;

            if (Convert.ToInt32(DateTime.Now.Date - startDate.Date) > 30)
            {
                sum = bookCost * 0.1;
            }

            return sum;
        }
    }
}
