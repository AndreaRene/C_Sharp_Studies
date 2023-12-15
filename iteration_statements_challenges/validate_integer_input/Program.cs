// Your solution must include either a do-while or while iteration.

// Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.

// Inside the iteration block:

// Your solution must use a Console.ReadLine() statement to obtain input from the user.
// Your solution must ensure that the input is a valid representation of an integer.
// If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
// Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.

// Below (after) the iteration code block: your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.


//----------------------

bool isNum = false;
int numValue = 0;
bool isValid = false;

Console.WriteLine("Please provide a value between 5 and 10:");

do {
    string input = Console.ReadLine() ?? "";
    isNum = int.TryParse(input, out numValue);
    
    if ( isNum && numValue >= 5 && numValue <= 10) 
        isValid = true;
    else Console.WriteLine($"Invalid input. Please try again.");
} while (isValid == false);

if (isValid == true) 
    Console.WriteLine($"Input {numValue} accepted.");

//better version 

do {
    Console.WriteLine("Please provide a value between 5 and 10:");
    string input = Console.ReadLine() ?? "";

    if (int.TryParse(input, out int numValue) && numValue >= 5 && numValue <= 10) {
        Console.WriteLine($"Input {numValue} accepted.");
        break;
    } else {
        Console.WriteLine($"Invalid input.");
    }

} while (true);