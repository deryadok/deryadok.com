using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP_Polymorphism.BusinessApp
{
    internal class Worker : Staff
    {
        public override decimal Salary
        {
            get
            {
                return DailyWage * WorkDays * 2;
            }
        }
    }
}
