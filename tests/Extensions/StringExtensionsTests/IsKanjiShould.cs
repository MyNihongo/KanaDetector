﻿/*
* Copyright © 2023 MyNihongo
*/

namespace MyNihongo.KanaDetector.Tests.Extensions.StringExtensionsTests;

public sealed class IsKanjiShould
{
	[Theory]
	[InlineData(null)]
	[InlineData("")]
	public void BeFalseIfNullOrEmpty(string input)
	{
		var result = input.IsKanji();

		result
			.Should()
			.BeFalse("{0} is null or empty", input);
	}
	
	[Theory]
	[InlineData(null)]
	[InlineData("")]
	public void BeTrueIfNullOrEmpty(string input)
	{
		var result = input.IsKanji(true);

		result
			.Should()
			.BeTrue("{0} is null or empty", input);
	}

	[Fact]
	public void BeTrueIfOnlyKanji()
	{
		var input = WordHelper.GenerateKanji();
		var result = input.IsKanji();

		result
			.Should()
			.BeTrue("{0} is kanji", input);
	}

	[Fact]
	public void BeFalseIfHasHiragana()
	{
		var input = WordHelper.GenerateKanji() + WordHelper.GenerateHiragana();
		var result = input.IsKanji();

		result
			.Should()
			.BeFalse("{0} has hiragana", input);
	}

	[Fact]
	public void BeFalseIfHasKatakana()
	{
		var input = WordHelper.GenerateKanji() + WordHelper.GenerateKatakana();
		var result = input.IsKanji();

		result
			.Should()
			.BeFalse("{0} has katakana", input);
	}

	[Fact]
	public void BeFalseIfHasRomaji()
	{
		var input = WordHelper.GenerateKanji() + WordHelper.GenerateRomaji();
		var result = input.IsKanji();

		result
			.Should()
			.BeFalse("{0} has romaji", input);
	}
}
