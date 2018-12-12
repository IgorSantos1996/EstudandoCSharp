using System;
using System.Globalization;

namespace ResolucaoExercicioEncapsulamento {
    class ContaBancaria {
        public int Numeroconta { get; private set; }
        private string Titular { get; set; }
        public double Saldo { get; private set; }


        public ContaBancaria(int numeroconta, string titular) {
            this.Numeroconta = numeroconta;
            this.Titular = titular;
            Saldo = 0.0;
        }

        public ContaBancaria(int numeroconta, string titular, double depositoinicial) : this(numeroconta, titular) {

            Deposito(depositoinicial);
        }


        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        public void Saque(double quantia) {
            Saldo -= quantia + 5.0;

        }
        public override string ToString() {
            return " Conta" +
               Numeroconta + " , Titular:  " + Titular + ", Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
