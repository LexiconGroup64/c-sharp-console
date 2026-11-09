using _2_Objects.Models;

PetrolStation station = new PetrolStation();
station.WriteToConsole("Side effect");

station.WriteToConsole("Side effect", " are sometimes okay");



Account newAccount = new Account();

Store newStore = new Store(530, 45, "Store");

Store alteredStore = new Store(607, newStore.Capacity, newStore.Name);

Location location = new Location(40, "Oligarchy");

int id = newAccount.GetId();

string text = "Header";
string.Compare("assist", "desist");
text.CompareTo("feeder");

// a = b + c + d + e
// GrossDomesticProduct = Consumption + GovernmentExpenditures + Investment + NetExports
// tCC = unity45 + u + typeAccess + grouping