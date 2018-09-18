using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;
using sia.Models;

namespace sia.Service
{

    public class DataService
    {

        public List<DataEntityModel> ProcessarDados(IFormFile file)
        {
            var lista = new List<DataEntityModel>();
            var strList = new List<string>();
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                while (reader.Peek() >= 0)
                    strList.Add(reader.ReadLine());
            }
            strList.RemoveAt(0);
            strList.RemoveAt(0);
            foreach (var linha in strList)
            {
                string sep = "\t";
                string[] splitContent = linha.Split(sep.ToCharArray());
                var dataAtual = new DataEntityModel();
                dataAtual.Id = int.Parse(splitContent[0]);
                var stringDate = splitContent[1] + " " + splitContent[2];
                CultureInfo provider = CultureInfo.InvariantCulture;
                dataAtual.DataHora = DateTime.ParseExact(stringDate, "dd/MM/yyyy HH:mm:ss", provider);
                dataAtual.Loja = splitContent[3];
                dataAtual.Tipo = splitContent[4];
                dataAtual.Valor = int.Parse(splitContent[5]);
                lista.Add(dataAtual);
            }
            return lista;
        }

        public List<LojaEntityModel> GetLojas(List<DataEntityModel> lista)
        {
            var strList = new List<string>();
            var lojasList = new List<LojaEntityModel>();
            foreach(var row in lista)
            {
                strList.Add(row.Loja);
            }
            var lojas = strList.Distinct().ToList();
            foreach(var loja in lojas)
            {
                LojaEntityModel lojaAtual = new LojaEntityModel();
                lojaAtual.VendasTotais = lista.Where(l => l.Loja == loja).Count();
                lojaAtual.Nome = loja;
                lojaAtual.ValorVendido = lista.Where(l => l.Loja == loja).Select(l => l.Valor).Sum();
                lojasList.Add(lojaAtual);
            }

            return lojasList;
        }

        public List<int> GetAnos(List<DataEntityModel> lista)
        {
            var listaRetorno = new List<int>();

            var anos = lista.OrderBy(x => x.DataHora).Select(x => x.DataHora.Day).Distinct().ToList();

            foreach (var ano in anos)
            {
                listaRetorno.Add(ano);
            }

            return listaRetorno;
        }

        public int GetValoresPorAno(int ano, List<DataEntityModel> lista)
        {
            var retorno = 0;

            foreach(var valor in lista.OrderBy(x => x.DataHora).Where(x => x.DataHora.Day == ano).Select(x => x.Valor))
            {
                retorno += valor;
            }

            return retorno;
        }

        public int GetVendasPorAno(int ano, List<DataEntityModel> lista)
        {
            return lista.OrderBy(x => x.DataHora).Where(x => x.DataHora.Day == ano).Count();
        }
    }

}