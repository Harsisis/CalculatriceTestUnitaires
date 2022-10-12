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
    }
}