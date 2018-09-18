using System.Collections.Generic;

namespace sia.Models
{
    public class ResultadoAnualEntityModel
    {
        
        public List<int> Anos { get; set; }

        public List<int> VendasAnuais { get; set; }

        public List<int> ValoresAnuais { get; set; }

        public ResultadoAnualEntityModel()
        {
            Anos = new List<int>();
            VendasAnuais = new List<int>();
            ValoresAnuais = new List<int>();
        }
    }
}