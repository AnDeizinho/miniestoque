using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace MINIESTOQUE.ENTIDADE
{
    public enum Tipo { Novo, Alterar }
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
        public string Endereco { get; set; }
        public override string ToString()
        {
            return string.Format("id={0} Desc={1} cor={2}", Id, Descricao, Cor);
        }
    }
}
