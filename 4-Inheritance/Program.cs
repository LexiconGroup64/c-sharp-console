

using _4_Inheritance;

Subscription subscriptionG = new ProSubscription();

Console.WriteLine((subscriptionG as ProSubscription).SupportHours);

Console.Read();

ProSubscription subscriptionA = new ProSubscription();
ProSubscription subscriptionB = new ProSubscription();
ProSubscription subscriptionC = new ProSubscription();
Subscription subscriptionD = new Subscription();
Subscription subscriptionE = new Subscription();
Subscription subscriptionF = new Subscription();

subscriptionB.SupportHours = 20;

Subscription[] alt = new Subscription[6];
alt[4] = subscriptionA;
alt[2] = subscriptionB;


List<Subscription> subscriptions = new List<Subscription>();
subscriptions.Add(subscriptionA);
subscriptions.Add(subscriptionB);
subscriptions.Add(subscriptionC);
subscriptions.Add(subscriptionD);
subscriptions.Add(subscriptionE);
subscriptions.Add(subscriptionF);
subscriptions.Add(subscriptionG);



if (subscriptionC is Subscription)
{
    Console.WriteLine("Both ways");
}

foreach (Subscription item in subscriptions)
{
    if (item is ProSubscription)
    {
        Console.WriteLine("ProSubscription");
    }
    else
    {
        Console.WriteLine("Subscription");
    }
}

foreach (Subscription item in subscriptions)
{
    if (item is ProSubscription)
    {
        Console.WriteLine((item as ProSubscription).SupportHours);
    }
    else
    {
        Console.WriteLine((item as ProSubscription).SupportHours);
    }
}
