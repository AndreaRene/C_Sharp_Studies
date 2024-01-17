//composite formatting

string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);
Console.WriteLine("{0} {0} {0}", first, second);

//string interpolation

Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");

//formatting currency

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

//formatting numbers

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
Console.WriteLine($"Measurement: {measurement:N4} units");

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");

decimal cost = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", cost - salePrice, cost);
yourDiscount += $"A discount of {(cost - salePrice)/cost:P2}!";
Console.WriteLine(yourDiscount);

//string interpolation exercise

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Shares: {productShares:N3} Product");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}");

//padding and alignment exercise

string input = "Pad this";
Console.WriteLine(input.PadRight(12));
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));

string paymentId = "769C";
 string payeeName = "Mr. Stephen Ortega";
 string paymentAmount = "$5,000.00";

 var formattedLine = paymentId.PadRight(6);
 formattedLine += payeeName.PadRight(24);
 formattedLine += paymentAmount.PadLeft(10);

 Console.WriteLine("1234567890123456789012345678901234567890");
 Console.WriteLine(formattedLine);