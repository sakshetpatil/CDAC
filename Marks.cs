using System;
public class Marks
{
	public static void Main(String[] args)
	{
	    int m=int.Parse(Console.ReadLine());
	    int p=int.Parse(Console.ReadLine());
	    int c=int.Parse(Console.ReadLine());
	    
		Console.WriteLine("Marks in Math "+m);
		Console.WriteLine("Marks in phy "+p);
		Console.WriteLine("Marks in chem "+c);
		if((m+p+c)>=180)
		    Console.WriteLine("Eligible");
		    else
		    Console.WriteLine("not Eligible");
	}
}
