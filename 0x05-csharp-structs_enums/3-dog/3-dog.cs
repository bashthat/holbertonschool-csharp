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
    // override ToString() method

    public override string ToString()
    {
        return String.Format($"Dog Name: {name}\nAge: {age}\nOwner: {owner}\nRating: {rating}");
    }

}    
// define a new enum called Rating
    enum Rating
    {
        Good,
        Great,
        Excellent
    }
