namespace _18_OOP_Polymorphism_New.BusinessApp
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
