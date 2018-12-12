using System;
using System.Collections.Generic;
using System.Text;

namespace Struct {
    struct Point {
        public double x;
        public double y;
        public override string ToString() {
            return "(" + x + ", " + y + ")";
        }
    }
}
