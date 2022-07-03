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
        // 10 uzduotis
        [TestMethod]
        public void KiekYraRaidziuA_Test1()
        {
            var fake = "as mokausi         programuoti     ";
            var expected = 3;
            var actual = P11_Uzduotys.Program.KiekYraRaidziuA(fake);
            Assert.AreEqual(expected, actual);
        }
        // 11 uzduotis
        [TestMethod]
        public void ArYraZodisMokausi_Test1()
        {
            var fake = " as labai mokausi programuoti     ";
        var expected = "Taip";
        var actual = P11_Uzduotys.Program.ArYraZodisMokausi(fake);
        Assert.AreEqual(expected, actual);
        }
       
        [TestMethod]
        public void ArYraZodisMokausi_Test2()
        {
            var fake = " as_labai_mokausi_programuoti     ";
            var expected = "Ne";
            var actual = P11_Uzduotys.Program.ArYraZodisMokausi(fake);
            Assert.AreEqual(expected, actual);
        }
        /*
        [TestMethod]
         public void ArYraZodisMokausi_Test3()
         {
             var fake = " as_labai_MOKAUSI_programuoti     ";
             var expected = "Taip";
             var actual = P11_Uzduotys.Program.ArYraZodisMokausi(fake);
             Assert.AreEqual(expected, actual);
         }*/

        [TestMethod]
        public void ArYraZodisMokausi_Test4()
        {
            var fake = "mokausi as labai programuoti     ";
            var expected = "Taip";
            var actual = P11_Uzduotys.Program.ArYraZodisMokausi(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ArYraZodisMokausi_Test5()
        {
            var fake = " ";
            var expected = "Ne";
            var actual = P11_Uzduotys.Program.ArYraZodisMokausi(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ArYraZodisMokausi_Test6()
        {
            var fake = "mokausi as labai programuoti     ";
            var expected = "Taip";
            var actual = P11_Uzduotys.Program.ArYraZodisMokausi(fake);
            Assert.AreEqual(expected, actual);
        }
        //11A Namø darbas
        //11A1
        [TestMethod]
        public void ArYraZodisMokausi1_Test1()
        {
            var fake = " as labai mokausi programuoti     ";
            var expected = "Taip";
            var actual = P11_Uzduotys.Program.ArYraZodisMokausi1(fake);
            Assert.AreEqual(expected, actual);
        }
        //11A2
        [TestMethod]
        public void ArYraZodisMokausi1_Test2()
        {
            var fake = "aslabaimokausiprogramuoti";
            var expected = "Ne";
            var actual = P11_Uzduotys.Program.ArYraZodisMokausi1(fake);
            Assert.AreEqual(expected, actual);
        }
        //11A3
        [TestMethod]
        public void ArYraZodisMokausi1_Test3()
        {
            var fake = "mokausi programuoti labai    ";
            var expected = "Taip";
            var actual = P11_Uzduotys.Program.ArYraZodisMokausi1(fake);
            Assert.AreEqual(expected, actual);
        }
        //11A4
        [TestMethod]
        public void ArYraZodisMokausi1_Test4()
        {
            var fake = "as mokausi, labai stipriai";
            var expected = "Taip";
            var actual = P11_Uzduotys.Program.ArYraZodisMokausi1(fake);
            Assert.AreEqual(expected, actual);           
        }
        //11A5
        [TestMethod]
        public void ArYraZodisMokausi1_Test5()
        {
            var fake = "as mokausi!";
            var expected = "Taip";
            var actual = P11_Uzduotys.Program.ArYraZodisMokausi1(fake);
            Assert.AreEqual(expected, actual);
        }
        //11A6
        [TestMethod]
        public void ArYraZodisMokausi1_Test6()
        {
            var fake = "as mokausi?";
            var expected = "Taip";
            var actual = P11_Uzduotys.Program.ArYraZodisMokausi1(fake);
            Assert.AreEqual(expected, actual);
        }
        //11A7
        [TestMethod]
        public void ArYraZodisMokausi1_Test7()
        {
            var fake = "as studijuoju (mokausi)";
            var expected = "Taip";
            var actual = P11_Uzduotys.Program.ArYraZodisMokausi1(fake);
            Assert.AreEqual(expected, actual);
        }
        //11A8
        [TestMethod]
        public void ArYraZodisMokausi1_Test8()
        {
            var fake = "as studijuojumokausi)";
            var expected = "Ne";
            var actual = P11_Uzduotys.Program.ArYraZodisMokausi1(fake);
            Assert.AreEqual(expected, actual);
        }


    }
}