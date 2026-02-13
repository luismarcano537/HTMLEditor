using System.Text;

namespace HTMLEditor.Models;

public class Editor
{
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("Modo editor");
        Console.WriteLine("============");
        
        Start();
        
    }
    public static void Start()
    {
        

        var file = new StringBuilder();

        do
        {
            file.Append(Console.ReadLine());
            file.AppendLine();
        } while (Console.ReadKey().Key != ConsoleKey.F1);

        Console.WriteLine("Deseja salvar seu arquivo? (Y/N): ");
    }
}