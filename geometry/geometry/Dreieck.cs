using System;

namespace geometry
{
    public class Dreieck : Geometry
    {
        public float Seite1 { get; set; }
        public float Seite2 { get; set; }
        public float Seite3 { get; set; }
        public float Höhe { get; set; }

        public Dreieck(float seite1, float seite2, float seite3, float höhe)
        {
            Seite1 = seite1;
            Seite2 = seite2;
            Seite3 = seite3;
            Höhe = höhe;
        }


        //berechnung Flaeche
        public override float Flaeche()
        {
            float f1 = 0.5F * Seite1 * Höhe;
            return f1;
        }

        //Berechnung Umfang
        public override float Umfang()
        {
            float u1 = Seite1 + Seite2 + Seite3;
            return u1;
        }


        //override + print
        public override string ToString()
        {
            return ($"Das Dreieck hat einen Umfang von {Umfang()} und eine Fläche von {Flaeche()}");
        }

    }
}
