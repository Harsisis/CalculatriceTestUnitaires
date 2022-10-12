namespace CalculatriceTestUnitaires {
    [TestClass]
    public class CalculatorTest {

        public int number1 { get; set; }
        public int number2 { get; set; }
        public Calculator calculator { get; set; }
        public CalculatorTest() {
            calculator = new Calculator();
            number1 = 10;
            number2 = 20;
        }

        [TestMethod]
        public void Calculator_Addition() {
            Assert.AreEqual(number1+number2, calculator.Addition(number1, number2));
        }

        [TestMethod]
        public void Calculator_Substraction() {
            Assert.AreEqual(number1 - number2, calculator.Substraction(number1, number2));
        }

        [TestMethod]
        public void Calculator_Division() {
            Assert.AreEqual(number1 / number2, calculator.Division(number1, number2));
        }

        [TestMethod]
        public void Calculator_Multiplication() {
            Assert.AreEqual(number1 * number2, calculator.Multiplication(number1, number2));
        }

        [TestMethod]
        [DataRow(10, 20, 0)]
        [DataRow(10, 2, 5)]
        [DataRow(100, 20, 5)]
        [DataRow(5, 5, 1)]
        public void DivideTwoElements_ShouldReturnRightResult(int firstNumber, int secondNumber, int result) {
            Assert.AreEqual(calculator.Division(firstNumber, secondNumber), result);
        }

        [TestMethod]
        [DataRow(10, 0)]
        public void DivideByZero_ShouldReturnException(int firstNumber, int secondNumber) {
            Assert.ThrowsException<DivideByZeroException>(() => calculator.Division(firstNumber, secondNumber));
        }
    }
}