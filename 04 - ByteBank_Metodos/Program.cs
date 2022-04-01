using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___ByteBank_Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaBruno = new ContaCorrente();

            contaBruno.titular = "Bruno Mezenga";

            Console.WriteLine("Saldo anterior: R$" + contaBruno.saldo);

            //chamando função Sacar
            contaBruno.Sacar(36);

            Console.WriteLine("Saldo atual: R$ " + contaBruno.saldo);
            
            //resultadoDposito não vai funcionar pois ele não tem retorno (void)
            //bool resultadoDeposito = contaBruno.Depositar;

            contaBruno.Depositar(562);

            Console.WriteLine("Depósito realizado com sucesso! saldo atual R$: " + contaBruno.saldo);

            
            // nova instância de ContaCorrente, que é contaDaGabriela
            ContaCorrente contaDaGabriela = new ContaCorrente();

            Console.WriteLine("Bruno seu saldo anterior R$: " + contaBruno.saldo);

            contaDaGabriela.titular = "gabriela";

            //aqui eu posso criar uma variavel para guardar a transferencia pois o método recebe tem retorno //chamando metodo transferir
            bool resultadotransferencia = contaBruno.Transferir(400, contaDaGabriela);
            

            Console.WriteLine("Transferencia realizada com sucesso!" +  contaBruno.titular + " Seu saldo atual é de R$:" + contaBruno.saldo);
            Console.WriteLine("Saldo de Gabriela" + contaDaGabriela.saldo);

            Console.WriteLine("Resultado da transferencia" + resultadotransferencia);


            Console.ReadLine();

            
        }
    }
}
