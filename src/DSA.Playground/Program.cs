using DSA.Core.DataStructures.Stacks;
using DSA.Problems.Easy.Sorting;

Console.WriteLine();
Console.WriteLine("== Big Sorting ==");
var nums = new List<string> { "31415926535897932384626433832795", "1", "3", "10", "3", "5" };
Console.WriteLine(string.Join(", ", DSA.Problems.Easy.Sorting.BigSorting.Sort(nums)));
