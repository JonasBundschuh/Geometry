using System;
using System.Collections.Generic;

namespace geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Daten für formen fest setzen
            Dreieck d = new Dreieck(4, 5, 6, 7);
            Quadrat q = new Quadrat(5, 7);
            Kreis k = new Kreis(4);

            //neue Liste erstellen
            List<Geometry> forms = new List<Geometry>();

            //formen zur Liste hinzufügen
            forms.Add(q);
            forms.Add(d);
            forms.Add(k);

            //Liste ausgeben
            foreach (Geometry geometry in forms)
            {
                Console.WriteLine(geometry.ToString());

            }


            Console.ReadKey();

        }
    }
}
