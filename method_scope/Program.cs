﻿//use value and reference type parameters
//pass by value

int a = 3;
int b = 4;
int c = 0;

Multiply(a, b, c);
Console.WriteLine($"global statement: {a} x {b} = {c}");

void Multiply(int a, int b, int c) 
{
    c = a * b;
    Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
}

//pass by reference
int[] array = {1, 2, 3, 4, 5};

PrintArray(array);
Clear(array);
PrintArray(array);

void PrintArray(int[] array) 
{
    foreach (int a in array) 
    {
        Console.Write($"{a} ");
    }
    Console.WriteLine();
}

void Clear(int[] array) 
{
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = 0;
    }
}

//pass strings

string status = "Healthy";

Console.WriteLine($"Start: {status}");

SetHealth(status, false);

Console.WriteLine($"End: {status}");

void SetHealth(string innerStatus, bool isHealthy) 
{
    innerStatus = (isHealthy ? "Healthy" : "Unhealthy");
    Console.WriteLine($"Middle: {innerStatus}");
}