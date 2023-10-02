namespace Banking.UnitTests;

public class UnitTest1
{
    [Fact]
    public void Ten_Plus_Twenty_Is_Thirty()
    {
        //Given == Arrange

        var a = 10; var b = 20; int answer;
        //When -- Act
        answer = a + b;
        //Then -- Assert
        Assert.Equal(30, answer);

    }
    [Theory]
    [InlineData(10, 20, 30)]
    [InlineData(5, 10, 15)]
    [InlineData(2, 10, 12)]
    public void AnyInterger_Plus_AnyInterger_GivesTheSum(int a, int b, int expected)
    {
        var answer = a + b;

        Assert.Equal(expected, answer);
    }
}