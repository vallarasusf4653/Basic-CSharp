using System;
class Program 
{
    public static void Main(string[] args)
    {
        
                    Console.WriteLine("Enter the Date of Birth: ");
                    bool istrue1=DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out DateTime date1);
                    bool istrue2=DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out DateTime date2);
                    TimeSpan date3=date2-date1;
                    int age=date3.Days/365;
                    Console.WriteLine(date3.Days);
                    String s=date1.DayOfWeek.ToString();
                    Console.WriteLine($"Age {age}");
                    Console.WriteLine($"Day Of Month {s}");
                    Console.WriteLine($"Total Hours:{date3.TotalHours}");
                    Console.WriteLine($"Total Minutes:{date3.TotalMinutes}");
                    
                   


                    
    }
}