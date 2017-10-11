using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string url = Request.Path + "?theme=" + DropDownList1.SelectedItem.Value;
        Response.Redirect(url);
    }
    protected void Page_PreInit(object sender, EventArgs e)
    {
        string theme = "TextBoxSkin";
        if (Request.QueryString["theme"] == null)
        {
            theme = "TextBoxSkin";
        }
        else
        {
            theme = Request.QueryString["theme"];
        }
        Page.Theme = theme;
        ListItem item = DropDownList1.Items.FindByValue(theme);
        if (item != null)
        {
            item.Selected = true;
        }
    }
}