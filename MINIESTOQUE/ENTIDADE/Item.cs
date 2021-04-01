using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace MINIESTOQUE.ENTIDADE
{
    [Serializable]
    public class Item
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Linha { get; set; }
        public string Cor { get; set; }
        public int Codg { get; set; }
        public string Fornecedor { get; set; }
        public double Largura { get; set; }
        public bool Plano { get; set; }
        public double Quantidade { get; set; }
        public string UND { get; set; }
    }
}
