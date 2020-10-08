using NUnit.Framework;

namespace Tests
{
    public class FactorialFilterTest
    {
        [Test]
        public void FactorialFilterTestInt()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10 };
            int[] output = FactorialFilter.Factorials(input);
            int[] expected = { 24, 2, 40320, 6, 362880, 24, 3628800 };

            CollectionAssert.AreEqual(expected, output);
        }

        [Test]
        public void FactorialFilterTestLong()
        {
            long[] input = { 4, 2, 8, 3, 9, 4, 10 };
            long[] output = FactorialFilter.FactorialsLong(input);
            long[] expected = { 24, 2, 40320, 6, 362880, 24, 3628800 };

            CollectionAssert.AreEqual(expected, output);
        }

        [Test]
        public void FactorialFilterZeroTest()
        {
            int[] input = { 0 };
            int[] output = FactorialFilter.Factorials(input);
            int[] expected = { 1 };

            CollectionAssert.AreEqual(expected, output);
        }

        [Test]
        public void FactorialFilterZeroTestLong()
        {
            long[] input = { 0 };
            long[] output = FactorialFilter.FactorialsLong(input);
            long[] expected = { 1 };

            CollectionAssert.AreEqual(expected, output);
        }

        [Test]
        public void FactorialFilterNegativeTest()
        {
            int[] input = { -100, -90909, -111001, -1 };
            int[] output = FactorialFilter.Factorials(input);
            int[] expected = { -1, -1, -1, -1};

            CollectionAssert.AreEqual(expected, output);
        }

        [Test]
        public void FactorialFilterNegativeTestLong()
        {
            long[] input = { -100, -90909, -111001, -1 };
            long[] output = FactorialFilter.FactorialsLong(input);
            long[] expected = { -1, -1, -1, -1 };

            CollectionAssert.AreEqual(expected, output);
        }

    }
}
