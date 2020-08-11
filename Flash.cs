using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Flash : Human, IFlash
    {
        public override string Name 
        {
            get;

            set; 
                 
        }

        public void ActivateSuperPowers()
        {
            Console.WriteLine($"I flash!");
        }

        public void FireLightnings()
        {
            Console.WriteLine($"Lightning Fire!");
        }
        private int _volt;
        
        public string Voltage { get; private set; }

        internal int Volt
        {
            get
            {
                return _volt;
            }
            set
            {
                if(Volt > 0)
                {
                    _volt = Volt;
                }
            }
        }
        public Flash(string name, int age, int volt) : base (name, age)
        {
            this.Name = name;
            this.Age = age;
            this.Volt = volt;
        }

        public override string ToString()
        {
            return $"{base.ToString()} volt : {_volt}";
        }
    }
}
