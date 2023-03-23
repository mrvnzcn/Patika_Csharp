using System;
class Dikdortgen
    {
        public string Isim="";
        private int mEn;
        private int mBoy;

        public int En 
        {
            get 
            {
                return mEn;
            } 
            set
            {
                if (value < 0)
                    mEn = 0;
                else
                    mEn=value;
            }
            
        }

        public int Boy
        {
            get
            {
                return mBoy;
            }
            set
            {
                if(value<0)
                    mEn = 0;
                else
                    mEn=value;
            }
        }



        public void EnBoyBelirle(int en, int boy, string isim)
        {
            
            if (en < 0 || boy < 0)
            {
                en = 0;
                boy = 0;
            }
            else
            {
                this.En = en;
                this.Boy = boy;
            }



            
            Isim = isim;
        }

        public int AlanHesapla()
        {
            int alan = En * Boy;
            return alan;
        }

        public void TumBilgileriYaz()
        {
            Console.WriteLine("**********{0} Dikdortgen Bilgileri*************",Isim);
            Console.WriteLine("Dikdortgenin En(cm): {0}",En);
            Console.WriteLine("Dikdortgenin Boy(cm): {0}",Boy);
            Console.WriteLine("Dikdortgenin Alan(cm): {0}",AlanHesapla());
            Console.WriteLine("*******************************************");
        }
    }