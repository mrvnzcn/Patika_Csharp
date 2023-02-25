﻿using System;
using System.Collections;

namespace arraylist
{
    class Program
    {
        public static object? True { get; private set; }

        static void Main(string[] args)
        {
            //System.Collections namespace

            ArrayList liste = new ArrayList();
            // liste.Add("Mervan");
            // liste.Add(2);
            // liste.Add(true);
            // liste.Add('A');

            //içeride verilere erişim
            // Console.WriteLine(liste[1]);

            // foreach (var item in liste)
            //     Console.WriteLine(item);

            //AddRange
            Console.WriteLine("***** Add Range *****");
            // string[] renkler = {"sarı","kırmızı","yeşil"};
            List<int> sayılar = new List<int>(){1,8,3,7,9,92,5};
            // liste.AddRange(renkler);
            liste.AddRange(sayılar);

            foreach (var item in liste)
                Console.WriteLine(item);

            //Sort
            Console.WriteLine("*****Sort*****");
            liste.Sort();
            foreach (var item in liste)
                Console.WriteLine(item);

            //Binary Search
            Console.WriteLine("*** BinarySearch ***");
            Console.WriteLine(liste.BinarySearch(9));

            //Reverse
            Console.WriteLine("*** Reverse ***");
            liste.Reverse();
            foreach (var item in liste)
                Console.WriteLine(item);

            //Clear
            liste.Clear();
            foreach (var item in liste)
                Console.WriteLine(item);
            
        }
    }
}