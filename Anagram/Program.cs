using System;

class Program 
{
    public static void Main(string[] args)
    {
                    string str1="vallarasu";
                    string str2="integras";

                    char [] ch1=str1.ToCharArray();
                    char [] ch2=str2.ToCharArray();
                    if(ch1.Length==ch2.Length)
                    {
                          int sum=0;
                    foreach(char c in ch1)
                    {
                    sum+=(int)c;
                    }
                    Console.WriteLine(sum);

                    int even=0;
                    foreach(char c in ch1)
                    {
                    even+=(int)c;
                    }
                    Console.WriteLine(even);

                    if(sum==even)
                    {
                        Console.WriteLine("Anagaram");
                    }
                    else
                    {  
                        Console.WriteLine("Not anagram");

                    }

                    }
                    else
                    {
                       Console.WriteLine("Not anagram");
                    }
                  
    }
}
