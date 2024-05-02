# Hankaku
���p�ϊ��ƕ������J�E���g�֐���񋟂��܂��B

## �f�����X�g���[�V����
```cs
using Hankaku;

Console.WriteLine("���p�ϊ����������������͌�AEnter�L�[�������Ă��������B");
var input = Console.ReadLine();
input ??= string.Empty;

Console.WriteLine("���͒l�@�@�@: " + input);

// ���p�ϊ���̕�������擾
var hankakuText = input.ToHankaku();
Console.WriteLine("���p�ϊ���@: " + hankakuText);

// ���p�������J�E���g
Console.WriteLine("�J�E���g���p: " + hankakuText.CountHankaku());
```

### ����
```
���p�ϊ����������������͌�AEnter�L�[�������Ă��������B
���}�_�^���E
���͒l�@�@�@: ���}�_�^���E
���p�ϊ���@: �����۳
�J�E���g���p: 7
```

## �@�\
- ������𔼊p������ɕϊ��ł��܂��B
- ���p�ύX�ł��镶����͉p�����A�L���i�X�y�[�X�܂ށj�A���{��J�i�݂̂ł��B
- ������𔼊p�����Ȃ�1�A����ȊO��2�Ƃ��ăJ�E���g���邱�Ƃ��ł��܂��B

## �C���X�g�[��
PM> Install-Package Hankaku

[Nuget�y�[�W�͂�����B](https://www.nuget.org/packages/Hankaku)

## �g����

### ToHankaku ���\�b�h
�^����ꂽ��������̑S�p�����𔼊p�����ɕϊ����܂��B
```cs
public static string ToHankaku(this string text)
```

### CountHankaku ���\�b�h
�^����ꂽ��������̓��{�ꔼ�p������1�A����ȊO��2�Ƃ��ăJ�E���g���܂��B
```cs
public static int CountHankaku(this string text)
```
