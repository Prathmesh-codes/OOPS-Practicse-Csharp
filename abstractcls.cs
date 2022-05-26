using System;

public abstract class Classabs
{
	public abstract void abc();

}

public class ov1 : Classabs
{
public override void abc()
{
Console.WriteLine("Overriden Method");
}
}

public class main_method
{
public static void Main()
{

ov1 a=new ov1();
a.abc();
}
}



