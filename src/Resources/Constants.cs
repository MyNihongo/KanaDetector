/*
* Copyright © 2023 MyNihongo
*/

namespace MyNihongo.KanaDetector;

internal static class Constants
{
	internal static class Romaji
	{
		internal const char EnglishStart = '!',
			EnglishEnd = '~';

		internal static class Hepbun
		{
			internal const char CapitalA = 'Ā',
				SmallA = 'ā',
				CapitalI = 'Ī',
				SmallI = 'ī',
				CapitalU = 'Ū',
				SmallU = 'ū',
				CapitalE = 'Ē',
				SmallE = 'ē',
				CapitalO = 'Ō',
				SmallO = 'ō';
		}
	}

	internal static class Kana
	{
		internal const char HiraganaStart = 'ぁ',
			HiraganaEnd = 'ゖ',
			KatakanaStart = 'ァ',
			KatakanaEnd = 'ー';
	}

	internal static class Kanji
	{
		internal const char Start = '一',
			End = '龯',
			RareStart = '㐀',
			RareEnd = '䶵',
			IterationMark = '々';
	}
	
	internal static class Punctuation
	{
		internal const char Comma = '、',
			FullStop = '。',
			ExclamationMark = '！',
			QuestionMark = '？';
	}
}
