using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Model
{
    public class Aeroporto
    {
        [JsonProperty("sigla")]
        public string Sigla { get; set; }
        [JsonProperty("nome")]
        public string Nome { get; set; }
        [JsonProperty("endereco")]
        public Endereco Endereco { get; set; }

        public Aeroporto(string sigla, string nome, Endereco endereco)
        {
            Sigla = sigla;
            Nome = nome;
            Endereco = endereco;
        }

        public string ExibirAeroporto()
        {
            return $"\nSigla: {Sigla}\n" +
                   $"Nome: {Nome}\n" +
                   $"{Endereco.ExibiEndereco()}";
        }
    }
}
