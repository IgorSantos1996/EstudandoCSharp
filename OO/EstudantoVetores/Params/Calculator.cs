using System;
using System.Collections.Generic;
using System.Text;

namespace Params {
    class Calculator {
        public static int Sum(params int[] numbers) {
            int soma = 0;
            for (int i = 0; i < numbers.Length; i++) {
                soma = soma + numbers[i];

            }
            return soma;
        }
    }
}
