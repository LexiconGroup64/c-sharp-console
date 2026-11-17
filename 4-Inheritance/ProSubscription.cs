namespace _4_Inheritance;

public class ProSubscription : Subscription
{
    public int SupportHours { get; set; }

    public ProSubscription()
    {
        
    }
    public ProSubscription(bool trialPeriod) : base(trialPeriod)
    {
    }
    
    
}