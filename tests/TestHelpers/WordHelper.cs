/*
* Copyright © 2023 MyNihongo
*/

using System.Security.Cryptography;

namespace MyNihongo.KanaDetector.Tests.TestHelpers;

public static class WordHelper
{
	public static string GenerateHiragana()
	{
		var length = RandomNumberGenerator.GetInt32(5, 10);

		return string.Create(length, string.Empty, static (span, _) =>
		{
			for (var i = 0; i < span.Length; i++)
				span[i] = GetRandomChar(Constants.Kana.HiraganaStart, Constants.Kana.HiraganaEnd);
		});
	}

	public static string GenerateKatakana()
	{
		var length = RandomNumberGenerator.GetInt32(5, 10);

		return string.Create(length, string.Empty, static (span, _) =>
		{
			for (var i = 0; i < span.Length; i++)
				span[i] = GetRandomChar(Constants.Kana.KatakanaStart, Constants.Kana.KatakanaEnd);
		});
	}

	public static string GenerateKanji()
	{
		var length = RandomNumberGenerator.GetInt32(5, 10);

		return string.Create(length, string.Empty, static (span, _) =>
		{
			for (var i = 0; i < span.Length; i++)
			{
				var (from, to) = i % 2 == 0
					? (Constants.Kanji.Start, Constants.Kanji.End)
					: (Constants.Kanji.RareStart, Constants.Kanji.RareEnd);

				span[i] = GetRandomChar(from, to);
			}
		});
	}

	public static string GenerateRomaji()
	{
		var length = RandomNumberGenerator.GetInt32(5, 10);

		return string.Create(length, string.Empty, static (span, _) =>
		{
			for (var i = 0; i < span.Length; i++)
			{
				var index = RandomNumberGenerator.GetInt32(0, CharacterHelper.Romaji.Count);
				span[i] = CharacterHelper.Romaji[index];
			}
		});
	}
	
	public static string GeneratePunctuation()
	{
		var length = RandomNumberGenerator.GetInt32(5, 10);

		return string.Create(length, string.Empty, static (span, _) =>
		{
			for (var i = 0; i < span.Length; i++)
			{
				var index = RandomNumberGenerator.GetInt32(0, CharacterHelper.Punctuation.Count);
				span[i] = CharacterHelper.Punctuation[index];
			}
		});
	}

	private static char GetRandomChar(int fromInclusive, int toInclusive) =>
		Convert.ToChar(RandomNumberGenerator.GetInt32(fromInclusive, toInclusive + 1));
}
