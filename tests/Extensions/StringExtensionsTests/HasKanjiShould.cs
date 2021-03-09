/*
* © Copyright MyNihongo 2020
*/

using FluentAssertions;
using MyNihongo.KanaDetector.Extensions;
using MyNihongo.KanaDetector.Tests.TestHelpers;
using Xunit;

namespace MyNihongo.KanaDetector.Tests.Extensions.StringExtensionsTests
{
	public class HasKanjiShould
	{
		[Theory]
		[InlineData(null)]
		[InlineData("")]
		public void BeFalseIfNullOrEmpty(string input)
		{
			var result = input.HasKanji();

			result
				.Should()
				.BeFalse("{0} is null or empty", input);
		}

		[Fact]
		public void BeTrueIfOnlyKanji()
		{
			var input = WordHelper.GenerateKanji();
			var result = input.HasKanji();

			result
				.Should()
				.BeTrue("{0} is kanji", input);
		}

		[Fact]
		public void BeTrueIfKanjiAndHiragana()
		{
			var input = WordHelper.GenerateKanji() + WordHelper.GenerateHiragana();
			var result = input.HasKanji();

			result
				.Should()
				.BeTrue("{0} has kanji", input);
		}

		[Fact]
		public void BeTrueIfKanjiAndKatakana()
		{
			var input = WordHelper.GenerateKanji() + WordHelper.GenerateKatakana();
			var result = input.HasKanji();

			result
				.Should()
				.BeTrue("{0} has kanji", input);
		}

		[Fact]
		public void BeTrueIfKanjiAndRomaji()
		{
			var input = WordHelper.GenerateKanji() + WordHelper.GenerateRomaji();
			var result = input.HasKanji();

			result
				.Should()
				.BeTrue("{0} has kanji", input);
		}

		[Fact]
		public void BeFalseIfOnlyHiragana()
		{
			var input = WordHelper.GenerateHiragana();
			var result = input.HasKanji();

			result
				.Should()
				.BeFalse("{0} is hiragana", input);
		}

		[Fact]
		public void BeFalseIfOnlyKatakana()
		{
			var input = WordHelper.GenerateKatakana();
			var result = input.HasKanji();

			result
				.Should()
				.BeFalse("{0} is katakana", input);
		}

		[Fact]
		public void BeFalseIfOnlyRomaji()
		{
			var input = WordHelper.GenerateRomaji();
			var result = input.HasKanji();

			result
				.Should()
				.BeFalse("{0} is romaji", input);
		}
	}
}
