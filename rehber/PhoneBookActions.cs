using System;

namespace PhoneBookApp
{
    class PhoneBookActions
    {
      
      
      
        static List<PhoneBookContacts> ContactList = new List<PhoneBookContacts>();
        


      
      
           
       private static int i = 0; 
      
      
      
      public int contactCreate()
      {
        
        // PhoneBookContacts contact11 = new PhoneBookContacts("Mervan","Ismail","905349318717",1);
        // PhoneBookContacts contact22 = new PhoneBookContacts("Nur","Efsan","905348381212",2);
        // PhoneBookContacts contact33 = new PhoneBookContacts("Eda","Karaca","905549730484",3);
        // PhoneBookContacts contact44 = new PhoneBookContacts("Taskin","Ozcan","905332232121",4);
        // PhoneBookContacts contact55 = new PhoneBookContacts("Can","Yilmaz","905392441516",5);
        
        // ContactList.Add(contact11);
        // ContactList.Add(contact22);
        // ContactList.Add(contact33);
        // ContactList.Add(contact44);
        // ContactList.Add(contact55);
        
        PhoneBookContacts contact1 = new PhoneBookContacts("","","",0);
        Console.WriteLine("Lutfen isim giriniz          :");
        contact1.username = Console.ReadLine();
        Console.WriteLine("Lutfen soyisim giriniz          :");
        contact1.userlastname = Console.ReadLine();
        Console.WriteLine("Lutfen telefon numarasi giriniz          :");
        contact1.userphone = Console.ReadLine();
        Console.WriteLine("Contact basariyla kaydedildi!");

        
        i++;
        contact1.userid = i;
        
        

        ContactList.Add(contact1);                                             //Contact Create işlemim aslında bu

        Console.WriteLine("Contact ID: " + contact1.userid);
        int count = ContactList.Count;
        Console.WriteLine("Rehberdeki Kisi Sayisi: " + count);
        PhoneBookMenu App2 = new PhoneBookMenu();
        App2.MenuEkrani();


        

        
        
        
        return contact1.userid; 
        //kontak create edildiğinde id döndürülmesi sağlanacaktır. userid.
        //contactCreate dediğim parametreleri bi dictionary içine yazacağız. 
      }

      public void contactDelete()
      {
        Console.WriteLine("\nLutfen silmek istediginiz contact için AD VEYA SOYAD bilgisini giriniz:");
        string deletedFullName = Console.ReadLine();
        PhoneBookContacts result = ContactList.Find(contact => 
        contact.username.Equals(deletedFullName) || contact.userlastname.Equals(deletedFullName));
        
        if (deletedFullName != null && result != null)
        {
            if (result != null)
            {
                Console.WriteLine("{0} {1} isimli kisi rehberden silinmek uzere, onayliyor musunuz) (y/n)",result.username,result.userlastname);
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.KeyChar == 'y')
                {
                    Console.WriteLine("\nContact was deleted successfully");
                    ContactList.Remove(result);
                    PhoneBookMenu App6 = new PhoneBookMenu();
                    App6.MenuEkrani();
                    //result list içinden silinecek
                }
                else if (keyInfo.KeyChar == 'n')
                {
                    PhoneBookMenu App3 = new PhoneBookMenu();
                    App3.MenuEkrani();
                    //menü gösterilsin
                    //app1 nesne adı tekrar oluşturulduğunda ne oluyor test edelim.
                }
                else
                {
                    Console.WriteLine("Hatali tuslama yaptiniz..");
                    PhoneBookMenu App4 = new PhoneBookMenu();
                    App4.MenuEkrani();
                    //hatali giris yaptiniz, menu gosterilsin
                }
            }
        }

