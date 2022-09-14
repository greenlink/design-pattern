using FacadePattern;

namespace FacadePattern.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var client = new Class();

        Assert.True(client.Method());
    }
}