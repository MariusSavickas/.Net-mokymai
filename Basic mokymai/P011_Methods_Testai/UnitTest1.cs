namespace P011_Methods_Testai
{
    [TestClass]
    public class P11_Uzduotys_Test
    {
        [TestMethod]
        public void ZodziuKiekis_Test1()
        {
            var fake = "as mokausi programuoti";
            var expected = 3;
            var actual = P11_Uzduotys.Program.ZodziuKiekis(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZodziuKiekis_Test2()
        {
            var fake = "as mokausi programuoti     ";
            var expected = 3;
            var actual = P11_Uzduotys.Program.ZodziuKiekis(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZodziuKiekis_Test3()
        {
            var fake = "as mokausi         programuoti     ";
            var expected = 3;
            var actual = P11_Uzduotys.Program.ZodziuKiekis(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TarpaiPriekyIrGale_Test1()
        {
            var fake = " as mokausi      ";
            var expextedPriekyje = 1;
            var expectedtarpaiGale = 6;

            P11_Uzduotys.Program.TarpaiPriekyIrGale(
                fake,
                out int actualPriekyje,
                out int actualtarpaiGale);
            Assert.AreEqual(expextedPriekyje, actualPriekyje);
            Assert.AreEqual(expectedtarpaiGale, actualtarpaiGale);

        }
        //5 test uzduoties
        [TestMethod]
        public void IsvalytiTarpus_Test1()
        {
            var fake = " as mokausi ";
            var expected = 10;
            var actual = P11_Uzduotys.Program.IsvalytiTarpus(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsvalytiTarpus_Test2()
        {
            var fake = " as  mokausi ";
            var expected = 11;
            var actual = P11_Uzduotys.Program.IsvalytiTarpus(fake);
            Assert.AreEqual(expected, actual);
        }
        //7 test uzduotis
        [TestMethod]
        public void KiektarpuGale_Test1()
        {
            var fake = " as mokausi      ";
            var expected = 6;
            var actual = P11_Uzduotys.Program.KiektarpuGale(fake);
            Assert.AreEqual(expected, actual);
        }



    }
}