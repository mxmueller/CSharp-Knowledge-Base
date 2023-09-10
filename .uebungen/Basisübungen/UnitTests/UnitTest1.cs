using Basisübungen;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StartenDesFahrzeugs()
        {
            Auto aKlasse = new Auto(
                "Mercedes-Benz",
                "A-Klasse",
                2023
                );
            
            Assert.IsTrue(aKlasse.Start());
            Assert.IsTrue(aKlasse.moving);
        }
        [TestMethod]
        public void Bewegung()
        {
            Auto cKlasse = new Auto(
               "Mercedes-Benz",
               "C-Klasse",
               2019
               );

            Assert.IsTrue(cKlasse.Start());
            if(cKlasse.moving)
            {
                Assert.AreEqual(true, cKlasse.Start());
            }
        }
    }
}