using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace File
{
    public class ReadFile
    {
        public static List<Passageiro>? RecebePassageiro(string FilePassageiro)
        {
            StreamReader leitura = new StreamReader(FilePassageiro);
            string jsonPassageiro = leitura.ReadToEnd();
            var lista = JsonConvert.DeserializeObject<List<Passageiro>>(jsonPassageiro) as List<Passageiro>;
            if (lista != null)
                return lista;
            return null;
        }
        public static List<Endereco>? RecebeEndereco(string FileEndereco)
        {
            StreamReader leitura = new StreamReader(FileEndereco);
            string jsonEndereco = leitura.ReadToEnd();
            var lista = JsonConvert.DeserializeObject<List<Endereco>>(jsonEndereco);
            if (lista != null)
                return lista;
            return null;
        }

        public static List<Aeronave>? RecebeAeronave(string FileAeronave)
        {
            StreamReader leitura = new StreamReader(FileAeronave);
            string jsonAeronave = leitura.ReadToEnd();
            var lista = JsonConvert.DeserializeObject<List<Aeronave>>(jsonAeronave);
            if (lista != null)
                return lista;
            return null;
        }

        public static List<Aeroporto>? RecebeAeroporto(string FileAeroporto)
        {
            StreamReader leitura = new StreamReader(FileAeroporto);
            string JsonAeroporto = leitura.ReadToEnd();
            var lista = JsonConvert.DeserializeObject<List<Aeroporto>>(JsonAeroporto);
            if (lista != null)
                return lista;
            return null;
        }
    }
}
