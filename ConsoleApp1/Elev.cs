using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Elev
    {
        private string nume;

        private string prenume;

        private int[] noteElevi;


        public int[] NoteElevi

        {
            get { return noteElevi; }

            set { noteElevi = value; }
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public string Prenume
        {
            get { return nume; }
            set { nume = value; }

        }
        public Elev(string nume, string prenume, int[] noteElevi)
        {
            this.Nume = nume;
            this.Prenume = prenume;
            this.NoteElevi = new int[3];
        }
        // functie care calcula media => facem intai o metoda care va calcula media 
        public int[] IntroducereNoteElevi(int[] noteElevi, string[] texte)
        {
            int i = 0;

            for (i = 0; i < noteElevi.Length; i++)
            { 
                Console.Write(texte[i]);
                
                noteElevi[i] = int.Parse(Console.ReadLine());
            }

            return noteElevi;

        }
        public void AfisareNote(int[] noteElevi)
        {
           
            foreach (int index in noteElevi)
            {
                Console.Write($" {index} , ");  
            }
           
        }

        public int SumaNotelor(int[] noteElevi , string[] texte)
        {
            int sum = 0;

            foreach(int parcurgereNumere in noteElevi)
            {
              sum = sum + parcurgereNumere;
            }
            return sum;
        }
        public  double MediaNoteElev(int[] noteElevi , string[] texte , int sum)
        {
            double mediaNote =(double) (sum / noteElevi.Length);
      

            return mediaNote;
        }
        public string[] Text()
        {
            string[] texte = { "Tastati prima nota =", "Tastati a doua nota =  ", "Tastati a treia nota = "};

            return texte;

        }
        public void Tipareste()
        {
            Console.WriteLine($"Elevul are numele {Nume} {Prenume} si notele {noteElevi}");
        }




    }

}
