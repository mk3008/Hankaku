using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Hankaku;

/// <summary>
/// 半角文字列操作に関する拡張メソッド
/// </summary>
public static class StringExtensions
{
    /// <summary>
    /// 半角かどうか調べる
    /// </summary>
    private static bool IsHalfWidth(char c)
    {
        // 変数化せず、関数内に直接記述ことでList<T>の1/3、HashSet<T>の1/2の処理速度になる
        switch (c)
        {
            case ' ':
            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
            case '!':
            case '"':
            case '#':
            case '$':
            case '%':
            case '&':
            case '\'':
            case '(':
            case ')':
            case '*':
            case '+':
            case ',':
            case '-':
            case '.':
            case '/':
            case ':':
            case ';':
            case '<':
            case '=':
            case '>':
            case '?':
            case '@':
            case '[':
            case '\\':
            case ']':
            case '^':
            case '_':
            case '`':
            case '{':
            case '|':
            case '}':
            case '~':
            case 'a':
            case 'b':
            case 'c':
            case 'd':
            case 'e':
            case 'f':
            case 'g':
            case 'h':
            case 'i':
            case 'j':
            case 'k':
            case 'l':
            case 'm':
            case 'n':
            case 'o':
            case 'p':
            case 'q':
            case 'r':
            case 's':
            case 't':
            case 'u':
            case 'v':
            case 'w':
            case 'x':
            case 'y':
            case 'z':
            case 'A':
            case 'B':
            case 'C':
            case 'D':
            case 'E':
            case 'F':
            case 'G':
            case 'H':
            case 'I':
            case 'J':
            case 'K':
            case 'L':
            case 'M':
            case 'N':
            case 'O':
            case 'P':
            case 'Q':
            case 'R':
            case 'S':
            case 'T':
            case 'U':
            case 'V':
            case 'W':
            case 'X':
            case 'Y':
            case 'Z':
            case 'ｱ':
            case 'ｲ':
            case 'ｳ':
            case 'ｴ':
            case 'ｵ':
            case 'ｶ':
            case 'ｷ':
            case 'ｸ':
            case 'ｹ':
            case 'ｺ':
            case 'ｻ':
            case 'ｼ':
            case 'ｽ':
            case 'ｾ':
            case 'ｿ':
            case 'ﾀ':
            case 'ﾁ':
            case 'ﾂ':
            case 'ﾃ':
            case 'ﾄ':
            case 'ﾅ':
            case 'ﾆ':
            case 'ﾇ':
            case 'ﾈ':
            case 'ﾉ':
            case 'ﾊ':
            case 'ﾋ':
            case 'ﾌ':
            case 'ﾍ':
            case 'ﾎ':
            case 'ﾏ':
            case 'ﾐ':
            case 'ﾑ':
            case 'ﾒ':
            case 'ﾓ':
            case 'ﾔ':
            case 'ﾕ':
            case 'ﾖ':
            case 'ﾗ':
            case 'ﾘ':
            case 'ﾙ':
            case 'ﾚ':
            case 'ﾛ':
            case 'ﾜ':
            case 'ｦ':
            case 'ﾝ':
            case 'ｧ':
            case 'ｨ':
            case 'ｩ':
            case 'ｪ':
            case 'ｫ':
            case 'ｯ':
            case 'ｬ':
            case 'ｭ':
            case 'ｮ':
            case 'ﾞ':
            case 'ﾟ':
            case 'ｰ':
                return true;
            default:
                return false;
        }
    }

