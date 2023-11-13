// See https://aka.ms/new-console-template for more information
using System.Globalization;

bool isprime = true;
Console.WriteLine("prime number:");
for (int i = 2; i < 1000; i++)
{
    for (int j = 2; j <= 1000; j++)
    {
        if (i != j && i % j == 0)
        {
            isprime = false;
            break;
        }
    }
    if (isprime)
    {
        Console.Write("\t" + i);
    }
    isprime = true;
}
Console.ReadKey();
