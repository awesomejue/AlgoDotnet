using System;
using System.Linq;
using System.Collections.Generic;
using Xunit;
using AlgoPlayground;

namespace AlgoTest
{
  public class UnitTestSort
  {
    public static readonly string ToSortString = "Awesome sort!!";

    public static List<IComparable> ToSortList()
    {
      return ToSortString.Select(c => (IComparable)c).ToList();
    }

    [Fact]
    public void mergeSortTest()
    {
      var list = ToSortList();
      Console.WriteLine(list.ToString());
      var sorter = new AlgoSort(ToSortList());
      sorter.sor
    }
  }
}
