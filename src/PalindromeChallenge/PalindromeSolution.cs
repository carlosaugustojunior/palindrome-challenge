namespace PalindromeChallenge;

public class PalindromeSolution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;

        var original = x;
        var reversedNumber = 0;
        while (x != 0)
        {
            var rest = x % 10;
            reversedNumber = reversedNumber * 10 + rest;
            x = (x / 10);
        }

        return original == reversedNumber;
    }
}
