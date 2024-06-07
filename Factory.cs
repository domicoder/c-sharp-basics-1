using System;

public class Factory {
  public static void ShowMenu() {
    Console.WriteLine("Welcome...\n");
    Console.WriteLine("Select you want: \n");
    Console.WriteLine("|  1. Printing in console");
    Console.WriteLine("|  2. Capturing and printing a Person in console");
    Console.WriteLine("|  3. Finding greater and less than");
    Console.WriteLine("|  4. Christmas tree");
    Console.WriteLine("|  5. Exit\n");
    Console.WriteLine("Please enter your choice: ");
    int choice = int.Parse(Console.ReadLine());

    switch (choice) {
      case 1:
        CreatePerson();
        break;
      case 2:
        CreatePerson();
        break;
      case 3:
        FindingGreaterAndLessThan();
        break;
      case 4:
        ChristmasTree();
        break;
      case 5:
      default:
        Console.WriteLine("Chaito pue!");
        break;
    }
  }

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

  public static void FindingGreaterAndLessThan() {
    Console.WriteLine("Welcome...\n");
    Console.WriteLine("Please enter 3 random numbers.");
    Console.WriteLine("|    Please, press enter after each number: "); 
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());
    int num3 = int.Parse(Console.ReadLine());

    List<int> numbers = new List<int> { num1, num2, num3 };

    Console.WriteLine($"The numbers are: {num1}, {num2}, {num3}");
    Console.WriteLine($"The greater number is: {MathsFactory.FindingGreater(numbers)}");
    Console.WriteLine($"The smaller number is: {MathsFactory.FindingLessThan(numbers)}");
    Console.ReadLine();
  }

  public static void ChristmasTree() {
    const int size = 2 * 6;

    // Crown [Tree]
    for  (int i = 0; i < size; i++)
    {
      for  (int k = 0; k < ((size) - i + 1); k++)
      {
        Console.Write(" ");
      }
      for  (int j = 0; j < ((2 * i ) - 1); j++)
      {
        Console.Write("*");
      }
      Console.WriteLine("");
    }

    // Trunk [Tree]
    for (int i = 0; i < 3; i++)
    {
      if (i < 2)
      {
        for (int j = 0; j <= (size - i + 1); j++)
        {
          string draft = (j == size) ? "||" : " ";
          Console.Write($"{draft}");
        }
        Console.WriteLine("");
      }
      else
      {
        for (int j = 0; j <= ((2*size) - i + 1); j++)
        {
          string draft = (j == size) ? "||" : "_";
          Console.Write($"{draft}");
        }
        Console.WriteLine("");
      }
    }
  }
}
