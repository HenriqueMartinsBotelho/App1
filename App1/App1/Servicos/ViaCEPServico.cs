using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App1.Servicos.Modelo;
using Newtonsoft.Json;

namespace App1.Servicos
{
    public class ViaCEPServico
    {
        private static string EnderecoURL = "http://viacep.com.br/ws/{0}/json/";
        public static Endereco BuscarEnderecoViaCEP(string cep)
        {
            string NovoEnderecoURL = string.Format(EnderecoURL, cep);
            WebClient wc = new WebClient();
            string Conteudo = wc.DownloadString(NovoEnderecoURL);
            Endereco end = JsonConvert.DeserializeObject<Endereco>(Conteudo)  ;
            return end; 
        }
    }
}
