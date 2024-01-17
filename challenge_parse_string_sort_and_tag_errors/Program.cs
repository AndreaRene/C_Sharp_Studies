string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderIdsArray = orderStream.Split(',');
Array.Sort(orderIdsArray);
foreach (string order in orderIdsArray)
{
    if( order.Length > 4 || order.Length < 4 )
    {
        Console.WriteLine($"{order}\t- Error");
    }else
    {
        Console.WriteLine(order);
    }
}

/*
A345
B123
B177
B179
C15     - Error
C234
C235
G3003   - Error
*/