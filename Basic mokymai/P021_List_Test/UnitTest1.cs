namespace P021_List_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RastiDidziausia_Test()
        {
            List<int> fake = new List<int> { 5, 1, 6, 8, 7 };
            var expected = 8;
            var actual = P021_List.Program.RastiDidziausia(fake);
            Assert.AreEqual(expected, actual);


            }
        [TestMethod]
        public void RastiDidziausiasuCiklu_Test()
        {
            var fake = new List<int> { 5, 1, 6, 8, 7 };
            var expected = 8;
            var actual = P021_List.Program.RastiDidziausiasuCiklu(fake);
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void RastiDidziausiaUZDidziausias_Test()
        {
            var fake = new List<int> { 5, 1, 6, 8, 7 };
            var expected = new List<int> { 5, 1, 6, 8, 7, 9 };
            var actual = P021_List.Program.DidesniszDidziausia(fake);
            CollectionAssert.AreNotEqual(expected, actual);


        }
        [TestMethod]
        public void RastiDidziausiaUZDidziausias2_Test()
        {
            var fake = new List<int> { 5, 1, 6, 8, 7 };
            var expected = new List<int> { 5, 1, 6, 8, 7, 9};
            var actual = P021_List.Program.RastiDidziausiasuuzDidziausia2(fake);
            CollectionAssert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void RastiDidziausiaUZDidziausias3_Test()
        {
            var fake = new List<int> { 11,5, 1, 6, 8, 7 };
            var expected = new List<int> { 11, 5, 1, 6, 8, 7, 9, 12 };
            var actual = P021_List.Program.RastiDidziausiasuuzDidziausia2(fake);
            CollectionAssert.AreNotEqual(expected, actual);


        }
        

    }

    [TestClass]
    public class P022_ForEach
    {
        [TestMethod]
        public void RastiDidziausia_Test()
        {
            List<int> fake = new List<int> { 5, 1, 6, 8, 7 };
            var expected = 8;
            var actual = P021_List.Program.RastiDidziausia(fake);
            Assert.AreEqual(expected, actual);


        }
    }