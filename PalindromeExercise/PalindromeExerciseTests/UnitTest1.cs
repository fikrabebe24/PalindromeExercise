using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("madam", true)]
        [InlineData("civic", true)]
        [InlineData("Hello", false)]
        public void Test1(string word, bool expected)
        {
            //Arrange
            var test = new WordSmith();

            //Act
            var actual = test.IsAPalindrome(word);

            //Assert
            Assert.Equal(actual, expected);
        }
    }
}
