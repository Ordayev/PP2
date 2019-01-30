using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
           // string s = Console.ReadLine(); //Reading First input 
            //int n = int.Parse(s); // Converting string to int
            int[] a = new int[n]; // Creating array
            string s = Console.ReadLine();// reading secong line of input
            string[] arr = s.Split();// Putting numbers into array
            int cnt = 0;
            List<int> p = new List<int>();
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(arr[i]); 
                for(int j = 2; j <= a[i]/2; j++)
                {
                    if(a[i]%j==0)
                    {
                        cnt++;
                    }
                }
                if (cnt == 0)
                {
                    p.Add(a[i]);
                }
                cnt = 0;
            }
            for(int i= 0; i < p.Count(); i++)
            {
                if(p[i]!=1)
                Console.Write(p[i] + " ");
            }
        }
    }
}
