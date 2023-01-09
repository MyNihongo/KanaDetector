﻿/*
* Copyright © 2023 MyNihongo
*/

namespace MyNihongo.KanaDetector.Tests.TestHelpers;

public static class CharacterHelper
{
	private static readonly Lazy<IReadOnlyList<char>> HiraganaLazy =
		new(() => new List<char>
		{
			'ぁ','あ','ぃ','い','ぅ','う','ぇ','え','ぉ','お','か','が','き','ぎ','く',
			'ぐ','け','げ','こ','ご','さ','ざ','し','じ','す','ず','せ','ぜ','そ','ぞ','た',
			'だ','ち','ぢ','っ','つ','づ','て','で','と','ど','な','に','ぬ','ね','の','は',
			'ば','ぱ','ひ','び','ぴ','ふ','ぶ','ぷ','へ','べ','ぺ','ほ','ぼ','ぽ','ま','み',
			'む','め','も','ゃ','や','ゅ','ゆ','ょ','よ','ら','り','る','れ','ろ','ゎ','わ',
			'ゐ','ゑ','を','ん','ゔ','ゕ','ゖ'
		});

	private static readonly Lazy<IReadOnlyList<char>> KatakanaLazy =
		new(() => new List<char>
		{
			'ァ','ア','ィ','イ','ゥ','ウ','ェ','エ','ォ','オ','カ','ガ','キ','ギ','ク',
			'グ','ケ','ゲ','コ','ゴ','サ','ザ','シ','ジ','ス','ズ','セ','ゼ','ソ','ゾ','タ',
			'ダ','チ','ヂ','ッ','ツ','ヅ','テ','デ','ト','ド','ナ','ニ','ヌ','ネ','ノ','ハ',
			'バ','パ','ヒ','ビ','ピ','フ','ブ','プ','ヘ','ベ','ペ','ホ','ボ','ポ','マ','ミ',
			'ム','メ','モ','ャ','ヤ','ュ','ユ','ョ','ヨ','ラ','リ','ル','レ','ロ','ヮ','ワ',
			'ヰ','ヱ','ヲ','ン','ヴ','ヵ','ヶ','ヷ','ヸ','ヹ','ヺ',
			'・','ー'
		});

	private static readonly Lazy<IReadOnlyList<char>> RomajiLazy =
		new(() => new List<char>
		{
			'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x' ,'y','z',
			'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X' ,'Y','Z',
			'ā', 'ī', 'ū', 'ē', 'ō',
			'Ā', 'Ī', 'Ū', 'Ē', 'Ō'
		});

	public static IReadOnlyList<char> Hiragana => HiraganaLazy.Value;

	public static IReadOnlyList<char> Katakana => KatakanaLazy.Value;

	public static IReadOnlyList<char> Romaji => RomajiLazy.Value;

	public static IEnumerable<char> Kanji()
	{
		for (var i = Constants.Kanji.Start; i <= Constants.Kanji.End; i++)
			yield return Convert.ToChar(i);

		for (var i = Constants.Kanji.RareStart; i <= Constants.Kanji.RareEnd; i++)
			yield return Convert.ToChar(i);

		yield return Convert.ToChar(Constants.Kanji.IterationMark);
	}
}
