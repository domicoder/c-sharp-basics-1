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
}