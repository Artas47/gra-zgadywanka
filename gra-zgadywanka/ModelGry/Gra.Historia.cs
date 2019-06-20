using System;
using System.Collections.Generic;
using System.Text;

namespace ModelGry
{
    public partial class Gra
    {
        private readonly List<Ruch> historia;
        IReadOnlyList<Ruch> Historia => historia;

        // klasa wewnetrzna
        public class Ruch
        {
            public readonly int Propozycja;
            public readonly Odp Odpowiedz;
            public readonly DateTime Kiedy;

            public Ruch(int prop, Odp odp)
            {
                Propozycja = prop;
                Odpowiedz = odp;
                Kiedy = DateTime.Now;
            }

            public override string ToString() =>
                $"({Propozycja}, {Odpowiedz}, {Kiedy})";

        } //konie klasy Ruch



    }
}