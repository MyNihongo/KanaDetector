/*
* Copyright © 2023 MyNihongo
*/

namespace MyNihongo.KanaDetector.Tests.Extensions.StringExtensionsTests;

public class IsKanaShould
{
	[Theory]
	[InlineData(null)]
	[InlineData("")]
	public void BeFalseIfNullOrEmpty(string input)
	{
		var result = input.IsKana();

		result
			.Should()
			.BeFalse("{0} is null or empty", input);
	}

	[Fact]
	public void BeTrueIfOnlyHiragana()
	{
		var input = WordHelper.GenerateHiragana();
		var result = input.IsKana();

		result
			.Should()
			.BeTrue("{0} is hiragana", input);
	}

	[Fact]
	public void BeTrueIfOnlyKatakana()
	{
		var input = WordHelper.GenerateKatakana();
		var result = input.IsKana();

		result
			.Should()
			.BeTrue("{0} is katakana", input);
	}

	[Fact]
	public void BeTrueIfHiraganaAndKatakana()
	{
		var input = WordHelper.GenerateHiragana() + WordHelper.GenerateKatakana();
		var result = input.IsKana();

		result
			.Should()
			.BeTrue("{0} is hiragana and katakana", input);
	}

	[Fact]
	public void BeFalseIfHasKanji()
	{
		var input = WordHelper.GenerateHiragana() + WordHelper.GenerateKatakana() + WordHelper.GenerateKanji();
		var result = input.IsKana();

		result
			.Should()
			.BeFalse("{0} has kanji", input);
	}

	[Fact]
	public void BeFalseIfHasRomaji()
	{
		var input = WordHelper.GenerateHiragana() + WordHelper.GenerateKatakana() + WordHelper.GenerateRomaji();
		var result = input.IsKana();

		result
			.Should()
			.BeFalse("{0} has kanji", input);
	}
}