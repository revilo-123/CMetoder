﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Slett9999
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kall på metodene som er definert under.
            //Der hvor det er en return, opprett variabel for å holde på returverdien
            SkrivHei();

            string returverdi = ReturnerHei();
            Console.WriteLine(returverdi);

            SkrivNoe("Dette er en test!!!!");

                int sum = Add(5, 3);
            Console.WriteLine("Summen av tallene er: " + sum);

            AddNoReturn(10, 15);

            Console.ReadLine();//for at consolet ikke skal stenges
        }

        public static void SkrivHei()
        {
            //Skriv kodelinjen som skriver hei ut til consol
            Console.WriteLine("Hei");

        }

        
        public static string ReturnerHei()
        {
            string bolle = "Hei";
            return bolle;
        }

        public static void SkrivNoe(string tekst)
        {
            Console.WriteLine(tekst);
        }

        
        public static int Add(int tall1, int tall2)
        {
            return tall1 + tall2;
        }

        public static void AddNoReturn(int num1, int num2)
        {
            Console.WriteLine(num1+num2);
        }
    }
}
