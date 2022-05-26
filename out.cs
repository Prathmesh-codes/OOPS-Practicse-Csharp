using System;
class Out
{
    static void Subtraction(out int p, out int q)
    {
        p = 100;
        q = 200;
        
    }

    public static void Main()
    {
        int a, b;
        Subtraction(out a, out b);
	Console.WriteLine("Subtraction is "+(a-b));
    }

}