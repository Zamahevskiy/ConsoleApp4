using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
     class Категория : Товар
    {
        public int MasivTovarov { get; set; }
        public void uКатегория()
        {
            Console.WriteLine($"Имя: {name} Масив товаров: {MasivTovarov}");
        }
    }
}
