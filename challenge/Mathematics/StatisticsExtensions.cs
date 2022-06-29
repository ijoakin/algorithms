using System.Collections.Generic;

public static class StatisticsExtensions
{
  public static double TruncatedMean<T>(this IEnumerable<T> values, int discardNumber)
  {
    IEnumerable<double> doubles = values.Select(value => Convert.ToDouble(value));
    double[] doubleArray = doubles.ToArray();

    Array.Sort(doubleArray);

    int minIndex = discardNumber;
    int maxIndex = doubleArray.Length - 1 - discardNumber;

    // Copy the desired items into a new array.
    int numRemaining = maxIndex - minIndex + 1;
    double[] remainingItems = new double[numRemaining];

    Array.Copy(doubleArray, minIndex, remainingItems, 0, numRemaining);
    // Calculate and return the truncated mean.
    return remainingItems.Average();
  }
}