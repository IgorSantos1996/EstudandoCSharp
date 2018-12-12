using System;
using System.Globalization;

namespace Construtores01 {
    class Produto {
        private string _nome;
        public double Preco { get; private set; }
        //public int Quantidade { get; private set; }
        public int Quantidade { get; private set; }

        public Produto() {
        }


        public Produto(string nome, double preco) : this() {
            this._nome = nome;
            this.Preco = preco;

        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco) {
            this.Quantidade = quantidade;

        }


        /*public double Preco {
            get { return _preco; }
        }*/
        /*public double Quantidade {
            get { return _quantidade; }
        }*/
        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        /* public string GetNome() {
             return _nome;
         }
         public void SetNome(string nome) {
             if (nome != null && nome.Length > 1) { _nome = nome; }

         }*/
        /*public double GetQuantidade() {
           return _quantidade;
       }
       public double GetPreco() {
           return _preco;
       }
       */

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidades) {
            Quantidade += quantidades;
        }
        public void RemoverProduto(int quantidade) {
            Quantidade = Quantidade - quantidade;
        }
        public override string ToString() {
            return _nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + Quantidade + " unidades , Total: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
