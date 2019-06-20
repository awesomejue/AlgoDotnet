using System;
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

      mergeSort(this.List, 0, this.List.Count - 1);
    }

    void mergeSort(List<IComparable> list, int left, int right)
    {
      if (left >= right)
      {
        return;
      }

      int mid = (left + right) / 2;
      mergeSort(list, left, mid);
      mergeSort(list, mid + 1, right);
      merge(list, left, mid, right);
    }

    void merge(List<IComparable> list, int left, int mid, int right)
    {
      IComparable[] array = new IComparable[right - left + 1];
      int i = left, j = mid + 1, k = 0;
      while (i <= mid && j <= right)
      {
        if (list[i].Lessthan(list[j]))
        {
          array[k++] = list[i++];
        }
        else
        {
          array[k++] = list[j++];
        }
      }

      while (i <= mid)
      {
        array[k++] = list[i++];
      }

      while (j <= right)
      {
        array[k++] = list[j++];
      }

      for (int index = 0; index < array.Length; index++)
      {
        list[left + index] = array[index];
      }
    }
  }
}