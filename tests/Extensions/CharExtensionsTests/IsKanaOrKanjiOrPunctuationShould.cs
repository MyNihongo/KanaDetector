/*
* Copyright © 2023 MyNihongo
*/

namespace MyNihongo.KanaDetector.Tests.Extensions.CharExtensionsTests;

public sealed class IsKanaOrKanjiOrPunctuationShould
{
	[Fact]
	public void BeTrueForAllHiraganaChars()
	{
		foreach (var @char in CharacterHelper.Hiragana)
		{
			var result = @char.IsKanaOrKanjiOrPunctuation();

			result
				.Should()
				.BeTrue();
		}
	}

	[Fact]
	public void BeTrueForAllKatakanaChars()
	{
		foreach (var @char in CharacterHelper.Katakana)
		{
			var result = @char.IsKanaOrKanjiOrPunctuation();

			result
				.Should()
				.BeTrue();
		}
	}

	[Fact]
	public void BeTrueForKanji()
	{
		foreach (var @char in CharacterHelper.Kanji())
		{
			var result = @char.IsKanaOrKanjiOrPunctuation();

			result
				.Should()
				.BeTrue();
		}
	}

	[Fact]
	public void BeFalseForRomaji()
	{
		foreach (var @char in CharacterHelper.Romaji)
		{
			var result = @char.IsKanaOrKanjiOrPunctuation();

			result
				.Should()
				.BeFalse();
		}
	}
	
	[Fact]
	public void BeTrueForPunctuationChars()
	{
		foreach (var @char in CharacterHelper.Punctuation)
		{
			var result = @char.IsKanaOrKanjiOrPunctuation();

			result
				.Should()
				.BeTrue();
		}
	}
}
