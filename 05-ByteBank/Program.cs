using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
     // a classe namespace pertence ao namespace então ele encontrou a classe Cliente
     class Program
    {   
        //OBJETO (gabriela e conta) diferentes com o mesmo valor na memória
        // ambos são refenrencia para o mesmo objeto para memória do computador.
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente();

            gabriela.nome = "gabriela";
            gabriela.profissao = "Analista de sistemas";
            gabriela.cpf = "1546.4548.48.- 45";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = gabriela;
            conta.saldo = 300;
            conta.agencia = 433;
            conta.numero = 4234;

            Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.profissao);

            Console.ReadLine();
        }
    }
}
