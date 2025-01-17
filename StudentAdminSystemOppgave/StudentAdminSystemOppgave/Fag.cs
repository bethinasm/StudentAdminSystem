﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdminSystemOppgave
{
    internal class Fag
    {
        public string FagNavn { get; set; }
        public string FagKode { get; set; }
        public int StudiePoeng { get; set; }

        public Fag(string name, string code, int points)
        {
            FagNavn = name;
            FagKode = code;
            StudiePoeng = points;
        }

        public void PrintInfo(List<Fag> faglista)
        {
            foreach (Fag item in faglista)
            {
                Console.WriteLine($"- Fag: {FagNavn}\nFagkode: {FagKode}\nStudiepoeng: {StudiePoeng}");
            }
        }
    }
}