using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab5
{
    class Кондитерское_изделие : Продукт
    {
        public int chocolate_percent;
        virtual public void ifgorki()
        {
            if (type == 2)
            {
                if (chocolate_percent >= 70)
                {
                    Console.WriteLine("Шоколад горький");
                }
                else Console.WriteLine("Шоколад  не горький");
            }
            else Console.WriteLine("Кондитерское изделие не состоит из шоколада");
        }
        public override string ToString()
        {
            return (this.GetType() + " Производитель:" + name + " Вес:" + weight + " Количество:" + count + " Тип продукта:" + type + " Процент шоколада:" + chocolate_percent + "%");
        }
        public Кондитерское_изделие(string a, int b, int c, int d, int e) : base(a, b, c, d)
        {
            name = a;
            weight = b;
            count = c;
            type = d;
            chocolate_percent = e;
        }
    }
}
