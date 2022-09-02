using System;
using System.Collections.Generic;
// class declaration
class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
	// prototype and arguments
        Console.WriteLine("Number of items: {0}", aStack.Count);
        if (aStack.Count == 0)
            Console.WriteLine("Stack is empty");
        else // true? falsE? else statement.
            Console.WriteLine("Top item: {0}", aStack.Peek());
        // if successful to end the search
	bool trump = aStack.Contains(search);
        Console.WriteLine("Stack contains \"{0}\": {1}", search, trump );
        if (trump)
        {
            string xyz;
            do {
                xyz = aStack.Pop();
            }
            while (xyz != search);
        
}
        
	aStack.Push(newItem);
        return aStack; // word
    }
}
