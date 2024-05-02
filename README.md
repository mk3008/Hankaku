# Hankaku
半角変換と文字数カウント関数を提供します。

## デモンストレーション
```cs
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
```

### 結果
```
半角変換したい文字列を入力後、Enterキーを押してください。
ヤマダタロウ
入力値　　　: ヤマダタロウ
半角変換後　: ﾔﾏﾀﾞﾀﾛｳ
カウント半角: 7
```

## 機能
- 文字列を半角文字列に変換できます。
- 半角変更できる文字列は英数字、記号（スペース含む）、日本語カナのみです。
- 文字列を半角文字なら1、それ以外を2としてカウントすることができます。

## インストール
PM> Install-Package Hankaku

[Nugetページはこちら。](https://www.nuget.org/packages/Hankaku)

## 使い方

### ToHankaku メソッド
与えられた文字列内の全角文字を半角文字に変換します。
```cs
public static string ToHankaku(this string text)
```

### CountHankaku メソッド
与えられた文字列内の日本語半角文字を1、それ以外を2としてカウントします。
```cs
public static int CountHankaku(this string text)
```
