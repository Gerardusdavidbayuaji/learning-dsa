using DSA.Problems.Easy.Sorting;

namespace DSA.Problems.Tests.Easy.Sorting;

public class InsertionSortTests
{
    [Fact]
    public void SampleInput()
    {
        // contoh dari soal: [2,4,6,8] sudah terurut, 3 perlu disisipkan
        var arr = new List<int> { 2, 4, 6, 8, 3 };
        var expected = new List<int> { 2, 3, 4, 6, 8 };

        InsertionSort1.InsertionSort(arr.Count, arr);

        Assert.Equal(expected, arr);
    }

    [Fact]
    public void LastElementIsSmallest_MovesToFront()
    {
        var arr = new List<int> { 2, 3, 4, 1 };

        InsertionSort1.InsertionSort(arr.Count, arr);

        Assert.Equal(new List<int> { 1, 2, 3, 4 }, arr);
    }

    [Fact]
    public void LastElementIsLargest_NoChange()
    {
        var arr = new List<int> { 1, 2, 3, 6 };

        InsertionSort1.InsertionSort(arr.Count, arr);

        Assert.Equal(new List<int> { 1, 2, 3, 6 }, arr);
    }
}
