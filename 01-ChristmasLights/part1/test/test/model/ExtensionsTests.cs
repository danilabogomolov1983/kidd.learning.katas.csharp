using model;

namespace test.model;

public class ExtensionsTests
{
    [Fact]
    public void AsIntReturnsValueForDerivedSideTypes()
    {
        var width = new Width(10);

        var result = width.AsInt();

        Assert.Equal(10, result);
    }
}
