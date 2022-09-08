using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class User : Basket
    {
        public string login { get; set; }
        public string password { get; set; }
        public void uUser()
        {
            Console.WriteLine($"Псевдоним: {login} Пароль: {password}");
        }
    }
}
