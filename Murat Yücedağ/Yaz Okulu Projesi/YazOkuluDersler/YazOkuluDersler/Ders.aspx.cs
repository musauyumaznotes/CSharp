using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ders : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack==false)
        {
            dropList.DataSource = DersManager.DersListele();
            dropList.DataTextField = "Ad";
            dropList.DataValueField = "Id";
            dropList.DataBind();

            
        }
    }

    protected void Unnamed3_Click(object sender, EventArgs e)
    {
        txtId.Text = dropList.SelectedValue.ToString();
    }
}