using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab5
{
    class Часы : Товар
    {
        public enum Types { meh = 1, electric, cvartz };
        public int type;
        public override string ToString()
        {
            switch (this.type) {
                case 1: return (this.GetType() + " Производитель:" + name + " Вес:" + weight + " Количество:" + count + " Тип часов: механические");
                case 2: return (this.GetType() + " Производитель:" + name + " Вес:" + weight + " Количество:" + count + " Тип часов: электрические"); 
                case 3: return (this.GetType() + " Производитель:" + name + " Вес:" + weight + " Количество:" + count + " Тип часов: кварцовые"); 
                default: return (this.GetType() + " Производитель:" + name + " Вес:" + weight + " Количество:" + count + " Тип часов: None"); 

            }
        }
        public Часы(string a, int b, int c, Types d, int g) : base(a, b, c)
        {
            name = a;
            weight = b;
            count = c;
            type = (int)d;
            cost = g * c;
        }
    }
}
