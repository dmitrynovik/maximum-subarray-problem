using Xunit;
using FluentAssertions;
using XUnitLib;

public class LargestArraySubSumTest
{
    [Fact] public void Foo() 
    {
        var input = new[] { 1, 2, -1, -1, 3 };
        LargestArraySubSum.Compute(input).Should().Be(4);
    }

    [Fact] public void Bar()
    {
        var input = new[] { 7, 0, -1, 0, -1 };
        LargestArraySubSum.Compute(input).Should().Be(7);
    }

    [Fact] public void Baz()
    {
        var input = new[] { -1, 1, 2, -1, -1, 3 };
        LargestArraySubSum.Compute(input).Should().Be(4);
    }

    [Fact] public void Foobar()
    {
        var input = new[] { 7, -1, -1, -1, 4 };
        LargestArraySubSum.Compute(input).Should().Be(8);
    }

}