/*
* Copyright © 2023 MyNihongo
*/

namespace MyNihongo.KanaDetector.Tests.Extensions.CharExtensionsTests;

public sealed class IsKanjiShould
{
	[Fact]
	public void BeTrueForKanji()
	{
		foreach (var @char in CharacterHelper.Kanji())
		{
			var result = @char.IsKanji();

			result
				.Should()
				.BeTrue("{0} is kanji", @char);
		}
	}

	[Fact]
	public void BeFalseForAllHiraganaChars()
	{
		foreach (var @char in CharacterHelper.Hiragana)
		{
			var result = @char.IsKanji();

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
			var result = @char.IsKanji();

			result
				.Should()
				.BeFalse("{0} is katakana", @char);
		}
	}

	[Fact]
	public void BeFalseForAllRomajiChars()
	{
		foreach (var @char in CharacterHelper.Romaji)
		{
			var result = @char.IsKanji();

			result
				.Should()
				.BeFalse("{0} is romaji", @char);
		}
	}
	
	[Fact]
	public void BeFalseForPunctuationChars()
	{
		foreach (var @char in CharacterHelper.Punctuation)
		{
			var result = @char.IsKanji();

			result
				.Should()
				.BeFalse();
		}
	}
}
