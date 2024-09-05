using System;

class Program {
  public static void Main (string[] args) {
    // Module 2 Exercise 2.1.1 

    const double AmountOfCentimeters = 2.54;

    Console.WriteLine("Enter the amount of inches you want to convert to centimeters (Type a Number)");

    float inches = float.Parse(Console.ReadLine());
    double convertion_in_centimeters = inches * AmountOfCentimeters;

    Console.WriteLine($"\n{inches} inches is equal to {convertion_in_centimeters} centimeters"); 
  }
}