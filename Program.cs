using System;
using System.Collections.Generic;

namespace Estacionamento
{
  public class Program
    {
        public static void Main(string[] args)
        {
            Estacionamento estacionamento = new Estacionamento();

            while (true)
            {
                Console.WriteLine("======================================");
				Console.WriteLine("Menu do Estacionamento:");
                Console.WriteLine("1. Adicionar veículo");
                Console.WriteLine("2. Remover veículo");
                Console.WriteLine("3. Listar veículos");
                Console.WriteLine("4. Sair");
				Console.WriteLine("--------------------------------------");

                Console.Write("Digite a opção desejada: ");
                int opcao = int.Parse(Console.ReadLine());
				Console.WriteLine("======================================");
                switch (opcao)
                {
                    case  1:
                        // Lógica para adicionar um veículo
                        Console.Write("Digite a placa do veículo: ");
                        string placa = Console.ReadLine();
                        Console.Write("Digite o modelo do veículo: ");
                        string modelo = Console.ReadLine();  
						Console.WriteLine("--------------------------------------");
                        estacionamento.AdicionarVeiculo(new Veiculo { Placa = placa, Modelo = modelo, HoraEntrada = DateTime.Now });
                        break;
                    case 2:
                        // Lógica para remover um veículo
                        Console.Write("Digite a placa do veículo para remover: ");
                        placa = Console.ReadLine();
						Console.WriteLine("--------------------------------------");
					
                        estacionamento.RemoverVeiculo(placa);
                        break;
                    case 3:
                        // Lógica para listar veículos
                        estacionamento.ListarVeiculos();
                        break;
                    case 4:
                        Console.WriteLine("Saindo...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}
