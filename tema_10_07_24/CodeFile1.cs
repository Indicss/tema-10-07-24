using System;

public class Carte
{
    public string Titlu { get; set; }
    public string Autor { get; set; }
    public int AnPublicare { get; set; }
    public int NumarPagini { get; set; }

    public Carte(string titlu, string autor, int anPublicare, int numarPagini)
    {
        Titlu = titlu;
        Autor = autor;
        AnPublicare = anPublicare;
        NumarPagini = numarPagini;
    }

    public void AfisareDetalii()
    {
        Console.WriteLine($"Titlu: {Titlu}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Anul Publicarii: {AnPublicare}");
        Console.WriteLine($"Numar Pagini: {NumarPagini}");
    }
}

class ProgramEx2
{
    static void MainEx2()
    {
        Carte carte = new Carte("C# pentru incepatori", "Ursu Nicolae", 2024, 300);
        carte.AfisareDetalii();
    }
}
