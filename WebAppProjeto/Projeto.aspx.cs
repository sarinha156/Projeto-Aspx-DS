using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppProjeto
{
    public partial class WebApp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Projeto E = new Projeto();
            E.Id = Convert.ToInt32(txtId.Text);
            E.Nome = Convert.ToString(txtNome.Text);
            E.Descricao = Convert.ToString(txtDescricao.Text);
            E.Url = Convert.ToString(txtUrl.Text);
            E.Plataforma= Convert.ToString(txtPlataforma.Text);
            E.PublicoAlvo = Convert.ToString(txtPublicoAlvo.Text);
            E.PrincipaisConcorrentes = Convert.ToString(txtPrincipaisConcorrentes.Text);
            E.PoliticasDeComercializacao = Convert.ToString(txtPoliticaComercializacao.Text);
            E.CustoEstimado = Convert.ToDecimal(txtCustoEstimado.Text);
            E.MediaFinal = Convert.ToChar(txtMediaf.Text);
            E.DataInclusao = Convert.ToDateTime(txtDataInclusao.Text);
            lblMensagem.Text = Convert.ToString(E.Exibir());


        }

        protected void txtDataInclusao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}