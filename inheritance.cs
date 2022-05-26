using System;
public class A
{
	
	public A(){}
    public void show()
    {
        Console.WriteLine("Showing Class A");
    }

  }

class B: A
{

    public void display()
    {
        Console.WriteLine("Showing class B");
    }

    public static void Main(String[] args)
    {
        B b = new B();
        b.display();
        b.show();
    }

     

}