    /// <summary>
    /// 半角化文字を取得できるか試みます。
    /// </summary>
    private static bool TryGetHankaku(char c, [MaybeNullWhen(false)] out string text)
    {
        // 変数化せず、関数内に直接記述することでDictionary<char, string>の1/2の処理速度になる
        switch (c)
        {
            case '　':
                text = " ";
                return true;
            case '０':
                text = "0";
                return true;
            case '１':
                text = "1";
                return true;
            case '２':
                text = "2";
                return true;
            case '３':
                text = "3";
                return true;
            case '４':
                text = "4";
                return true;
            case '５':
                text = "5";
                return true;
            case '６':
                text = "6";
                return true;
            case '７':
                text = "7";
                return true;
            case '８':
                text = "8";
                return true;
            case '９':
                text = "9";
                return true;
            case 'Ａ':
                text = "A";
                return true;
            case 'Ｂ':
                text = "B";
                return true;
            case 'Ｃ':
                text = "C";
                return true;
            case 'Ｄ':
                text = "D";
                return true;
            case 'Ｅ':
                text = "E";
                return true;
            case 'Ｆ':
                text = "F";
                return true;
            case 'Ｇ':
                text = "G";
                return true;
            case 'Ｈ':
                text = "H";
                return true;
            case 'Ｉ':
                text = "I";
                return true;
            case 'Ｊ':
                text = "J";
                return true;
            case 'Ｋ':
                text = "K";
                return true;
            case 'Ｌ':
                text = "L";
                return true;
            case 'Ｍ':
                text = "M";
                return true;
            case 'Ｎ':
                text = "N";
                return true;
            case 'Ｏ':
                text = "O";
                return true;
            case 'Ｐ':
                text = "P";
                return true;
            case 'Ｑ':
                text = "Q";
                return true;
            case 'Ｒ':
                text = "R";
                return true;
            case 'Ｓ':
                text = "S";
                return true;
            case 'Ｔ':
                text = "T";
                return true;
            case 'Ｕ':
                text = "U";
                return true;
            case 'Ｖ':
                text = "V";
                return true;
            case 'Ｗ':
                text = "W";
                return true;
            case 'Ｘ':
                text = "X";
                return true;
            case 'Ｙ':
                text = "Y";
                return true;
            case 'Ｚ':
                text = "Z";
                return true;
            case 'ａ':
                text = "a";
                return true;
            case 'ｂ':
                text = "b";
                return true;
            case 'ｃ':
                text = "c";
                return true;
            case 'ｄ':
                text = "d";
                return true;
            case 'ｅ':
                text = "e";
                return true;
            case 'ｆ':
                text = "f";
                return true;
            case 'ｇ':
                text = "g";
                return true;
            case 'ｈ':
                text = "h";
                return true;
            case 'ｉ':
                text = "i";
                return true;
            case 'ｊ':
                text = "j";
                return true;
            case 'ｋ':
                text = "k";
                return true;
            case 'ｌ':
                text = "l";
                return true;
            case 'ｍ':
                text = "m";
                return true;
            case 'ｎ':
                text = "n";
                return true;
            case 'ｏ':
                text = "o";
                return true;
            case 'ｐ':
                text = "p";
                return true;
            case 'ｑ':
                text = "q";
                return true;
            case 'ｒ':
                text = "r";
                return true;
            case 'ｓ':
                text = "s";
                return true;
            case 'ｔ':
                text = "t";
                return true;
            case 'ｕ':
                text = "u";
                return true;
            case 'ｖ':
                text = "v";
                return true;
            case 'ｗ':
                text = "w";
                return true;
            case 'ｘ':
                text = "x";
                return true;
            case 'ｙ':
                text = "y";
                return true;
            case 'ｚ':
                text = "z";
                return true;
            case '！':
                text = "!";
                return true;
            case '”':
                text = "\"";
                return true;
            case '＃':
                text = "#";
                return true;
            case '＄':
                text = "$";
                return true;
            case '％':
                text = "%";
                return true;
            case '＆':
                text = "&";
                return true;
            case '’':
                text = "'";
                return true;
            case '（':
                text = "(";
                return true;
            case '）':
                text = ")";
                return true;
            case '＊':
                text = "*";
                return true;
            case '＋':
                text = "+";
                return true;
            case '，':
                text = ",";
                return true;
            case '－':
                text = "-";
                return true;
            case '．':
                text = ".";
                return true;
            case '／':
                text = "/";
                return true;
            case '：':
                text = ":";
                return true;
            case '；':
                text = ";";
                return true;
            case '＜':
                text = "<";
                return true;
            case '＝':
                text = "=";
                return true;
            case '＞':
                text = ">";
                return true;
            case '？':
                text = "?";
                return true;
            case '＠':
                text = "@";
                return true;
            case '［':
                text = "[";
                return true;
            case '＼':
                text = "\\";
                return true;
            case '］':
                text = "]";
                return true;
            case '＾':
                text = "^";
                return true;
            case '＿':
                text = "_";
                return true;
            case '｀':
                text = "`";
                return true;
            case '｛':
                text = "{";
                return true;
            case '｜':
                text = "|";
                return true;
            case '｝':
                text = "}";
                return true;
            case '〜':
                text = "~";
                return true;
            case 'ア':
                text = "ｱ";
                return true;
            case 'イ':
                text = "ｲ";
                return true;
            case 'ウ':
                text = "ｳ";
                return true;
            case 'エ':
                text = "ｴ";
                return true;
            case 'オ':
                text = "ｵ";
                return true;
            case 'カ':
                text = "ｶ";
                return true;
            case 'キ':
                text = "ｷ";
                return true;
            case 'ク':
                text = "ｸ";
                return true;
            case 'ケ':
                text = "ｹ";
                return true;
            case 'コ':
                text = "ｺ";
                return true;
            case 'サ':
                text = "ｻ";
                return true;
            case 'シ':
                text = "ｼ";
                return true;
            case 'ス':
                text = "ｽ";
                return true;
            case 'セ':
                text = "ｾ";
                return true;
            case 'ソ':
                text = "ｿ";
                return true;
            case 'タ':
                text = "ﾀ";
                return true;
            case 'チ':
                text = "ﾁ";
                return true;
            case 'ツ':
                text = "ﾂ";
                return true;
            case 'テ':
                text = "ﾃ";
                return true;
            case 'ト':
                text = "ﾄ";
                return true;
            case 'ナ':
                text = "ﾅ";
                return true;
            case 'ニ':
                text = "ﾆ";
                return true;
            case 'ヌ':
                text = "ﾇ";
                return true;
            case 'ネ':
                text = "ﾈ";
                return true;
            case 'ノ':
                text = "ﾉ";
                return true;
            case 'ハ':
                text = "ﾊ";
                return true;
            case 'ヒ':
                text = "ﾋ";
                return true;
            case 'フ':
                text = "ﾌ";
                return true;
            case 'ヘ':
                text = "ﾍ";
                return true;
            case 'ホ':
                text = "ﾎ";
                return true;
            case 'マ':
                text = "ﾏ";
                return true;
            case 'ミ':
                text = "ﾐ";
                return true;
            case 'ム':
                text = "ﾑ";
                return true;
            case 'メ':
                text = "ﾒ";
                return true;
            case 'モ':
                text = "ﾓ";
                return true;
            case 'ヤ':
                text = "ﾔ";
                return true;
            case 'ユ':
                text = "ﾕ";
                return true;
            case 'ヨ':
                text = "ﾖ";
                return true;
            case 'ラ':
                text = "ﾗ";
                return true;
            case 'リ':
                text = "ﾘ";
                return true;
            case 'ル':
                text = "ﾙ";
                return true;
            case 'レ':
                text = "ﾚ";
                return true;
            case 'ロ':
                text = "ﾛ";
                return true;
            case 'ワ':
                text = "ﾜ";
                return true;
            case 'ヲ':
                text = "ｦ";
                return true;
            case 'ン':
                text = "ﾝ";
                return true;
            case 'ヴ':
                text = "ｳﾞ";
                return true;
            case 'ガ':
                text = "ｶﾞ";
                return true;
            case 'ギ':
                text = "ｷﾞ";
                return true;
            case 'グ':
                text = "ｸﾞ";
                return true;
            case 'ゲ':
                text = "ｹﾞ";
                return true;
            case 'ゴ':
                text = "ｺﾞ";
                return true;
            case 'ザ':
                text = "ｻﾞ";
                return true;
            case 'ジ':
                text = "ｼﾞ";
                return true;
            case 'ズ':
                text = "ｽﾞ";
                return true;
            case 'ゼ':
                text = "ｾﾞ";
                return true;
            case 'ゾ':
                text = "ｿﾞ";
                return true;
            case 'ダ':
                text = "ﾀﾞ";
                return true;
            case 'ヂ':
                text = "ﾁﾞ";
                return true;
            case 'ヅ':
                text = "ﾂﾞ";
                return true;
            case 'デ':
                text = "ﾃﾞ";
                return true;
            case 'ド':
                text = "ﾄﾞ";
                return true;
            case 'バ':
                text = "ﾊﾞ";
                return true;
            case 'ビ':
                text = "ﾋﾞ";
                return true;
            case 'ブ':
                text = "ﾌﾞ";
                return true;
            case 'ベ':
                text = "ﾍﾞ";
                return true;
            case 'ボ':
                text = "ﾎﾞ";
                return true;
            case 'パ':
                text = "ﾊﾟ";
                return true;
            case 'ピ':
                text = "ﾋﾟ";
                return true;
            case 'プ':
                text = "ﾌﾟ";
                return true;
            case 'ペ':
                text = "ﾍﾟ";
                return true;
            case 'ポ':
                text = "ﾎﾟ";
                return true;
            case 'ァ':
                text = "ｧ";
                return true;
            case 'ィ':
                text = "ｨ";
                return true;
            case 'ゥ':
                text = "ｩ";
                return true;
            case 'ェ':
                text = "ｪ";
                return true;
            case 'ォ':
                text = "ｫ";
                return true;
            case 'ッ':
                text = "ｯ";
                return true;
            case 'ャ':
                text = "ｬ";
                return true;
            case 'ュ':
                text = "ｭ";
                return true;
            case 'ョ':
                text = "ｮ";
                return true;
            case 'ー':
                text = "ｰ";
                return true;
            default:
                text = null;
                return false;
        }
    }

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
            if (TryGetHankaku(c, out var str))
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
            else if (IsHalfWidth(text[i]))
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
            remainingText = text;
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
            else if (IsHalfWidth(text[i]))
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
