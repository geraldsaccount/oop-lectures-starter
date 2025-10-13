namespace StaticAndNonStatic;

public class Counter
{
    public static int objectCount;
    public string Name;

    public Counter(string name) {
        Name = name;
        objectCount++;
    }

    public static void DisplayCount() {
        Console.WriteLine($"Total objects created: {objectCount}");
    }

    public void DisplayInfo() {
        Console.WriteLine($"Object Name: {Name}");
    }
}