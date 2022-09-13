using System.Reflection.Metadata.Ecma335;
using System.Reflection.Metadata;
using System;
using System.Collections.Generic;

/// <summary>Initializes Class Obj</summary>

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
        /// <summary>Initializes Class Obj</summary>
        /// <returns>???nothing!!!</returns>
        public new int Area()
        {
            return width * height;
        }
        /// <summary>Initializes Class Obj</summary>
        /// <returns>???nothing!!!</returns>
        public override string ToString()
        {
            return $"[Rectangle] {width} / {height}";
        }
    }

    /// <summary>Initializes Class Obj</summary>
    class Square : Rectangle
    {
        private int size;
        public int Size
        {
            get { return size; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Size must be greater than or equal to 0");
                else if (value == 0)
                    throw new ArgumentException("Size must be greater than or equal to 0");
                else
                    size = value;
                    Width = size;
                    Height = size;
            }
        }
    }