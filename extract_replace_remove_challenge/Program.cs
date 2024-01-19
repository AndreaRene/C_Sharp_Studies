const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingSpanPosition = input.IndexOf(openSpan);
int closingSpanPosition = input.IndexOf(closeSpan);

openingSpanPosition += openSpan.Length;
int length = closingSpanPosition - openingSpanPosition;

output = input.Replace("<div>","");
output = output.Replace("</div>", "");
output = output.Replace("trade", "reg");

quantity = input.Substring(openingSpanPosition, length);
Console.WriteLine("Quantity: " + quantity);
Console.WriteLine("Output: " + output);