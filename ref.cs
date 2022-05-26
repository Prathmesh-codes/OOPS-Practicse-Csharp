using System;
class refprogram
{
    public static int Add( ref int x,  ref int y)
    {
        int z;
	z = x + y;
        return z;
    }
    static void Main(string[] args)
    {
        int a = 20, b = 30;
        int sum= Add(ref a, ref b);
	Console.WriteLine("The sum is="+sum);
	 
        
    }
}