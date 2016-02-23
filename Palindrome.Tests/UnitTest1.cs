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
            string phrase = "A nut fox a jar  of tuna.";
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

        [TestMethod]
        public void how_about_a_long_one_for_good_measure()
        {
            string phrase = @"
Dammit I'm mad.
Evil is a deed as I live.
God, am I reviled? I rise, my bed on a sun, I melt.
To be not one man emanating is sad. I piss.
Alas, it is so late. Who stops to help?
Man, it is hot. I'm in it. I tell.
I am not a devil. I level ""Mad Dog"".
Ah, say burning is, as a deified gulp,
In my halo of a mired rum tin.
I erase many men. Oh, to be man, a sin.
Is evil in a clam? In a trap?
No. It is open. On it I was stuck.
Rats peed on hope. Elsewhere dips a web.
Be still if I fill its ebb.
Ew, a spider… eh?
We sleep. Oh no!
Deep, stark cuts saw it in one position.
Part animal, can I live? Sin is a name.
Both, one… my names are in it.
Murder? I'm a fool.
A hymn I plug, deified as a sign in ruby ash,
A Goddam level I lived at.
On mail let it in. I'm it.
Oh, sit in ample hot spots. Oh wet!
A loss it is alas (sip). I'd assign it a name.
Name not one bottle minus an ode by me:
""Sir, I deliver. I'm a dog""
Evil is a deed as I live.
Dammit I'm mad.";
            var result = Instance.IsPalindrome(phrase.ToCharArray());
            Assert.AreEqual(true, result);
        }


    }
}
