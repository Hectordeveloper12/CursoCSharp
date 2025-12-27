using System.Globalization;

namespace Exercicio8
{
    internal class Banco
    {
        public int Id { get; private set; }
        //Não pode ser mudado
        public string Name { get; set; }
        //Só pode ser adicionado depósito atravéz de um metodo
        public double Deposito { get; private set;}

        public Banco() { }

        public Banco(int id, string name)
        {
            Id = id;
            Name = name;
            Deposito = 0;
        }

        public Banco(int id, string name, double depositoInicial) :this(id, name)
        {
            Depositar(depositoInicial);
        }

        public string Nome
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public double Depositar(double deposito)
        {
            return Deposito += deposito;
        }

        public double Sacar(double deposito)
        {
            return Deposito -= (deposito + 5);
        }

        public override string ToString()
        {
            return "Conta " + Id + ", Titular: " + Nome + ", Saldo: " + Deposito.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
