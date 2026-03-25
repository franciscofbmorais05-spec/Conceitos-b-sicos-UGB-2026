using ConceitosPOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteConceitosPOO
{
    [TestClass]
    public class TesteConceitoPOO
    {
        [TestMethod]
        public void TestDeposito()
        {
            //cenário
            decimal saldoInicial = 1000;
            decimal valorDeposito = 500;
            decimal saldoEsperado = 1500;
            Conta conta = new Conta(1111, saldoInicial);

            //ação
            conta.Deposito(valorDeposito);

            //verificação
            Assert.AreEqual(saldoEsperado, conta.Saldo);
        }

        [TestMethod]
        public void TestSaque()
        {
            decimal saldoInicial = 1000;
            decimal valorSaque = 500;
            decimal saldoEsperado = 500;
            Conta conta = new Conta(1111, saldoInicial);

            //ação
            conta.Saque(valorSaque);

            //verificação
            Assert.AreEqual(saldoEsperado, conta.Saldo);
        }

        [TestMethod]
        public void TestTransferencia()
        {
            decimal saldoInicialconta = 1000;
            decimal saldoInicialconta2 = 500;
            decimal valorTransferencia = 500;

            decimal saldoEsperadoconta = 500;
            decimal saldoEsperadoconta2 = 1000;

            Conta conta = new Conta(1111, saldoInicialconta);
            Conta conta2 = new Conta(2222, saldoInicialconta2);

            //ação
            conta.Transferencia(conta2, valorTransferencia);

            //verificação
            Assert.AreEqual(saldoEsperadoconta, conta.Saldo);
            Assert.AreEqual(saldoEsperadoconta2, conta2.Saldo);
        }

        [TestMethod]
        public void TestSaqueValoMenorQueZero()
        {
            decimal saldoInicial = 1000;
            decimal valorSaque = 500;
            Conta conta = new Conta(1111, saldoInicial);

            //ação e verificação
            Assert.ThrowsException<ArgumentException>(() => conta.Saque(valorSaque));
        }

    }
}
