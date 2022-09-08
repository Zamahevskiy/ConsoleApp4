using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
     class Товар
    {
        public string name { get; set; }
        public int cena { get; set; }
        public int rayting { get; set; }
        public void uТовар()
        {
            Console.WriteLine($"Товар: {name} Цена: {cena} Рейтинг: {rayting}");
        }
    }
}
