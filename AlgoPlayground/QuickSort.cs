using System;
using System.Collections.Generic;

namespace AlgoPlayground
{
  public class QuickSort : AlgoSortBase
  {

    public Random random { get; private set; }
    public QuickSort(List<IComparable> list) : base(list)
    {
      random = new Random();
    }

    override public void Sort()
    {
      if (this.List == null || this.List.Count == 0)
      {
        return;
      }
      quickSort(this.List, 0, this.List.Count - 1);
    }

    void quickSort(List<IComparable> list, int left, int right)
    {
      if (left >= right)
      {
        return;
      }

      int pivot = partition(list, left, right, random.Next(left, right));
      quickSort(list, left, pivot - 1);
      quickSort(list, pivot + 1, right);
    }

    int partition(List<IComparable> list, int left, int right, int pivot)
    {
      // Console.WriteLine($"{String.Concat(List)} | left: {left}, right: {right}, pivot: {list[pivot]} at {pivot}");

      list.Swap(right, pivot);

      int rover = left;
      for (int i = left; i < right; i++)
      {
        if (list[i].Lessthan(list[right]))
        {
          // Console.WriteLine($"{i}, {rover}");
          list.Swap(i, rover++);
          // Console.WriteLine($"{String.Concat(List)}");
        }
      }

      list.Swap(rover, right);

      return rover;
    }
  }
}