namespace TestProject1
{
    [TestClass]
    public class P11_Uzduotys
    {
        public static object Program { get; private set; }

        [TestMethod]
        public void IsvalytiTarpus()
        {
            var fake = " as mokausi programuoti  ";
            var expected = 2;
            var actual = P11_Uzduotys.Program.IsvalytiTarpus(fake);
            Assert.AreEqual(expected, actual);
        }



    }
}