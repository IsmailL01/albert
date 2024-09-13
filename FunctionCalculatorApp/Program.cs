using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
         string str;
        int x;
        Console.WriteLine("Enter x");
        str=Console.ReadLine();
        x=Convert.ToInt32(str);


        double y = 4 * Math.Pow((x - 3), 6) - 7 * Math.Pow(x - 3, 3) + 2;

        Console.WriteLine("y="+y);
        
    }
}