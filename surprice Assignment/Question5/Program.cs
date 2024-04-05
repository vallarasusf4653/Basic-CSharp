using System;
namespace Question4;
class Program 
{
    public static void Main(string[] args)
    {
        //string str=Console.ReadLine();
        string str="computer program";
        char [] ch=str.ToCharArray();
        for(int i=0;i<ch.Length;i++)
        {
            int count=0;
            for(int j=0;j<ch.Length;j++)
            {
                if(ch[i]==ch[j])
                {
                  count++;
                }
            }

            if(count>1)
            {
                Console.Write((char)(ch[i]-32));
            }
            else
            {
               
                Console.Write(ch[i]);
            }

        }
    }
}
