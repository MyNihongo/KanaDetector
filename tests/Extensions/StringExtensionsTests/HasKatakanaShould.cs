﻿/*
* Copyright © 2023 MyNihongo
*/

namespace MyNihongo.KanaDetector.Tests.Extensions.StringExtensionsTests;

public sealed class HasKatakanaShould
{
	[Theory]
	[InlineData(null)]
	[InlineData("")]
	public void ReturnFalseIfNullOrEmpty(string input)
	{
		input
			.Should()
			.BeNullOrEmpty();

		var result = input.HasKatakana();

		result
			.Should()
			.BeFalse();
	}

	[Fact]
	public void ReturnFalseIfHiragana()
	{
		const string input = "textひらがな";

		var result = input.HasKatakana();

		result
			.Should()
			.BeFalse();
	}

	[Fact]
	public void ReturnTrueIfKatakana()
	{
		const string input = "textカタカナ";

		var result = input.HasKatakana();

		result
			.Should()
			.BeTrue();
	}

	[Fact]
	public void ReturnFalseIfKanji()
	{
		const string input = "text漢字";

		var result = input.HasKatakana();

		result
			.Should()
			.BeFalse();
	}

	[Fact]
	public void ReturnFalseIfRomaji()
	{
		const string input = "random text";

		var result = input.HasKatakana();

		result
			.Should()
			.BeFalse();
	}
}
