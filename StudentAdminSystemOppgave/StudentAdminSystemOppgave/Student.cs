using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdminSystemOppgave
{
    internal class Student
    {
        public string StudentName { get; private set; } // get; set; = 50% private 50% public
        public int StudentAge { get; private set; }
        public string StudieProgram { get; private set; }
        private int _studentID; // understrek + liten bokstav fordi private, blir lettere å lese
        public List<Fag> FagListe { get; private set; }
        public List<Karakter> KarakterListe { get; private set; } 

        public Student(string name, int age, string program, int id, List<Fag> Fag, List<Karakter> Karakter)
        {
            StudentName = name;
            StudentAge = age;
            StudieProgram = program;
            _studentID = id;
            FagListe = Fag;
            KarakterListe = Karakter;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Student ID: {_studentID} \nStudentens navn: {StudentName}\nAlder: {StudentAge}\nStudie: {StudieProgram}");
        }


        public double BeregnGjennomsnittKarakter()
        {
            // tar inn alle karakterer og deler de på antall fag
            double alleKarakterer = 0;

            foreach (Karakter info in KarakterListe)
            {
                alleKarakterer += info.KarakterTall;
            }
            double sum = alleKarakterer / KarakterListe.Count;

            return sum;
        }

        public int TotaltStudiePoeng()
        {
            int allePoeng = 0;
            // regne ut alle studiepoeng en student har (plusse alle poeng sammen)
            foreach (Fag info in FagListe)
            {
                allePoeng += info.StudiePoeng;
            }
            return allePoeng;
        }
    }
}
