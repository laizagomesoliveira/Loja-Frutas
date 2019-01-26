using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Classes.BL;

public partial class Admin_Produtos_Cadastrar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        Classes.VO.Fruta fruta =  new Classes.VO.Fruta () ;
        fruta.Nome = txtNomefruta.Text;
        Fruta.Cadastrar(fruta,Server.MapPath("/Dados")+"/Frutas.csv");
    }
}