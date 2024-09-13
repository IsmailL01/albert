public class HelloWorld
{
    public static void Main(string[] args)
    {
         string str;
        int TF,TC;
        Console.WriteLine("Enter TF");
        str=Console.ReadLine();
        TF=Convert.ToInt32(str);

        TC=(TF-32)*5/9;

        Console.WriteLine("TC="+TC);
        
    }
}