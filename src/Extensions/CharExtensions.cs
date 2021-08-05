/*
* Copyright © 2021 MyNihongo
*/

using static MyNihongo.KanaDetector.Resources.Constants;

namespace MyNihongo.KanaDetector.Extensions
{
	public static class CharExtensions
	{
		public static bool IsHiragana(this char @this) =>
			@this is >= Kana.HiraganaStart and <= Kana.HiraganaEnd;

		public static bool IsKatakana(this char @this) =>
			@this is >= Kana.KatakanaStart and <= Kana.KatakanaEnd;

		public static bool IsKana(this char @this) =>
			@this.IsHiragana() || @this.IsKatakana();

		public static bool IsKanji(this char @this) =>
			@this is
				>= Kanji.Start and <= Kanji.End or
				>= Kanji.RareStart and <= Kanji.RareEnd or
				Kanji.IterationMark;

		public static bool IsKanaOrKanji(this char @this) =>
			@this.IsHiragana() || @this.IsKatakana() || @this.IsKanji();

		public static bool IsRomaji(this char @this) =>
			@this
				is >= Romaji.EnglishStart and <= Romaji.EnglishEnd or
				Romaji.Hepbun.CapitalA or Romaji.Hepbun.SmallA or
				Romaji.Hepbun.CapitalI or Romaji.Hepbun.SmallI or
				Romaji.Hepbun.CapitalU or Romaji.Hepbun.SmallU or
				Romaji.Hepbun.CapitalE or Romaji.Hepbun.SmallE or
				Romaji.Hepbun.CapitalO or Romaji.Hepbun.SmallO;
	}
}
