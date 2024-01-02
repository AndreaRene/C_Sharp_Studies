// Your solution must include either a do-while or while iteration.

// Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for one of three role names: Administrator, Manager, or User.

// Inside the iteration block:

// Your solution must use a Console.ReadLine() statement to obtain input from the user.
// Your solution must ensure that the value entered matches one of the three role options.
// Your solution should use the Trim() method on the input value to ignore leading and trailing space characters.
// Your solution should use the ToLower() method on the input value to ignore case.
// If the value entered isn't a match for one of the role options, your code must use a Console.WriteLine() statement to prompt the user for a valid entry.
// Below (after) the iteration code block: Your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.

bool isValid = false;
string[] options = {"administrator", "manager", "user"};
string input;

Console.WriteLine("Please enter your role name (Administrator, Manager, or User)");

//loop
do {
    input = Console.ReadLine().Trim().ToLower();

    foreach (var option in options) {
        if (input == option) {
            isValid = true;
            break;
        }
    }

    if (!isValid) {
        Console.WriteLine("Invalid role. Please enter Administrator, Manager, or User");
    }
} while (!isValid);

Console.WriteLine($"Role {input} accepted.");
