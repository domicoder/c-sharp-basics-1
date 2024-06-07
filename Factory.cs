using System;

public class Factory {
  public static void CreatePerson() {
    Console.WriteLine("Welcome...\n");
    Console.WriteLine("Please enter your Name: ");
    string name = Console.ReadLine();
    Console.WriteLine("Please enter your Last Name: ");
    string lastName = Console.ReadLine();
    Console.WriteLine("Please enter your age: ");
    string age = Console.ReadLine();
    Console.WriteLine("Please enter your gender (male/female): ");
    string gender = Console.ReadLine();

    Person p = new Person(name, lastName, int.Parse(age), gender);

    Console.WriteLine($"\n\nHello {p.Name} {p.LastName}, You are registered now.\n");
    Console.WriteLine($"{p.ShowMe()}");
    Console.WriteLine($"{p.ExtraInfo()}");
    Console.ReadLine();
  }
}