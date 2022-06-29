public static class StatisticsExtensions
{
  public static double TruncatedMean<T>(this IEnumarable<T> values, int discardNumber)
  {
    IEnumerable<double> doubles = values.Select(value => Convert.ToDouble(value));
    double[] arrDoubles = doubles.ToArray();

    Array.Sort(arrDoubles);

    int minIndex = discardNumber;
    int maxIndex = arrDoubles.Length - 1 - discardNumber;

    // Copy the desired items into a new array.
    int numRemaining = maxIndex - minIndex + 1;
    double[] remainingItems = new double[numRemaining];

    Array.Copy(doubleArray, minIndex, remainingItems, 0, numRemaining);
    // Calculate and return the truncated mean.
    return remainingItems.Average();
  }
}