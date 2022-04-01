//pegando atributos da classe Cliente , caso a classe ContaCorrente não tivesse dentro de um name space
//using _05_ByteBank;

// quando a classe já tem o namespace ele já encontra a classe dentro do projeto
namespace _05_ByteBank
{
    public class ContaCorrente
    {

        public Cliente titular;
        public int agencia;
        public int numero;
        public double saldo = 100;

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
