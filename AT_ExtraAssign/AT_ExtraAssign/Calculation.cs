using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_ExtraAssign
{
    public class Calcultion
    {
        private int a, b;
        public Calcultion(int a, int b) {
            this.a = a;
            this.b = b;
        }
        public int Execute(string CalSymbol)
        {
            int result = 0;
            switch(CalSymbol)
            {
                case "+":
                    result = this.a + this.b; break;
                case "-":
                    result = this.a - this.b; break;
                case "*":
                    result = this.a * this.b; break;
                case "/":
                    result = this.a / this.b; break;
            }
            return result;
        }
    }
}
