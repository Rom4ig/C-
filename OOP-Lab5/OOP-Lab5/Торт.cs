using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab5
{
    class Торт : Кондитерское_изделие
    {
        string mark;
        public override string ToString()
        {
            return (this.GetType() + " Производитель:" + name + " Вес:" + weight + " Количество:" + count + " Тип продукта:" + type + " Марка:" + mark);
        }
        public override void ifgorki()
        {
            if (type == 2)
            {
                if (chocolate_percent >= 70)
                {
                    Console.WriteLine("Шоколад в торте горький");
                }
                else Console.WriteLine("Шоколад  в торте горький");
            }
            else Console.WriteLine("В торте нет шоколада");
        }
        public Торт(string a, int b, int c, int d, int e, string f, int g) : base(a, b, c, d, e)
        {
            name = a;
            weight = b;
            count = c;
            type = d;
            chocolate_percent = e;
            mark = f;
            cost = g*c;
        }
    }
}
