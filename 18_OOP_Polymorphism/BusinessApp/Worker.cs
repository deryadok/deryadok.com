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
