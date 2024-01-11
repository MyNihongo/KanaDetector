﻿/*
* Copyright © 2023 MyNihongo
*/

namespace MyNihongo.KanaDetector.Tests.Extensions.StringExtensionsTests;

public sealed class HasKanaOrKanjiShould
{
	[Theory]
	[InlineData(null)]
	[InlineData("")]
	public void ReturnFalseIsNullOrEmpty(string input)
	{
		input
			.Should()
			.BeNullOrEmpty();

		var result = input.HasKanaOrKanji();

		result
			.Should()
			.BeFalse();
	}

	[Fact]
	public void ReturnTrueIfHasHiragana()
	{
		const string input = "textひらがな";

		var result = input.HasKanaOrKanji();

		result
			.Should()
			.BeTrue();
	}

	[Fact]
	public void ReturnTrueIfKatakana()
	{
		const string input = "textカタカナ";

		var result = input.HasKanaOrKanji();

		result
			.Should()
			.BeTrue();
	}

	[Fact]
	public void ReturnTrueIfKanji()
	{
		const string input = "text漢字";

		var result = input.HasKanaOrKanji();

		result
			.Should()
			.BeTrue();
	}

	[Fact]
	public void ReturnFalseForRomaji()
	{
		const string input = "random text";

		var result = input.HasKanaOrKanji();

		result
			.Should()
			.BeFalse();
	}
}
