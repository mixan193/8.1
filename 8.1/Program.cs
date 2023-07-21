using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1
{
    internal class Program
    {
        static List<int> list = new List<int>();

        static void Main(string[] args)
        {
            CompleteTheList(100);
            PrintList();
            FilterTheList(25, 50);
            PrintList();
            Console.ReadKey();
        }

        private static void CompleteTheList(int count)
        {
            Random rnd = new Random();
            for(int i = 0; i < count; i++)
            {
                list.Add(rnd.Next(100));
            }
        }

        private static void FilterTheList(int min, int max)
        {
            List<int> listOfIndexesToDelete = new List<int>();
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i] > min && list[i] < max)
                {
                    listOfIndexesToDelete.Add(i);
                }
            }
            for(int i = listOfIndexesToDelete.Count - 1; i >= 0; i--)
            {
                list.RemoveAt(listOfIndexesToDelete[i]);
            }
        }

        private static void PrintList()
        {
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
    }
}
