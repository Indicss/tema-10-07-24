using System;

public class Student
{
    public string Nume { get; set; }
    public int Varsta { get; set; }
    public string Specializare { get; set; }

    public Student(string nume, int varsta, string specializare)
    {
        Nume = nume;
        Varsta = varsta;
        Specializare = specializare;
    }

    public Student(Student student)
    {
        Nume = student.Nume;
        Varsta = student.Varsta;
        Specializare = student.Specializare;
    }

    public void AfisareDetalii()
    {
        Console.WriteLine($"Nume: {Nume}");
        Console.WriteLine($"Varsta: {Varsta}");
        Console.WriteLine($"Specializare: {Specializare}");
    }
}

class ProgramEx3
{
    static void MainEx3()
    {
        Student student1 = new Student("Ana Ionescu", 21, "Informatica");
        Student student2 = new Student(student1);

        student1.Nume = "Madalina Caltea";
        student1.Varsta = 20;
        student1.Specializare = "Matematica";




        Console.WriteLine("Detalii student1:");
        student1.AfisareDetalii();







        Console.WriteLine("\nDetalii student2:");
        student2.AfisareDetalii();
    }
}
