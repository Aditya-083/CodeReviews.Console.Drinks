﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks_Info
{
	internal class Validation
	{
		internal static bool IsIdValid(string stringInput)
		{
			if (String.IsNullOrEmpty(stringInput))
			{
				return false;
			}
			foreach(char c in stringInput)
			{
				if(!Char.IsDigit(c))
					return false;
			}
			return true;
		}
		internal static bool IsStringValid(string stringInput)
		{
			if (String.IsNullOrEmpty(stringInput))
			{
				return false;
			}
			foreach (char c in stringInput)
			{
				if(!char.IsLetter(c) && c != '/' && c != ' ')
					return false;
			}
			return true;
		}
	}
}
