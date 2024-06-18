using System;

public class MathsFactory {
  public static int FindingGreater(List<int> numbers) {
    if (numbers == null || numbers.Count == 0)
    {
      throw new ArgumentException("The list is empty or null.");
    }

    return numbers.Max();
  }

  public static int FindingLessThan(List<int> numbers) {
    if (numbers == null || numbers.Count == 0)
    {
      throw new ArgumentException("The list is empty or null.");
    }

    return numbers.Min();
  }

  public static double CalculatingIMC(double weightInKg, double heightInMeters) {
    if (weightInKg <= 0 || heightInMeters <= 0)
    {
      throw new ArgumentException("The weight or height is empty or null.");
    }

    // return (weightInKg * heightInMeters) / 1000;
    return weightInKg / (heightInMeters * heightInMeters);
    // return weightInKg / heightInMeters / heightInMeters;
  }
}