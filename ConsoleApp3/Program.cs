using System;
using System.Runtime.Serialization;
using System.Security;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Hello World!");
            string tt = Carl("aki");
            Console.WriteLine(tt);
            Console.WriteLine(Srt("face"));
            Console.WriteLine(bb);
            Console.WriteLine(Bla("something"));
            int[] nomr= { 1, 2,}
        }



        static int Millet(int m, int t)
        {
            int result = 1;
            for (int i = 0; i < m; i++)
            {
                result *= m;
            }
            return result;
        }

        //verilmis yazida a charinin sayini tapan metod
        
            
            
        

        //verilmis yazida a charinin olub olmadigini tapan metod
        
        

    


       //verilmis yazini eksi seklinde qaytaran metod
       
       
        
        


       

        //verilmis yazida verilmis charin sayini tapan metod

        static int Srt(string text,char mtv)
        {
            int count = 0;
            for (int i = 0; i < text.Length;i++) 
            {
             if (text[i] == mtv)
                    count++;
            }
            return count;
        }
        //verilmis ededler siyahisinda verilmis ededin yerlesdiyi ilk indexi qaytaran metod
        static int Bla(int[] nums, int num)
        {
            for (int i =0; i < nums.Length;i++)
            {
                if (nums[i] == num)
                    return i;
            }
            return -1;
        }

    }
    static string First(string s)
    {
        char empty = '';
        string word = "";
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == empty)
            {
                word += s[i];
            }
            return word;
        }

    }

        
}      