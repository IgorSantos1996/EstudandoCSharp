using System;
using System.Collections.Generic;
using System.Text;

namespace Ref {
    class Calculador {
        public static void Triple(ref int a) {
            a = a * 3;
        }
        public static void Triple(int origem, out int resultado) {
            resultado = origem * 3;
        }

    }
}
