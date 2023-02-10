using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static Walls;
using static FoodFactory;

class Game
{
    static readonly int x = 80;
    static readonly int y = 27;
    static Walls? walls;
    static FoodFactory? foodFactory;

    static void Main()
    {
        SetWindowSize(x + 1, y + 1);
        SetBufferSize(x + 1, y + 1);
        CursorVisible = false;
        walls = new Walls(x, y, '#');
        foodFactory = new FoodFactory(x, y, '@');
        foodFactory.CreateFood();
    }
}

struct Point
{
    public int x { get; set; }
    public int y { get; set; }
    public char ch { get; set; }

    public static implicit operator Point((int, int, char) value) =>
        new Point { x = value.Item1, y = value.Item2, ch = value.Item3 };

    public void Draw()
    {
        DrawPoint(ch);
    }
    public void Clear()
    {
        DrawPoint(' ');
    }
    public void DrawPoint(char _ch)
    {
        SetCursorPosition(x, y);
        Write(_ch);
    }
}
