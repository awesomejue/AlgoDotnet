using System;
using System.Collections.Generic;

namespace AlgoPlayground
{

  public static class IComparableExtension
  {
    public static bool Lessthan(this IComparable left, IComparable right)
    {
      return left.CompareTo(right) < 0;
    }
  }

  public static class IListExtension
  {
    public static void Swap<T>(this IList<T> list, int left, int right)
    {
      T temp = list[left];
      list[left] = list[right];
      list[right] = temp;
    }
  }

  public abstract class AlgoSort
  {
    public List<IComparable> List { get; set; }

    public AlgoSort(List<IComparable> list)
    {
      this.List = list;
    }

    abstract public void Sort();

    override public string ToString()
    {
      return String.Concat(List);
    }

    public bool Validate()
    {
      for (int i = 1; i < List.Count; i++)
      {
        if (List[i].Lessthan(List[i - 1]))
        {
          return false;
        }
      }
      return true;
    }
  }
}