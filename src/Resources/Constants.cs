/*
* Copyright © 2021 MyNihongo
*/

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("MyNihongo.KanaDetector.Tests")]
namespace MyNihongo.KanaDetector.Resources
{
	internal static class Constants
	{
		internal static class Romaji
		{
			internal const char EnglishStart = '!';
			internal const char EnglishEnd = '~';

			internal static class Hepbun
			{
				internal const char CapitalA = 'Ā';
				internal const char SmallA = 'ā';
				internal const char CapitalI = 'Ī';
				internal const char SmallI = 'ī';
				internal const char CapitalU = 'Ū';
				internal const char SmallU = 'ū';
				internal const char CapitalE = 'Ē';
				internal const char SmallE = 'ē';
				internal const char CapitalO = 'Ō';
				internal const char SmallO = 'ō';
			}
		}

		internal static class Kana
		{
			internal const char HiraganaStart = 'ぁ';
			internal const char HiraganaEnd = 'ゖ';
			internal const char KatakanaStart = 'ァ';
			internal const char KatakanaEnd = 'ー';
		}

		internal static class Kanji
		{
			internal const char Start = '一';
			internal const char End = '龯';
			internal const char RareStart = '㐀';
			internal const char RareEnd = '䶵';
			internal const char IterationMark = '々';
		}
	}
}
