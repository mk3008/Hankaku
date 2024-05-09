using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;
using Hankaku;

class Program
{
    static void Main(string[] args) => BenchmarkRunner.Run<Test>();
}

public class Test
{
    static string Text =>
"""
＊＊＊¡Hla! Привет! Bnjour! 你好! مرحبا! Γεια σας! Cia! Hallo! ｺﾝﾆﾁﾊ! Oa! שלום! Hej! Привіт! Merhba! こんにちわ! ਸਤ ਸ੍ਰੀ ਅਕਾਲ! Salutn! سلام! Здравствуйте! He! سلام! Halå! Ahj! สวัสดี! Kust! హలో! Cześć! გამარჯობა! 你好! ഹലോ! مرحب! Halò! नमस्त! こんにちわ! سلام! Привт! ሰላም! ជំរាបសួរ! ໂປດຊາບ! မင်္ဂလာပါ! ନମସ୍କାର! سلام! හෙලෝ! வணக்கம! హలో! สวัสดีครับ! բարեւ! Xin chào! ಹಲೋ! გამარჯობა! ＄＄＄
😊✨＊＊Greetngs frm beyond＊＊✨😊. Let's communicte in th lnguage of th univrse.＊＊＊Tgether, we explre th unknown＊＊＊. ＄＄＄Let curisity be our gide＄＄＄. ＃＃＃In the vasness of existnce, we fnd cnnection＃＃＃. ※※※Let's jurney bynd boundries※※※.＊＊＊Best rgards＊＊＊. 🚀🌌🌠＊＊＊
＊＊＊¡Hla! Привет! Bnjour! 你好! مرحبا! Γεια σας! Cia! Hallo! ｺﾝﾆﾁﾊ! Oa! שלום! Hej! Привіт! Merhba! こんにちわ! ਸਤ ਸ੍ਰੀ ਅਕਾਲ! Salutn! سلام! Здравствуйте! He! سلام! Halå! Ahj! สวัสดี! Kust! హలో! Cześć! გამარჯობა! 你好! ഹലോ! مرحب! Halò! नमस्त! こんにちわ! سلام! Привт! ሰላም! ជំរាបសួរ! ໂປດຊາບ! မင်္ဂလာပါ! ନମସ୍କାର! سلام! හෙලෝ! வணக்கம! హలో! สวัสดีครับ! բարեւ! Xin chào! ಹಲೋ! გამარჯობა! ＄＄＄
😊✨＊＊Greetngs frm beyond＊＊✨😊. Let's communicte in th lnguage of th univrse.＊＊＊Tgether, we explre th unknown＊＊＊. ＄＄＄Let curisity be our gide＄＄＄. ＃＃＃In the vasness of existnce, we fnd cnnection＃＃＃. ※※※Let's jurney bynd boundries※※※.＊＊＊Best rgards＊＊＊. 🚀🌌🌠＊＊＊
＊＊＊¡Hla! Привет! Bnjour! 你好! مرحبا! Γεια σας! Cia! Hallo! ｺﾝﾆﾁﾊ! Oa! שלום! Hej! Привіт! Merhba! こんにちわ! ਸਤ ਸ੍ਰੀ ਅਕਾਲ! Salutn! سلام! Здравствуйте! He! سلام! Halå! Ahj! สวัสดี! Kust! హలో! Cześć! გამარჯობა! 你好! ഹലോ! مرحب! Halò! नमस्त! こんにちわ! سلام! Привт! ሰላም! ជំរាបសួរ! ໂປດຊາບ! မင်္ဂလာပါ! ନମସ୍କାର! سلام! හෙලෝ! வணக்கம! హలో! สวัสดีครับ! բարեւ! Xin chào! ಹಲೋ! გამარჯობა! ＄＄＄
😊✨＊＊Greetngs frm beyond＊＊✨😊. Let's communicte in th lnguage of th univrse.＊＊＊Tgether, we explre th unknown＊＊＊. ＄＄＄Let curisity be our gide＄＄＄. ＃＃＃In the vasness of existnce, we fnd cnnection＃＃＃. ※※※Let's jurney bynd boundries※※※.＊＊＊Best rgards＊＊＊. 🚀🌌🌠＊＊＊
＊＊＊¡Hla! Привет! Bnjour! 你好! مرحبا! Γεια σας! Cia! Hallo! ｺﾝﾆﾁﾊ! Oa! שלום! Hej! Привіт! Merhba! こんにちわ! ਸਤ ਸ੍ਰੀ ਅਕਾਲ! Salutn! سلام! Здравствуйте! He! سلام! Halå! Ahj! สวัสดี! Kust! హలో! Cześć! გამარჯობა! 你好! ഹലോ! مرحب! Halò! नमस्त! こんにちわ! سلام! Привт! ሰላም! ជំរាបសួរ! ໂປດຊາບ! မင်္ဂလာပါ! ନମସ୍କାର! سلام! හෙලෝ! வணக்கம! హలో! สวัสดีครับ! բարեւ! Xin chào! ಹಲೋ! გამარჯობა! ＄＄＄
😊✨＊＊Greetngs frm beyond＊＊✨😊. Let's communicte in th lnguage of th univrse.＊＊＊Tgether, we explre th unknown＊＊＊. ＄＄＄Let curisity be our gide＄＄＄. ＃＃＃In the vasness of existnce, we fnd cnnection＃＃＃. ※※※Let's jurney bynd boundries※※※.＊＊＊Best rgards＊＊＊. 🚀🌌🌠＊＊＊
＊＊＊¡Hla! Привет! Bnjour! 你好! مرحبا! Γεια σας! Cia! Hallo! ｺﾝﾆﾁﾊ! Oa! שלום! Hej! Привіт! Merhba! こんにちわ! ਸਤ ਸ੍ਰੀ ਅਕਾਲ! Salutn! سلام! Здравствуйте! He! سلام! Halå! Ahj! สวัสดี! Kust! హలో! Cześć! გამარჯობა! 你好! ഹലോ! مرحب! Halò! नमस्त! こんにちわ! سلام! Привт! ሰላም! ជំរាបសួរ! ໂປດຊາບ! မင်္ဂလာပါ! ନମସ୍କାର! سلام! හෙලෝ! வணக்கம! హలో! สวัสดีครับ! բարեւ! Xin chào! ಹಲೋ! გამარჯობა! ＄＄＄
😊✨＊＊Greetngs frm beyond＊＊✨😊. Let's communicte in th lnguage of th univrse.＊＊＊Tgether, we explre th unknown＊＊＊. ＄＄＄Let curisity be our gide＄＄＄. ＃＃＃In the vasness of existnce, we fnd cnnection＃＃＃. ※※※Let's jurney bynd boundries※※※.＊＊＊Best rgards＊＊＊. 🚀🌌🌠＊＊＊
＊＊＊¡Hla! Привет! Bnjour! 你好! مرحبا! Γεια σας! Cia! Hallo! ｺﾝﾆﾁﾊ! Oa! שלום! Hej! Привіт! Merhba! こんにちわ! ਸਤ ਸ੍ਰੀ ਅਕਾਲ! Salutn! سلام! Здравствуйте! He! سلام! Halå! Ahj! สวัสดี! Kust! హలో! Cześć! გამარჯობა! 你好! ഹലോ! مرحب! Halò! नमस्त! こんにちわ! سلام! Привт! ሰላም! ជំរាបសួរ! ໂປດຊາບ! မင်္ဂလာပါ! ନମସ୍କାର! سلام! හෙලෝ! வணக்கம! హలో! สวัสดีครับ! բարեւ! Xin chào! ಹಲೋ! გამარჯობა! ＄＄＄
😊✨＊＊Greetngs frm beyond＊＊✨😊. Let's communicte in th lnguage of th univrse.＊＊＊Tgether, we explre th unknown＊＊＊. ＄＄＄Let curisity be our gide＄＄＄. ＃＃＃In the vasness of existnce, we fnd cnnection＃＃＃. ※※※Let's jurney bynd boundries※※※.＊＊＊Best rgards＊＊＊. 🚀🌌🌠＊＊＊
＊＊＊¡Hla! Привет! Bnjour! 你好! مرحبا! Γεια σας! Cia! Hallo! ｺﾝﾆﾁﾊ! Oa! שלום! Hej! Привіт! Merhba! こんにちわ! ਸਤ ਸ੍ਰੀ ਅਕਾਲ! Salutn! سلام! Здравствуйте! He! سلام! Halå! Ahj! สวัสดี! Kust! హలో! Cześć! გამარჯობა! 你好! ഹലോ! مرحب! Halò! नमस्त! こんにちわ! سلام! Привт! ሰላም! ជំរាបសួរ! ໂປດຊາບ! မင်္ဂလာပါ! ନମସ୍କାର! سلام! හෙලෝ! வணக்கம! హలో! สวัสดีครับ! բարեւ! Xin chào! ಹಲೋ! გამარჯობა! ＄＄＄
😊✨＊＊Greetngs frm beyond＊＊✨😊. Let's communicte in th lnguage of th univrse.＊＊＊Tgether, we explre th unknown＊＊＊. ＄＄＄Let curisity be our gide＄＄＄. ＃＃＃In the vasness of existnce, we fnd cnnection＃＃＃. ※※※Let's jurney bynd boundries※※※.＊＊＊Best rgards＊＊＊. 🚀🌌🌠＊＊＊
＊＊＊¡Hla! Привет! Bnjour! 你好! مرحبا! Γεια σας! Cia! Hallo! ｺﾝﾆﾁﾊ! Oa! שלום! Hej! Привіт! Merhba! こんにちわ! ਸਤ ਸ੍ਰੀ ਅਕਾਲ! Salutn! سلام! Здравствуйте! He! سلام! Halå! Ahj! สวัสดี! Kust! హలో! Cześć! გამარჯობა! 你好! ഹലോ! مرحب! Halò! नमस्त! こんにちわ! سلام! Привт! ሰላም! ជំរាបសួរ! ໂປດຊາບ! မင်္ဂလာပါ! ନମସ୍କାର! سلام! හෙලෝ! வணக்கம! హలో! สวัสดีครับ! բարեւ! Xin chào! ಹಲೋ! გამარჯობა! ＄＄＄
😊✨＊＊Greetngs frm beyond＊＊✨😊. Let's communicte in th lnguage of th univrse.＊＊＊Tgether, we explre th unknown＊＊＊. ＄＄＄Let curisity be our gide＄＄＄. ＃＃＃In the vasness of existnce, we fnd cnnection＃＃＃. ※※※Let's jurney bynd boundries※※※.＊＊＊Best rgards＊＊＊. 🚀🌌🌠＊＊＊
""";

    [Benchmark]
    public void CountHankaku()
    {
        Text.CountHankaku();
    }

    [Benchmark]
    public void ToHankaku()
    {
        Text.ToHankaku();
    }
}
