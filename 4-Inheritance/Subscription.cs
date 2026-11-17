namespace _4_Inheritance;

public abstract class Subscription
{
    public DateTime TermEndDate { get; set; }
    public decimal Discount { get; private set; }

    public Subscription()
    {
        
    }
    
    public Subscription(bool trialPeriod)
    {
        if (trialPeriod)
        {
            StartTrial();
        }
        TermEndDate = new DateTime().AddMonths(12);
    }
    
    public bool Cancel()
    {
        if (TermEndDate < DateTime.Now)
        {
            return false;
        }
        TermEndDate = DateTime.Now.AddDays(5);
        return true;
    }

    public abstract decimal Refund(int daysLeft);
    
    private void StartTrial()
    {
        TermEndDate = new DateTime().AddMonths(13);
        Discount = 150;
    }
}