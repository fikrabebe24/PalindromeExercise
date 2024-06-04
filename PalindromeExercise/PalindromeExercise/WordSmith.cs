using System;
namespace PalindromeExercise
{
	public class WordSmith
	{
		public static bool IsAPalindrome(string word)
		{

			var wordReversed = "";

			for(int i = word.Length; i >= 0; i--)
			{
				wordReversed += word[i];
			}



			if(word == wordReversed)
			{
				return true;
			}
			else
			{
				return false;
			}
				
		}



		
	}
}

