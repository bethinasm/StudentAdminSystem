using StudentAdminSystemOppgave;

Console.WriteLine("OPPGAVE: Studentadministrasjons system");
var Student = new Student();
var Karakter = new Karakter();
var Fag = new Fag();

Main();


void Main()
{
    var existingStudentIds = new List<int>();

    var student1 = new Student {StudentName = "Bethina S. M", StudentAge = 28, StudieProgram = "IT utvikling", StudentID = Student.GetStudentId(existingStudentIds) };
    var student2 = new Student {StudentName = "Oscar Katt", StudentAge = 1, StudieProgram  = "Couch Destroying 101", StudentID = Student.GetStudentId(existingStudentIds)};
    var student3 = new Student { StudentName = "Kairo Katt", StudentAge = 2, StudieProgram = "Baking", StudentID = Student.GetStudentId(existingStudentIds) };


    var fag1 = new Fag();
}



