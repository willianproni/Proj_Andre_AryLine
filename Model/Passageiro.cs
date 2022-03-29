using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Model
{
    public class Passageiro
    {
        #region Propriedades

        [JsonProperty("cpf")]
        public string? CPF { get; set; }

        [JsonProperty("nome")]
        public string? Nome { get; set; }

        [JsonProperty("telefone")]
        public string? Telefone { get; set; }

        [JsonProperty("DataNascimento")]
        public DateTime? DataNasc { get; set; }

        [JsonProperty("email")]
        public string? Email { get; set; }

        [JsonProperty("endereco")]
        public  int? Endereco { get; set; }

        #endregion

        public Passageiro(string cpf, string nome, string telefone, DateTime dataNasc, string email, int endereco)
        {
            CPF = cpf;
            Nome = nome;
            Telefone = telefone;
            DataNasc = dataNasc;
            Email = email;
            Endereco = endereco;
        }
        public Passageiro()
        {
        }

        public override string ToString()
        {
            return $"\n\nNome: {Nome}\n" +
                   $"CPF: {CPF}\n" +
                   $"Telefone: {Telefone}\n" +
                   $"Data Nascimento: {DataNasc}\n" +
                   $"Email: {Email}\n" +
                   $"Endereço: {Endereco}";
        }


    }
}
