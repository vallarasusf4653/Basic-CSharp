using System;
namespace Question3;
class Program 
{
    public static void Main(string[] args)
    {
        string str=Console.ReadLine();
        string str2="";
        for(int i=str.Length-1;i>=0;i--)
        {
            switch(str[i])
            {
                case '{':
                {
                    str2+='}';
                    break;
                }
                case '}':
                {
                    str2+='{';
                    break;
                }
                case '[':
                {
                    str2+=']';
                    break;
                }
                case ']':
                {
                    str2+='[';
                    break;
                }
                case '(':
                {
                    str2+=')';
                    break;
                }
                case ')':
                {
                    str2+='(';
                    break;
                }
            }
        }
        Console.Write(str +" "+str2);
        if(str.Equals(str2))
        {
            Console.WriteLine("1");
        }
        else
        {
           Console.WriteLine("0");
        }
    }
}
