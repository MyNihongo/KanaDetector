/*
* Copyright © 2021 MyNihongo
*/

using FluentAssertions;
using MyNihongo.KanaDetector.Extensions;
using MyNihongo.KanaDetector.Tests.TestHelpers;
using Xunit;

namespace MyNihongo.KanaDetector.Tests.Extensions.CharExtensionsTests
{
	public class IsKanaOrKanjiShould
	{
		[Fact]
		public void BeTrueForAllHiraganaChars()
		{
			foreach (var @char in CharacterHelper.Hiragana)
			{
				var result = @char.IsKanaOrKanji();

				result
					.Should()
					.BeTrue("{0} is hiragana", @char);
			}
		}

		[Fact]
		public void BeTrueForAllKatakanaChars()
		{
			foreach (var @char in CharacterHelper.Katakana)
			{
				var result = @char.IsKanaOrKanji();

				result
					.Should()
					.BeTrue("{0} is katakana", @char);
			}
		}

		[Fact]
		public void BeTrueForKanji()
		{
			foreach (var @char in CharacterHelper.Kanji())
			{
				var result = @char.IsKanaOrKanji();

				result
					.Should()
					.BeTrue("{0} is kanji", @char);
			}
		}

		[Fact]
		public void BeFalseForRomaji()
		{
			foreach (var @char in CharacterHelper.Romaji)
			{
				var result = @char.IsKanaOrKanji();

				result
					.Should()
					.BeFalse("{0} is romaji", @char);
			}
		}
	}
}
