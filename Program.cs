using System;
class Program
{
    static void Main(string[] args)
    {
        int op = 0;
        string placa;
        Estacionamento E = new Estacionamento();
        while (op != 4)
        {
            Console.WriteLine("Digite a opção Desejada!");
            Console.WriteLine("1 - Cadastrar Veiculo \n2 - Remover Veiculo \n3 - Listar Veiculos \n4 - Encerrar ");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.Write("Digite a placa: ");
                    placa = Console.ReadLine();
                    E.AdicionarCarro(placa);
                    break;
                case 2:
                    Console.Write("Digite a placa: ");
                    placa = Console.ReadLine();
                    E.RemoverCarro(placa);
                    break;
                case 3:
                    E.ListarTodos();
                    break;
                case 4:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção invalida...");
                    break;
            }
        }

    }
    class Estacionamento
    {
        public Estacionamento()
        {

        }
        private decimal precoinicial;
        private decimal precoporhora = 5;
        private List<string> Lista = new List<string>();

        public decimal Precoinicial
        {
            get { return precoinicial; }
            set { precoinicial = value; }
        }
        public decimal Precoporhora
        {
            get { return precoporhora; }
            set { precoporhora = value; }
        }

        public void AdicionarCarro(string placa)
        {
            Lista.Add(placa);
        }
        public void RemoverCarro(string placa)
        {
            if (Lista.Contains(placa))
            {
                Console.WriteLine("Por quanto tempo ficou estacionado?");
                precoinicial = decimal.Parse(Console.ReadLine());
                Console.WriteLine($"Total: R${precoinicial * precoporhora}");
                Lista.Remove(placa);
            }
            else
            {
                Console.WriteLine("A placa não consta no sistema.");
            }
        }
        public void ListarTodos()
        {
            if (Lista.Count == 0)
            {
                Console.WriteLine("Não ha veiculos Estacionados!");
            }
            else
            {
                Lista.ToArray();
                foreach (string carro in Lista)
                {
                    Console.WriteLine(carro);
                }
            }

        }
    }

}