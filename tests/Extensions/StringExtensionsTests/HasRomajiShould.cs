using FluentAssertions;
using MyNihongo.KanaDetector.Extensions;
using Xunit;

namespace MyNihongo.KanaDetector.Tests.Extensions.StringExtensionsTests
{
	public sealed class HasRomajiShould
	{
		[Theory]
		[InlineData(null)]
		[InlineData("")]
		public void ReturnFalseIsNullOrEmpty(string input)
		{
			var result = input.HasRomaji();

			result
				.Should()
				.BeFalse();
		}

		[Fact]
		public void ReturnTrueIfHasRomaji()
		{
			const string input = "ひらがなtext";

			var result = input.HasRomaji();

			result
				.Should()
				.BeTrue();
		}

		[Fact]
		public void ReturnTrueIfHiragana()
		{
			const string input = "ひらがな";

			var result = input.HasRomaji();

			result
				.Should()
				.BeFalse();
		}

		[Fact]
		public void ReturnTrueIfKatakana()
		{
			const string input = "カタカナ";

			var result = input.HasRomaji();

			result
				.Should()
				.BeFalse();
		}

		[Fact]
		public void ReturnTrueIfKanji()
		{
			const string input = "漢字";

			var result = input.HasRomaji();

			result
				.Should()
				.BeFalse();
		}
	}
}
