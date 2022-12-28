// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main(String[] strings)
    {
        Console.WriteLine("Welcome to Comparison Computation Program");
        //UC1
        //double lengthofline = CalculateLength.CalculateLengthofLine();
        //Console.WriteLine("The length of the line is :" + lengthofline);
        //UC2

        // CheckEquality_UC2 ceobj=new CheckEquality_UC2();
        // ceobj.Compare_Length();
        CompareLines_UC3 clobj = new CompareLines_UC3();
        clobj.CompareLinesLength();

        


        Console.ReadKey(true);//use for show screen for a some time.

    }
}