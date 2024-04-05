using System;
namespace Question1;
class Program 
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the Size :");
        int size=int.Parse(Console.ReadLine());
        Console.Write("Enter the String :");
        string str=Console.ReadLine();
        string[] str2=str.Split(',');
        int []arr=new int[size];
        for(int i=0;i<str2.Length;i++)
        {
            arr[i]=int.Parse(str2[i]);
        }

       /* foreach(int c in arr)
        {
            Console.WriteLine(c);
        }*/

        for(int i=0;i<arr.Length-1;i++)
        {
            for(int j=i+1;j<=i+1;j++)
            {
                if(arr[i]>arr[j])
                {
                    Console.Write(arr[i]+" ");
                }
                else
                {

                }
            }
        }
        int len=arr.Length-1;
        if(arr[len]!=0)
        {
          Console.Write(arr[len]);
        }
        
    }
}
