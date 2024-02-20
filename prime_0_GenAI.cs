using System;

static void Main(string[] args)
{
    for (int I = 2; I < 100; I++)
    {
        bool isPrime = true;
        if (Is_Primer_Number(I) == true)
            Console.WriteLine(I);
    }

    Console.ReadKey();
}

static bool Is_Primer_Number(int Number)
{
    for (int I = 2; I < Number; I++)
    {
        if ((Number % I) == 0) return false;
    }
    return true;
}
