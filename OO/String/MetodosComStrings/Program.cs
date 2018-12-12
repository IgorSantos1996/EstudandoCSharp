using System;

namespace MetodosComStrings {
    class Program {
        static void Main(string[] args) {
            string original = "abcde FGHIJ ABC  abc DEFG";
            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            int n1 = original.IndexOf("bc"); // primeira ocorrencia de bc
            int n2 = original.LastIndexOf("bc"); // ultima ocorrencia de bc
            string s4 = original.Substring(3); // corta a minha string a partir da posição que eu passar
            string s5 = original.Substring(3, 5); // cortar a minha string a partir da posição 3, cinco caracteres

            string s6 = original.Replace('a', 'x'); // todo caractere 'a' trocarei pelo caractere 'x'
            bool b1 = String.IsNullOrEmpty(original); // ver se a minha variavel é nula ou vazia
            bool b2 = String.IsNullOrWhiteSpace(original); // ver se minha variavel é nula ou contem espaço em branco

            Console.WriteLine("Original = " + original);
            Console.WriteLine("Resultado do ToUpper() =  " + s1);
            Console.WriteLine("Resultado do ToLower() = " + s2);
            string s3 = original.Trim(); // apagar os espaços em branco
            Console.WriteLine("Resultado do Trim()" + s3);
            Console.WriteLine("IndexOf('bc')  = " + n1);
            Console.WriteLine("LastIndexOf('bc') = " + n2);
            Console.WriteLine("Substring 3 : " + s4);
            Console.WriteLine("Substring(3,5 :  - " + s5 + "-");
            Console.WriteLine("Replace('a','x'): - " + s6 + "-");
            Console.WriteLine("IsNullOrEmpty" + b1);
            Console.WriteLine("IsNullOrWhiteSpace = " + b2);



            Console.ReadKey();
        }
    }
}
