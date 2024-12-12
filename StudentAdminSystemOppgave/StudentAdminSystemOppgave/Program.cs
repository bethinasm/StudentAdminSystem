using StudentAdminSystemOppgave;

Console.WriteLine("OPPGAVE: Studentadministrasjons system");

List<int> existingStudentIds = new List<int>();
List<Fag> AlleFag = new List<Fag>
{
    new Fag ( "IT101", "Introduksjon til IT utvikling", 30 ),
    new Fag ( "ST101", "How to become a successful sock thief", 10 ),
    new Fag ( "BA201", "Kneading 101", 40 ),
};


Main();


void Main()
{
    // Studenter
    var student1 = new Student ("Bethina S. M", 28, "IT utvikling", GetStudentId(), new List<Fag> { AlleFag[0], AlleFag[1] }, new List<Karakter>{new Karakter(AlleFag[0], 3.5), new Karakter(AlleFag[1], 4.1)});
    var student2 = new Student ("Oscar Katt", 1,"Sock Theft 101", GetStudentId());
    var student3 = new Student ("Kairo Katt", 2, "Baking", GetStudentId());
    
}

int GetStudentId()
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

