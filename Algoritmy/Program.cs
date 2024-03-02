using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Algoritmy
{

    public class User
    {
        public string Pass { get; set; }
        public string Name { get; set; }
        public bool IsPrem { get; set; }

        public User(string pass, string name, bool isPrem)
        {
            Pass = pass;
            Name = name;
            IsPrem = isPrem;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            User[] users =
            {
                new User("pass12", "Ivan", false),
                new User("pass123", "Stas", true)
            };

            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].IsPrem == false)
                {
                    Console.WriteLine($"Приветствуем, {users[i].Name} ");
                    ShowAds();
                }
                else
                {
                    Console.WriteLine($"Приветствуем, {users[i].Name}");
                }

            }
        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}
