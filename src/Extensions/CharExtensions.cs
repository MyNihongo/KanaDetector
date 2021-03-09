/*
* Copyright © 2021 MyNihongo
*/

using System;
using static MyNihongo.KanaDetector.Resources.Constants;

namespace MyNihongo.KanaDetector.Extensions
{
	public static class CharExtensions
	{
		public static bool IsHiragana(this char @this) =>
			IsHiragana(Convert.ToInt32(@this));

		public static bool IsKatakana(this char @this) =>
			IsKatakana(Convert.ToInt32(@this));

		public static bool IsKana(this char @this)
		{
			var @int = Convert.ToInt32(@this);
			return IsHiragana(@int) || IsKatakana(@int);
		}

		public static bool IsKanji(this char @this) =>
			IsKanji(Convert.ToInt32(@this));

		public static bool IsKanaOrKanji(this char @this)
		{
			var @int = Convert.ToInt32(@this);
			return IsHiragana(@int) || IsKatakana(@int) || IsKanji(@int);
		}

		private static bool IsHiragana(int number) =>
			number >= Kana.HiraganaStart && number <= Kana.HiraganaEnd;

		private static bool IsKatakana(int number) =>
			number >= Kana.KatakanaStart && number <= Kana.KatakanaEnd;

		private static bool IsKanji(int number) =>
			number >= Kanji.Start && number <= Kanji.End ||
			number >= Kanji.RareStart && number <= Kanji.RareEnd ||
			number == Kanji.IterationMark;
	}
}
