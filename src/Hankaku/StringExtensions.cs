using System.Text;

namespace Hankaku;

/// <summary>
/// 半角文字列操作に関する拡張メソッド
/// </summary>
public static class StringExtensions
{
    /// <summary>
    /// 半角と認識する文字リスト
    /// </summary>
    private static List<char> hankakuList = new List<char>()
    {
        ' ',
        '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
        '!', '"', '#', '$', '%', '&', '\'', '(', ')', '*', '+', ',',
        '-', '.', '/', ':', ';', '<', '=', '>', '?', '@', '[', '\\',
        ']', '^', '_', '`', '{', '|', '}', '~',
        'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
        'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
        'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
        'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
        'ｱ', 'ｲ', 'ｳ', 'ｴ', 'ｵ',
        'ｶ', 'ｷ', 'ｸ', 'ｹ', 'ｺ',
        'ｻ', 'ｼ', 'ｽ', 'ｾ', 'ｿ',
        'ﾀ', 'ﾁ', 'ﾂ', 'ﾃ', 'ﾄ',
        'ﾅ', 'ﾆ', 'ﾇ', 'ﾈ', 'ﾉ',
        'ﾊ', 'ﾋ', 'ﾌ', 'ﾍ', 'ﾎ',
        'ﾏ', 'ﾐ', 'ﾑ', 'ﾒ', 'ﾓ',
        'ﾔ', 'ﾕ', 'ﾖ',
        'ﾗ', 'ﾘ', 'ﾙ', 'ﾚ', 'ﾛ',
        'ﾜ', 'ｦ', 'ﾝ',
        'ｧ', 'ｨ', 'ｩ', 'ｪ', 'ｫ',
        'ｯ',
        'ｬ', 'ｭ', 'ｮ',
        'ﾞ', 'ﾟ',
        'ｰ'
    };

    /// <summary>
    /// 全角半角変換表
    /// </summary>
    private static Dictionary<char, string> conversionMap = new Dictionary<char, string>()
    {
        {'　', " "},

        {'０', "0"}, {'１', "1"}, {'２', "2"}, {'３', "3"}, {'４', "4"},
        {'５', "5"}, {'６', "6"}, {'７', "7"}, {'８', "8"}, {'９', "9"},

        {'Ａ', "A"}, {'Ｂ', "B"}, {'Ｃ', "C"}, {'Ｄ', "D"}, {'Ｅ', "E"},
        {'Ｆ', "F"}, {'Ｇ', "G"}, {'Ｈ', "H"}, {'Ｉ', "I"}, {'Ｊ', "J"},
        {'Ｋ', "K"}, {'Ｌ', "L"}, {'Ｍ', "M"}, {'Ｎ', "N"}, {'Ｏ', "O"},
        {'Ｐ', "P"}, {'Ｑ', "Q"}, {'Ｒ', "R"}, {'Ｓ', "S"}, {'Ｔ', "T"},
        {'Ｕ', "U"}, {'Ｖ', "V"}, {'Ｗ', "W"}, {'Ｘ', "X"}, {'Ｙ', "Y"},
        {'Ｚ', "Z"},

        {'ａ', "a"}, {'ｂ', "b"}, {'ｃ', "c"}, {'ｄ', "d"}, {'ｅ', "e"},
        {'ｆ', "f"}, {'ｇ', "g"}, {'ｈ', "h"}, {'ｉ', "i"}, {'ｊ', "j"},
        {'ｋ', "k"}, {'ｌ', "l"}, {'ｍ', "m"}, {'ｎ', "n"}, {'ｏ', "o"},
        {'ｐ', "p"}, {'ｑ', "q"}, {'ｒ', "r"}, {'ｓ', "s"}, {'ｔ', "t"},
        {'ｕ', "u"}, {'ｖ', "v"}, {'ｗ', "w"}, {'ｘ', "x"}, {'ｙ', "y"},
        {'ｚ', "z"},

        {'！', "!"}, {'”', "\""}, {'＃', "#"}, {'＄', "$"}, {'％', "%"},
        {'＆', "&"}, {'’', "'"}, {'（', "("}, {'）', ")"}, {'＊', "*"},
        {'＋', "+"}, {'，', ","}, {'－', "-"}, {'．', "."}, {'／', "/"},
        {'：', ":"}, {'；', ";"}, {'＜', "<"}, {'＝', "="}, {'＞', ">"},
        {'？', "?"}, {'＠', "@"}, {'［', "["}, {'＼', "\\"}, {'］', "]"},
        {'＾', "^"}, {'＿', "_"}, {'｀', "`"}, {'｛', "{"}, {'｜', "|"},
        {'｝', "}"}, {'〜', "~"},

        {'ア', "ｱ"}, {'イ', "ｲ"}, {'ウ', "ｳ"}, {'エ', "ｴ"}, {'オ', "ｵ"},
        {'カ', "ｶ"}, {'キ', "ｷ"}, {'ク', "ｸ"}, {'ケ', "ｹ"}, {'コ', "ｺ"},
        {'サ', "ｻ"}, {'シ', "ｼ"}, {'ス', "ｽ"}, {'セ', "ｾ"}, {'ソ', "ｿ"},
        {'タ', "ﾀ"}, {'チ', "ﾁ"}, {'ツ', "ﾂ"}, {'テ', "ﾃ"}, {'ト', "ﾄ"},
        {'ナ', "ﾅ"}, {'ニ', "ﾆ"}, {'ヌ', "ﾇ"}, {'ネ', "ﾈ"}, {'ノ', "ﾉ"},
        {'ハ', "ﾊ"}, {'ヒ', "ﾋ"}, {'フ', "ﾌ"}, {'ヘ', "ﾍ"}, {'ホ', "ﾎ"},
        {'マ', "ﾏ"}, {'ミ', "ﾐ"}, {'ム', "ﾑ"}, {'メ', "ﾒ"}, {'モ', "ﾓ"},
        {'ヤ', "ﾔ"}, {'ユ', "ﾕ"}, {'ヨ', "ﾖ"},
        {'ラ', "ﾗ"}, {'リ', "ﾘ"}, {'ル', "ﾙ"}, {'レ', "ﾚ"}, {'ロ', "ﾛ"},
        {'ワ', "ﾜ"}, {'ヲ', "ｦ"}, {'ン', "ﾝ"},

        {'ヴ', "ｳﾞ"},
        {'ガ', "ｶﾞ"}, {'ギ', "ｷﾞ"}, {'グ', "ｸﾞ"}, {'ゲ', "ｹﾞ"}, {'ゴ', "ｺﾞ"},
        {'ザ', "ｻﾞ"}, {'ジ', "ｼﾞ"}, {'ズ', "ｽﾞ"}, {'ゼ', "ｾﾞ"}, {'ゾ', "ｿﾞ"},
        {'ダ', "ﾀﾞ"}, {'ヂ', "ﾁﾞ"}, {'ヅ', "ﾂﾞ"}, {'デ', "ﾃﾞ"}, {'ド', "ﾄﾞ"},
        {'バ', "ﾊﾞ"}, {'ビ', "ﾋﾞ"}, {'ブ', "ﾌﾞ"}, {'ベ', "ﾍﾞ"}, {'ボ', "ﾎﾞ"},
        {'パ', "ﾊﾟ"}, {'ピ', "ﾋﾟ"}, {'プ', "ﾌﾟ"}, {'ペ', "ﾍﾟ"}, {'ポ', "ﾎﾟ"},

        {'ァ', "ｧ"}, {'ィ', "ｨ"}, {'ゥ', "ｩ"}, {'ェ', "ｪ"}, {'ォ', "ｫ"},
        {'ッ', "ｯ"},
        {'ャ', "ｬ"}, {'ュ', "ｭ"}, {'ョ', "ｮ"},
        {'ー', "ｰ" }
    };

