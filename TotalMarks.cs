using System;
public class TotalMarks
{
	public static void Main(String[] args)
	{
	    int r=int.Parse(Console.ReadLine());
	    String n=Console.ReadLine();
	    int p=int.Parse(Console.ReadLine());
	    int c=int.Parse(Console.ReadLine());
	    int ca=int.Parse(Console.ReadLine());
	   // int c=int.Parse(Console.ReadLine());
	    
		Console.WriteLine("Roll no "+r);
		Console.WriteLine("Name "+n);
		Console.WriteLine("Marks in phy "+p);
		Console.WriteLine("Marks in chem "+c);
		Console.WriteLine("Marks in com application "+ca);
		Console.WriteLine("Total Marks "+(c+p+ca));
		Console.WriteLine("Percentage "+((c+p+ca)/3));
		if((ca+p+c)>=180)
		    Console.WriteLine("class: First class");
		    else
		    Console.WriteLine("not Eligible");
	}
}
