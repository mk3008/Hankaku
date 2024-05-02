using Hankaku;

Console.WriteLine("半角変換したい文字列を入力後、Enterキーを押してください。");
var input = Console.ReadLine();
input ??= string.Empty;

Console.WriteLine("入力値　　　: " + input);

// 半角変換後の文字列を取得
var hankakuText = input.ToHankaku();
Console.WriteLine("半角変換後　: " + hankakuText);

// 半角文字数カウント
Console.WriteLine("カウント半角: " + hankakuText.CountHankaku());