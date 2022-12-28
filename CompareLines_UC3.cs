using System;

public class CompareLines_UC3
{
	public  void CompareLinesLength()
	{
        CalculateLength cl = new CalculateLength();
        Console.WriteLine("Enter the Co-ordinates for First Line.");
        double lengthofline1 = cl.CalculateLengthofLine();
        //Console.WriteLine("The length of the line is :" + lengthofline1);

        Console.WriteLine("Enter the Co-ordinates for Second Line.");
        double lengthofline2 = cl.CalculateLengthofLine();
        //Console.WriteLine("The length of the line is :" + lengthofline2);

        int check= lengthofline1.CompareTo(lengthofline2);
        if(check>0)
        {
            Console.WriteLine("Line1 is greaterthen Line2.");
        }
        else if(check<0)
        {
            Console.WriteLine("Line1 is lessthen Line2.");
        }
        else
        {
            Console.WriteLine("Both Lines are Equal.");
        }
    }
}
