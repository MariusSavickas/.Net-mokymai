namespace DNR_Uzduoties_Testai
{
    [TestClass]
    public class DNR_Uzduoties_Testai
    {
        #region BeTarpuIrDidziosiomisRaidemis_Testai
        [TestMethod]
        public void BeTarpuIrDidziosiomisRaidemis_Test1()
        {
            var fake = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT      ";
            var expected = "TCGTACGACTACCGTCAGACTTAACCAGTCCATAGAGCT";
            var actual = DNR_uzduotis.Program.BeTarpuIrDidziosiomisRaidemis(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void BeTarpuIrDidziosiomisRaidemis_Test2()
        {
            var fake = " T CG-TAC- gaC   -TAC---CGT-CAG-ACT-TAa-CcA---GTC-cAt-AGA-GCT      ";
            var expected = "TCGTACGACTACCGTCAGACTTAACCAGTCCATAGAGCT";
            var actual = DNR_uzduotis.Program.BeTarpuIrDidziosiomisRaidemis(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void BeTarpuIrDidziosiomisRaidemis_Test3()
        {
            var fake = "  T C G -TA C- gaC-TA C---CGT-CAG-ACT-TAa-CcA---GTC-cAt-AGA-GCT      ";
            var expected = "TCGTACGACTACCGTCAGACTTAACCAGTCCATAGAGCT";
            var actual = DNR_uzduotis.Program.BeTarpuIrDidziosiomisRaidemis(fake);
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region PatikrinameValidacija_Testai
        [TestMethod]
        public void PatikrinameValidacija_Test1()
        {
            var fake = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT      ";
            var expected = "Kodas yra validus";
            var actual = DNR_uzduotis.Program.PatikrinameValidacija(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PatikrinameValidacija_Test2()
        {
            var fake = " TF CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT      ";
            var expected = "Kodas neteisingas";
            var actual = DNR_uzduotis.Program.PatikrinameValidacija(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PatikrinameValidacija_Test3()
        {
            var fake = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT  F    ";
            var expected = "Kodas neteisingas";
            var actual = DNR_uzduotis.Program.PatikrinameValidacija(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PatikrinameValidacija_Test4()
        {
            var fake = "b T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT      ";
            var expected = "Kodas neteisingas";
            var actual = DNR_uzduotis.Program.PatikrinameValidacija(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PatikrinameValidacija_Test5()
        {
            var fake = "a T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT      ";
            var expected = "Kodas yra validus";
            var actual = DNR_uzduotis.Program.PatikrinameValidacija(fake);
            Assert.AreEqual(expected, actual);
        }


        #endregion

        #region Kei�iam GCT � AGG
        [TestMethod]
        public void Kei�iamGCT_Test1()
        {
            var fake = "TCGTACGACTACCGTCAGACTTAACCAGTCCATAGAGCT";
            var expected = "TCGTACGACTACCGTCAGACTTAACCAGTCCATAGAAGG";
            var actual = DNR_uzduotis.Program.Kei�iamGCT(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Kei�iamGCT_Test2()
        {
            var fake = "GCTTACGACTACCGTCAGACTTAACCAGTCCATAGAGCT";
            var expected = "AGGTACGACTACCGTCAGACTTAACCAGTCCATAGAAGG";
            var actual = DNR_uzduotis.Program.Kei�iamGCT(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Kei�iamGCT_Test3()
        {
            var fake = "TCGTACGACTACCGTCAGCTTTAACCAGTCCATAGAGCT";
            var expected = "TCGTACGACTACCGTCAAGGTTAACCAGTCCATAGAAGG";
            var actual = DNR_uzduotis.Program.Kei�iamGCT(fake);
            Assert.AreEqual(expected, actual);
        }


        #endregion

        #region SurastiCAT_Testai
        [TestMethod]
        public void SurastiCAT_Test1()
        {
            var fake = "TCGTACGACTACCGTCAGACTTAACCAGTCCATAGAGCT";
            var expected = "CAT buvo rasta";
            var actual = DNR_uzduotis.Program.SurastiCAT(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SurastiCAT_Test2()
        {
            var fake = "TCGCATTACGACTACCGTCAGACTTAACCAGTCAGAGCT";
            var expected = "CAT buvo rasta";
            var actual = DNR_uzduotis.Program.SurastiCAT(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SurastiCAT_Test3()
        {
            var fake = "TCGTACGACTACCGTCAGACTTAACCAGTCCAGAGAGCT";
            var expected = "CAT nebuvo rasta";
            var actual = DNR_uzduotis.Program.SurastiCAT(fake);
            Assert.AreEqual(expected, actual);
        }


        #endregion

        #region TreciasIrPenktasSegmentas_Testai
        [TestMethod]
        public void TreciasIrPenktasSegmentas_Test()
        {
            var fake = "TCGTACGACTACCGTCAGACTTAACCAGTCCATAGAGCT";
            var expected = $"Tre�ias segmentas = GAC \nPenktas segmentas = CGT";
            var actual = DNR_uzduotis.Program.TreciasIrPenktasSegmentas(fake);
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Raid�iuKiekis_Testai
        [TestMethod]
        public void Raid�iuKiekis_Test1()
        {
            var fake = "TCGTACGACTACCGTCAGACTTAACCAGTCCATAGAGCT";
            var expected = "Raid�i� kiekis yra = 39";
            var actual = DNR_uzduotis.Program.Raid�iuKiekis(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Raid�iuKiekis_Test2()
        {
            var fake = "TCGTACGACTACCGTCAGACTTAACCAGTCCATAGAGCTAGG";
            var expected = "Raid�i� kiekis yra = 42";
            var actual = DNR_uzduotis.Program.Raid�iuKiekis(fake);
            Assert.AreEqual(expected, actual);
        }


        #endregion

        
        #region IeskomeIvestoSegmento
        [TestMethod]
        public void IeskomeIvestoSegmento_Test1()
        {
            var Segmentas = "BBCXZ";
            var fake1 = "";
            var expected = "Segmentas buvo rastas"; 
            var actual = DNR_uzduotis.Program.IeskomeIvestoSegmento(Segmentas, fake1);
            Assert.AreEqual(expected, actual);
        }
        #endregion
        #region SurastiCAT_Testai
        #endregion
        #region SurastiCAT_Testai
        #endregion
        #region SurastiCAT_Testai
        #endregion
        #region SurastiCAT_Testai
        #endregion
    }
}