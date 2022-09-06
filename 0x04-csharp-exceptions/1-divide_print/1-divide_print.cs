using System;

// class Int

class Int {
  public static void divide(int a, int b) {
    // to print int a or int b given divisibility
    int c = 0;
    try {
      print = (a / b);
    } catch {
      Console.WriteLine("Cannot divide by zero");
    } finally {
      Console.WriteLine("{0} / {1} = {2}", a, b, c);
    }
  } 
