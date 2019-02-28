using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace Lab16
{
    public static class Paralleler
    {
        public static void For()
        {
            Console.WriteLine("\n\nFor");
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Generate(10000);
            watch.Stop();
            Console.WriteLine("Общий цикл -> Время выполнения: {0}:{1} ", watch.Elapsed.Seconds, watch.Elapsed.Milliseconds);
            watch.Start();
            Parallel.For(1, 10000, Generate);
            watch.Stop();
            Console.WriteLine("Параллельный цикл-> Время выполнения: {0}:{1}\n ", watch.Elapsed.Seconds, watch.Elapsed.Milliseconds);
        }
        public static void ForEach()
        {
            Console.WriteLine("\nForEach");
            Stopwatch watch = new Stopwatch();
            watch.Start();
            foreach (int vec in new List<int>() { 10000, 10000 })
            {
                Generate(vec);
            }
            watch.Stop();
            Console.WriteLine("Общий цикл-> Время выполнения: {0}:{1} ", watch.Elapsed.Seconds, watch.Elapsed.Milliseconds);
            watch.Start();
            ParallelLoopResult result = Parallel.ForEach<int>(new List<int>() { 10000, 10000 }, Generate);
            watch.Stop();
            Console.WriteLine("Параллельный цикл-> Время выполнения: {0}:{1}\n ", watch.Elapsed.Seconds, watch.Elapsed.Milliseconds);
        }
        public static void Generate(int n)
        {
            Vector vector = new Vector(n);
        }
        public static void DoubleTask(int n)
        {
            Parallel.Invoke(Display, () =>
            {
                Console.WriteLine("Текущее: {0}", Task.CurrentId);
                Thread.Sleep(300);
                Generate(n);
            },
                                    () => Generate(n));
        }
        private static void Display()
        {
            Console.WriteLine("Текущее: {0}", Task.CurrentId);
            Thread.Sleep(3000);
        }
    }
}
