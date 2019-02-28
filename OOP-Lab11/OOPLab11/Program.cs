using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab11
{

    partial class Heap : HashSet<int>
    {
        
        public override string ToString()
        {
            return base.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (this.GetType() != obj.GetType()) return false;
            return true;
        }
    }

    partial class Heap : HashSet<int>
    {
        
        private static int count { get; set; }

        public string name { get; set; }

        public int idHash
        {
            get
            {
                return this.GetHashCode();
            }
        }

        static Heap()
        {
            count = 0;
        }

        public Heap(string _name, params int[] elem)
        {
            name = _name;
            count++;
            for (int i = 0; i < elem.Length; ++i)
            {
                this.AddElem(elem[i]);
            }
        }

        public Heap()
        {
            count++;
        }

    }

    partial class Heap : HashSet<int>
    {

        public void AddElem(int elem)
        {
            this.Add(elem);
        }

        public void DelElem(int elem)
        {
            this.Remove(elem);
        }

        public void Elems()
        {
            Console.WriteLine($"Количество элементов в множестве: {this.Count()}");
        }

        public void ClassInfo()
        {
            Console.WriteLine("Название класса: Heap");
            Console.WriteLine($"Количество экземпляров класса: {Heap.count}");
        }
    }

        class Program
    {
        static void Main(string[] args)
        {

            string[] months = new string[]
            {

                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"

            };

            int n = 5;
            var LengthEqualsN =
                months
                .Where(month=> months.Length == n)
                .Select (month=>month);

            Console.WriteLine($"Months with names, which contain {n} symbols:");

            foreach (string s in LengthEqualsN)
                Console.WriteLine(s);

            Console.WriteLine();

            var SummerWinterMonths =
                from month in months
                where month == "December" || month == "January" || month == "February" || month == "June" || month == "July" || month == "August"
                select month;

            Console.WriteLine("Summer and Winter months:");

            foreach (string s in SummerWinterMonths)
                Console.WriteLine(s);

            Console.WriteLine();

            var AlphabeticalOrder =
                months.OrderBy(x => x);

            Console.WriteLine("Months in alphabetical order:");

            foreach (string s in AlphabeticalOrder)
                Console.WriteLine(s);

            Console.WriteLine();

            var ContainsU =
                from month in months
                where month.Contains('u')
                select month;


            Console.WriteLine("Months, which contain 'u':");

            foreach (string s in ContainsU)
                Console.WriteLine(s);

            Console.WriteLine();

            int b = 4;
            var LengthMoreThanB =
                from month in months
                where month.Length > b
                select month;

            Console.WriteLine($"Months with names, which contain more than {b} symbols:");

            foreach (string s in LengthMoreThanB)
                Console.WriteLine(s);

            Console.WriteLine();

            ////////////////////////////////////////////////////////////////////////
            
            Heap heap1 = new Heap("heap1", 65, -2, 3, 4, 5);
            Heap heap2 = new Heap("heap2", 45, 5, 6, 7, 134, 620);
            Heap heap3 = new Heap("heap3", 78, -89, 0);
            Heap heap4 = new Heap("heap4", 11, 22, -5, 1, 0);

            List<Heap> list = new List<Heap> { heap1, heap2, heap3, heap4 };

            var ListWithSums =
                from s in list
                select s.Sum();

            var MaxSum =
                ListWithSums.Max();

            var MinSum =
                ListWithSums.Min();

            Console.WriteLine("Maximum sum: " + MaxSum);
            Console.WriteLine("Minimum sum: " + MinSum);

            Console.WriteLine();

            var ListWithNegative =
                from s in list
                from v in s
                where v < 0
                select s.name;

            Console.WriteLine("Multitudes with negative elements:");

            foreach (string s in ListWithNegative)
                Console.WriteLine(s);

            Console.WriteLine();

            //Console.WriteLine("What u want find?");
            //int specEl = Convert.ToInt32(Console.ReadLine());
            int specEl = 5;
            var MultitudesWithSpecifiedElement =
                from s in list
                from v in s
                where v == specEl
                select s;


            Console.WriteLine("Quantity of multitudes with specified element: " + MultitudesWithSpecifiedElement.Count());

            Console.WriteLine();

            var MaxMultitudeQuery =
                from s in list
                select s.Count;

            int MaxMultitude = MaxMultitudeQuery.Max();

            Console.WriteLine("Max multitude: " + MaxMultitude);

            Console.WriteLine();

            var FirstMultitudeWithSpecifiedElementQuery =
                from s in list
                from v in s
                where v == specEl
                select s.name;

            string FirstMultitudeWithSpecifiedElement = FirstMultitudeWithSpecifiedElementQuery.First();

            Console.WriteLine("First multitude with specified element: " + FirstMultitudeWithSpecifiedElement);

            Console.WriteLine();

            var SortedArrayByFirstQuery =
                (from s in list
                 select s.ElementAt(0)).ToArray().OrderBy(x => x);


            Console.WriteLine("Sorted by first element array of multitudes: ");

            foreach (var a in SortedArrayByFirstQuery)
                Console.WriteLine(a);


            Console.WriteLine("Grouped by count of elements : ");

            IEnumerable<IGrouping<int, Heap>> outerSequence =
            list.GroupBy(o => o.Count);
            foreach (var item in outerSequence)
            {
                Console.WriteLine(item.Key + " Elements in ");
                foreach (var element in item)
                    Console.WriteLine(element.name);
            }

            int[] key = { 1, 4, 5, 7 };
            var sometype = months
            .Join(
            key, // внутренняя
            w => w.Length, // внешний ключ выбора
            q => q, // внутренний ключ выбора
            (q, w) => new // результат
            {
                id = w,
                name = string.Format("{0} ", q),
            });
            foreach (var item in sometype)
                Console.WriteLine(item);

        }
    }
}
