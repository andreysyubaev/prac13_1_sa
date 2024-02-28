using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ArrayList list = new ArrayList();
                list.Add(4.5);
                list.Add(18);
                list.AddRange(new string[] { "Студент", "Петров" });

                foreach (object e in list)
                {
                    Console.WriteLine(e);
                }

                list.Remove(0);
                list.Reverse();

                Console.WriteLine(list[1]);

                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }
                Console.WriteLine("=================");
                ArrayList list2 = new ArrayList();
                list2.Add(3.5);
                list2.Add(16);
                Console.Write("введите: ");
                int n1 = int.Parse(Console.ReadLine());
                if (n1 < list2.Count || n1 > 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    list.InsertRange(n1, list2);
                    Console.WriteLine();
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine(list[i]);
                    }
                }
                Console.Write("k: ");
                int k = int.Parse(Console.ReadLine());
                if (k > list.Count || k < 0)
                {
                    Console.WriteLine("erorr");
                }
                else
                {
                    list.RemoveRange(n1 / 2, k);
                    Console.WriteLine();
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine(list[i]);
                    }
                }
                
                Console.Read();
            
            }
            catch
            {
                Console.WriteLine("error");
                Console.ReadKey();
                return;
            }
            
        }
    }
}
