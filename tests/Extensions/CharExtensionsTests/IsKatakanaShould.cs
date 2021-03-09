/*
* © Copyright MyNihongo 2020
*/

using FluentAssertions;
using MyNihongo.KanaDetector.Extensions;
using MyNihongo.KanaDetector.Tests.TestHelpers;
using Xunit;

namespace MyNihongo.KanaDetector.Tests.Extensions.CharExtensionsTests
{
	public class IsKatakanaShould
	{
		[Fact]
		public void BeTrueForAllKatakanaChars()
		{
			foreach (var @char in CharacterHelper.Katakana)
			{
				var result = @char.IsKatakana();

				result
					.Should()
					.BeTrue("{0} is katakana", @char);
			}
		}

		[Fact]
		public void BeFalseForAllHiraganaChars()
		{
			foreach (var @char in CharacterHelper.Hiragana)
			{
				var result = @char.IsKatakana();

				result
					.Should()
					.BeFalse("{0} is hiragana", @char);
			}
		}

		[Fact]
		public void BeFalseForKanji()
		{
			foreach (var @char in CharacterHelper.Kanji())
			{
				var result = @char.IsKatakana();

				result
					.Should()
					.BeFalse("{0} is kanji", @char);
			}
		}

		[Fact]
		public void BeFalseForRomaji()
		{
			foreach (var @char in CharacterHelper.Romaji)
			{
				var result = @char.IsKatakana();

				result
					.Should()
					.BeFalse("{0} is romaji", @char);
			}
		}
	}
}
