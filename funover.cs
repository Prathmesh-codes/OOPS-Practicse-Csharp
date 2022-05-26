using System;
    class Overload
    {
       void sum(int m, int n)
      {
        int a, b;
        a = m;
        b = n;
        Console.WriteLine("Addition of two integers is " + (a + b));

       }
    void sum(double l,double  m, double n)
    {
        double a, b,c;
        a=l;
        b=m;
        c=n;
        Console.WriteLine("Addition of three double variables is " + (a + b+c));

    }

    static void Main(string[] args)
        {
        Overload p = new Overload();
        p.sum(10,20);
        p.sum(1.2,1.8,1.9);
            
        }
    }
