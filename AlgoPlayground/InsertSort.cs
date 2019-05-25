using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgoPlayground
{
  public class InsertSort : AlgoSortBase
  {
    public InsertSort(List<IComparable> list) : base(list)
    {
    }

    override public void Sort()
    {
      if (this.List == null || this.List.Count == 0)
      {
        return;
      }

      var toSortList = this.List;
      int listCount = toSortList.Count;
      for (int i = 1; i < listCount; i++)
      {
        for (int j = i; j > 0 && toSortList[j].Lessthan(toSortList[j - 1]); j--)
        {
          toSortList.Swap(j, j - 1);
        }
      }
    }
  }
}