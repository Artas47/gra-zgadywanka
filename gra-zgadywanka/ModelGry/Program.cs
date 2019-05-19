using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGry
{
    public class Gra
    {

        //subtypes

        public enum Odp { ZaMalo = -1, Trafiono = 0, ZaDuzo = 1 };
        public enum StanGry { Trwa, Poddana, Odgadnieta };

        //fields

        public readonly int zakresOd;
        public readonly int zakresDo;
        private readonly int wylosowana;
        public StanGry Stan { get; private set; } = 0;

        public int LicznikRuchow { get; private set; } = 0; // jest publiczny - mozesz czytac, ograniczam dostep ze prywatnie mozesz modyfikowac(automatic properties)


        //historia gry toDo


        // constructors

        public Gra(int min = 1, int max = 100)
        {
            zakresOd = min;
            zakresDo = max;
            wylosowana = Losuj(zakresOd, zakresDo);
            Stan = StanGry.Trwa;
        }

        //methods

        Odp Ocena(int liczba)
        {
            LicznikRuchow++;
            if (liczba < wylosowana)
            {
                return Odp.ZaMalo;
            } else if (liczba > wylosowana)
            {
                return Odp.ZaDuzo;
            }
            else
            {
                Stan = StanGry.Odgadnieta;
                return Odp.Trafiono;
            }
        }

        public void Poddaj()
        {
            Stan = StanGry.Poddana;
        }


        // auxilary methods
        private int Losuj(int min = 1, int max = 100) //wartosci domyslne
        {
            if (min > max)
            {
                int temp = max; //zmienna dodatkowa 
                max = min;
                min = temp;
            }
            Random generator = new Random();
            return generator.Next(min, max + 1);
        }
        static void Main(string[] args)
        {
            
           

        }
    }
}
