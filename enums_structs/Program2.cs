using System;
using System.Threading;

struct MovingObject
{
    public char Symbol;
    public int PosX, PosY;

    public MovingObject(char symbol, int x, int y)
    {
        Symbol = symbol;
        PosX = x;
        PosY = y;
    }

    public void Draw()
    {
        Console.SetCursorPosition(PosX, PosY);
        Console.Write(Symbol);
    }

    public void Motion(int dx, int dy)
    {
        Console.SetCursorPosition(PosX, PosY);
        Console.Write(" ");
        PosX += dx;
        PosY += dy;
        Draw();
    }
}

class Program2
{
    static void Main()
    {
        MovingObject obj = new MovingObject('*', 10, 5);
        obj.Draw();

        for (int i = 0; i < 10; i++)
            obj.Motion(1, 0);
    }
}
