using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Spiderman : Human, IClimb
    {
        public override string Name 
        { 
            get;
            set;
        }

        public void ActivateSuperPowers()
        {
            Console.WriteLine($"I climb!");
        }

        public void Climb()
        {
            Console.WriteLine($"Climbing!");
        }
        private int _speed;
        public int Speed { get; private set; }

        internal int Speed1
        {
            get
            {
                return _speed;
            }
            set
            {
                if(Speed > 0)
                {
                    _speed = Speed;
                }
            }
        }

        public Spiderman(string name, int age, int speed) : base(name, age)
        {
            this.Name = name;
            this.Age = age;
            this.Speed = speed;
        }
        public override string ToString()
        {
            return $"{base.ToString()} speed : {_speed}";
        }
    }
}
