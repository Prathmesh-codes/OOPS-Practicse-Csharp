using System;

public sealed class Classabs
{
	public void abc()
{
}

	//This is sealed class theus can't be inherited
}

public class ov1 : Classabs //invalid
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



