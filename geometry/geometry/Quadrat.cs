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


        //berechnung Flaeche
        public override float Flaeche()
        {
            float f1 = Seite1 * Seite2;
            return f1;
        }

        //berechnung Umfang
        public override float Umfang()
        {
            float u1 = (Seite1 * 2) + (Seite2 * 2);
            return u1;
        }

        //override + print
        public override string ToString()
        {
            return ($"Das Quadrat hat eine Flaeche von {Umfang()} und einen Umfang von {Flaeche()}");
        }

    }
}
