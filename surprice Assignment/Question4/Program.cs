using System;
namespace Question4;
class Program 
{
    public static void Main(string[] args)
    {
        string str=Console.ReadLine();
        //str="vallarasu ravichandran";
        string []str1=str.Split(' ');
      
        string str2="";
        string str3=str1[0].ToLower();
        str2+=str3;
        for(int i=1;i<str1.Length;i++)
        {
           
                string s=str1[i];
                for(int j=0;j<s.Length;j++)
                {
                    if(j==0)
                    {
                        if(s[j]>=97 && s[j]<=122)
                        {
                           str2+=(char)(s[j]-32);
                        }
                        else
                        {
                            str2+=(s[j]);
                        }
                        
                    }
                    else
                    {
                        str2+=s[j];
                    }
                }
            

       }
       
        Console.Write(str2);
       
    
    }
}
