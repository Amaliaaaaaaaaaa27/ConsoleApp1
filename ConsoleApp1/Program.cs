using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numele elevului:");
            string nume = Console.ReadLine();

            Console.WriteLine("Introduceti prenumele elevului:");
            string prenume = Console.ReadLine();

            int[] noteElevi = new int[3]; 

            
            Elev elev = new Elev(nume, prenume, noteElevi);

           
            elev.IntroducereNoteElevi(elev.NoteElevi, elev.Text());


            elev.MediaNoteElev(elev.NoteElevi, elev.Text(), elev.SumaNotelor(elev.NoteElevi, elev.Text()));

            Console.WriteLine($"Elevul {elev.Nume}  {elev.Prenume} are notele: ");

            elev.AfisareNote(elev.NoteElevi); 

           
            Console.WriteLine($"Media notelor: {elev.MediaNoteElev(elev.NoteElevi, elev.Text(), elev.SumaNotelor(elev.NoteElevi, elev.Text()))}");

            // nou elev 

            Elev elev1 = elev;

            int[] noteElevi1 = new int[3];

            Console.WriteLine("Introduceti numele elevului:");
            string nume1 = Console.ReadLine();

            Console.WriteLine("Introduce ti prenumele elevului ");
            string prenume1= Console.ReadLine();


            elev1.IntroducereNoteElevi(elev1.NoteElevi, elev1.Text());


            elev1.MediaNoteElev(elev1.NoteElevi, elev1.Text(), elev1.SumaNotelor(elev1.NoteElevi, elev1.Text()));

            Console.WriteLine($"Elevul {elev1.Nume}  {elev1.Prenume} are notele: ");

            elev.AfisareNote(elev1.NoteElevi);


            Console.WriteLine($"Media notelor: {elev1.MediaNoteElev(elev1.NoteElevi, elev1.Text(), elev1.SumaNotelor(elev1.NoteElevi, elev1.Text()))}");


            // creem acum alt elev 

            Elev elev2 = elev;

            int[] noteElevi2 = new int[3];

            Console.WriteLine("Introduceti numele elevului:");
            string nume2 = Console.ReadLine();

            Console.WriteLine("Introduce ti prenumele elevului ");
            string prenume2 = Console.ReadLine();


            elev2.IntroducereNoteElevi(elev2.NoteElevi, elev2.Text());


            elev2.MediaNoteElev(elev2.NoteElevi, elev2.Text(), elev2.SumaNotelor(elev2.NoteElevi, elev2.Text()));

            Console.WriteLine($"Elevul {elev2.Nume}  {elev2.Prenume} are notele: ");

            elev2.AfisareNote(elev2.NoteElevi);


            Console.WriteLine($"Media notelor: {elev2.MediaNoteElev(elev2.NoteElevi, elev2.Text(), elev2.SumaNotelor(elev2.NoteElevi, elev2.Text()))}");

            // cast la medie in double 

           
        }

    }
}







       




   