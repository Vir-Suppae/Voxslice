using System.Text;
class Program
{
    static StringBuilder output = new StringBuilder();
    static string toPrint = "[]";
    static int Main()
    {
        Setup();
        while (true)
        {
            // HandleInput returns true if it thinks the program should exit.
            // TODO[p0]: use enum
            // TODO[p3]: properly implement HandleInput
            if (HandleInput()) break;
            Update();
            Render();
        }
        return Exit();
    }
    static void Setup()
    {
        Console.Write("\x1b[?1049h");
    }
    static bool HandleInput()
    {
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            toPrint += key.KeyChar;
            if (key.Key == ConsoleKey.Escape) return true;
        }
        return false;
    }
    static void Update()
    {
    }
    static void Render()
    {
        output.Clear();
        output.Append("\x1b[H");
        output.Append(toPrint);
        Console.Write(output.ToString());
    }
    static int Exit()
    {
        Console.WriteLine("\x1b[?1049l");
        return 0;
    }
}
