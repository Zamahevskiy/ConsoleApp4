using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
     class Category : Goods
    {
       
        public int ArrayOfGoods { get; set; }
        public void uCategory()
        {
            Console.WriteLine($"Имя: {name} Масив товаров: {ArrayOfGoods}");
        }
    }
}
