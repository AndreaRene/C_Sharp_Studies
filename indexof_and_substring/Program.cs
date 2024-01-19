//find parenthesis pairs inside a string

string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

//use substring to extract the message

openingPosition += 1;

// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

//increasing opening position

// string message = "What is the value <span>between the tags</span>?";

// int openingPosition = message.IndexOf("<span>");
// int closingPosition = message.IndexOf("</span>");

// openingPosition += 6;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

//misspelling could impact performance

string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";//set a const
const string closeSpan = "</span>";//set a const

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

/*
IndexOf() gives you the first position of a character or string inside of another string.
IndexOf() returns -1 if it can't find a match.
Substring() returns just the specified portion of a string, using a starting position and optional length.
There's often more than one way to solve a problem. You used two separate techniques to find all instances of a given character or string.
Avoid hardcoded magic values. Instead, define a const variable. A constant variable's value can't be changed after initialization.
*/