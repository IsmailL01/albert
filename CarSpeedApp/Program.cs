using System;

public class HelloWorld
{
    public static void Main()
    {
        string str;
        int V1, V2, T, s, T2;
        Console.WriteLine ("Enter V1");
        str=Console.ReadLine();
        V1=Convert.ToInt32(str);
        Console.WriteLine ("Enter V2");
        str=Console.ReadLine();
        V2=Convert.ToInt32(str);
        Console.WriteLine ("Enter time");
        str=Console.ReadLine();
        T=Convert.ToInt32(str);
        Console.WriteLine("Введите изначальное расстояние между автомобилями");
        str=Console.ReadLine();
        T2=Convert.ToInt32(str);
        s=(V1+V2)*T+T2;

        
        Console.WriteLine ("The distance between the machines ="+s +"km"); 
    }
    
}