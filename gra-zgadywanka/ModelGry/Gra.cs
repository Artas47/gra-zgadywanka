using System;
using System.Collections.Generic;

namespace ModelGry
{
    public partial class Gra
    {
        // subtypes
        public enum Odp { ZaMalo = -1, Trafiono = 0, ZaDuzo = 1 }
        public enum StanGry { Trwa, Poddana, Odgadnieta }


        // fields
        public readonly int ZakresOd;
        public readonly int ZakresDo;
        private readonly int wylosowana;
        public int? Wylosowana
        {
            get
            {
                if (Stan != StanGry.Trwa)
                    return wylosowana;
                else
                    return null;
            }
        }

        public StanGry Stan { get; private set; }

        public int LicznikRuchow { get; private set; } = 0;

        // historia gry: ToDo


        //constructors
        public Gra(int min = 1, int max = 100)
        {
            ZakresOd = min;
            ZakresDo = max;

            wylosowana = Losuj(ZakresOd, ZakresDo);
            //LicznikRuchow = 0;
            Stan = StanGry.Trwa;
            historia = new List<Ruch>();
        }

        // methods
        public Odp Ocena(int liczba)
        {
            LicznikRuchow++;
            Odp odp;
            if (liczba < wylosowana)
                odp = Odp.ZaMalo;
            else if (liczba > wylosowana)
                odp = Odp.ZaDuzo;

            // trafiono
            Stan = StanGry.Odgadnieta;
            odp = Odp.Trafiono;
            historia.Add(new Ruch(liczba, odp));

            return odp;
        }

        public void Poddaj()
        {
            Stan = StanGry.Poddana;
        }

        // auxiliary methods
        public static int Losuj(int min = 1, int max = 100)
        {
            if (min > max)
            {
                int temp = max;
                max = min;
                min = temp;
            }
            Random generator = new Random();
            return generator.Next(min, max + 1);
        }
    }
}