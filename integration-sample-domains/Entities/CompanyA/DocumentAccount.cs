using System.Collections.Generic;

namespace integration_sample_domains.Entities.CompanyA
{
    public class DocumentAccount
    {
        public bool EmModoEdicao { get; set; }
        public int Ano { get; set; }
        public int Numerador { get; set; }
        public string Documento { get; set; }
        public string Descricao { get; set; }
        public string Diario { get; set; }
        public bool BalFinanceira { get; set; }
        public string TipoLancamento { get; set; }
        public bool IntegraCCT { get; set; }
        public int DataIntegracaoCCT { get; set; }
        public List<Linhasdocumento> LinhasDocumento { get; set; } = new List<Linhasdocumento>();
    }

    public class Linhasdocumento
    {
        public string Documento { get; set; }
        public string Conta { get; set; }
        public string Natureza { get; set; }
        public int Grupo { get; set; }
        public bool Repete { get; set; }
        public bool PoeValor { get; set; }
        public bool EmModoEdicao { get; set; }
        public bool SujeitaDuodecimos { get; set; }
        public int Ano { get; set; }
        public string DescricaoEntidade { get; set; }
    }

}