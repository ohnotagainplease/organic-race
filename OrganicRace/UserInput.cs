﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganicRace
{
	public class UserInput : IUserInput
	{
		public string GetUserInput ()
		{
			string prompt = Console.ReadLine().ToLower();

			return prompt;
		}
	}
}
