using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatriceTestUnitaires {
    public class Calculator {
        public int number1 { get; set; }
        public int number2 { get; set; }

        public int Addition(int number1, int number2) {
            return number1 + number2;
        }

        public int Substraction(int number1, int number2) {
            return number1 - number2;
        }

        public int Division(int number1, int number2) {
            if (number2 == 0) {
                throw new DivideByZeroException("Division par Zero impossible");
            }
            return number1 / number2;
        }

        public int Multiplication(int number1, int number2) {
            return number1 * number2;
        }
    }
}
