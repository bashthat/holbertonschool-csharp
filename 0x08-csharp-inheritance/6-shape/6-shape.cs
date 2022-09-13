using System.Collections.Generic;
using System;
/// <summary>Initializes Class Obj</summary>
/// <returns>???nothing!!!</returns>
class Shape
{
    /// <summary>Initializes Class Obj</summary>
    /// <returns>???nothing!!!</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
/// <summary>Initializes Class Obj</summary>
/// <returns>???nothing!!!</returns>
class Rectangle : Shape
{
    private int width;
    private int height;
    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            else if (value == 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            else
                width = value;
        }
    }
    /// <summary>Initializes Class Obj</summary>
    /// <returns>???nothing!!!</returns>
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            else if (value == 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            else
                height = value;
        }
    }

}