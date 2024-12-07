using FluentAssertions;
using PalindromeChallenge;
using Xunit;

namespace UnitTests;

public class PalindromeSolutionTests
{
    [Theory]
    [InlineData(11)]
    [InlineData(121)]
    [InlineData(222)]
    [InlineData(1331)]
    public void Must_return_true_for_palindromes_numbers(int number)
    {
        ///Arrange
        var palindromeValidation = new PalindromeSolution();

        ///Act
        var isPalindrome = palindromeValidation.IsPalindrome(number);

        ///Assert
        isPalindrome.Should().BeTrue();
    }

    [Theory]
    [InlineData(10)]
    [InlineData(201)]
    [InlineData(12341)]
    public void Must_return_false_for_non_palindromes_numbers(int number)
    {
        ///Arrange
        var palindromeValidation = new PalindromeSolution();

        ///Act
        var isPalindrome = palindromeValidation.IsPalindrome(number);

        ///Assert
        isPalindrome.Should().BeFalse();
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(-100)]
    public void Must_return_false_for_negative_numbers(int number)
    {
        ///Arrange
        var palindromeValidation = new PalindromeSolution();

        ///Act
        var isPalindrome = palindromeValidation.IsPalindrome(number);

        ///Assert
        isPalindrome.Should().BeFalse();
    }
}
