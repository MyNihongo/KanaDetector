/*
* Copyright © 2021 MyNihongo
*/

using static MyNihongo.KanaDetector.Resources.Constants;

namespace MyNihongo.KanaDetector.Extensions
{
	public static class CharExtensions
	{
		public static bool IsHiragana(this char @this) =>
			IsHiragana(in @this);

		public static bool IsKatakana(this char @this) =>
			IsKatakana(in @this);

		public static bool IsKana(this char @this) =>
			IsHiragana(in @this) || IsKatakana(in @this);

		public static bool IsKanji(this char @this) =>
			IsKanji(in @this);

		public static bool IsKanaOrKanji(this char @this) =>
			IsHiragana(in @this) || IsKatakana(in @this) || IsKanji(in @this);

		private static bool IsHiragana(in char @char) =>
			@char is >= Kana.HiraganaStart and <= Kana.HiraganaEnd;

		private static bool IsKatakana(in char @char) =>
			@char is >= Kana.KatakanaStart and <= Kana.KatakanaEnd;

		private static bool IsKanji(in char @char) =>
			@char is
				>= Kanji.Start and <= Kanji.End or
				>= Kanji.RareStart and <= Kanji.RareEnd or
				Kanji.IterationMark;
	}
}
