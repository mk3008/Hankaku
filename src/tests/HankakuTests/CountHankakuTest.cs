using Hankaku;

namespace HankakuTests;

public class CountHankakuTest
{
    [Fact]
    public void EnglishCapitalLettersCount()
    {
        var text = "ＡＢＣＤＥＦＧＨＩＪＫＬＭＮＯＰＱＲＳＴＵＶＷＸＹＺ";

        Assert.Equal(26, text.Length);
        Assert.Equal(26, text.Count());
        Assert.Equal(26 * 2, text.CountHankaku());
    }

    [Fact]
    public void EnglishSmallLettersCount()
    {
        var text = "ａｂｃｄｅｆｇｈｉｊｋｌｍｎｏｐｑｒｓｔｕｖｗｘｙｚ";

        Assert.Equal(26, text.Length);
        Assert.Equal(26, text.Count());
        Assert.Equal(26 * 2, text.CountHankaku());
    }

    [Fact]
    public void NumbersCount()
    {
        var text = "０１２３４５６７８９";

        Assert.Equal(10, text.Length);
        Assert.Equal(10, text.Count());
        Assert.Equal(10 * 2, text.CountHankaku());
    }

    [Fact]
    public void SymbolsCount()
    {
        var text = "　！＠＃＄％＾＆＊（）＿＋－＝｛｝＼｜；：’”，＜＞．？／";

        Assert.Equal(29, text.Length);
        Assert.Equal(29, text.Count());
        Assert.Equal(29 * 2, text.CountHankaku());
    }

    [Fact]
    public void KanaCount()
    {
        var text = "アイウエオカキクケコサシスセソタチツテトナニヌネノハヒフヘホマミムメモヤユヨラリルレロワヲンー";

        Assert.Equal(47, text.Length);
        Assert.Equal(47, text.Count());
        Assert.Equal(47 * 2, text.CountHankaku());
    }

    [Fact]
    public void DakutenCount()
    {
        var text = "ガギグゲゴザジズゼゾダヂヅデドバビブベボヴ";

        Assert.Equal(21, text.Length);
        Assert.Equal(21, text.Count());
        Assert.Equal(21 * 2, text.CountHankaku());
    }

    [Fact]
    public void HandakutenCount()
    {
        var text = "パピプペポ";

        Assert.Equal(5, text.Length);
        Assert.Equal(5, text.Count());
        Assert.Equal(5 * 2, text.CountHankaku());
    }

    [Fact]
    public void SmallKanaCount()
    {
        var text = "ァィゥェォッャュョッ";

        Assert.Equal(10, text.Length);
        Assert.Equal(10, text.Count());
        Assert.Equal(10 * 2, text.CountHankaku());
    }

    [Fact]
    public void SurrogatePairCount_1()
    {
        var text = "😊";

        Assert.Equal(2, text.Length);
        Assert.Equal(2, text.Count());
        Assert.Equal(2, text.CountHankaku());
    }

    [Fact]
    public void SurrogatePairCount_2()
    {
        var text = "☺";
#pragma warning disable xUnit2013 // Do not use equality check to check for collection size.
        Assert.Equal(1, text.Length);
        Assert.Equal(1, text.Count());
        Assert.Equal(2, text.CountHankaku());
#pragma warning restore xUnit2013 // Do not use equality check to check for collection size.
    }

    [Fact]
    public void MixedCharactersCount()
    {
        var text = "１２３456ＡＢCDａｂｃｄ！？漢字カナー＠#$％＾＆＊（）_+=-😊🍺🍣";

        Assert.Equal(40, text.Count());
        Assert.Equal(63, text.CountHankaku());
    }
}