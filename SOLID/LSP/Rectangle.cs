﻿namespace SOLID.LSP;

public class Rectangle
{
    public int Height { get; set; }
    public int Width { get; set; }

    public Rectangle()
    {
        
    }

    public Rectangle(int height, int width)
    {
        Height = height;
        Width = width;
    }

    //better not to use Square class and just check and make some validation
    public static Rectangle NewSquare(int side)
    {
        return new Rectangle(side, side);
    }

    public bool IsSquare => Height == Width;

    public int Area => Height * Width;

    public override string ToString()
    {
        return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
    }
}