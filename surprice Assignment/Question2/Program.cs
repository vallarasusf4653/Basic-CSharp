using System;
namespace Question2;
class Program 
{
    public static void Main(string[] args)
    {
        int size=int.Parse(Console.ReadLine());
        string str=Console.ReadLine();
        string []str2 = str.Split(',');
        int []arr=new int[size];
        for(int i=0;i<str2.Length;i++)
        {
            arr[i]=int.Parse(str2[i]);
        }
        
        
        int max=arr[0];
        int min=arr[0];

       int maxIndex=0;
        for(int i=0;i<arr.Length;i++)
        {
            if(max<arr[i])
            {
                max=arr[i];
                maxIndex=i;
                
            }
        }

        int minIndex=0;
        for(int i=0;i<arr.Length;i++)
        {
            if(min>arr[i])
            {
                min=arr[i];
                minIndex=i;
            }
        }

        //Console.WriteLine(max+"\n"+min);
        Console.WriteLine(maxIndex-minIndex);
         
         
        
        
    }
}
