// //find the last occourance of a character/substring

// // string message = "(What if) I am (only interested) in the last (set of parentheses)?";
// // int openingPosition = message.LastIndexOf('(');

// // openingPosition += 1;
// // int closingPosition = message.LastIndexOf(')');
// // int length = closingPosition - openingPosition;
// // Console.WriteLine(message.Substring(openingPosition, length));

// //retrieve all occourances of a character/substring

// string message = "(What if) there are (more than) one (set of parentheses)?";
// while (true)
// {
//     int openingPosition = message.IndexOf('(');
//     if (openingPosition == -1) break;

//     openingPosition += 1;
//     int closingPosition = message.IndexOf(')');
//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));

//     // Note the overload of the Substring to return only the remaining 
//     // unprocessed message:
//     message = message.Substring(closingPosition + 1); //reassigning the value of message to exclude the previous substring
// }

//find different symbols using sets?

string message = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = { '[', '{', '(' };
int startPosition = 6;//isnt this counter-productive? Won't know the number...
int openingPosition = message.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}: {message.Substring(openingPosition)}");