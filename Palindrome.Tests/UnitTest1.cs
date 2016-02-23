using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Palindrome.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private PalinDromeRunner Instance = new PalinDromeRunner();

        [TestMethod]
        public void racecar_is_palindrome()
        {
            string phrase = "racecar";
            var result = Instance.IsPalindrome(phrase.ToCharArray());
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void this_is_not_a_palindrome()
        {
            string phrase = "mike roth";
            var result = Instance.IsPalindrome(phrase.ToCharArray());
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void spacing_and_location_can_be_different()
        {
            string phrase = "A Santa dog lived as a devil God at NASA";
            var result = Instance.IsPalindrome(phrase.ToCharArray());
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void looks_like_one_but_is_not()
        {
            string phrase = "A nut for a lar  of tuna.";
            var result = Instance.IsPalindrome(phrase.ToCharArray());
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void finally_a_tricky_one()
        {
            string phrase =
                @"Are we not pure? ""No sir!"" Panama’s moody Noriega brags. ""It is garbage!"" Irony dooms a man; a prisoner up to new era.";
            var result = Instance.IsPalindrome(phrase.ToCharArray());
            Assert.AreEqual(result, true);
        }




    }
}
