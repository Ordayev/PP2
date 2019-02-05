using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = false;
            string text = System.IO.File.ReadAllText(@"C:\Users\acer\Desktop\PP2\Week2\Task1\cin.txt");
            for(int i= 0, j = text.Length-1; i < text.Length/2; i++, j--)
            {
                if (text[i] != text[j])
                {
                    check = true;
                    break;
                }
            }
            if(check == true)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
                      
        } 
    }
}
