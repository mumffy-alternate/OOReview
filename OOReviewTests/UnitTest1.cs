using System;
using OOReview.Appendix02;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OOReviewTests
{
    [TestClass]
    public class AirplaneTests
    {
        [TestMethod]
        public void AirplaneSpeedGetter()
        {
            Airplane a = new Airplane();
            a.Speed = 4;
            Assert.AreEqual(4, a.Speed);
        }

        [TestMethod]
        public void JetDoublesSpeed()
        {
            Jet j = new Jet();
            j.Speed = 4;
            Assert.AreEqual(8, j.Speed);
        }
    }
}
