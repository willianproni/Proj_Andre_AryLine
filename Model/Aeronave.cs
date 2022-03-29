using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Model
{
    public class Aeronave
    {
        [JsonProperty("id_aeronave")]
        public int ID { get; set; }
        [JsonProperty("nome")]
        public string Nome { get; set; }
        [JsonProperty("capacidade")]
        public int Capacidade { get; set; }

        public Aeronave(int iD, string nome, int capacidade)
        {
            ID = iD;
            Nome = nome;
            Capacidade = capacidade;
        }

        public string ExibirAeronaves()
        {
            return $"\n\nid: {ID}\n" +
                   $"Nome: {Nome}\n" +
                   $"Capacidade: {Capacidade}";
        }
    }
}
