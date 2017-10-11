using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SubMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Master.MValue = "***Welcome!";
    }

    protected void LabelMaster_PreRender1(object sender, EventArgs e)
    {
        Label MLabel = (Label)this.Master.FindControl("MainLabelMaster");
        LabelMaster.Text = MLabel.Text;
    }
}
