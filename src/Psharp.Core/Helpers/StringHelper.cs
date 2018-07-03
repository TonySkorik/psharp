﻿namespace Psharp.Core.Helpers.Extensions
{
	public static class StringHelper
	{

		public static bool HasText(this string s)
		{
			return !string.IsNullOrEmpty(s.Trim());
		}
	}
}
