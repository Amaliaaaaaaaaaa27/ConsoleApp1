using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Catalog:Elev
    {
        private string[] totiElevi;

        public string[] TotiElevi
        {
            get { return totiElevi; }
            set { totiElevi = value; }
        }

        public Catalog(string nume,string prenume, int[] noteElevi, string[] totiElevi):base(nume, prenume, noteElevi)
        {
            this.totiElevi = totiElevi;
        }


        public void GetPremiantul(int mediaNote)
        {
            int mediaCeMaiMare = 0;

               if (mediaCeMaiMare> mediaNote)
               {
                Console.WriteLine($"Media cea mai mare este = {mediaCeMaiMare}");
               }
        }

        
        // functie tipareste care va afisa numele clasei si care va tiparii fiecare elev in parte 

        // functei GetPremiantul care va determina elevul cu media cea mai mare 

       


    }
}
