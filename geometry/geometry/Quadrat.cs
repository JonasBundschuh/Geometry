using System;

namespace geometry
{
    public class Quadrat : Geometry
    {
        public float Seite1 { get; set; }
        public float Seite2 { get; set; }

        public Quadrat(float seite1, float seite2)
        {
            Seite1 = seite1;
            Seite2 = seite2;
        }

        float f1 = 0;
        float u1 = 0;

        public override float Flaeche()
        {
            float f1 = Seite1 * Seite2;
            return f1;
        }

        public override float Umfang()
        {
            float u1 = (Seite1 * 2) + (Seite2 * 2);
            return u1;
        }

        public override string ToString()
        {
            Console.WriteLine($"Das Quadrat hat eine Flaeche von {f1} und einen Umfang von {u1}");
            return ToString();
        }

    }
}
