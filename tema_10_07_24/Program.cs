using System;

public static class Helper
{
    private static Random random = new Random();

    public static string GenerareCodUnic(string prefix)
    {
        int numarAleatoriu = random.Next(1000, 9999);
        return $"{prefix}{numarAleatoriu}";
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine(Helper.GenerareCodUnic("PRF"));
        Console.WriteLine(Helper.GenerareCodUnic("COD"));
        Console.WriteLine(Helper.GenerareCodUnic("TEST"));
    }
}
