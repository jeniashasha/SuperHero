using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    abstract class Human
    {
        private int _age;
        public abstract string Name { get; set; }
        internal int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (Age > 0 && Age < 100)
                {
                    _age = Age;
                }

            }
        }
            public Human (string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public override string ToString()
        {
            return $"{base.ToString()} name : {Name}, age : {_age}";
        }
    }
    }


