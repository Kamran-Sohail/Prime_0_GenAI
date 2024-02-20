using System;

static void Main(string[] args)
{
    for (int I = 2; I < 100; I++)
    {
        bool isPrime = true;
        for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
    }
}
