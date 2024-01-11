/*
* Copyright © 2023 MyNihongo
*/

namespace MyNihongo.KanaDetector.Tests.Extensions.CharExtensionsTests;

public sealed class IsHiraganaShould
{
	[Fact]
	public void BeTrueForAllHiraganaChars()
	{
		foreach (var @char in CharacterHelper.Hiragana)
		{
			var result = @char.IsHiragana();

			result
				.Should()
				.BeTrue("{0} is hiragana", @char);
		}
	}

	[Fact]
	public void BeFalseForAllKatakanaChars()
	{
		foreach (var @char in CharacterHelper.Katakana)
		{
			var result = @char.IsHiragana();

			result
				.Should()
				.BeFalse("{0} is katakana", @char);
		}
	}

	[Fact]
	public void BeFalseForKanji()
	{
		foreach (var @char in CharacterHelper.Kanji())
		{
			var result = @char.IsHiragana();

			result
				.Should()
				.BeFalse("{0} is kanji", @char);
		}
	}

	[Fact]
	public void BeFalseForRomaji()
	{
		foreach (var @char in CharacterHelper.Romaji)
		{
			var result = @char.IsHiragana();

			result
				.Should()
				.BeFalse("{0} is romaji");
		}
	}
	
	[Fact]
	public void BeFalseForPunctuationChars()
	{
		foreach (var @char in CharacterHelper.Punctuation)
		{
			var result = @char.IsHiragana();

			result
				.Should()
				.BeFalse();
		}
	}
}
