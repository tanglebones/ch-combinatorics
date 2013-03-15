using System.Linq;
using NUnit.Framework;

namespace CH.Combinatorics.Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestPermute()
        {
            Assert.AreEqual(0, Enumerable.Empty<int>().Permute().Count());
            Assert.AreEqual(1, new[] {0}.Permute().Count());
            Assert.AreEqual(2, new[] {0, 1}.Permute().Count());
            Assert.AreEqual(6, new[] {0, 1, 2}.Permute().Count());
            Assert.AreEqual(24, new[] {0, 1, 2, 3}.Permute().Count());
        }
    }
}