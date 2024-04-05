using System;
namespace Question2;
class Program 
{
    public static void Main(string[] args)
    {
        //string str=Console.ReadLine();
        string str="occurrence";     //o1c3c3u1r2r2e2
        for(int i=0;i<str.Length;i++)
        {
            bool isrepeat=false;
            for(int j=0;j<i;j++)
            {
                if(str[i]==str[j])
                {
                    isrepeat=true;
                    break;
                }
            }

            if(isrepeat==false)
            {
                int count=0;
                for(int k=0;k<str.Length;k++)
                {
                    
                    if(str[k]==str[i])
                    {
                       count++;
                    }
                }
                Console.Write($"{str[i]}{count}");
            }
        }
    }
}
