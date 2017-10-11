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
    //进行投票
    protected void Button1_Click(object sender, EventArgs e)
    {
        //判断指定的IP是否已经投过票，如果投过票则弹出提示对话框
        string UserIP = Request.UserHostAddress.ToString();
        HttpCookie oldCookie = Request.Cookies["userIP"];
        int VoteID = Convert.ToInt32(RadioButtonList1.SelectedIndex.ToString()) + 1;
        if (oldCookie == null)
        {
            UpdateVote(VoteID);
            Response.Write("<script>alert('投票成功，谢谢参与！')</script>");
            //定义新的Cookie对象
            HttpCookie newCookie = new HttpCookie("userIP");
            newCookie.Expires = DateTime.MaxValue;
            //添加新的Cookie变量IPAddress，值为UserIP
            newCookie.Values.Add("IPAddress", UserIP);
            //将变量写入Cookie文件中
            Response.AppendCookie(newCookie);
            return;
        }
        else
        {
            string userIP = oldCookie.Values["IPAddress"];
            if (UserIP.Trim() == userIP.Trim())
            {
                Response.Write("<script>alert('同一个IP地址不能重复投票！！');history.go(-1);</script>");
                return;
            }
            else 
            {
                //定义新的Cookie对象
                HttpCookie newCookie = new HttpCookie("userIP");
                //添加新的Cookie变量IPAddress，值为UserIP
                newCookie.Values.Add("IPAddress", UserIP);
                newCookie.Expires = DateTime.MaxValue;
                //将变量写入Cookie文件中
                Response.AppendCookie(newCookie);
                UpdateVote(VoteID);
                Response.Write("<script>alert('投票成功，谢谢参与！')</script>");
                return;
            }
        }
    }
}