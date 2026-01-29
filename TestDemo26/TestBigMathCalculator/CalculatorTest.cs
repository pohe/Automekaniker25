using TestDemo26;

namespace TestBigMathCalculator
{
    [TestClass]
    public class CalculatorTest
    {



        [TestMethod]
        public void TestAdd2Plus5()
        {
            //Arrange
            Calculator c = new Calculator();
            int expectedResult = 7;
            //Act
            int result = c.Add(2, 5);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestDivision5dividedBy2()
        {
            //Arrange
            Calculator c = new Calculator();
            int expectedResult = 2;
            //Act
            int result = c.Division(5, 2);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivisionByZero()
        {
            //Arrange
            Calculator c = new Calculator();

            //Act
            int result = c.Division(10, 0);

            //Assert

        }

        [TestMethod]
        public void TestDivisionByZeroAlternativ()
        {
            //Arrange
            Calculator c = new Calculator();

            //Act
            //Assert
            Assert.ThrowsException<DivideByZeroException>(() => { c.Division(10, 0); });
        }
    }
}
