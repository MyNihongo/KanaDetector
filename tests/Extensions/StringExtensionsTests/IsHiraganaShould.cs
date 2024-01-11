/*
* Copyright © 2023 MyNihongo
*/

namespace MyNihongo.KanaDetector.Tests.Extensions.StringExtensionsTests;

public sealed class IsHiraganaShould
{
	[Theory]
	[InlineData(null)]
	[InlineData("")]
	public void BeFalseIfNullOrEmpty(string input)
	{
		var result = input.IsHiragana();

		result
			.Should()
			.BeFalse("{0} is null or empty", input);
	}
	
	[Theory]
	[InlineData(null)]
	[InlineData("")]
	public void BeTrueIfNullOrEmpty(string input)
	{
		var result = input.IsHiragana(true);

		result
			.Should()
			.BeTrue("{0} is null or empty", input);
	}

	[Fact]
	public void BeTrueIfOnlyHiragana()
	{
		var input = WordHelper.GenerateHiragana();
		var result = input.IsHiragana();

		result
			.Should()
			.BeTrue("{0} is hiragana", input);
	}

	[Fact]
	public void BeFalseIfHasKatakana()
	{
		var input = WordHelper.GenerateHiragana() + WordHelper.GenerateKatakana();
		var result = input.IsHiragana();

		result
			.Should()
			.BeFalse("{0} has katakana", input);
	}

	[Fact]
	public void BeFalseIfHasKanji()
	{
		var input = WordHelper.GenerateHiragana() + WordHelper.GenerateKanji();
		var result = input.IsHiragana();

		result
			.Should()
			.BeFalse("{0} has kanji", input);
	}

	[Fact]
	public void BeFalseIfHasRomaji()
	{
		var input = WordHelper.GenerateHiragana() + WordHelper.GenerateRomaji();
		var result = input.IsHiragana();

		result
			.Should()
			.BeFalse("{0} has romaji", input);
	}
}
