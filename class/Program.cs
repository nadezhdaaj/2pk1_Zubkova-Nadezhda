namespace Class;

internal class Program
{
    static void Main(string[] args)
    {
        Human human1=new Human("Иван", "Ургант", new DateTime(1999, 05, 02), Gender .male, "РФ");
        Human human2 = new Human("Нурсиля", "Кинзабаева", new DateTime(2006, 12, 19), Gender.male, "РФ");
        Human human3 = human1;
        human1.PrintInfo();
        Console.WriteLine();
        human2.PrintInfo();
        Console.WriteLine();
        human3.PrintInfo();
        Console.WriteLine();

    }
}
