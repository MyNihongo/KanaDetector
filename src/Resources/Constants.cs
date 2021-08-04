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
			internal const int EnglishStart = 0x0021; // !
			internal const int EnglishEnd = 0x007f; // " "

			internal static class Hepbun
			{
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
