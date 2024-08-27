using System;
using System.Collections.Generic;

namespace Estacionamento
{
    class Veiculo
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSaida { get; set; }
        public double ValorPago { get; set; }
    }
}
