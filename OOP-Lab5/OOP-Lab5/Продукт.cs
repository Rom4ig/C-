using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab5
{
    class Продукт : Товар
    {
        public enum types { milk = 1, chocolate, meat };
        public int type;
        public override string ToString()
        {
            return (this.GetType() + " Производитель:" + name + " Вес:" + weight + " Количество:" + count + " Тип продукта:" + type);
        }
        public Продукт(string a, int b, int c, int d) : base(a, b, c)
        {
            name = a;
            weight = b;
            count = c;
            type = d;
        }
    }
}
