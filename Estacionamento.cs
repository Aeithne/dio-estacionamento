using System;
using System.Collections.Generic;

namespace Estacionamento
class Estacionamento
    {
        private List<Veiculo> veiculos = new List<Veiculo>();
        private double tarifaPorHora = 5.0;
		private double valor;

        public void AdicionarVeiculo(Veiculo veiculo)
        {
            veiculos.Add(veiculo);
            Console.WriteLine("Veículo adicionado com sucesso!");
        }

        public void RemoverVeiculo(string placa)
        {
			
            var veiculo = veiculos.Find(v => v.Placa == placa);
            if (veiculo != null)
            {
                veiculo.HoraSaida = DateTime.Now;
                var tempoPermanencia = (veiculo.HoraSaida - veiculo.HoraEntrada).TotalHours;
                veiculo.ValorPago = tempoPermanencia * tarifaPorHora;
                veiculos.Remove(veiculo);
				valor = veiculo.ValorPago;
                Console.WriteLine($"Veículo {placa} removido. Valor a pagar: R${valor}");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado.");
            }
        }

        public void ListarVeiculos()
        {
            Console.WriteLine("Veículos estacionados:");
			Console.WriteLine("--------------------------------------");
            foreach (var veiculo in veiculos)
            {
                Console.WriteLine($"Placa: {veiculo.Placa} - Modelo: {veiculo.Modelo} - Hora de entrada: {veiculo.HoraEntrada}");
            }
        }
    }
