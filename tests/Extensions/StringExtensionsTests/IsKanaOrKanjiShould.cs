﻿/*
* Copyright © 2023 MyNihongo
*/

namespace MyNihongo.KanaDetector.Tests.Extensions.StringExtensionsTests;

public sealed class IsKanaOrKanjiShould
{
	[Theory]
	[InlineData(null)]
	[InlineData("")]
	public void BeFalseIfNullOrEmpty(string input)
	{
		var result = input.IsKanaOrKanji();

		result
			.Should()
			.BeFalse("{0} is null or empty", input);
	}
	
	[Theory]
	[InlineData(null)]
	[InlineData("")]
	public void BeTrueIfNullOrEmpty(string input)
	{
		var result = input.IsKanaOrKanji(true);

		result
			.Should()
			.BeTrue("{0} is null or empty", input);
	}

	[Fact]
	public void BeTrueIfOnlyHiragana()
	{
		var input = WordHelper.GenerateHiragana();
		var result = input.IsKanaOrKanji();

		result
			.Should()
			.BeTrue("{0} is hiragana", input);
	}

	[Fact]
	public void BeTrueIfOnlyKatakana()
	{
		var input = WordHelper.GenerateKatakana();
		var result = input.IsKanaOrKanji();

		result
			.Should()
			.BeTrue("{0} is katakana", input);
	}

	[Fact]
	public void BeTrueIfHiraganaAndKatakana()
	{
		var input = WordHelper.GenerateHiragana() + WordHelper.GenerateKatakana();
		var result = input.IsKanaOrKanji();

		result
			.Should()
			.BeTrue("{0} is hiragana and katakana", input);
	}

	[Fact]
	public void BeTrueIfHiraganaAndKanji()
	{
		var input = WordHelper.GenerateHiragana() + WordHelper.GenerateKanji();
		var result = input.IsKanaOrKanji();

		result
			.Should()
			.BeTrue("{0} is hiragana and kanji", input);
	}

	[Fact]
	public void BeTrueIfKatakanaAndKanji()
	{
		var input = WordHelper.GenerateKatakana() + WordHelper.GenerateKanji();
		var result = input.IsKanaOrKanji();

		result
			.Should()
			.BeTrue("{0} is katakana and kanji", input);
	}

	[Fact]
	public void BeTrueIfHiraganaKatakanaAndKanji()
	{
		var input = WordHelper.GenerateHiragana() + WordHelper.GenerateKatakana() + WordHelper.GenerateKanji();
		var result = input.IsKanaOrKanji();

		result
			.Should()
			.BeTrue("{0} is hiragana, katakana and kanji", input);
	}

	[Fact]
	public void BeFalseIfHasRomaji()
	{
		var input = WordHelper.GenerateHiragana() + WordHelper.GenerateKatakana() + WordHelper.GenerateKanji() + WordHelper.GenerateRomaji();
		var result = input.IsKanaOrKanji();

		result
			.Should()
			.BeFalse("{0} has romaji", input);
	}
}
