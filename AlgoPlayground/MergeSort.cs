using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgoPlayground
{
  public class MergeSort : AlgoSortBase
  {
    public MergeSort(List<IComparable> list) : base(list)
    {
    }

    override public void Sort()
    {
      if (this.List == null || this.List.Count == 0)
      {
        return;
      }

      var toSortList = this.List;

      // MergeSort(List.)
    }

    // List<IComparable> MergeSort(List<IComparable> left, List<IComparable> right)
    // {

    // }

  }
}