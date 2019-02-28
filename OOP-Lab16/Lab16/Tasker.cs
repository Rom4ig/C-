using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab16
{
    public static class Tasker
    {
        public static void GetTask(int size, int num)
        {
            Console.WriteLine("GetTask: ");
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Vector vector = new Vector(size);
            Task task = Task.Factory.StartNew(() => vector = vector * num);
            Console.WriteLine("Status: " + task.Status);
            task.Wait();
            watch.Stop();
            Console.WriteLine("{0}:{1}", watch.Elapsed.Seconds, watch.Elapsed.Milliseconds);
        }
        public static async Task FourSum(Vector one, Vector two, Vector three)
        {
            Task<int> task1 = new Task<int>(() => one.Sum());
            task1.Start();
            Task<int> task2 = new Task<int>(() => two.Sum());
            task2.Start();
            Task<int> task3 = new Task<int>(() => three.Sum());
            task3.Start();
            Task<Vector> task4 = new Task<Vector>(() => new Vector(task1.Result + task2.Result + task3.Result));
            Task task5 = task4.ContinueWith(Display);
            task4.Start();
            task5.Wait();
            Console.WriteLine(task4.Result.Sum());
        }
        public static void Display(Task task)
        {
            Console.WriteLine("ID сейчас: {0}", Task.CurrentId);
            Console.WriteLine("ID до: {0}", task.Id);
            Thread.Sleep(3000);
        }
    }

}
