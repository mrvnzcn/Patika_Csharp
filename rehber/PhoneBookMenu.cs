using System;

namespace PhoneBookApp
{
    class PhoneBookMenu
    {
        public void MenuEkrani()
        {
            
            
            Console.WriteLine("\nLutfen yapmak istediginiz islemi seciniz :)");
            Console.WriteLine("************************************");
            Console.WriteLine("(1) Yeni Numara Kaydet");
            Console.WriteLine("(2) Mevcut Numara Sil");
            Console.WriteLine("(3) Mevcut Contact Güncelle");
            Console.WriteLine("(4) Rehberi Listele");
            Console.WriteLine("(5) Rehberde Arama Yap");
            Console.WriteLine("(q) Cikis");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            while (keyInfo.KeyChar != 'q')
            {
            
                if (keyInfo.KeyChar == '1')
                {
                    Console.WriteLine("\n1'e bastiniz.");
                    PhoneBookActions CreateContact = new PhoneBookActions();
                    CreateContact.contactCreate();
                    Console.ReadLine();
                }
                else if (keyInfo.KeyChar == '2')
                {
                    Console.WriteLine("\n2'e bastiniz.");
                    PhoneBookActions DeleteContact = new PhoneBookActions();
                    DeleteContact.contactDelete();
                    Console.ReadLine();
                }
                else if (keyInfo.KeyChar == '3')
                {
                    Console.WriteLine("\n3'e bastiniz.");
                    PhoneBookActions UpdateContact = new PhoneBookActions();
                    UpdateContact.contactUpdate();
                    Console.ReadLine();
                }
                else if (keyInfo.KeyChar == '4')
                {
                    Console.WriteLine("\n4'e bastiniz.");
                    PhoneBookActions ShowContacts = new PhoneBookActions();
                    ShowContacts.showContacts();
                    Console.ReadLine();
                }
                else if (keyInfo.KeyChar == '5')
                {
                    Console.WriteLine("\n5'e bastiniz.");
                    PhoneBookActions searchContacts = new PhoneBookActions();
                    searchContacts.contactSearch();
                    Console.ReadLine();
                }
                
                
                
                else
                {
                    Console.WriteLine("\nHatali tuslama yaptiniz...");
                    PhoneBookMenu App7 = new PhoneBookMenu();
                    App7.MenuEkrani();
                    
                }
            }

            Console.WriteLine("\nCikis yapiliyor..");
            for (int a = 10; a > 0; a--)
            {
                Console.WriteLine(a);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Console'u kapatmak icin herhangi bir tusa basiniz..");
            Console.ReadKey();
            Environment.Exit(0);
           
            // console kapat.


                
                
            
            
            
        }
    }
}