using System;
class inprogram
{
    public static int Add( in int x,  in int y)
    {
        int z;
	z = x + y;
        return z;
    }
    static void Main(string[] args)
    {
        int a = 20, b = 30;
        int sum= Add(in a, in b);
	Console.WriteLine("The sum is="+sum);
	 
        
    }
}