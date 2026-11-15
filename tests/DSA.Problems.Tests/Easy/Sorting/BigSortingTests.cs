using DSA.Problems.Easy.Sorting;

namespace DSA.Problems.Tests.Easy.Sorting;

public class BigSortingTests
{
    [Fact]
    public void Sort_SampleInput()
    {
        var input = new List<string> { "31415926535897932384626433832795", "1", "3", "10", "3", "5" };
        var expected = new List<string> { "1", "3", "3", "5", "10", "31415926535897932384626433832795" };
        
        Assert.Equal(expected, BigSorting.Sort(input));
    }

    [Fact]
    public void Sort_SameLength_UsesLexicographicOrder()
    {
        var input = new List<string> { "999", "100", "555" };
        var expected = new List<string> { "100", "555", "999" };
        
        Assert.Equal(expected, BigSorting.Sort(input));
    }
}

