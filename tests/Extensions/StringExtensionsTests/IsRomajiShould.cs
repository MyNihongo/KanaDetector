using FluentAssertions;
using MyNihongo.KanaDetector.Extensions;
using MyNihongo.KanaDetector.Tests.TestHelpers;
using Xunit;

namespace MyNihongo.KanaDetector.Tests.Extensions.StringExtensionsTests
{
	public sealed class IsRomajiShould
	{

		[Theory]
		[InlineData(null)]
		[InlineData("")]
		public void BeFalseIfNullOrEmpty(string input)
		{
			var result = input.IsRomaji();

			result
				.Should()
				.BeFalse("{0} is null or empty", input);
		}

		[Fact]
		public void BeTrueIfOnlyRomaji()
		{
			var input = WordHelper.GenerateRomaji();
			var result = input.IsRomaji();

			result
				.Should()
				.BeTrue("{0} is romaji", input);
		}

		[Fact]
		public void BeFalseIfHasHiragana()
		{
			var input = WordHelper.GenerateRomaji() + WordHelper.GenerateHiragana();
			var result = input.IsRomaji();

			result
				.Should()
				.BeFalse("{0} has hiragana", input);
		}

		[Fact]
		public void BeFalseIfHasKatakana()
		{
			var input = WordHelper.GenerateRomaji() + WordHelper.GenerateKatakana();
			var result = input.IsRomaji();

			result
				.Should()
				.BeFalse("{0} has katakana", input);
		}

		[Fact]
		public void BeFalseIfHasKanji()
		{
			var input = WordHelper.GenerateRomaji() + WordHelper.GenerateKanji();
			var result = input.IsRomaji();

			result
				.Should()
				.BeFalse("{0} has kanji", input);
		}
	}
}
