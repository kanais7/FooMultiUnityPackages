using NUnit.Framework;

namespace Tests
{
    public class HogeTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void HogeTestSimplePasses()
        {
            Assert.True(HogeScript.HogeMethod());
        }
    }
}
