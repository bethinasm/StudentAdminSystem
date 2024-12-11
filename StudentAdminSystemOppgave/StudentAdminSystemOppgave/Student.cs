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
        private List<Fag> FagListe { get; set; } = new List<Fag>();
        private List<Karakter> KarakterListe { get; set; } = new List<Karakter>();

        //ctor
        /*public Student(string name, int age, string program, int id)
        {
            StudentName = name;
            StudentAge = age;
            StudieProgram = program;
            StudentID = id;
        }*/

        public void PrintInfo()
        {
            Console.WriteLine($"Student ID: {StudentID} \nStudentens navn: {StudentName}\nAlder: {StudentAge}\nStudie: {StudieProgram}");
        }

        public int GetStudentId(List<int> existingStudentIds)
        {
            Random rand = new Random();
            int randomId = rand.Next(1, 501); // gir en id

            while (existingStudentIds.Contains(randomId)) // sjekker om id allerede eksisterer
            {
                randomId = rand.Next(1, 501); // gir ny id om nødvendig
            }

            existingStudentIds.Add(randomId); // legger til den nye id i listen
            return randomId;
        }
    }
}
