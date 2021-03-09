/*
* Copyright © 2021 MyNihongo
*/

namespace MyNihongo.KanaDetector.Extensions
{
	public static class StringExtensions
	{
		#region Is methods

		public static bool IsHiragana(this string @this)
		{
			if (string.IsNullOrEmpty(@this))
				return false;

			for (var i = 0; i < @this.Length; i++)
				if (!@this[i].IsHiragana())
					return false;

			return true;
		}

		public static bool IsKatakana(this string @this)
		{
			if (string.IsNullOrEmpty(@this))
				return false;

			for (var i = 0; i < @this.Length; i++)
				if (!@this[i].IsKatakana())
					return false;

			return true;
		}

		public static bool IsKana(this string @this)
		{
			if (string.IsNullOrEmpty(@this))
				return false;

			for (var i = 0; i < @this.Length; i++)
				if (!@this[i].IsKana())
					return false;

			return true;
		}

		public static bool IsKanji(this string @this)
		{
			if (string.IsNullOrEmpty(@this))
				return false;

			for (var i = 0; i < @this.Length; i++)
				if (!@this[i].IsKanji())
					return false;

			return true;
		}

		public static bool IsKanaOrKanji(this string @this)
		{
			if (string.IsNullOrEmpty(@this))
				return false;

			for (var i = 0; i < @this.Length; i++)
				if (!@this[i].IsKanaOrKanji())
					return false;

			return true;
		}

		#endregion

		#region Has methods

		public static bool HasHiragana(this string @this)
		{
			if (string.IsNullOrEmpty(@this))
				return false;

			for (var i = 0; i < @this.Length; i++)
				if (@this[i].IsHiragana())
					return true;

			return false;
		}

		public static bool HasKatakana(this string @this)
		{
			if (string.IsNullOrEmpty(@this))
				return false;

			for (var i = 0; i < @this.Length; i++)
				if (@this[i].IsKatakana())
					return true;

			return false;
		}

		public static bool HasKana(this string @this)
		{
			if (string.IsNullOrEmpty(@this))
				return false;

			for (var i = 0; i < @this.Length; i++)
				if (@this[i].IsKana())
					return true;

			return false;
		}

		public static bool HasKanji(this string @this)
		{
			if (string.IsNullOrEmpty(@this))
				return false;

			for (var i = 0; i < @this.Length; i++)
				if (@this[i].IsKanji())
					return true;

			return false;
		}

		public static bool HasKanaOrKanji(this string @this)
		{
			if (string.IsNullOrEmpty(@this))
				return false;

			for (var i = 0; i < @this.Length; i++)
				if (@this[i].IsKanaOrKanji())
					return true;

			return false;
		}

		#endregion
	}
}
