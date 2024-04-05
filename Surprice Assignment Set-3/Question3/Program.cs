using System;
namespace Program;
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
        foreach(int ch in arr)
        {
            Console.Write(ch);
        }
        string s="";
        int count=0;
        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i]==0)
            {
                count++;
            }
            else
            {
               s+=arr[i]+" ";
            }
        }
        for(int i=count;i>0;i--)
        {
            s+="0 ";
        }

        Console.Write(s.Trim());
    }
}
