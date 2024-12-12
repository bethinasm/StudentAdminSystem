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
        public string StudentName { get; set; }
        public int StudentAge { get; set; }
        public string StudieProgram { get; set; }
        public int StudentID { get; set; }
        public List<Fag> FagListe { get; set; }
        public List<Karakter> KarakterListe { get; set; } 

        public Student(string name, int age, string program, int id, List<Fag> Fag, List<Karakter> Karakter)
        {
            StudentName = name;
            StudentAge = age;
            StudieProgram = program;
            StudentID = id;
            FagListe = Fag;
            KarakterListe = Karakter;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Student ID: {StudentID} \nStudentens navn: {StudentName}\nAlder: {StudentAge}\nStudie: {StudieProgram}");
        }

        

        public double BeregnGjennomsnittKarakter()
        {
            // regne ut gjennomsnitt karakter til en student
            return;
        }

        public int TotaltStudiePoeng()
        {
            // regne ut alle studiepoeng en student har
            return;
        }
    }
}
