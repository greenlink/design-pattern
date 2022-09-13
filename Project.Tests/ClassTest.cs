namespace Project.Tests;

public class ClassTest
{
    [Fact]
    public void MethodReturnsTrue()
    {
        var obj = new Class();

        Assert.True(obj.Method());
    }
}