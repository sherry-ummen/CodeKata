using NextHighestNumberWithSameDigits;
using NUnit.Framework;

namespace NextHighestNumberTests {
    [TestFixture]
    public class NextHigherNumberTests {

        [Test]
        public void TestSingleDigit() {
            Assert.That(NextHigherNumber.GiveNextHighestNumber(1), Is.EqualTo(1));
        }

        [Test]
        public void TestPalindromeDigit() {
            Assert.That(NextHigherNumber.GiveNextHighestNumber(9999), Is.EqualTo(9999));
        }

        [Test]
        public void TestDescendingorderedDigits() {
            Assert.That(NextHigherNumber.GiveNextHighestNumber(54321), Is.EqualTo(54321));
        }

        [Test]
        public void TestDNexthighestNumberDigit() {
            Assert.That(NextHigherNumber.GiveNextHighestNumber(351), Is.EqualTo(513));
            Assert.That(NextHigherNumber.GiveNextHighestNumber(218765), Is.EqualTo(251678));
            Assert.That(NextHigherNumber.GiveNextHighestNumber(1234), Is.EqualTo(1243));
            Assert.That(NextHigherNumber.GiveNextHighestNumber(534976), Is.EqualTo(536479));
            Assert.That(NextHigherNumber.GiveNextHighestNumber(38276), Is.EqualTo(38627));
            Assert.That(NextHigherNumber.GiveNextHighestNumber(45156), Is.EqualTo(45165));
            Assert.That(NextHigherNumber.GiveNextHighestNumber(21897), Is.EqualTo(21978));
            Assert.That(NextHigherNumber.GiveNextHighestNumber(19000), Is.EqualTo(90001));
            Assert.That(NextHigherNumber.GiveNextHighestNumber(12345678), Is.EqualTo(12345687));
        }

        [Test]
        public void TestBiggerNumbers() {
            Assert.That(NextHigherNumber.GiveNextHighestNumber(987239879), Is.EqualTo(987239897));
            Assert.That(NextHigherNumber.GiveNextHighestNumber(1234567980), Is.EqualTo(1234568079));
        }
    }
}
