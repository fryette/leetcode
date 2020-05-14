using LeetCode.Solutions.Low;
using Xunit;

public class CountAndSayTests
{
    [Fact]
    public void Common_Test_Should_Return_Proper_Result()
    {
        // Arrange
        var solution = new CountAndSaySolution();
        var expected = "312211";

        //act
        var result = solution.CountAndSay(6);

        //Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Number_10_Should_Return_Proper_Result()
    {
        // Arrange
        var solution = new CountAndSaySolution();
        var expected = "13211311123113112211";

        //act
        var result = solution.CountAndSay(10);

        //Assert
        Assert.Equal(expected, result);
    }
}