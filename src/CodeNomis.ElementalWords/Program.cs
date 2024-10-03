namespace CodeNomis.ElementalWords;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Starting...");
        Console.WriteLine();

        ElementalWords.ElementalForms("snack");
        ElementalWords.ElementalForms("beach");
        ElementalWords.ElementalForms("yes");

        Console.WriteLine();
        Console.WriteLine("Finished!");
        Console.ReadKey();
    }
}
