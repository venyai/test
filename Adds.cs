using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Кофейни
{
    public enum сироп { Нет, Карамель, Гренадин, Мята, Ваниль, Шоколад, БлюКюрасао, Фундук };
    public enum алкоголь { Нет, Бренди, Ликер, Ром, Виски};
    class Add
    {
        
        public List<Add> Adds = new List<Add>()
        {
            new Add()
            {
                Корица = false,
                Сироп = сироп.Нет,
                Сахар = 0,
                Алкоголь = алкоголь.Нет,
            }
        };

        public bool Корица { get; set; }
        public сироп Сироп { get; set; }
        public int Сахар { get;  set; }
        public алкоголь Алкоголь { get;  set; }
    }
}
