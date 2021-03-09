/*
* © Copyright MyNihongo 2020
*/

using FluentAssertions;
using MyNihongo.KanaDetector.Extensions;
using MyNihongo.KanaDetector.Tests.TestHelpers;
using Xunit;

namespace MyNihongo.KanaDetector.Tests.Extensions.StringExtensionsTests
{
	public class IsKatakanaShould
	{
		[Theory]
		[InlineData(null)]
		[InlineData("")]
		public void BeFalseIfNullOrEmpty(string input)
		{
			var result = input.IsKatakana();

			result
				.Should()
				.BeFalse("{0} is null or empty", input);
		}

		[Fact]
		public void BeTrueIfOnlyKatakana()
		{
			var input = WordHelper.GenerateKatakana();
			var result = input.IsKatakana();

			result
				.Should()
				.BeTrue("{0} is katakana", input);
		}

		[Fact]
		public void BeFalseIfHasHiragana()
		{
			var input = WordHelper.GenerateKatakana() + WordHelper.GenerateHiragana();
			var result = input.IsKatakana();

			result
				.Should()
				.BeFalse("{0} has hiragana", input);
		}

		[Fact]
		public void BeFalseIfHasKanji()
		{
			var input = WordHelper.GenerateKatakana() + WordHelper.GenerateKanji();
			var result = input.IsKatakana();

			result
				.Should()
				.BeFalse("{0} has kanji", input);
		}

		[Fact]
		public void BeFalseIfHasRomaji()
		{
			var input = WordHelper.GenerateKatakana() + WordHelper.GenerateRomaji();
			var result = input.IsKatakana();

			result
				.Should()
				.BeFalse("{0} has romaji", input);
		}
	}
}
