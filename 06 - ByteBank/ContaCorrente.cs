
//using _05_ByteBank;

namespace _06_ByteBank
{
    public class ContaCorrente
    {
        //agora titular é referencia de um objeto cliente
        //apenas a ContaCorrente pode ver o saldo(private)
        public Cliente titular;
        public int agencia;
        public int numero;
        private double saldo = 100;

        //SetSaldo e GetSaldo é um  ENCAPSULAMENTO  de saldo
        //método para o cliente depositar
        public void SetSaldo(double saldo)
        {   
            // se o valor que o cliente tentar depositar for menor que 0 não haverá alteração
            //este saldo é da referencia(argumento) acima(double saldo)
            if(saldo < 0)
            {
                //void implica na ausência de retorno. Não inserimos um Booleano, um inteiro, ou algo que retorne. Nesse caso, podemos simplesmente escrever return
                return;
            }
            else {
                //à esquerda do sinal de igual (=) trata-se de saldo como campo e, na atribuição, à direita do sinal de igual, trata-se de saldo como argumento.
                this.saldo = saldo;
            }
        }

        //Criando método Obtersaldo para usar em outras classes 

        public double GetSaldo()
        {
            return saldo;
        }

        //função (método sacar)
        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {

                return false;

            }
            else
            {
                //se o saldo for > que valor (averá a subtração)
                this.saldo -= valor;
                return true;
            }
        }
        // VOID - quando a função não tem retorno
        public void Depositar(double valor)
        {
            this.saldo += valor;
        }
        //Método transferencia - 
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                //subtraindo valor da conta e transferindo para contaDestino
                this.saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }

    }
}
