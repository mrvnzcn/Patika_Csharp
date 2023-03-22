namespace arayuzler_ornek
{
    public class Fabia : IOtomobil
    {
        public Marka HangiMarkaninAraci()
        {
            return Marka.Skoda;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Kirmizi;
        }
    }
}