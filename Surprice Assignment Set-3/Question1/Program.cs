using System;
class Program 
{
    public static void Main(string[] args)
    {
        int size=int.Parse(Console.ReadLine());
        string str=Console.ReadLine();
        string []str1=str.Split(' ');
        int[] arr=new int[size];

        for(int i=0;i<str1.Length;i++)
        {
            arr[i]=int.Parse(str1[i]);
        }
        foreach (int item in arr)
        {
            Console.WriteLine(item);
        }
        string s="";
        for(int i=0;i<arr.Length-1;i++)
        {
            
                if(arr[i]>arr[i+1])
                {
                   // Console.Write(arr[i]+" ");
                    s+=arr[i]+" ";
                }
                else
                {
                  s+=arr[i+1]+" ";
                }
                
           
        }

       
        Console.Write(s.Trim());

        
       
    }
}
