/*
* Copyright © 2021 MyNihongo
*/

using FluentAssertions;
using MyNihongo.KanaDetector.Extensions;
using Xunit;

namespace MyNihongo.KanaDetector.Tests.Extensions.StringExtensionsTests
{
	public class HasHiraganaShould
	{
		[Theory]
		[InlineData(null)]
		[InlineData("")]
		public void ReturnFalseIsNullOrEmpty(string input)
		{
			input
				.Should()
				.BeNullOrEmpty();

			var result = input.HasHiragana();

			result
				.Should()
				.BeFalse();
		}

		[Fact]
		public void ReturnTrueIfHasHiragana()
		{
			const string input = "textひらがな";

			var result = input.HasHiragana();

			result
				.Should()
				.BeTrue();
		}

		[Fact]
		public void ReturnFalseIfKatakana()
		{
			const string input = "textカタカナ";

			var result = input.HasHiragana();

			result
				.Should()
				.BeFalse();
		}

		[Fact]
		public void ReturnFalseIfKanji()
		{
			const string input = "text漢字";

			var result = input.HasHiragana();

			result
				.Should()
				.BeFalse();
		}

		[Fact]
		public void ReturnFalseForRomaji()
		{
			const string input = "random text";

			var result = input.HasHiragana();

			result
				.Should()
				.BeFalse();
		}
	}
}
