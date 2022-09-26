namespace geometry
{
    public class Pyramide : Geometry
    {
        public float Seite1 { get; set; }
        public float Seite2 { get; set; }
        public float Seite3 { get; set; }
        public float Seite4 { get; set; }
        public float Seite5 { get; set; }



        public Pyramide(float seite1, float seite2, float seite3, float seite4, float seite5)
        {
            Seite1 = seite1;
            Seite2 = seite2;
            Seite3 = seite3;
            Seite4 = seite4;
            Seite5 = seite5;
        }


        //Rechnung fläche
        public override float Flaeche()
        {
            float f1 = Seite1 * Seite2;
            return f1;
        }

        //Rechnung Umfang
        public override float Umfang()
        {
            float u1 = 3 * Seite1;
            return u1;
        }


        //Override & Print
        public override string ToString()
        {
            return ($"Die Pyramide hat eine Flaeche von {Flaeche()} und einen Umfang von {Umfang()}");
        }

    }
}
