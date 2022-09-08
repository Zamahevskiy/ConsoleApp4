using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
     class Basket : Категория
    {
        public int MasivBuyTovarov { get; set; }
        public void uBasket()
        {
            Console.WriteLine($"Масив купленных товаров: {MasivBuyTovarov}");
        }
    }
}
