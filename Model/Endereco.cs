using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Model
{
    public class Endereco
    {
        [JsonProperty("id_end")]
        public int ID { get; set; }
        [JsonProperty("Pais")]
        public string Pais { get; set; }

        [JsonProperty("CEP")]
        public string Cep { get; set; }

        [JsonProperty("Cidade")]
        public string Cidade { get; set; }

        [JsonProperty("Estado")]
        public string Estado { get; set; }

        [JsonProperty("Logradouro")]
        public string Logradouro { get; set; }

        [JsonProperty("Bairro")]
        public string Bairro { get; set; }
        [JsonProperty("Complemento")]
        public string Complemento { get; set; }
        [JsonProperty("Numero")]
        public string Numero { get; set; }

        public Endereco()
        {
        }

        public Endereco(int id, string pais, string cep, string cidade, string estado, string logradouro, string bairro, string complemento, string numero)
        {
            ID = id;
            Pais = pais;
            Cep = cep;
            Cidade = cidade;
            Estado = estado;
            Logradouro = logradouro;
            Bairro = bairro;
            Complemento = complemento;
            Numero = numero;
        }

        public string ExibiEndereco()
        {
            return $"\n\nId: {ID}\n" +
                   $"País: {Pais}\n" +
                   $"CEP: {Cep}\n" +
                   $"Cidade: {Cidade}\n" +
                   $"Estado: {Estado}\n" +
                   $"Bairro: {Bairro}\n" +
                   $"Logradouro: {Logradouro}\n" +
                   $"Complemento: {Complemento}\n" +
                   $"Número: {Numero}";
        }


    }
}
