using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab5
{
    class Конфеты : Кондитерское_изделие
    {
        string mark;
        public override string ToString()
        {
            return (this.GetType() + " Производитель:" + name + " Вес:" + weight + " Количество:" + count + " Тип продукта:" + type + " Процент шоколада:" + chocolate_percent + "%" +" Марка:" + mark);
        }
        public Конфеты(string a, int b, int c, int d, int e, string f, int g) : base(a, b, c, d, e)
        {
            name = a;
            weight = b;
            count = c;
            type = d;
            chocolate_percent = e;
            mark = f;
            cost = g * c;
        }
    }
}
