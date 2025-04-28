using PGL.Core;

internal class Program
{
    private static void Main(string[] args)
    {
        StringWithSlots stringWithSlots = new StringWithSlots("Привет, мое имя {name}. Мне {age} лет");

        Console.WriteLine(stringWithSlots.GetFormattedString());
    }
}