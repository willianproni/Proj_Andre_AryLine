using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using File;
using Data;
using System.Globalization;

namespace Porj_Andre_Arlines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadBd banco = new ReadBd();
            string opc;

            do
            {
                Menu();
                opc = Console.ReadLine();
                switch (opc)
                {
                    case "1":
                        banco.TodosOsVoosBrasil();
                        break;
                    case "2":
                        
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Digite uma Opçaõ válida");
                        break;
                }
            } while (opc != "0");


            

            #region Endereço
            
            string fileEndereco = @"C:\5by5\andre_airline\andre_aryline.json";

            var listaEndereco = ReadFile.RecebeEndereco(fileEndereco);

            if (listaEndereco != null)
            {
                var consultaEndereco = (from dados in listaEndereco
                                        select dados);

                foreach (var endereco in consultaEndereco)
                {
                    //Console.WriteLine(endereco.ExibiEndereco());
                    //banco.InserirEndereco(endereco);
                }
            }

            #endregion

            #region Passageiro
            string filePassageiro = @"C:\5by5\andre_airline\andre_aryline.json";

            var listaPassageiro = ReadFile.RecebePassageiro(filePassageiro);

            if (listaPassageiro != null)
            {
                var consultaPassageiro =
                                (from dados in listaPassageiro
                                 select dados);

                foreach (var passageiros in consultaPassageiro)
                {
                    //Console.WriteLine(passageiros.ToString());
                    //banco.InserirPassageiro(passageiros);
                }
            }
            Console.WriteLine("fim");

            #endregion

            #region Aeronave
            string fileAeronave = @"C:\5by5\andre_airline\andre_aryline.json";

            var listaAeronave = ReadFile.RecebeAeronave(fileAeronave);

            if (listaAeronave != null)
            {
                var consultaAeronave = (from dados in listaAeronave
                                        select dados);

                foreach (var aeronave in consultaAeronave)
                {
                    //Console.WriteLine(aeronave.ToString());
                    //banco.InserirAeronave(aeronave);
                }
            }
            #endregion

            #region Aeroporto
            string fileAeroporto = @"C:\5by5\andre_airline\andre_aryline.json";

            var listaAeroporto = ReadFile.RecebeAeroporto(fileAeroporto);

            if (listaAeronave != null)
            {
                var consultaAeroporto = (from dados in listaAeroporto
                                         select dados);

                foreach (var aeroporto in consultaAeroporto)
                {
                    //Console.WriteLine(aeroporto.ToString());
                    //banco.InserirAeroportoOrigem(aeroporto);
                    //banco.InserirAeroportoDestino(aeroporto);
                }
            }

            #endregion

            string fileVoo = @"C:\5by5\andre_airline\andre_aryline.json";

            var listaVoo = ReadFile.RecebeVoo(fileVoo);

            if (listaVoo != null)
            {
                var consultaVoo = (from dados in listaVoo
                                   select dados);

                foreach (var voo in consultaVoo)
                {
                    //Console.WriteLine(voo.ToString());
                    //banco.InserirVoo(voo);
                }
            }
        }

        public static void Menu()
        {
            Console.WriteLine("----------------------------------------\n" +
                              "[1] - Todos os destinos e origens de Hoje\n" +
                              "[2] - Todos os Voos realizados no Brasil\n" +
                              "[0] - Sair" +
                              "\n------------------------------------------");
            Console.Write("Opção: ");
        }
    }
}

