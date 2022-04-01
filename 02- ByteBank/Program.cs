using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02__ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
             
        {
                         //criando objeto 
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Jorge";
            conta.numero = 234;

            Console.WriteLine(conta.titular);
            Console.WriteLine(conta.numero);
            Console.WriteLine(conta.saldo);

            
            Console.ReadLine();
        }
    }
}
