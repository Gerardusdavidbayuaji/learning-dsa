using DSA.Problems.Easy;

namespace DSA.Problems.Tests.Easy;

public class P0020_ValidParenthesesTests
{
    [Theory]
    // contoh dari soal
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    [InlineData("([])", true)]
    // edge case
    [InlineData("", true)]
    [InlineData(")", false)]
    [InlineData("((", false)]
    [InlineData("([)]", false)]
    [InlineData("{[()()]}", true)]
    public void IsValid_ReturnsExpected(string input, bool expected)
    {
        Assert.Equal(expected, P0020_ValidParentheses.IsValid(input));
    }
}
