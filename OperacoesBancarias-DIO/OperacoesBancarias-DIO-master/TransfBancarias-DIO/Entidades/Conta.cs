using System;
using TransfBancarias_DIO.Enumeradores;

namespace TransfBancarias_DIO.Entidades
{
    public class Conta
    {
        private string Nome { get; set; }
        private TipoConta TipoConta { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }

        public Conta(string nome, TipoConta tipoConta, double saldo, double credito)
        {
            Nome = nome;
            TipoConta = tipoConta;
            Saldo = saldo;
            Credito = credito;
        }

        /// <summary>
        /// Método responsável por validar o saldo disponível para saque.
        /// Se houver saldo disponível será deduzido da propriedade <see cref="Saldo"/>
        /// </summary>
        public bool Sacar(double valorSaque)
        {
            if (Saldo - valorSaque < (Credito * -1))
            {
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }

            Saldo -= valorSaque;
            Console.WriteLine("Saldo de conta de {0} é {1}", Nome, Saldo);
            return true;
        }

        /// <summary>
        /// Método para adicionar valor na propriedade 
        /// <see cref="Saldo"/>
        /// </summary>
        /// <param name="valorDeposito"></param>
        public void Depositar (double valorDeposito)
        {
            Saldo += valorDeposito;
            Console.WriteLine("Saldo atual da conta de {0} é {1}", Nome, Saldo);
        }

        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if (Sacar(valorTransferencia))            
                contaDestino.Depositar(valorTransferencia);           

        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "TipoConta " + TipoConta + " | ";
            retorno += "Nome " + Nome + " | ";
            retorno += "Saldo " + Saldo + " | ";
            retorno += "Crédito " + Credito + " | ";
            return base.ToString();
        }

    }
}
