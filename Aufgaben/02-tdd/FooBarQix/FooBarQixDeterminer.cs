using System;
using System.Threading;

namespace FooBarQix
{
    public class FooBarQixDeterminer
    {
        public string Determine(int Eingabe)
        {
            string EingabeString = Eingabe.ToString();
            string Resultat = "";
            if(Eingabe % 3 == 0){
              Resultat += "Foo";
            }
            if(Eingabe % 5 == 0){
              Resultat += "Bar";
            }
            if(Eingabe % 7 == 0){
              Resultat += "Qix";
            }
            if (Resultat == "")
            {
                Resultat += Eingabe.ToString();
            }
            return Resultat;
        }
    }
}