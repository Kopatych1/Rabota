using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;
using static _1Praktik.Searching;


namespace _1Praktik
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Для выбора сортировки напишите 1 и следом Enter");
            Console.WriteLine("Для выбора прямым поиском напишите 2 и следом Enter");
            string EntryKey = Console.ReadLine();
            if (EntryKey == "1")
                Sort();
            else if (EntryKey == "2")
                Search();
        }
        public static void Sort()
        {
            int N = 100000;
            int[] a = new int[N];
            Random r = new Random();
            for (int i = 0; i < N; i++)
                a[i] = r.Next() % 300;
            Sort sorts = new Sort();
            Timing timing = new Timing();
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            timing.StartTime();

            sorts.SortInsertion(a);

            stopwatch.Stop();
            timing.StopTime();

            Console.WriteLine("Результат секундомера при сортировке вставками" + stopwatch.Elapsed.ToString());
            Console.WriteLine("Результат сортировки вставками по времени:" + timing.Result().ToString());

        }
        public static void Search()
        {
            int N = 1000000;
            int[] a = new int[N];
            Random random = new Random();
            for (int i = 0; i < N; i++)
                a[i] = random.Next();
            Sort sorts = new Sort();
            Timing timing = new Timing();
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Бинарный поиск");
            Console.WriteLine("Введите любое число до 1000000");
            int x = Convert.ToInt32(Console.ReadLine());
            stopwatch.Start();
            timing.StartTime();

            sorts.SortInsertion(a);

            int z = BinarySearch(a, x);

            stopwatch.Stop();
            timing.StopTime();

            Console.WriteLine("Результат секундомера при пузырьковой сортировке: " + stopwatch.Elapsed.ToString());

            Console.WriteLine("Временной результат пузырьковой сортировки:" + timing.Result().ToString());
        }
    }
}
