namespace DNR_Uzduoties_Testai
{
    [TestClass]
    public class DNR_Uzduoties_Testai
    {
        /*
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

        #region Keièiam GCT á AGG
        [TestMethod]
        public void KeièiamGCT_Test1()
        {
            var fake = "TCGTACGACTACCGTCAGACTTAACCAGTCCATAGAGCT";
            var expected = "TCGTACGACTACCGTCAGACTTAACCAGTCCATAGAAGG";
            var actual = DNR_uzduotis.Program.KeièiamGCT(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void KeièiamGCT_Test2()
        {
            var fake = "GCTTACGACTACCGTCAGACTTAACCAGTCCATAGAGCT";
            var expected = "AGGTACGACTACCGTCAGACTTAACCAGTCCATAGAAGG";
            var actual = DNR_uzduotis.Program.KeièiamGCT(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void KeièiamGCT_Test3()
        {
            var fake = "TCGTACGACTACCGTCAGCTTTAACCAGTCCATAGAGCT";
            var expected = "TCGTACGACTACCGTCAAGGTTAACCAGTCCATAGAAGG";
            var actual = DNR_uzduotis.Program.KeièiamGCT(fake);
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
            var expected = $"Treèias segmentas = GAC \nPenktas segmentas = CGT";
            var actual = DNR_uzduotis.Program.TreciasIrPenktasSegmentas(fake);
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region RaidþiuKiekis_Testai
        [TestMethod]
        public void RaidþiuKiekis_Test1()
        {
            var fake = "TCGTACGACTACCGTCAGACTTAACCAGTCCATAGAGCT";
            var expected = "Raidþiø kiekis yra = 39";
            var actual = DNR_uzduotis.Program.RaidþiuKiekis(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RaidþiuKiekis_Test2()
        {
            var fake = "TCGTACGACTACCGTCAGACTTAACCAGTCCATAGAGCTAGG";
            var expected = "Raidþiø kiekis yra = 42";
            var actual = DNR_uzduotis.Program.RaidþiuKiekis(fake);
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
*/

        string dnr = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT"; //Globalus kintamasis
        int iteration = 10_000_000; //Kiek kartø norime kartoti operacija
        [TestMethod]

        public void DNRGrandinesValidacija_Replace_Test()
        {
            var actual = false;
            for (int i = 0; i < iteration; i++)
            {
                actual = P016_Ciklai2.Program.DNRGrandinesValidacija_Replace(dnr);
            }
            Assert.IsTrue(actual);

        }

        [TestMethod]

        public void DNRGrandinesValidacija_Replace_False()
        {
            string baddnr = "QTCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var actual = false;
            for (int i = 0; i < iteration; i++)
            {
                actual = P016_Ciklai2.Program.DNRGrandinesValidacija_Replace(baddnr);
            }
            Assert.IsFalse(actual);

        }
        [TestMethod]

        public void DNRGrandinesValidacija_For_Test()
        {
            var actual = false;
            for (int i = 0; i < iteration; i++)
            {
                actual = P016_Ciklai2.Program.DNRGrandinesValidacija_For(dnr);
            }
            Assert.IsTrue(actual);

        }
        [TestMethod]
        public void DNRGrandinesValidacija_For_False()
        {
            string baddnr = "QTCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var actual = false;
            for (int i = 0; i < iteration; i++)
            {
                actual = P016_Ciklai2.Program.DNRGrandinesValidacija_For(baddnr);
            }
            Assert.IsFalse(actual);

        }
        [TestMethod]
        public void KiekKartuPasiakrtoja_For_Interpolation_Test()
        {
            var actual = 0;
            var expected = 1;
            for (int i = 0; i < iteration; i++) { }
            {
                actual = P016_Ciklai2.Program.KiekKartuPasiakrtoja_For_Interpolation(dnr, "CCA");
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void KiekKartuPasiakrtoja_For_Composition_Test()
        {
            var actual = 0;
            var expected = 1;
            for (int i = 0; i < iteration; i++) { }
            {
                actual = P016_Ciklai2.Program.KiekKartuPasiakrtoja_For_Composition(dnr, "CCA");
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void KiekKartuPasiakrtoja_For_Concat()
        {
            var actual = 0;
            var expected = 1;
            for (int i = 0; i < iteration; i++) { }
            {
                actual = P016_Ciklai2.Program.KiekKartuPasiakrtoja_For_Concat(dnr, "CCA");
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void KiekKartuPasikartoja_For_StringBuilder_Test()
        {
            var actual = 0;
            var expected = 1;
            for (int i = 0; i < iteration; i++) { }
            {
                actual = P016_Ciklai2.Program.KiekKartuPasikartoja_For_StringBuilder(dnr, "CCA");
            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void KiekKartuPasikartoja_For_StringConstructor_Test()
        {
            var actual = 0;
            var expected = 1;
            for (int i = 0; i < iteration; i++) { }
            {
                actual = P016_Ciklai2.Program.KiekKartuPasikartoja_For_StringConstructor(dnr, "CCA");
            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void KiekKartuPasikartoja_For_Substring()
        {
            var actual = 0;
            var expected = 1;
            for (int i = 0; i < iteration; i++) { }
            {
                actual = P016_Ciklai2.Program.KiekKartuPasikartoja_For_Substring(dnr, "CCA");
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntegerToBinary_Test()
        {
            var fake = 45;           
            var expected = "101101";
            
              var  actual = P017For_Uzduotys.Program.IntegerToBinary(fake);
            
            Assert.AreEqual(expected, actual);
        }

    }
}