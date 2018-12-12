using System;
using System.Collections.Generic;
using System.Text;

namespace Vetores03 {
    class Hospede {
        public String Email { get; set; }
        public String Nome { get; set; }


        public override string ToString() {
            return Nome + ", " + Email;
        }
    }
}
