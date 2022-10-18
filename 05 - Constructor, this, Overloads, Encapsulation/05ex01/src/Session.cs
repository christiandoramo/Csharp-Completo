using System;
using System.Globalization;

namespace _05ex01
{
    class Session
    {
        private int conta;
        private string nome;
        private double deposito;

        public int getConta()
        {
            return this.conta;
        }
        public void setConta()
        {
            Console.WriteLine("Numero da Conta: ");
            this.conta = int.Parse(Console.ReadLine());
        }
        public string getNome()
        {
            return this.nome;
        }
        public void setNome()
        {
            Console.WriteLine("Nome do Titular: ");
            this.nome = Console.ReadLine();
        }
        public void Depositar()
        {
            Console.WriteLine("Quantia a depositar: ");
            double _deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            this.deposito += _deposito;
            Console.WriteLine("Dados da conta atualizados:");
            DadosConta();
            Console.WriteLine();
        }

        public void Sacar()
        {
            Console.WriteLine("Quantia a sacar: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            this.deposito -= saque + 5.0;
            Console.WriteLine("Dados da conta atualizados: (OBS: -5,00 de Tarifa de saque)");
            DadosConta();
            Console.WriteLine();
        }

        public double getSaldo()
        {
            return this.deposito;
        }

        public void DadosConta()
        {
            Console.WriteLine("Conta " + this.getConta().ToString() + ", Titular: " + this.getNome() +
            ", Saldo: " + this.getSaldo().ToString("F2") + ".");
        }

        public void Cadastrar()
        {
            setConta();
            setNome();
            Console.WriteLine("Haverá depósito inicial? (s) para sim (n) para não)");
            string _havera = Console.ReadLine();

            if (_havera == "s")
            {
                Console.WriteLine("Depósito Inicial: ");
                this.deposito += double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Dados da conta:");
            DadosConta();
            Console.WriteLine();
        }
    }
}