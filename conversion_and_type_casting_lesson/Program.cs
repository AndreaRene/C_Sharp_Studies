
// int first = 2;
// string second = "4";
// int result = first + second;
// Console.WriteLine(result); 

//output error
//Can not implicitly convert type 'string' to 'int'



// int first = 2;
// string second = "4";
// string result = first + second;
// Console.WriteLine(result);

//convert int to string to concat a number to a string
//output 24


// int first = 2;
// string second = "4";
// int result = first + second;
// Console.WriteLine(result); 

// output error
//Can not implicitly convert type 'int' to 'string'


// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");

//output 
//int: 3
//decimal: 3

// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

//output 
//decimal: 3.14
//int: 3

//Widening/narrowing conversions

// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float  : {myFloat}");

//output
// Decimal: 1.23456789
// Float:   1.234568
//narrowing: casting decimal to float loses percision

//ToString() converting int values into strings

// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);

//output 57

//Parse() convert a string to an int

// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);

//output 12

//string to int using Convert class

// string value1 = "5";
// string value2 = "7";
// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(result);

//output 35

int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);

//output 
// 1
// 2