    /// <summary>
    /// 与えられた文字列内の全角文字を半角文字に変換します。
    /// </summary>
    /// <param name="text">対象の文字列</param>
    /// <returns>変換された文字列</returns>
    public static string ToHankaku(this string text)
    {
        var output = new StringBuilder();
        foreach (char c in text)
        {
            if (conversionMap.TryGetValue(c, out var str))
            {
                output.Append(str);
            }
            else
            {
                output.Append(c);
            }
        }
        return output.ToString();
    }

    /// <summary>
    /// 与えられた文字列内の日本語半角文字を1、それ以外を2としてカウントします。
    /// </summary>
    /// <param name="text">対象の文字列</param>
    /// <returns>半角文字の数</returns>
    public static int CountHankaku(this string text)
    {
        int count = 0;

        for (int i = 0; i < text.Length;)
        {
            // サロゲートペアの場合、2charで表現されるため専用の判定式を使用する
            if (char.IsSurrogatePair(text, i))
            {
                count += 2;
                i += 2;
            }
            else if (hankakuList.Contains(text[i]))
            {
                count += 1;
                i++;
            }
            else
            {
                count += 2;
                i++;
            }
        }
        return count;
    }

    /// <summary>
    /// 文字列を左から半角文字数分切り出します。
    /// </summary>
    /// <param name="text">処理対象の文字列。</param>
    /// <param name="hankakuCount">左から切り出す半角文字数。負の値は許可されません。</param>
    /// <returns>指定された文字数だけ左から切り出された文字列。</returns>
    public static string LeftHankaku(this string text, int hankakuCount)
    {
        return text.LeftHankaku(hankakuCount, out _);
    }

    /// <summary>
    /// 文字列を左から半角文字数分切り出します。
    /// </summary>
    /// <param name="text">処理対象の文字列。</param>
    /// <param name="hankakuCount">左から切り出す半角文字数。負の値は許可されません。</param>
    /// <param name="remainingText">残りの文字列。切り出された部分が全体の文字列と等しい場合は空文字列です。</param>
    /// <returns>指定された文字数だけ左から切り出された文字列。</returns>
    public static string LeftHankaku(this string text, int hankakuCount, out string remainingText)
    {
        if (string.IsNullOrEmpty(text) || hankakuCount <= 0)
        {
            remainingText = string.Empty;
            return string.Empty;
        }

        int count = 0;
        int readIndex = 0;

        for (int i = 0; i < text.Length;)
        {
            // サロゲートペアの場合、2charで表現されるため専用の判定式を使用する
            if (char.IsSurrogatePair(text, i))
            {
                count += 2;
                i += 2;
            }
            else if (hankakuList.Contains(text[i]))
            {
                count += 1;
                i++;
            }
            else
            {
                count += 2;
                i++;
            }

            // 条件内であれば文字列として採用する
            if (count <= hankakuCount)
            {
                readIndex = i;
            }

            // 文字数上限を超えた場合、中断する
            if (hankakuCount <= count)
            {
                break;
            }
        }

        // 残った文字列を取得する
        remainingText = text.Substring(readIndex);

        return text.Substring(0, readIndex);
    }
}
