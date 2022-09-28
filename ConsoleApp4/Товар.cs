using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
     class Goods
    {
        public string name { get; set; }
        public int price { get; set; }
        public int rating { get; set; }
        public void uGoods()
        {
            Console.WriteLine($"Товар: {name} Цена: {price} Рейтинг: {rating}");
        }
    }
}
