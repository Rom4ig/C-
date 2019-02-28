using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab15
{
    public class Thread_Handler
    {
        static object locker = new object();
        public Thread myThread;
        public Thread myThread1;
        public int Num { get; set; }
        public Thread_Handler(int num)
        {
            myThread = new Thread(this.Even);
            myThread1 = new Thread(new ThreadStart(this.Odd)) { Priority = ThreadPriority.AboveNormal };
            Num = num;
        }
        public void Count(object obj)
        {
            int x = (int)obj;
            for (int i = 1; i < 9; i++, x++)
            {
                Console.WriteLine( x * i);
            }
        }
      
        public void Even()
        {
            for (int i = 0; i < Num; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
                Thread.Sleep(500);
            }
        }
        public void Odd()
        {
            for (int i = 0; i < Num; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
                Thread.Sleep(500);
            }
        }
    }
}