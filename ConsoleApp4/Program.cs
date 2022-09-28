using System;
using ConsoleApp4;

namespace ConsoleApp4
{
     class Program : User
    {
        static void Main(string[] args)
        {
            Goods goods = new Goods { name = "Banana", price = 30, rating = 10 };
            goods.uGoods();
            Category category7 = new Category { name = "Good", ArrayOfGoods = 7 };
            Category category10 = new Category { name = "Exelent", ArrayOfGoods = 10 };
            category7.uCategory();
            category10.uCategory();
            Basket basket = new Basket { ArrayOfPurchasedGoods = 10 };
            basket.uBasket();
            User user = new User { login = "ProstoBOG", password = "8(800)555-35-35" };
            user.uUser();
        }
    }
}
