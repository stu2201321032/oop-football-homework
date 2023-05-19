using System;

namespace oop_homework
{
    public class Player : Person
    {
        public int Number { get; private set; }
        public int Height { get; private set; }

        public Player(string name, int age, int number, int height) : base(name, age)
        {
            Number = number;
            Height = height;
        }
    }
}
