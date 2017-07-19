using System;

public class Rectangle : IDrawable
{
    private int width;

    private int height;

    public Rectangle()
    {
        this.Width = this.width;
        this.Height = this.height;
    }

    public int Height
    {
        get => this.height;
        set { this.height = value; }
    }



    public int Width
    {
        get => this.width;
        set { this.width = value; }
    }

    public void Draw()
    {
        DrawLine(this.Width, '*', '*');
        for (int i = 1; i < this.Height - 1; i++)
        {
            DrawLine(this.Width, '*', ' ');
        }
        DrawLine(this.Width, '*', '*');
    }

    private void DrawLine(int width, char end, char mid)
    {
        Console.WriteLine(end);
        for (int i = 1; i < width - 1; i++)
        {
            Console.WriteLine(mid);
        }

        Console.WriteLine(end);
    }
}
