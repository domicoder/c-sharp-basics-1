using System;

public class Factory {
  public static void ShowMenu() {
    Console.WriteLine("Welcome...\n");
    Console.WriteLine("Select you want: \n");
    Console.WriteLine("|  1. Printing in console");
    Console.WriteLine("|  2. Capturing and printing a Person in console");
    Console.WriteLine("|  3. Finding greater and less than");
    Console.WriteLine("|  4. Christmas tree");
    Console.WriteLine("|  5. IMC calculator");
    Console.WriteLine("|  0. Exit\n");
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
      case 5: // IMC calculator
        ShowMenuIMCCalculator();
        break;
      case 0:
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

  public static void ShowMenuIMCCalculator() {
    Console.WriteLine("Welcome...\n");

    Console.WriteLine("|  1. Weight in Kg");
    Console.WriteLine("|  2. Weight in Pounds");
    Console.WriteLine("Please enter your choice: ");
    int choice = int.Parse(Console.ReadLine());

    switch (choice) {
      case 1:
        CalculatingIMCDataWithKg();
        break;
      case 2:
        CalculatingIMCDataWithPounds();
        break;
      default:
        Console.WriteLine("Chaito pue!");
        break;
    }
  }

  public static void CalculatingIMCDataWithKg() {
    double IMC, heightInMeters, weightInKg;

    Console.WriteLine("Input your height in meters (ex. 1.8): ");
    heightInMeters = double.Parse(Console.ReadLine());
    Console.WriteLine("Input your weight in Kg: ");
    weightInKg = double.Parse(Console.ReadLine());

    IMC = MathsFactory.CalculatingIMC(weightInKg, heightInMeters);

    CalculatingIMC(IMC);

  }

  public static void CalculatingIMCDataWithPounds() {
    double IMC, heightInMeters, weightInPounds;

    Console.WriteLine("Input your height in meters (ex. 1.8): ");
    heightInMeters = double.Parse(Console.ReadLine());
    Console.WriteLine("Input your weight in Pounds: ");
    weightInPounds = double.Parse(Console.ReadLine());

    double weightInKg = weightInPounds / 2.20462;

    IMC = MathsFactory.CalculatingIMC(weightInKg, heightInMeters);

    CalculatingIMC(IMC);
  }

  public static void CalculatingIMC(double IMC) {
    if(IMC<16)
      Console.WriteLine("Criteria for admission to hospital."); // Criterio de ingreso en hospital.
    if(IMC>=16&&IMC<17)
      Console.WriteLine("Underweight."); // Infrapeso
    if(IMC>=17&&IMC<18)
      Console.WriteLine("Low weight."); // Bajo peso
    if(IMC>=18&&IMC<25)
      Console.WriteLine("Normal weight (healthy)."); // Peso normal (saludable)
    if(IMC>=5&&IMC<30)
      Console.WriteLine("Overweight (grade I obesity)."); // Sobrepeso (obesidad de grado I)
    if(IMC>=30&&IMC<35)
      Console.WriteLine("Chronically overweight (grade II obesity)."); // Sobrepeso cronico (obesidad de grado II)
    if(IMC>=35&&IMC<40)
      Console.WriteLine("Premobited obesity (grade III obesity)."); // Obesidad premobida (obesidad de grado III)
    if(IMC>=40)
      Console.WriteLine("Morbid obesity (grade IV obesity))."); // Obesidad morbida (obesidad de grado IV)

    Console.WriteLine("Your IMC is: " + IMC);
    Console.WriteLine();
    Console.Write("Press a key to continue...");
    Console.ReadKey();
  }
}
