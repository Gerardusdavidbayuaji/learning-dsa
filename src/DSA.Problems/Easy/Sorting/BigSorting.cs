namespace DSA.Problems.Easy.Sorting;

public static class BigSorting
{
    public static List<string> Sort(List<string> unsorted)
    {
     unsorted.Sort((a, b) =>
     {
         if (a.Length != b.Length) 
             return a.Length.CompareTo(b.Length);
         
         return string.Compare(a, b, StringComparison.Ordinal);
     });
     
     return unsorted;
    }
}

