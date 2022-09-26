using System;

namespace geometry
{
    public class Kreis : Geometry
    {
        public float Radius { get; set; }

        public Kreis(float radius)
        {
            Radius = radius;
        }


        //berechnung Flaeche
        public override float Flaeche()
        {
            return (float)Math.PI * (Radius * Radius);
        }

        //Berechnung Umfang
        public override float Umfang()
        {
            return 2 * Radius * (float)Math.PI;
        }


        //override + print
        public override string ToString()
        {
            return ($"Der Kreis hat einen Umfang von {Umfang()} und eine Fläche von {Flaeche()}");
        }

    }
}
