﻿using System;

namespace PhoneBookApp
{
    class Program
    {
        static void Main()
        {
            
            PhoneBookActions DefaultContacts = new PhoneBookActions();
            DefaultContacts.DefaultContactCreate();
            PhoneBookMenu App1 = new PhoneBookMenu();
            App1.MenuEkrani();

            
            
            // Console.WriteLine("Name: " + contact.username);
            // Console.WriteLine("Last Name: " + contact.userlastname);
            // Console.WriteLine("Phone: " + contact.userphone);
            
            // contact.username = "Jane";
            // contact.userlastname = "Smith";
            // contact.userphone = "987-654-3210";
            
            // Console.WriteLine("Name: " + contact.username);
            // Console.WriteLine("Last Name: " + contact.userlastname);
            // Console.WriteLine("Phone: " + contact.userphone);

            Console.ReadLine();
        }
    }

    

}