/*
* Copyright © 2023 MyNihongo
*/

namespace MyNihongo.KanaDetector.Tests.Extensions.CharExtensionsTests;

public sealed class IsKanaShould
{
	[Fact]
	public void BeTrueForAllHiraganaChars()
	{
		foreach (var @char in CharacterHelper.Hiragana)
		{
			var result = @char.IsKana();

			result
				.Should()
				.BeTrue("{0} is hiragana", @char);
		}
	}

	[Fact]
	public void BeTrueForAllKatakanaChars()
	{
		foreach (var @char in CharacterHelper.Katakana)
		{
			var result = @char.IsKana();

			result
				.Should()
				.BeTrue("{0} is katakana", @char);
		}
	}

	[Fact]
	public void BeFalseForAllKanjiChars()
	{
		foreach (var @char in CharacterHelper.Kanji())
		{
			var result = @char.IsKana();

			result
				.Should()
				.BeFalse("{0} is kanji", @char);
		}
	}

	[Fact]
	public void BeFalseForAllRomajiChars()
	{
		foreach (var @char in CharacterHelper.Romaji)
		{
			var result = @char.IsKana();

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
			var result = @char.IsKana();

			result
				.Should()
				.BeFalse();
		}
	}
}
