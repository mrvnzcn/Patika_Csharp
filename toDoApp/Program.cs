using System;

namespace ToDoApp {
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ToDo Uygulamasına Hoş Geldiniz!");
            Console.WriteLine("=================================");
            Board board = new Board(); // Varsayılan board oluştur

            while (true)
            {
                // Kullanıcıya yapmak istediği işlemi seçtir
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
                Console.WriteLine("(1) Board Listelemek");
                Console.WriteLine("(2) Board'a Kart Eklemek");
                Console.WriteLine("(3) Board'dan Kart Silmek");
                Console.WriteLine("(4) Kart Tasimak");

                string secim = Console.ReadLine();
                
                // Kullanıcının seçimine göre ilgili işlemi yap
                switch (secim) {
                    case "1":
                        UserInterface.BoardListele(board);
                        break;
                    case "2":
                        UserInterface.KartEkle(board);
                        break;
                    case "3":
                        UserInterface.KartSil(board);
                        break;
                    case "4":
                        UserInterface.KartTasi(board);
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                        break;
                }
                
                Console.WriteLine(); // İşlem sonrası bir satır boşluk bırak
                // Seçime göre ilgili UserInterface fonksiyonunu çağır
            }
        }
    }
}