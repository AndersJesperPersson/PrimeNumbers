namespace PrimeNrTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using DatalogiLektion1;


    [TestClass]
    public class UnitTest1
    {
     
      
        [TestMethod]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(5)]
        [DataRow(7)]
        [DataRow(11)]
        [DataRow(13)]
        [DataRow(17)]
        [DataRow(61)]
        [DataRow(97)]
        public void PrimeNumbers(double x)
        {
            var result = PrimeCalculator.IsPrime(x);
            Assert.IsTrue(result);

   
        }

        [TestMethod]
        [DataRow(4)]
        [DataRow(6)]
        [DataRow(8)]
        [DataRow(10)]
        [DataRow(20)]
        [DataRow(64)]
        [DataRow(872)]
        [DataRow(5000)]
        [DataRow(875636)]
        public void EvenNumber(double x)
        {

            var result = PrimeCalculator.IsPrime(x);
            Assert.IsFalse(result);


        }
        [TestMethod]
        [DataRow(21)]
        [DataRow(15)]
        [DataRow(285)]
        [DataRow(854753)]
        [DataRow(2123654781)]
        [DataRow(12365478112121)]
        public void OddNumber(double x)
        {

            var result = PrimeCalculator.IsPrime(x);
            Assert.IsFalse(result);


        }

        [TestMethod]
        [DataRow(2.4)]
        [DataRow(5.5)]
        public void DecimalNumber(double x)
        {

            var result = PrimeCalculator.IsPrime(x);
            Assert.IsFalse(result);


        }
    }
}
