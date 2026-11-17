namespace _3_Flow;

public class Booking
{
    public DateOnly ReturnDay { get; set; }
    public DateTime RegistrationDate { get; set; }
    public TimeOnly CheckTime { get; set; }

    public Booking()
    {
        RegistrationDate = DateTime.Now;
        ReturnDay = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddDays(30);
    }

    public void PostponeReturn(int months)
    {
        ReturnDay.AddMonths(months);
        
    }

    public void PrintDayType()
    {
        Console.WriteLine(DateTime.UtcNow);
        Console.WriteLine(ReturnDay.DayOfWeek);
        Console.WriteLine(RegistrationDate.DayOfWeek);

        DateTime old = new(1589, 12, 2, 4, 30, 0, 0);
        DateTime newButStillOld = old.AddYears(50).AddMonths(2).AddDays(8);

        DateTime nextExample = new(ReturnDay, CheckTime, DateTimeKind.Utc);

    }
}