using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdminSystemOppgave
{
    internal class General
    {
        private List<int> existingStudentIds = new List<int>();

        public int GetStudentId()
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