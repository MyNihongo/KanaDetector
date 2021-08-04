﻿/*
* © Copyright MyNihongo 2020
*/

using FluentAssertions;
using MyNihongo.KanaDetector.Extensions;
using Xunit;

namespace MyNihongo.KanaDetector.Tests.Extensions.StringExtensionsTests
{
	public class HasKanaShould
	{
		[Theory]
		[InlineData(null)]
		[InlineData("")]
		public void ReturnFalseIfNullOrEmpty(string input)
		{
			input
				.Should()
				.BeNullOrEmpty();

			var result = input.HasKana();

			result
				.Should()
				.BeFalse();
		}

		[Fact]
		public void ReturnTrueIfHasHiragana()
		{
			const string input = "textひらがな";

			var result = input.HasKana();

			result
				.Should()
				.BeTrue();
		}

		[Fact]
		public void ReturnTrueIfKatakana()
		{
			const string input = "textカタカナ";

			var result = input.HasKana();

			result
				.Should()
				.BeTrue();
		}

		[Fact]
		public void ReturnFalseIfKanji()
		{
			const string input = "text漢字";

			var result = input.HasKana();

			result
				.Should()
				.BeFalse();
		}

		[Fact]
		public void ReturnFalseForRomaji()
		{
			const string input = "random text";

			var result = input.HasKana();

			result
				.Should()
				.BeFalse();
		}
	}
}