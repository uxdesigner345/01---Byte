using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // criando objeto na memória
            ContaCorrente contaDaSamilla = new ContaCorrente();

            // referencia
            contaDaSamilla.titular = "Gabriela";
            contaDaSamilla.numero = 84;
            contaDaSamilla.agencia = 424;

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.numero = 84;
            contaDaGabriela.agencia = 424;

            // APESAR DE TEREM OS MESMO VALORES O OBJETO (ENDEREÇO) É DIFERENTE , ESTA EM OUTRO LUGAR
            Console.WriteLine("IGUALDADE DE TIPO DE REFERÊNCIA: " +(contaDaGabriela == contaDaSamilla));

            int idade = 27;
            int idadeMaior = 27;

            Console.WriteLine("IGUALDADE DE TIPO DE VALOR: " + (idade == idadeMaior));

            // duas variaveis apontando para o mesmo objeto na memória = true
            contaDaSamilla = contaDaGabriela;
            Console.WriteLine(contaDaSamilla ==  contaDaGabriela);

            contaDaSamilla.saldo = 300;

            Console.WriteLine(contaDaSamilla.saldo);
            Console.WriteLine(contaDaGabriela.saldo);
            Console.ReadLine();

        }
    }
}
