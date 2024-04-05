using System;
namespace Question5;
class Program 
{
    public static void Main(string[] args)
    {
        string str1=Console.ReadLine();
        string str2=Console.ReadLine();

        string []str3=str1.Split(' ');
        string []str4=str2.Split(' ');
        int []arr1=new int[str3.Length];
        int []arr2=new int[str4.Length];

        for(int i=0;i<str3.Length;i++)
        {
            arr1[i]=int.Parse(str3[i]);
        }

        for(int i=0;i<str4.Length;i++)
        {
            arr2[i]=int.Parse(str4[i]);
        }

       /* foreach(int n in arr1)
        {
            Console.Write(n);
        }

        foreach(int n in arr2)
        {
            Console.Write(n);
        }
        */

        for(int i=0;i<arr1.Length;i++)
        {
            for(int j=i+1;j<=i+1;i++)
            {
               if(arr1[i]<arr1[j])
               {
                  int temp=arr1[i];
                  arr1[i]=arr1[j];
                  arr1[j]=temp;
               }
            }
        }
        foreach(int n in arr1)
        {
            Console.Write(n);
        }
    }
}
