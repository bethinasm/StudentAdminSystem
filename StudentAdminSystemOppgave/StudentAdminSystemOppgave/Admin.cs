using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdminSystemOppgave
{
    internal class Admin
    {
        
        public List<Fag> Faglista { get; private set; }
        public List<Student> Studentlista { get; private set; }

        public Admin(List<Fag> faglista, List<Student> studentlista)
        {
            Faglista = faglista;
            Studentlista = studentlista;
        }

        public void Run(General general)
        {

        }
        
        public void Menu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Hva ønsker du å gjøre?");
                var userInput = Console.ReadLine();
                switch (userInput)
                {

                }
            }
        }

        public void MenuChoice()
        {

        }
    }
}