using System;
namespace Question4;
class Program 
{
    public static void Main(string[] args)
    {
        string str1 = Console.ReadLine();
        string[] str2=str1.Split(' ');

        int kValue=int.Parse(Console.ReadLine());

        string str3 = Console.ReadLine();
        string[] str4=str3.Split(' ');

        int size1=str2.Length;
        int size2=str4.Length;

        string []arr1 = new string[size1];
        string []arr2 = new string[size2];

        for(int i=0;i<str2.Length;i++)
        {
           arr1[i]=str2[i];
        }

        for(int i=0;i<str4.Length;i++)
        {
            
           arr2[i]=str4[i];
        }

        string s="";
        for(int i=0;i<arr1.Length;i++)
        {
            if(i==kValue)
            {
                for(int j=0;j<arr2.Length;j++)
                {
                     s+=arr2[j]+" ";
                }
            }
            s+=arr1[i]+" ";
        }
        Console.WriteLine(s.Trim());

    }
}
