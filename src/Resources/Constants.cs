/*
* Copyright © 2021 MyNihongo
*/

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("MyNihongo.KanaDetector.Tests")]
namespace MyNihongo.KanaDetector.Resources
{
	internal static class Constants
	{
		internal static class Kana
		{
			internal const int HiraganaStart = 0x3041; // // ぁ
			internal const int HiraganaEnd = 0x3096; // ゖ
			internal const int KatakanaStart = 0x30a1; // ァ
			internal const int KatakanaEnd = 0x30fc; // ー
		}

		internal static class Kanji
		{
			internal const int Start = 0x4e00; // 一
			internal const int End = 0x9faf; // 龯
			internal const int RareStart = 0x3400; // 㐀
			internal const int RareEnd = 0x4db5; // 䶵
			internal const int IterationMark = 0x3005; // 々
		}
	}
}
