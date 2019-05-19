using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGry
{
    public class Gra
    {

        int zakresOd;
        int zakresDo;
        int wylosowana;

        public Gra(int min = 1, int max = 100)
        {
            zakresOd = min;
            zakresDo = max;
            wylosowana = Losuj(min, max);
        }

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
