using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab5
{
    partial class Цветы : Товар
    {
        public int length;
        public string color;
        public override string ToString()
        {
            return (this.GetType() + " Вид:" + name + " Вес:" + weight + " Количество:" + count + " Длина:" + length + " Цвет:" + color);
        }
    }
}
