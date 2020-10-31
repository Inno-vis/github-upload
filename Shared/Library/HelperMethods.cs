using System;

namespace OrganizedCrimeApp.Shared.Library
{
  public static class Helper
  {
    static Random _random = new Random();
    public static void Shuffle<T>(T[] array)
    {
      int n = array.Length;
      for (int i = 0; i < (n - 1); i++)
      {
        int r = i + _random.Next(n - i);
        T t = array[r];
        array[r] = array[i];
        array[i] = t;
      }
    }
  }
}