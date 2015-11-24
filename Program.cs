using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            while (T-->0)
            {
                string str1 = Console.ReadLine();
                string str2 = Console.ReadLine();

                int flag = 0;
                foreach (char item in str2)
                {
                    if(str1.Contains(item))
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 1)
                {
                    Console.WriteLine("Yes");
                }
                else
                    Console.WriteLine("No");
                //Console.ReadLine();
            }
        }
    }
}

