using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void ActivateHero(ISuperHero superHero)
        {
            superHero.ActivateSuperPowers();
        }
        static void IdentifyHero(ISuperHero superHero)
        {
            if(superHero is SuperMan)
            {
                Console.WriteLine("Superman detected");
            }
            else if(superHero is Flash)
            {
                Console.WriteLine("Flash detected");
            }
            else
            {
                Console.WriteLine("Spiderman detected");
            }
        }
        static void GetMoreHeroData(ISuperHero superHero)
        {
            if (superHero is SuperMan)
            {
                SuperMan superMan = superHero as SuperMan;
                superMan.Fly();
            }
            else if (superHero is Flash)
            {
                Flash flash = superHero as Flash;
                flash.FireLightnings();
            }
            else
            {
                Spiderman spiderman = superHero as Spiderman;
                spiderman.Climb();
            }
        }
        static ISuperHero CreateHero(string hulk)
        {
            if (hulk == "SpiderMan")
            {
                Spiderman spider = new Spiderman("Tim", 25, 140);
                return spider;

            }
            else if (hulk == "Flash")
            {
                Flash f = new Flash("Mark", 85, 220);
                return f;
            }
            else if(hulk == "SuperMan")
            {
                SuperMan super = new SuperMan("Charles", 40, 5);
                return super;
            }
            else
            {
                return null;
            }
        }



        static void Main(string[] args)
        {
            Flash f = new Flash("Diego", 31, 220);
            Spiderman s = new Spiderman("Marcus", 28, 120);
            SuperMan m = new SuperMan("Carlos", 30, 50);
            ISuperHero [] _superHeroes = { f, s, m};
            foreach (ISuperHero superHero in _superHeroes)
            {
                ActivateHero(superHero);
            }


        }
    }
}
