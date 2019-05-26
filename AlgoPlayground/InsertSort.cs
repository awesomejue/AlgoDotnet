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
        IComparable value = toSortList[i];
        int j = i - 1;
        for (; j >= 0; j--)
        {
          if (value.Lessthan(toSortList[j]))
          {
            toSortList[j + 1] = toSortList[j];
          }
          else
          {
            break;
          }
        }
        toSortList[j + 1] = value;
      }
    }
  }
}