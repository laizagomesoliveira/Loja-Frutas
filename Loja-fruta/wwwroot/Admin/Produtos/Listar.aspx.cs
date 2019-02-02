using Classes.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Produtos_Listar : System.Web.UI.Page
{
    public List<Fruta> Frutas = new List<Fruta>() { new Fruta() { Nome="Banana" }, new Fruta() { Nome = "Laranja" } };
    protected void Page_Load(object sender, EventArgs e)
    {
        Listar();
    }
    public void Listar()
    {
        DdwProdutos.DataSource = Frutas;
        DdwProdutos.DataValueField = "Id";
        DdwProdutos.DataTextField = "Nome";
        DdwProdutos.DataBind();
    }
}