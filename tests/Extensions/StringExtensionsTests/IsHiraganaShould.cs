/*
* © Copyright MyNihongo 2020
*/

using FluentAssertions;
using MyNihongo.KanaDetector.Extensions;
using MyNihongo.KanaDetector.Tests.TestHelpers;
using Xunit;

namespace MyNihongo.KanaDetector.Tests.Extensions.StringExtensionsTests
{
	public class IsHiraganaShould
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
}
