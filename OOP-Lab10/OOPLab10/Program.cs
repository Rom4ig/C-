using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab10
{
    class Student
    {
    }
    class Program
    {
        static void Main(string[] args)
        {          
            ArrayList arrayList = new ArrayList();
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                arrayList.Add(random.Next(0, 100));
            }
            Console.WriteLine("First collection of random ints: ");
            foreach (var element in arrayList)
                Console.Write(element + " ");
            Console.WriteLine("Added string 'string'");
            arrayList.Add("String");
            foreach (var element in arrayList)
                Console.Write(element + " ");
            Console.WriteLine();
            Student student = new Student();
            arrayList.Add(student);
            Console.WriteLine("Enter number of element to delete");
            arrayList.RemoveAt(Convert.ToInt32(Console.ReadLine()));
            foreach (var element in arrayList)
                Console.Write(element + " ");
            Console.WriteLine();
            Console.WriteLine("Count = " + arrayList.Count);
            Console.WriteLine(arrayList.Contains("String"));
            Console.WriteLine("Part 2");

            SortedSet<float> sortedSet = new SortedSet<float>();
             Console.Write("Enter size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter elements of new collection: ");
            for (int i = 0; i < size; i++)
            {
                sortedSet.Add(Convert.ToSingle(Console.ReadLine()));
            }
            Console.WriteLine();
            Console.Write("Enter count of elements you would like to delete: ");
            int toDelete = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < toDelete; i++)
                {
                    sortedSet.Remove(sortedSet.First());
            }
            foreach (float element in sortedSet)
                Console.Write(element + " ");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            sortedSet.Add((float)1.23);
            foreach (float element in sortedSet)
                Console.WriteLine(element + " ");
            Queue<float> queue = new Queue<float>();
            for (int i = 0; i < sortedSet.Count; i++)
            {
                queue.Enqueue(sortedSet.ElementAt(i));
            }
            Console.Write("Second collection Queue<float>: ");
            foreach (float element in sortedSet)
                Console.Write(element + " ");
            Console.WriteLine();
            Console.Write("\nEnter element you would like to find: ");
            Console.WriteLine(sortedSet.Contains(Convert.ToSingle(Console.ReadLine())));
            Console.WriteLine("--------------------------------------------");



            Tovar sweet = new Tovar("Sweet", 50, 25);
            Tovar meat = new Tovar("Meat", 300, 150);
            Tovar bread = new Tovar("Bread", 200, 100);
            Tovar milk = new Tovar("Milk", 150, 75);
            int key = sweet.CompareTo(meat);
            switch (key)
            {
                case 1: Console.WriteLine("Cost sweet>cost meat"); break;
                case 0:Console.WriteLine("Cost sweet=cost meat"); break;
                case -1: Console.WriteLine("Cost sweet<cost meat"); break;
            }
            SortedSet<Tovar> tovar = new SortedSet<Tovar>
            {
                sweet,
                meat,
                bread,
                milk
            };
            foreach (Tovar element in tovar)
                Console.WriteLine(element + " ");
            Console.Write("Enter number of elements you would like to delete: ");
            int Delete = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Delete; i++)
            {
                tovar.Remove(tovar.First());
            }
            foreach (Tovar element in tovar)
                Console.WriteLine(element + " ");
            Console.WriteLine("--------------------------------------------");

            Queue<Tovar> tovarqueue = new Queue<Tovar>();
            for (int i = 0; i < tovar.Count; i++)
            {
                tovarqueue.Enqueue(tovar.ElementAt(i));
            }
            Console.Write("Second collection Queue<Tovar>: ");
            foreach (Tovar element in tovar)
                Console.WriteLine(element + " ");
            Console.WriteLine();           
            Console.WriteLine("--------------------------------------------");


            ObservableCollection<Tovar> observableCollection = new ObservableCollection<Tovar>();
            observableCollection.CollectionChanged += Notification;
            observableCollection.Add(sweet);
            observableCollection.Remove(meat);
        }
        static void Notification(object sender, NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("The collection has been changed");
        }
    }
}
