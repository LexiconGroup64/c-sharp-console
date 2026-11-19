

using _4_Inheritance;

List<Address> addresses = new List<Address>()
{
    new Address(1, "Hornsgatan", "Flen"),
    new Address(2, "Grevegatan", "Alingsås"),
    new Address(3, "Alpvägen", "Hög"),
    new Address(3, "Alpvägen", "Hög"),
    new Address(4, "Lindblomsgatan", "Gråbo")
};

List<Address> newAddresses = addresses
    .Where(a => a.Id > 1)
    .OrderBy(a => a.City)
    .DistinctBy(a => a.Id)
    .ToList();

foreach (var address in newAddresses)
{
    Console.WriteLine($"{address.Id}, {address.Street}, {address.City}" );
}

Console.Read();



List<Location> locations = addresses
    .Select(a => new Location(a.Id, a.Street, a.City))
    .ToList();


List<string> addressesTransformed = addresses
    .Select(a => a.Street + "12")
    .ToList();

foreach (var address in addressesTransformed)
{
    Console.WriteLine(address);
}


Console.Read();


int[] numbers = [45, 33, 93, 557, 210, 834];

double yetMoreNumbers = numbers
    .Max();

Console.WriteLine(yetMoreNumbers);

List<string> newNumbers = numbers
    .Where(item => item > 50 && item < 700)
    .Select(item => "12:" + item)
    .Order()
    .ToList();

int amount = newNumbers.Count();

foreach (string num in newNumbers)
{
    Console.WriteLine(num);
}

Console.Read();


LifeInsurance altInsurance = new LifeInsurance();
IInsurance insurance = new LifeInsurance();
altInsurance.ChangeData(89);
insurance.ChangeData(89);


Console.WriteLine(insurance.GetType());
Console.WriteLine(insurance is LifeInsurance);

Console.Read();

Subscription subscriptionG = new ProSubscription();

Console.WriteLine((subscriptionG as ProSubscription).SupportHours);


ProSubscription subscriptionA = new ProSubscription();
ProSubscription subscriptionB = new ProSubscription();
ProSubscription subscriptionC = new ProSubscription();
Subscription subscriptionD = new BasicSubscription();
Subscription subscriptionE = new BasicSubscription();
Subscription subscriptionF = new BasicSubscription();

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
