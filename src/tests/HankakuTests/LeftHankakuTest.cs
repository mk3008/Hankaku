using Hankaku;

namespace HankakuTests;

public class LeftHankakuTest
{
    [Fact]
    public void LeftTextOnly()
    {
        var text = "１２３４５６７８９０".LeftHankaku(4);

        Assert.Equal("１２", text);
    }

    [Fact]
    public void Divisible()
    {
        var text = "１２３４５６７８９０".LeftHankaku(4, out var remainingText);

        Assert.Equal("１２", text);
        Assert.Equal("３４５６７８９０", remainingText);
    }

    [Fact]
    public void Indivisible()
    {
        var text = "１２３４５６７８９０".LeftHankaku(3, out var remainingText);

        Assert.Equal("１", text);
        Assert.Equal("２３４５６７８９０", remainingText);
    }

    [Fact]
    public void Divisible_SurrogatePair_1()
    {
        var text = "😊😊😊😊😊".LeftHankaku(4, out var remainingText);

        Assert.Equal("😊😊", text);
        Assert.Equal("😊😊😊", remainingText);
    }

    [Fact]
    public void Indivisible_SurrogatePair_1()
    {
        var text = "😊😊😊😊😊".LeftHankaku(3, out var remainingText);

        Assert.Equal("😊", text);
        Assert.Equal("😊😊😊😊", remainingText);
    }

    [Fact]
    public void Divisible_SurrogatePair_2()
    {
        var text = "☺☺☺☺☺".LeftHankaku(4, out var remainingText);

        Assert.Equal("☺☺", text);
        Assert.Equal("☺☺☺", remainingText);
    }

    [Fact]
    public void Indivisible_SurrogatePair_2()
    {
        var text = "☺☺☺☺☺".LeftHankaku(3, out var remainingText);

        Assert.Equal("☺", text);
        Assert.Equal("☺☺☺☺", remainingText);
    }
}