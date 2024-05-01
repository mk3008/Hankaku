using Hankaku;

namespace HankakuTests;

public class ToHankakuTest
{
    [Fact]
    public void EnglishCapitalLettersConversion()
    {
        var text = "ＡＢＣＤＥＦＧＨＩＪＫＬＭＮＯＰＱＲＳＴＵＶＷＸＹＺ";
        var expect = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        Assert.Equal(expect, text.ToHankaku());
    }

    [Fact]
    public void EnglishSmallLettersConversion()
    {
        var text = "ａｂｃｄｅｆｇｈｉｊｋｌｍｎｏｐｑｒｓｔｕｖｗｘｙｚ";
        var expect = "abcdefghijklmnopqrstuvwxyz";

        Assert.Equal(expect, text.ToHankaku());
    }

    [Fact]
    public void NumbersConversion()
    {
        var text = "０１２３４５６７８９";
        var expect = "0123456789";

        Assert.Equal(expect, text.ToHankaku());
    }

    [Fact]
    public void SymbolsConversion()
    {
        var text = "　！＠＃＄％＾＆＊（）＿＋－＝｛｝＼｜；：’”，＜＞．？／";
        var expect = " !@#$%^&*()_+-={}\\|;:'\",<>.?/";

        Assert.Equal(expect, text.ToHankaku());
    }

    [Fact]
    public void KanaConversion()
    {
        var text = "アイウエオカキクケコサシスセソタチツテトナニヌネノハヒフヘホマミムメモヤユヨラリルレロワヲンー";
        var expect = "ｱｲｳｴｵｶｷｸｹｺｻｼｽｾｿﾀﾁﾂﾃﾄﾅﾆﾇﾈﾉﾊﾋﾌﾍﾎﾏﾐﾑﾒﾓﾔﾕﾖﾗﾘﾙﾚﾛﾜｦﾝｰ";

        Assert.Equal(expect, text.ToHankaku());
    }

    [Fact]
    public void DakutenConversion()
    {
        var text = "ガギグゲゴザジズゼゾダヂヅデドバビブベボヴ";
        var expect = "ｶﾞｷﾞｸﾞｹﾞｺﾞｻﾞｼﾞｽﾞｾﾞｿﾞﾀﾞﾁﾞﾂﾞﾃﾞﾄﾞﾊﾞﾋﾞﾌﾞﾍﾞﾎﾞｳﾞ";

        Assert.Equal(expect, text.ToHankaku());
    }

    [Fact]
    public void HandakutenConversion()
    {
        var text = "パピプペポ";
        var expect = "ﾊﾟﾋﾟﾌﾟﾍﾟﾎﾟ";

        Assert.Equal(expect, text.ToHankaku());
    }

    [Fact]
    public void SmallKanaConversion()
    {
        var text = "ァィゥェォッャュョッ";
        var expect = "ｧｨｩｪｫｯｬｭｮｯ";

        Assert.Equal(expect, text.ToHankaku());
    }

    [Fact]
    public void MixedCharactersConversion()
    {
        var text = "１２３456ＡＢCDａｂｃｄ！？漢字カナー＠#$％＾＆＊（）_+=-😊🍺🍣";
        var expect = "123456ABCDabcd!?漢字ｶﾅｰ@#$%^&*()_+=-😊🍺🍣";

        Assert.Equal(expect, text.ToHankaku());
    }
}