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

    // .tostring() override

    public override string ToString()
    {
        return String.Format("Dog Name: {0}\nAge: {1}\nOwner: {2}\nRating: {3}", name, age, owner, rating);
    }

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