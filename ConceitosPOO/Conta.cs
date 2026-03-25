using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosPOO
{
    public class Conta
    {
        private long _numero;
        private decimal _saldo;
        private Cliente _titular;

        private Agencia _agencia;

        public Agencia Agencia
        {
            get { return _agencia; }
            set { _agencia = value; }
        }

        public Cliente Titular        
        {
            get { return _titular; }
            set { _titular = value;  }
        }

        public Conta(long numero, decimal saldo)
        {
            _numero = numero;
            _saldo = saldo;
        }

        public long Numero 
        {
            get => _numero;
            private set 
            {
                _numero = value;
            }
        }

        public decimal Saldo
        {
            get => _saldo;
            private set
            {
                _saldo = value;
            }
        }

        public void Deposito(decimal valor)
        {
            _saldo += valor;
        }

        public void Saque(decimal valor)
        {
            if (valor <= _saldo)
            {
                _saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque");
            }

        }

        public void Transferencia(Conta conta, decimal valorTransferencia)
        {
            if (valorTransferencia <= 0) throw new ArgumentException("O valor a ser transferido deve ser superior a zero.");
            this.Saque(valorTransferencia);
            conta.Deposito(valorTransferencia);
        }
    }
}
