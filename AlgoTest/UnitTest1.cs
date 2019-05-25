using System;
using System.Linq;
using System.Collections.Generic;
using Xunit;
using AlgoPlayground;

namespace AlgoTest
{
  public class UnitTestSort
  {
    static readonly string ToSortString = "Amazing sort test 3 1 4 8 2!!";

    List<IComparable> ToSortList()
    {
      return ToSortString.Select(c => (IComparable)c).ToList();
    }

    [Fact]
    public void SelectionSortTest()
    {
      var sorter = new SelectionSort(ToSortList());
      SortTest(sorter);
    }

    [Fact]
    public void InsertSortTest()
    {
      var sorter = new InsertSort(ToSortList());
      SortTest(sorter);
    }

    public void SortTest(IAlgoSort sorter)
    {      
      Console.WriteLine($"Sorter: {sorter.GetType()}");

      var list = ToSortList();
      Console.WriteLine($"Sort list: `{sorter}`");

      sorter.Sort();

      if (sorter.Validate() == true)
      {
        Console.WriteLine($"Sorted: `{sorter}`");
      }
      else
      {
        Console.WriteLine($"Sorter validate failed, `{sorter}`");
      }

      Assert.True(sorter.Validate());
    }
  }
}
