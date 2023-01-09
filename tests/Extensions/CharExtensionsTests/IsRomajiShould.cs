/*
* Copyright © 2023 MyNihongo
*/

namespace MyNihongo.KanaDetector.Tests.Extensions.CharExtensionsTests;

public sealed class IsRomajiShould
{
	[Fact]
	public void BeTrueForAllRomajiChars()
	{
		foreach (var @char in CharacterHelper.Romaji)
		{
			var result = @char.IsRomaji();

			result
				.Should()
				.BeTrue("{0} is romaji", @char);
		}
	}

	[Fact]
	public void BeFalseForAllHiraganaChars()
	{
		foreach (var @char in CharacterHelper.Hiragana)
		{
			var result = @char.IsRomaji();

			result
				.Should()
				.BeFalse("{0} is hiragana", @char);
		}
	}

	[Fact]
	public void BeFalseForAllKatakanaChars()
	{
		foreach (var @char in CharacterHelper.Katakana)
		{
			var result = @char.IsRomaji();

			result
				.Should()
				.BeFalse("{0} is katakana", @char);
		}
	}

	[Fact]
	public void BeFalseForKanjiChars()
	{
		foreach (var @char in CharacterHelper.Kanji())
		{
			var result = @char.IsRomaji();

			result
				.Should()
				.BeFalse("{0} is kanji", @char);
		}
	}
}