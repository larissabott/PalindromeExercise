using System;
namespace ExampleForPalindrome
{ 
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            //reverse the word //racecar Length--> 7 --> 6
            var reversed = "";
            for(int i = word.Length -1; i >= 0; i--)
            {
                reversed += word[i];
            }

            //compare the original with the reversed
            if(reversed == word)
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
