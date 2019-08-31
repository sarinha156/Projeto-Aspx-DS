<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Projeto.aspx.cs" Inherits="WebAppProjeto.WebApp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <div>
                    ID: 
                </div>
                <br />

                <div>
                    <asp:TextBox ID="txtId" runat="server" Width="148px"></asp:TextBox>
                    <br />
                </div>

            </div>
            <br />

              <div>
                <div>
                    Nome:
                </div>
                <br />

                <div>
                    <asp:TextBox ID="txtNome" runat="server" Width="148px"></asp:TextBox>
                    <br />
                </div>

            </div>
            <br />

              <div>
                <div>
                    Descrição:
                </div>
                <br />

                <div>
                    <asp:TextBox ID="txtDescricao" runat="server" Width="148px"></asp:TextBox>
                    <br />
                </div>

            </div>
            <br />

              <div>
                <div>
                    Url:
                </div>
                <br />

                <div>
                    <asp:TextBox ID="txtUrl" runat="server" Width="148px"></asp:TextBox>
                    <br />
                </div>

            </div>
            <br />

              <div>
                <div>
                    Plataforma:
                </div>
                <br />

                <div>
                    <asp:TextBox ID="txtPlataforma" runat="server" Width="148px"></asp:TextBox>
                    <br />
                </div>

            </div>
            <br />


             <div>
                <div>
                        Público Alvo:
                </div>
                <br />

                <div>
                    <asp:TextBox ID="txtPublicoAlvo" runat="server" Width="148px"></asp:TextBox>
                    <br />
                </div>

            </div>
            <br />

            <div>
                <div>
                    Principais Concorrentes:
                </div>
                <br />

                <div>
                    <asp:TextBox ID="txtPrincipaisConcorrentes" runat="server" Width="148px"></asp:TextBox>
                    <br />
                </div>

            </div>
            <br />


              <div>
                <div>
                    Política de Comercialização:
                </div>
                <br />

                <div>
                    <asp:TextBox ID="txtPoliticaComercializacao" runat="server" Width="148px"></asp:TextBox>
                    <br />
                </div>

            </div>
            <br />

            <div>
                    <div>
                        Custo Estimado:
                    </div>
                <br />

                <div>
                    <asp:TextBox ID="txtCustoEstimado" runat="server" Width="148px"></asp:TextBox>
                    <br />
                </div>

            </div>
            <br />


            <div>
                <div>
                      Media Final:
                </div>
                <br />

                <div>
                    <asp:TextBox ID="txtMediaf" runat="server" Width="148px"></asp:TextBox>
                    <br />
                </div>

            </div>
            <br />



            <div>
                <div>
                        Data Inclusão: 
                </div>
                <br />

                <div>
                    <asp:TextBox ID="txtDataInclusao" runat="server" Width="148px" OnTextChanged="txtDataInclusao_TextChanged"></asp:TextBox>
                    <br />
                </div>

            </div>
            <br />

            <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
            <asp:Label ID="lblMensagem" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
