string permission = "Employee";
int level = 100;

if (permission.Contains("Admin"))
    Console.WriteLine((level >= 55) ? "Welcome, Super Admin User." : "Welcome, Admin user.");
else if (permission.Contains("Manager"))
    Console.WriteLine((level >= 20) ? "Contact an admin for access." : "You do not have sufficient privileges.");
else
    Console.WriteLine("You do not have sufficient privileges.");