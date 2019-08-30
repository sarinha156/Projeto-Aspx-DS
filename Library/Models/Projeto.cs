using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    class Projeto
    {
        private int id;
        private string nome;
        private string descricao;
        private string url;
        private string plataforma;
        private string publicoAlvo;
        private string principaisConcorrentes;
        private string politicasDeComercializacao;
        private decimal custoEstimado;
        private char mediaFinal;
        private int dataInclusao;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Url { get => url; set => url = value; }
        public string Plataforma { get => plataforma; set => plataforma = value; }
        public string PublicoAlvo { get => publicoAlvo; set => publicoAlvo = value; }
        public string PrincipaisConcorrentes { get => principaisConcorrentes; set => principaisConcorrentes = value; }
        public string PoliticasDeComercializacao { get => politicasDeComercializacao; set => politicasDeComercializacao = value; }
        public decimal CustoEstimado { get => custoEstimado; set => custoEstimado = value; }
        public char MediaFinal { get => mediaFinal; set => mediaFinal = value; }
        public int DataInclusao { get => dataInclusao; set => dataInclusao = value; }
    }
}
