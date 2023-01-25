namespace MyNihongo.KanaDetector.Tests.Extensions.CharExtensionsTests;

public sealed class IsPunctuationShould
{
	[Fact]
	public void BeTrueForPunctuationChars()
	{
		foreach (var @char in CharacterHelper.Punctuation)
		{
			var result = @char.IsPunctuation();

			result
				.Should()
				.BeTrue();
		}
	}
	
	[Fact]
	public void BeTrueFalseAllHiraganaChars()
	{
		foreach (var @char in CharacterHelper.Hiragana)
		{
			var result = @char.IsPunctuation();

			result
				.Should()
				.BeFalse();
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
				.BeFalse();
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
}
