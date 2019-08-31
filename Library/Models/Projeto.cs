using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Projeto
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
        private DateTime dataInclusao;

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
        public DateTime DataInclusao { get => dataInclusao; set => dataInclusao = value; }

        public string Exibir()
        {
            string mensagem = string.Format("<br>Id: {0} <br> Nome: {1}<br>  Descrição: {2} <br> Url: {3}<br> Plataforma: {4}<br> Público Alvo: {5} <br>" +
                " Principais Concorrentes: {6} <br>Politicas De Comercializacao: {7} <br> Custo Estimado: {8} <br>" +
                "Media Final: {9} <br> DataInclusao: {10}  ", Id, Nome, Descricao, Url, publicoAlvo, plataforma, 
                principaisConcorrentes,PoliticasDeComercializacao, custoEstimado,mediaFinal,dataInclusao);
            return mensagem;
            //return mensagemFormatada;
        }
    }

  

}
