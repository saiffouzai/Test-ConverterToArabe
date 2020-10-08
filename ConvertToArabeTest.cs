using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FnacTest
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class ConverterRomainToArabeTest
    {

        private Converter _converter;
        private Converter converter
        {
            get
            {
                if(_converter == null)
                {
                    _converter = new Converter();
                }
                return _converter;
            }
            set
            {
                _converter = value;
            }
        }

        [TestMethod]
        public void ShouldReturnArabe1WhenRomainIsokI()
        {
            int resultConvertion = converter.ConvertRomainNumberToArabe("I");
            Assert.AreEqual(1, resultConvertion);
        }

        [TestMethod]
        public void ShouldReturnArabe2WhenRomainIsokII()
        {
            int resultConvertion = converter.ConvertRomainNumberToArabe("II");
            Assert.AreEqual(2, resultConvertion);
        }

        [TestMethod]
        public void ShouldReturnArabe10WhenRomainIsokX()
        {
            int resultConvertion = converter.ConvertRomainNumberToArabe("X");
            Assert.AreEqual(10, resultConvertion);
        }

        [TestMethod]
        public void ShouldReturnArabe100WhenRomainIsokM()
        {
            int resultConvertion = converter.ConvertRomainNumberToArabe("M");
            Assert.AreEqual(1000, resultConvertion);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldThrowExceptionWhenRomainIsNotOk()
        {
            int resultConvertion = converter.ConvertRomainNumberToArabe("H");
        }

        [TestCleanup]
        public void MyTestCleanup()
        {
            converter = null;
        }
        
    }
}
