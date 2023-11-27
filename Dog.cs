using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Dog : Animals
    {
        public Dog(string name, string voiceSound, int age) : base(name, voiceSound, age)
        {
            Console.WriteLine($"Введите имя, тип голоса и возраст собаки");
            name = Console.ReadLine();
            voiceSound = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Имя: {name}  Голос: {voiceSound}  Возраст: {age}");
        }
    }
}
