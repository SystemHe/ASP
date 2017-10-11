using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MainMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MainLabelMaster.Text = "今天是：" + DateTime.Now.Year + "年" + DateTime.Now.Month + "月" + DateTime.Now.Day + "日，" + DateTime.Now.DayOfWeek;
    }

    string mValue = "";
    public string MValue
    {
        get { return mValue; }
        set { mValue = value; }
    }
}
