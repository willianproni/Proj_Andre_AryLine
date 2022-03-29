using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Voo
    {
        public int ID { get; set; }
        public Aeroporto Destino { get; set; }
        public Aeroporto Origem { get; set; }
        public Aeronave Aeronave { get; set; }
        public DateTime HorarioEmbarque { get; set; }
        public DateTime HorarioDesembarque { get; set; }
        public Passageiro Passageiro { get; set; }

        public Voo(int iD, Aeroporto destino, Aeroporto origem, Aeronave aeronave, DateTime horarioEmbarque, DateTime horarioDesembarque, Passageiro passageiro)
        {
            ID = iD;
            Destino = destino;
            Origem = origem;
            Aeronave = aeronave;
            HorarioEmbarque = horarioEmbarque;
            HorarioDesembarque = horarioDesembarque;
            Passageiro = passageiro;
        }
    }
}
