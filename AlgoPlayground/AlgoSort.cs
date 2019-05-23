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

  public class AlgoSort
  {
    public List<IComparable> list { get; set; }

    public AlgoSort(List<IComparable> list)
    {
      this.list = list;
    }

    virtual public void sort()
    {
      
    }

    virtual public bool validate()
    {
      for (int i = 1; i < list.Count; i++)
      {
        if (list[i].Lessthan(list[i - 1]))
        {
          return false;
        }
      }
      return true;
    }
  }
}