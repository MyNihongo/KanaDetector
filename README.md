[![Version](https://img.shields.io/nuget/v/MyNihongo.KanaDetector?style=plastic)](https://www.nuget.org/packages/MyNihongo.KanaDetector/)  
Extension methods to detect Japanese characters in `string` and `char` variables.
### Character methods
```cs
var result = 'ひ'.IsHiragana();
var result = 'ナ'.IsKatakana();
var result = 'ら'.IsKana();

var result = '日'.IsKanji();
var result = '本'.IsKanaOrKanji();
```
### Kana methods
```cs
var result = "ひらがな".IsHiragana();
var result = "カタカナ".IsKatakana();
var result = "ひらがなカタカナ".IsKana();

var result = "歌う".HasHiragana();
var result = "消しゴム".HasKatakana();
var result = "ケイタイがある".HasKana();
```
### Kanji methods
```cs
var result = "教育制度".IsKanji();
var result = "東京に死んでる".IsKanaOrKanji();

var result = "漢字を覚える".HasKanji();
var result = "日本語の勉強".HasKanaOrKanji();
```
