using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class q2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        productservice sh= new productservice();
        sh.addData(this.productc.Text, double.Parse(this.price.Text), int.Parse(this.supplier.Text), this.picture.Text);
    }
}