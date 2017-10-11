using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Result : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public int FormateVoteCount(string voteCount)
    {
        int total = TotalNum();
        if (voteCount.Length <= 0)
        {
            return (0);
        }
        if (total > 0)
        {
            return (int.Parse(voteCount) * 100 / total);
        }
        return (0);
    }
}