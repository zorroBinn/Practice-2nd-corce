using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2nd_corce
{
    internal class Person
    {
        public string State { get; set; } //Текущий статус
        public System.Drawing.Color Color { get; set; } //Цвет
        public int Age { get; set; } //Возраст (у человека)

        public Person() //Конструктор по умолчанию (пустая ячейка)
        {
            State = "Empty";
            Color = System.Drawing.Color.WhiteSmoke;
            Age = 0;
        }
    }
}
