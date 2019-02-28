using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16
{
    public static class Store
    {
        public static BlockingCollection<int> store;

        public static void Producer()
        {
            for (int i = 1; i <= 10; i++)
            {
                store.Add(i);
                Console.WriteLine("Продавец: " + i);
            }
            store.CompleteAdding();
        }

        public static void Consumer()
        {
            int i;
            while (!store.IsCompleted)
            {
                if (store.TryTake(out i))
                {
                    Console.WriteLine("Покупатель: " + i);
                }
            }
        }

        public static void Work()
        {
            store = new BlockingCollection<int>(5);
            Task Pr = new Task(Producer);
            Task Cn = new Task(Consumer);
            Pr.Start();
            Cn.Start();
            try
            {
                Task.WaitAll(Cn, Pr);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Cn.Dispose();
                Pr.Dispose();
                store.Dispose();
            }
        }
    }
}