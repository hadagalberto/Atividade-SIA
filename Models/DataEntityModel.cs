using System;

namespace sia.Models
{

    public class DataEntityModel{

        public int Id {get;set;}

        public DateTime DataHora {get;set;}

        public string Loja { get; set; }

        public string Tipo { get; set; }

        public int Valor {get;set;}

    }
    
}