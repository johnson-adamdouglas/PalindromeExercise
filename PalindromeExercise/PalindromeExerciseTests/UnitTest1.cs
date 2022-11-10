using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)] // ← you will need to put some test data and expected result here.  
        [InlineData("trackcar", false)]
        // For example [InlineData(“racecar”, true)]
        public void Test1(string word, bool expected)
        {
            //Arrange (instantiate an object of class WordSmith)
            var iCheckForPalindromes = new WordSmith();
            //Act 
            var actual = iCheckForPalindromes.IsAPalindrome(word);
            //Assert
            Assert.Equal(actual, expected);
        }
    }
}
