using System;
 namespace TypeConversion;
 class Program 
 {
    public static void Main(string[] args)
    {
        Console.Write("Enter the first number : ");
        int num1=int.Parse(Console.ReadLine());
        Console.Write("Enter the Second Number : ");
        int num2=int.Parse(Console.ReadLine());
        Console.Write("Enter a Double number : ");
        double num3=int.Parse(Console.ReadLine());
        Console.WriteLine(num3);
       //int c= num1+num2+num3;
       // Console.WriteLine(c);

        //Console.WriteLine(typeof(num1));            // work in object only
        //Console.WriteLine(num1.GetType());
         Console.Write("Enter a Double number : ");
        double num4=Convert.ToInt32(Console.ReadLine());
    }
 }

