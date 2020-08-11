using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class SuperMan : Human, IFly
    {
        public override string Name
        {
            get;
            set;
        }

        public void ActivateSuperPowers()
        {
            Console.WriteLine($"I fly!");
        }

        public void Fly()
        {
            Console.WriteLine($"Flying!"); 
        }
        private int _webleft;
        public int WebLeft { get; set; }

        internal int WebLeft1
        {
            get
            {
                return _webleft;
            }
            set
            {
                if (WebLeft > 0)
                {
                    _webleft = WebLeft;
                }

            }
        }
            public SuperMan(string name, int age, int webleft) : base(name, age)
        {
            this.Name = name;
            this.Age = age;
            this.WebLeft = webleft;
        }
        public override string ToString()
        {
            return $"{base.ToString()} webleft : {_webleft}";
        }
    }
    }

