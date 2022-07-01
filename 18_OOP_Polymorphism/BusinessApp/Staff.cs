using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP_Polymorphism.BusinessApp
{
    internal class Staff
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int WorkDays { get; set; }
        public decimal DailyWage { get; set; }

        public virtual decimal Salary
        {
            get
            {
                return WorkDays * DailyWage;
            }
        }
    }
}
