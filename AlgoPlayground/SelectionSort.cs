using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgoPlayground
{
  public class SelectionSort : AlgoSort
  {
    public SelectionSort(List<IComparable> list) : base(list)
    {
    }

    override public void Sort()
    {
      if (this.List == null || this.List.Count == 0)
      {
        return;
      }

      var toSortList = this.List;
      for (int i = 0; i < toSortList.Count; i++)
      {
        int min = i;
        for (int j = i; j < toSortList.Count; j++)
        {
          min = toSortList[min].Lessthan(List[j]) ? min : j;
        }
        toSortList.Swap(min, i);
      }
    }
  }
}