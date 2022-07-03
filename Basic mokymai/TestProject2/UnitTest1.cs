namespace TestProject2
{
    [TestClass]
    public class P010_Methods_Test
    {
        [TestMethod]
        public void KiekYraZodziu_Test1()
        {
            var fake = "as mokausi programuoti";
            var expected = 3;
            var actual = P010_Methods.Program.KiekYraZodziu(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void KiekYraZodziu_Test2()
        {
            var fake = "as mokausi programuoti       ";
            var expected = 3;
            var actual = P010_Methods.Program.KiekYraZodziu(fake);
            Assert.AreEqual(expected, actual);
        }

    }
}