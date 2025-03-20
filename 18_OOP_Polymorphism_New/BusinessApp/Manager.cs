namespace _18_OOP_Polymorphism_New.BusinessApp
{
    internal class Manager : Staff
    {
        public override decimal Salary
        {
            get
            {
                return DailyWage * WorkDays * 5;
            }
        }
    }
}
