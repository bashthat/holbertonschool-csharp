using System.Collections.Generic;
using System;

// define a new struct called Dog

struct Dog
{
    // define public fields
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    // constructor

    public Dog(string name, float age, string owner, Rating rating)
    {
        this.name = name;
        this.age = age;
        this.owner = owner;
        this.rating = rating;
    }
    // define a constructor
    
    enum Rating
    {
        Good,
        Great,
        Excellent
    }

}