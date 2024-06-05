class Person {
  private string _name;
  private string _lastName;
  private int _age;
  private string _gender;

  private const int Const1 = 50;
  private const Double Const2 = 33.2;
  private const String Const3 = "Alpha Prime"; 

  public Person(string name = "", string lastName = "", int age = 0, string gender = "male") {
    _name = name; // or use this.name = name; if you don't like to use _ prefix
    _lastName = lastName;
    _age = age;
    _gender = gender;
  }

  public string Name {
    get { return _name; }
    set {
      if (value != null) {
        _name = value;
      }
    }
  }

  public string LastName {
    get { return _lastName; }
    set {
      if (value != null) {
        _lastName = value;
      }
    }
  }

  public int Age {
    get { return _age; }
    set {
      if (value > 0) {
        _age = value;
      }
    }
  }

  public string Gender {
    get {
      return _gender;
    }
    set {
      if (value != null) {
        _gender = value;
      }
    }
  }

  public string CallMe() {
    if (Gender == "male") {
      return "he";
    } else if (Gender == "female") {
      return "she";
    } else {
      return "he/she";
    }
  }

  public string ShowMe() {
    string message = $"This is your info:\n";
    message += $"|   Name:    {Name}\n";
    message += $"|   Last Name: {LastName}\n";
    message += $"|   Age:     {Age.ToString()}\n";
    message += $"|   Gender:  {Gender}\n";
    return message;
  }

  public string ExtraInfo() {
    string message = $"\nYour extra info for {Name} is:\n";
    message += $"|   Integer: {(Const1.ToString())}\n";
    message += $"|   Double: {Const2.ToString()}\n";
    message += $"|   String: {Const3}\n";
    return message;
  }

  public void ShowPresentation() {
    Console.WriteLine("Welcome...\n");
    Console.WriteLine("Please enter your Name: ");
    string name = Console.ReadLine();
    Console.WriteLine("Please enter your Last Name: ");
    string lastName = Console.ReadLine();
    Console.WriteLine("Please enter your age: ");
    string age = Console.ReadLine();
    Console.WriteLine("Please enter your gender (male/female): ");
    string gender = Console.ReadLine();

    Name = name;
    LastName = lastName;
    Age = int.Parse(age);
    Gender = gender;
 
    Console.WriteLine($"\n\nHello {Name} {LastName}, You are registered now.\n");
    Console.WriteLine($"{ShowMe()}");
    Console.WriteLine($"{ExtraInfo()}");
    Console.ReadLine();
  }
}