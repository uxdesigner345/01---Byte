using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Conta Corrrente****");
            Console.WriteLine();

            ContaCorrente contaDoSandro =  new ContaCorrente();

            contaDoSandro.titular = "sandro";
            contaDoSandro.agencia = 456;
            contaDoSandro.numero = 487489;
            contaDoSandro.saldo = 100;

            Console.WriteLine("Titular: " + contaDoSandro.titular);
            Console.WriteLine("Agencia: " + contaDoSandro.agencia);
            Console.WriteLine("Número: " + contaDoSandro.numero);
            Console.WriteLine("Saldo: " + contaDoSandro.saldo);

            Console.ReadLine();
        }
    }
}
