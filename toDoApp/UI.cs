using System;

namespace ToDoApp {
    public class UserInterface
    {
        public static void BoardListele(Board board)
        {
            // Board listeleme işlevi
            Console.WriteLine("TODO Line");
            ListeyiYazdir(board.TODO);

            Console.WriteLine("IN PROGRESS Line");
            ListeyiYazdir(board.INPROGRESS);

            Console.WriteLine("DONE Line");
            ListeyiYazdir(board.DONE);
        }

        private static void ListeyiYazdir(Line line)
        {
            foreach (var kart in line.KartListesi)
            {
                Console.WriteLine($"Başlık: {kart.Baslik}");
                Console.WriteLine($"İçerik: {kart.Icerik}");
                Console.WriteLine($"Atanan Kişi: {TakimUyeleri.Uyeler[kart.AtananKisiID]}");
                Console.WriteLine($"Büyüklük: {kart.Buyukluk}");
                Console.WriteLine();
            }
            
            if (line.KartListesi.Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            
            Console.WriteLine();
    }

        public static void KartEkle(Board board)
        {
            // Kart ekleme işlevi
            Console.WriteLine("Başlık Giriniz: ");
            string baslik = Console.ReadLine();

            Console.WriteLine("İçerik Giriniz: ");
            string icerik = Console.ReadLine();

            Console.WriteLine("Büyüklük Seçiniz -> XS(1), S(2), M(3), L(4), XL(5): ");
            int buyuklukSecim;
            if (int.TryParse(Console.ReadLine(), out buyuklukSecim) && Enum.IsDefined(typeof(KartBuyukluk), buyuklukSecim))
            {
                KartBuyukluk buyukluk = (KartBuyukluk)buyuklukSecim;

                Console.WriteLine("Kişi Seçiniz: ");
                foreach (var uye in TakimUyeleri.Uyeler)
                {
                    Console.WriteLine($"{uye.Key}) {uye.Value}");
                }
                int atananKisiID;
                if (int.TryParse(Console.ReadLine(), out atananKisiID) && TakimUyeleri.Uyeler.ContainsKey(atananKisiID))
                {
                    Kart yeniKart = new Kart
                    {
                        Baslik = baslik,
                        Icerik = icerik,
                        AtananKisiID = atananKisiID,
                        Buyukluk = buyukluk
                    };

                    Console.WriteLine("Kart başarıyla eklendi!");
                    board.TODO.KartListesi.Add(yeniKart);
                }
                else
                {
                    Console.WriteLine("Geçersiz kişi seçimi!");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz büyüklük seçimi!");
            }
        }

        public static void KartSil(Board board)
        {
            // Kart silme işlevi
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız: ");
            string arananBaslik = Console.ReadLine();

            Kart bulunanKart = null;
            Line bulunanLine = null;

            foreach (var line in new Line[] { board.TODO, board.INPROGRESS, board.DONE })
            {
                bulunanKart = line.KartListesi.FirstOrDefault(kart => kart.Baslik == arananBaslik);
                if (bulunanKart != null)
                {
                    bulunanLine = line;
                    break;
                }
            }

            if (bulunanKart != null)
            {
                Console.WriteLine("Bulunan Kart Bilgileri:");
                Console.WriteLine($"Başlık: {bulunanKart.Baslik}");
                Console.WriteLine($"İçerik: {bulunanKart.Icerik}");
                Console.WriteLine($"Atanan Kişi: {TakimUyeleri.Uyeler[bulunanKart.AtananKisiID]}");
                Console.WriteLine($"Büyüklük: {bulunanKart.Buyukluk}");
                if (bulunanLine == board.TODO)
                {
                    Console.WriteLine("Line: TODO");
                }
                else if (bulunanLine == board.INPROGRESS)
                {
                    Console.WriteLine("Line: IN PROGRESS");
                }
                else
                {
                    Console.WriteLine("Line: DONE");
                }

                
                Console.WriteLine("Kartı silmek istediğinize emin misiniz? (E/H)");
                string cevap = Console.ReadLine();
                if (cevap.Equals("E", StringComparison.OrdinalIgnoreCase))
                {
                    bulunanLine.KartListesi.Remove(bulunanKart);
                    Console.WriteLine("Kart başarıyla silindi!");
                }
                else
                {
                    Console.WriteLine("Kart silme işlemi iptal edildi.");
                }
            }
            else
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı.");
            }
        }

        public static void KartTasi(Board board)
        {
            // Kart taşıma işlevi
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız: ");
            string arananBaslik = Console.ReadLine();

            Kart bulunanKart = null;
            Line bulunanLine = null;

            foreach (var line in new Line[] { board.TODO, board.INPROGRESS, board.DONE })
            {
                foreach (var kart in line.KartListesi)
                {
                    if (kart.Baslik == arananBaslik)
                    {
                        bulunanKart = kart;
                        bulunanLine = line;
                        break;
                    }
                }
                if (bulunanKart != null)
                    break;
            }

            if (bulunanKart != null)
            {
                Console.WriteLine("Bulunan Kart Bilgileri:");
                Console.WriteLine($"Başlık: {bulunanKart.Baslik}");
                Console.WriteLine($"İçerik: {bulunanKart.Icerik}");
                Console.WriteLine($"Atanan Kişi: {TakimUyeleri.Uyeler[bulunanKart.AtananKisiID]}");
                Console.WriteLine($"Büyüklük: {bulunanKart.Buyukluk}");
                string lineText;
                if (bulunanLine == board.TODO)
                    lineText = "TODO";
                else if (bulunanLine == board.INPROGRESS)
                    lineText = "IN PROGRESS";
                else
                    lineText = "DONE";

                Console.WriteLine($"Line: {lineText}");
                
                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
                Console.WriteLine("(1) TODO");
                Console.WriteLine("(2) IN PROGRESS");
                Console.WriteLine("(3) DONE");

                if (int.TryParse(Console.ReadLine(), out int secim) && secim >= 1 && secim <= 3)
                {
                    Line hedefLine = secim == 1 ? board.TODO : (secim == 2 ? board.INPROGRESS : board.DONE);
                    bulunanLine.KartListesi.Remove(bulunanKart);
                    hedefLine.KartListesi.Add(bulunanKart);

                    Console.WriteLine("Kart başarıyla taşındı!");
                }
                else
                {
                    Console.WriteLine("Hatalı bir seçim yaptınız!");
                }
            }
            else
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı.");
            }
        }
    }
}