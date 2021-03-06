/*
* Copyright © 2021 MyNihongo
*/

using FluentAssertions;
using MyNihongo.KanaDetector.Extensions;
using MyNihongo.KanaDetector.Tests.TestHelpers;
using Xunit;

namespace MyNihongo.KanaDetector.Tests.Extensions.CharExtensionsTests
{
	public class IsKanaShould
	{
		[Fact]
		public void BeTrueForAllHiraganaChars()
		{
			foreach (var @char in CharacterHelper.Hiragana)
			{
				var result = @char.IsKana();

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
				var result = @char.IsKana();

				result
					.Should()
					.BeTrue("{0} is katakana", @char);
			}
		}

		[Fact]
		public void BeFalseForAllKanjiChars()
		{
			foreach (var @char in CharacterHelper.Kanji())
			{
				var result = @char.IsKana();

				result
					.Should()
					.BeFalse("{0} is kanji", @char);
			}
		}

		[Fact]
		public void BeFalseForAllRomajiChars()
		{
			foreach (var @char in CharacterHelper.Romaji)
			{
				var result = @char.IsKana();

				result
					.Should()
					.BeFalse("{0} is romaji", @char);
			}
		}
	}
}