        else
        {
            Console.WriteLine("\nAradiginiz kriterlere uygun veri rehberde bulunamadi, lutfen nasil devam etmek istediginizi seciniz:");
            Console.WriteLine("\n\tSilmeyi sonlandirmak icin: (1)");
            Console.WriteLine("\n\tYeniden denemek icin: (2)");


            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.KeyChar == '1')
            {
                PhoneBookMenu App4 = new PhoneBookMenu();
                App4.MenuEkrani();
            }
            else if (keyInfo.KeyChar == '2')
            {
                PhoneBookActions DeleteContact = new PhoneBookActions();
                DeleteContact.contactDelete();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Hatali tuslama yaptiniz, menuye yonlendiriliyor.");
                PhoneBookMenu App5 = new PhoneBookMenu();
                App5.MenuEkrani();

            }
        }

        

        
        //kontak silinecek
        //contactdelete dediğim parametreleri bi dictionary içinden sileceğiz.

      }

      public void contactUpdate()
      {
        Console.WriteLine("\nLutfen guncellemek istediginiz contact için AD VEYA SOYAD bilgisini giriniz:");
        string updatedFullName = Console.ReadLine();
        PhoneBookContacts result1 = ContactList.Find(contact1 => 
        contact1.username.Equals(updatedFullName) || contact1.userlastname.Equals(updatedFullName));

        if (updatedFullName != null && result1 != null)
        {
            if (result1 != null)
            {
                Console.WriteLine("{0} {1} isimli kisi guncellenmek uzere, onayliyor musunuz) (y/n)",result1.username,result1.userlastname);
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.KeyChar == 'y')
                {
                    
                    Console.WriteLine("\nLutfen isim giriniz          :");
                    result1.username = Console.ReadLine();
                    Console.WriteLine("Lutfen soyisim giriniz          :");
                    result1.userlastname = Console.ReadLine();
                    Console.WriteLine("Lutfen telefon numarasi giriniz          :");
                    result1.userphone = Console.ReadLine();
                    Console.WriteLine("Contact basariyla guncellendi!");
                    
                    //güncellemek icin tekrar contac create sorularını sor.
                    //alinan bilgileri olanlariyle degistir.
                    
                    
                    
                    PhoneBookMenu App6 = new PhoneBookMenu();
                    App6.MenuEkrani();
                    
                }
                else if (keyInfo.KeyChar == 'n')
                {
                    PhoneBookMenu App3 = new PhoneBookMenu();
                    App3.MenuEkrani();
                    //menü gösterilsin
                    //app1 nesne adı tekrar oluşturulduğunda ne oluyor test edelim.
                }
                else
                {
                    Console.WriteLine("Hatali tuslama yaptiniz..");
                    PhoneBookMenu App4 = new PhoneBookMenu();
                    App4.MenuEkrani();
                    //hatali giris yaptiniz, menu gosterilsin
                }
            }
        }

        else
        {
            Console.WriteLine("\nAradiginiz kriterlere uygun veri rehberde bulunamadi, lutfen nasil devam etmek istediginizi seciniz:");
            Console.WriteLine("\n\tGuncellemeyi sonlandirmak icin: (1)");
            Console.WriteLine("\n\tYeniden denemek icin: (2)");


            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.KeyChar == '1')
            {
                PhoneBookMenu App4 = new PhoneBookMenu();
                App4.MenuEkrani();
            }
            else if (keyInfo.KeyChar == '2')
            {
                PhoneBookActions UpdateContact = new PhoneBookActions();
                UpdateContact.contactUpdate();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Hatali tuslama yaptiniz, menuye yonlendiriliyor.");
                PhoneBookMenu App5 = new PhoneBookMenu();
                App5.MenuEkrani();

            }
        }

        //kontak güncellenecek
        //contactupdate dediğim parametreleri bi dictionary içinde değiştireceğiz.
      }
      
      public void showContacts()
      {
        
        if (ContactList.Count != 0)
        {
            foreach (var item in ContactList)
            {
                Console.WriteLine("\nPhoneBook\t\tCreated by mrvnzcn");
                Console.WriteLine("Toplam Contact Sayisi: {0}",ContactList.Count);
                Console.WriteLine("************************************************");
                Console.WriteLine("Ad: {0}",item.username);
                Console.WriteLine("Soyad: {0}",item.userlastname);
                Console.WriteLine("Telefon Numarasi: {0}",item.userphone);
                Console.WriteLine("Contact ID: {0}",item.userid);
                Console.WriteLine("************************************************");

                
            }

            PhoneBookMenu App7 = new PhoneBookMenu();
            App7.MenuEkrani();
        }

        else
        {
            Console.WriteLine("Rehber bos oldugu icin goruntulenemiyor. Lutfen contact ekleyiniz");
            PhoneBookMenu App8 = new PhoneBookMenu();
            App8.MenuEkrani();

        }

        
      }  
    
      public void DefaultContactCreate()
      {
        
        // PhoneBookContacts contact11 = new PhoneBookContacts("Mervan","Ismail","905349318717",1);
        // PhoneBookContacts contact22 = new PhoneBookContacts("Nur","Efsan","905348381212",2);
        // PhoneBookContacts contact33 = new PhoneBookContacts("Eda","Karaca","905549730484",3);
        // PhoneBookContacts contact44 = new PhoneBookContacts("Taskin","Ozcan","905332232121",4);
        // PhoneBookContacts contact55 = new PhoneBookContacts("Can","Yilmaz","905392441516",5);
        
        // ContactList.Add(contact11);
        // ContactList.Add(contact22);
        // ContactList.Add(contact33);
        // ContactList.Add(contact44);
        // ContactList.Add(contact55);
        
            for (int j = 0; j < 5; j++)
            {
                PhoneBookContacts contact0 = new PhoneBookContacts("","","",0);
                contact0.username = string.Format("Mervan{0}",j);
                contact0.userlastname = string.Format("Ismail{0}",j);
                contact0.userphone = string.Format("90534931871{0}",j);
                Console.WriteLine("Contact basariyla kaydedildi!");
                i++;
                contact0.userid = i;
                ContactList.Add(contact0);                                             //Contact Create işlemim aslında bu
                Console.WriteLine("Contact ID: " + contact0.userid);
                int count = ContactList.Count;
                Console.WriteLine("Rehberdeki Kisi Sayisi: " + count);
            }
            
            PhoneBookMenu App2 = new PhoneBookMenu();
            App2.MenuEkrani();
        //kontak create edildiğinde id döndürülmesi sağlanacaktır. userid.
        //contactCreate dediğim parametreleri bi dictionary içine yazacağız. 
      }

      public void contactSearch()
      {
        Console.WriteLine("Arama yapmak istediginiz tipi seciniz.");
        Console.WriteLine("*************************************************");
        Console.WriteLine("İsim veya soyisime gore arama yapmak icin: (1)");
        Console.WriteLine("Telefon numarasina göre arama yapmak icin: (2)");
        ConsoleKeyInfo keyInfo = Console.ReadKey();


        if (keyInfo.KeyChar == '1')
        {
            Console.WriteLine("\nIsim veya soy isim giriniz:");
            string searchedFullName = Console.ReadLine();
            var result2 = ContactList.Where(contact2 =>
            contact2.username.Contains(searchedFullName) || contact2.userlastname.Contains(searchedFullName));

            if (searchedFullName != null && result2 != null)
            {
                Console.WriteLine("\nArama Sonuclariniz:");
                
                
                foreach (var result4 in result2)
                {
                    Console.WriteLine("****************************");
                
                    Console.WriteLine("Ad: {0}",result4.username);
                    Console.WriteLine("Soyad: {0}",result4.userlastname);
                    Console.WriteLine("Telefon Numarasi: {0}",result4.userphone);
                    Console.WriteLine("****************************");
                }
                

                PhoneBookMenu App6 = new PhoneBookMenu();
                App6.MenuEkrani();


            }
            else
            {
                Console.WriteLine("Sonuc bulunamadi...");
                PhoneBookMenu App4 = new PhoneBookMenu();
                App4.MenuEkrani();
            }
        }

        else if (keyInfo.KeyChar == '2')
        {
            Console.WriteLine("\nTelefon Numarasi giriniz:");
            string searchedPhoneNumber = Console.ReadLine();
            var result3 = ContactList.Where(contact3 =>
            contact3.userphone.Contains(searchedPhoneNumber));

            if (searchedPhoneNumber != null && result3 != null)
            {
                Console.WriteLine("\nArama Sonuclariniz:");
                
                foreach (var result5 in result3)
                {
                    Console.WriteLine("****************************");
                
                    Console.WriteLine("Ad: {0}",result5.username);
                    Console.WriteLine("Soyad: {0}",result5.userlastname);
                    Console.WriteLine("Telefon Numarasi: {0}",result5.userphone);
                    Console.WriteLine("****************************");
                }
                
                

                PhoneBookMenu App6 = new PhoneBookMenu();
                App6.MenuEkrani();


            }
            else
            {
                Console.WriteLine("Sonuc bulunamadi...");
                PhoneBookMenu App4 = new PhoneBookMenu();
                App4.MenuEkrani();
            }
        }
        else
        {
            Console.WriteLine("Hatali tuslama yaptiniz..");
            PhoneBookMenu App4 = new PhoneBookMenu();
            App4.MenuEkrani();

        }

        
        

        
    {
      
        }


      }
       
       //contactCreate()->bir list içine bilgileri(nesne) yaz. isim + soyisim + numara -> id dönecek
       //contactDelete()->list'ten bilgileri sil. var olan kaydı bul(ad veya soy ad ile) -> bulamazsa silmeyi sonlandır ya da yeniden dene.bulursa onay için y/n?
       //contactUpdate()->var olan kaydı değiştir. var olan kaydı bul(ad veya soy ad ile) -> bulamazsa güncellemeyi sonlandır ya da yeniden dene.bulursa onay için y/n?
    }

    
    
}