using System;

namespace HTMLEditor.Models;

public static class Menu
{
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;

        DrawScreen();
        WriteOptions();

        short option = short.Parse(Console.ReadLine());
        
        HadleMenuOption(option);
        
    }

    public static void DrawScreen()
    {
        Console.Write("+");
        for (int i = 0; i <= 30; i++)
        {
            Console.Write("-");
        }
        Console.Write("+");
        Console.Write("\n");

        for (int line = 0; line <= 10; line++)
        {
            Console.Write("|");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|");
        }
        
        Console.Write("+");
        for (int i = 0; i <= 30; i++)
        {
            Console.Write("-");
        }
        Console.Write("+");
        Console.Write("\n");
    }

    public static void WriteOptions()
    {
        Console.SetCursorPosition(3, 1);
        Console.WriteLine("Gerenciador de arquivos HTML");
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("============================");
        Console.SetCursorPosition(3, 4);
        Console.WriteLine("1 - Novo arquivo HTML");
        Console.SetCursorPosition(3, 5);
        Console.WriteLine("2 - Editar arquivo");
        Console.SetCursorPosition(3, 6);
        Console.WriteLine("3 - Encerrar programa");
        Console.SetCursorPosition(3, 7);
        Console.WriteLine("============================");
        Console.SetCursorPosition(3, 8);
        Console.Write("Digite uma opção: ");
        
    }

    public static void HadleMenuOption(short option)
    {
        switch (option)
        {
            case 1: Console.WriteLine("OpenFile"); break;
            case 2: Editor.Show(); break;
            case 3:
            {
                Console.Clear();
                System.Environment.Exit(0); break;
            }
        }
    }
}
