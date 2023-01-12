using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("deified", true)]
        [InlineData("apple", false)]
        public void Test1(string word, bool expected)
        {
            var instance = new WordSmith();
            var actual = instance.IsAPalindrome(word);
            Assert.Equal(expected, actual);
        }
    }
}
