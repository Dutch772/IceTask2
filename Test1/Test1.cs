using IceTask2;

namespace Test1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestName()
        {
            Consoles console = new Consoles("Series S", 4, "Xbox", 6500, "Good");
            console[0] = "Playstation 5";
            Assert.AreEqual(console[0], "Playstation 5");
        }
        [TestMethod]
        public void TesAge()
        {
            Consoles console = new Consoles("Series S", 4, "Xbox", 6500, "Good");
            console[1] = 5;
            Assert.AreEqual(console["ConsoleAge"], 5);
        }
        [TestMethod]
        public void TestBrand()
        {
            Consoles console = new Consoles("Series S", 4, "Xbox", 6500, "Good");
            console[0] = "Xbox";
            Assert.AreEqual(console[0], "Xbox");
        }
        [TestMethod]
        public void TestPrice()
        {
            Consoles console = new Consoles("Series S", 4, "Xbox", 6500, "Good");
            console[0] = 6500;
            Assert.AreEqual(console["ConsolePrice"], 6500);
        }
        [TestMethod]
        public void TestPerformance()
        {
            Consoles console = new Consoles("Series S", 4, "Xbox", 6500, "Good");
            console[0] = "Very Good";
            Assert.AreEqual(console[0], "Very Good");
        }
    }
}
