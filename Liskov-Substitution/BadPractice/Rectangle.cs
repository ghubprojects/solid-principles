﻿namespace Liskov_Substitution.BadPractice;

public class Rectangle() {
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    public int Area() {
        return Width * Height;
    }
}