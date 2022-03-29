using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Model
{
    public class Voo
    {
        [JsonProperty("id_voo")]
        public int ID { get; set; }

        [JsonProperty("destino")]
        public Aeroporto Destino { get; set; }

        [JsonProperty("origem")]
        public Aeroporto Origem { get; set; }

        [JsonProperty("aeronave")]
        public Aeronave Aeronave { get; set; }

        [JsonProperty("horario_embarque")]
        public string HorarioEmbarque { get; set; }

        [JsonProperty("horario_desembarque")]
        public string HorarioDesembarque { get; set; }
        [JsonProperty("Passageiro")]
        public Passageiro Passageiro { get; set; }

        public Voo(int iD, Aeroporto destino, Aeroporto origem, Aeronave aeronave, string horarioEmbarque, string horarioDesembarque, Passageiro passageiro)
        {
            ID = iD;
            Destino = destino;
            Origem = origem;
            Aeronave = aeronave;
            HorarioEmbarque = horarioEmbarque;
            HorarioDesembarque = horarioDesembarque;
            Passageiro = passageiro;
        }

        public override string ToString()
        {
            return $"\n\n----------------Voo: {ID}-----------------------\n" +
                    $"\n\n\t- - -Passageiro- - -\n " +
                   $"{Passageiro.ToString()}" +
                            $"\n\n\t- - -Aeronave- - -" +
                    $"{Aeronave.ExibirAeronaves()}" +
                    $"\n\t- - -Origem - - -\n" +
                   $"{Origem.ExibirAeroporto()}\n" +
                   $"\n\n\t- - -Destino- - -\n\n" +
                   $"Destino: {Destino.ExibirAeroporto()}\n";
        }
    }
}
