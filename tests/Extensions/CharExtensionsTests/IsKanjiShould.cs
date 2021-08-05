/*
* Copyright © 2021 MyNihongo
*/

using FluentAssertions;
using MyNihongo.KanaDetector.Extensions;
using MyNihongo.KanaDetector.Tests.TestHelpers;
using Xunit;

namespace MyNihongo.KanaDetector.Tests.Extensions.CharExtensionsTests
{
	public class IsKanjiShould
	{
		[Fact]
		public void BeTrueForKanji()
		{
			foreach (var @char in CharacterHelper.Kanji())
			{
				var result = @char.IsKanji();

				result
					.Should()
					.BeTrue("{0} is kanji", @char);
			}
		}

		[Fact]
		public void BeFalseForAllHiraganaChars()
		{
			foreach (var @char in CharacterHelper.Hiragana)
			{
				var result = @char.IsKanji();

				result
					.Should()
					.BeFalse("{0} is hiragana", @char);
			}
		}

		[Fact]
		public void BeFalseForAllKatakanaChars()
		{
			foreach (var @char in CharacterHelper.Katakana)
			{
				var result = @char.IsKanji();

				result
					.Should()
					.BeFalse("{0} is katakana", @char);
			}
		}

		[Fact]
		public void BeFalseForAllRomajiChars()
		{
			foreach (var @char in CharacterHelper.Romaji)
			{
				var result = @char.IsKanji();

				result
					.Should()
					.BeFalse("{0} is romaji", @char);
			}
		}
	}
}
