using StudentAdminSystemOppgave;

Console.WriteLine("OPPGAVE: Studentadministrasjons system");

var general = new General();

List<Fag> AlleFag = new List<Fag>
{
    new Fag ( "IT101", "Introduksjon til IT utvikling", 10 ),
    new Fag ( "ST101", "How to become a successful sock thief", 10 ),
    new Fag ( "BA201", "Kneading 101", 10 ),
    new Fag ( "BA202", "What describes a good loaf and how to achive one", 10 ),
    new Fag ( "IT103", "Nøkkelkompetanse", 10 )
};

List<Student> alleStudenter = new List<Student>
{
    new Student ("Bethina S. M", 28, "IT utvikling", general.GetStudentId(), new List<Fag> { AlleFag[0], AlleFag[4] }, new List<Karakter>{new Karakter(AlleFag[0], 3.5), new Karakter(AlleFag[4], 3.9)}),
    new Student ("Oscar Katt", 1,"Sock Theft 101", general.GetStudentId(), new List<Fag> { AlleFag[1] }, new List<Karakter>{new Karakter(AlleFag[1], 5.7)}),
    new Student ("Kairo Katt", 2, "Baking", general.GetStudentId(), new List<Fag> { AlleFag[2], AlleFag[3] }, new List<Karakter>{new Karakter(AlleFag[2], 4.6), new Karakter(AlleFag[3], 4.1)}),
};

var admin = new Admin(AlleFag, alleStudenter);
admin.Run(general);
