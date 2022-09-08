using System;
using ConsoleApp4;

namespace Program
{
     class Program : User
    {
        static void Main(string[] args)
        {
            Товар товар = new Товар { name = "Banana", cena = 30, rayting = 10 };
            товар.uТовар();
            Категория категория = new Категория { name = "Good",  MasivTovarov = 7 };
            Категория категория1 = new Категория { name = "Exelent",  MasivTovarov = 10 };
            категория.uКатегория();
            категория1.uКатегория();
            Basket basket = new Basket { MasivBuyTovarov = 25 };
            basket.uBasket();
            User user = new User { login = "ProstoBOG", password = "8(800)555-35-35" };
            user.uUser();
        }
    }
}
