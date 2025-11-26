using System;
using System.Security.Cryptography;
using System.Text;

using Seido.Utilities.SeedGenerator;

namespace _03_Pearls;


public enum Season { Winter, Summer, Fall}

public class Necklace
{
    public List<Pearl> Pearls { get; } = new List<Pearl>();

    public Necklace(int numbOfPearls, SeedGenerator _seeder) 
    {
        for (int i = 0; i <= numbOfPearls; i++)
        {
            Pearls.Add(new Pearl(_seeder));
        }
    }
}
class Program
{
    static void Main(string[] args)
    {

        int[] list = { 1, 3, -5, 8, 6, 10 };
        int minVal = int.MaxValue;

        for (int i = 0; i < list.Length; i++)
        {
            if (list[i] <= minVal )
                minVal = list[i];

        }

        Console.WriteLine(minVal);


        int maxVal = int.MinValue;

        for (int i = 0; i < list.Length; i++)
        {
            if (list[i] >= maxVal)
                maxVal = list[i];

        }

        Console.WriteLine(maxVal);


        Console.WriteLine("Hello, World!");

        var rnd = new SeedGenerator();

        Console.WriteLine(rnd.Next(5, 26));
        Console.WriteLine(rnd.FromEnum<Season>());

    }
}

//Exercise:
// 1. Modellera en pärlan i en C# class. Utmärkande för en pärla är
//    Storlek: Diameter 5mm till 25mm
//    Färg: Svart, Vit, Rosa
//    Form: Rund, Droppformad
//    Typ: Sötvatten, Saltvatten
public enum Color { Svart, Vit, Rosa }
public enum Shape { Rund, Droppformad }
public enum Type { Sötvatten, Saltvatten }

public record Pearl{
    public int Size { get; init; }
    public Color PearlColor { get; init; }
    public Shape PearlShape { get; init; }
    public Type PearlType { get; init; }


    public Pearl(SeedGenerator _seeder)
    {
        Size = _seeder.Next(5, 26);
        PearlColor = _seeder.FromEnum<Color>();
        PearlShape = _seeder.FromEnum<Shape>();
        PearlType = _seeder.FromEnum<Type>();
    }

    public Pearl(int size, Color color, Shape shape, Type type)
    {
        PearlSize = size;
        PearlColor = color;
        PearlShape = shape;
        PearlType = type;
    }
    public Pearl(Pearl original)
    {
        this.PearlSize = original.Size;
        this.PearlColor = original.Color;
        this.PearlShape = original.Shape;
        this.PearlType = original.Type;
    }
}

// 2. När pärlan väl är skapad så ska man inte kunna ändra den.

// 3. Gör om constructor Pearl(csSeedGenerator _seeder) som initierar en slumpmässig pärla

// 4. Skapa en ToString i din pärlklass som presenterar pärlan.
//
// 5. Skapa ett halsband bestående av 10 pärlor av slumpmässig storlek, färg
//    form, och typ 
//
// 6. Skriv kod som visar vilken färg, form och typ har den minsta och den största pärlan i halsbandet?
//
// 7. Deklarera en contruktor som tillåter dig att själv bestämma alla Pearl public properties
//
// 8. Deklarera en Copy constructor.
//
// 9. Använd copy constructorn för att skapa ett nytt halsband som är en kopia av ursprunget



