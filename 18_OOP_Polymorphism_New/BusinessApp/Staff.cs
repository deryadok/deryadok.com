namespace _18_OOP_Polymorphism_New.BusinessApp
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
