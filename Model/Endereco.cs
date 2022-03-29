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
        [JsonProperty("id")]
        public int ID { get; set; }
        [JsonProperty("pais")]
        public string Pais { get; set; }

        [JsonProperty("cep")]
        public string Cep { get; set; }

        [JsonProperty("cidade")]
        public string Cidade { get; set; }

        [JsonProperty("estado")]
        public string Estado { get; set; }

        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }

        [JsonProperty("bairro")]
        public string Bairro { get; set; }
        [JsonProperty("complemento")]
        public string Complemento { get; set; }
        [JsonProperty("numero")]
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
            return $"País: {Pais}\n" +
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
