using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("使用Request[String key]方法" + Request["Value"] + "<br/>");
        Response.Write("使用Request.Params[String key]方法" + Request.Params["Value"] + "<br/>");
        Response.Write("使用Request.QueryString[String key]方法" + Request.QueryString["Value"] + "<br/>");
        Response.Write("<hr>");
        HttpBrowserCapabilities b = Request.Browser;
        Response.Write("获取浏览器信息：");
        Response.Write("<hr>");
        Response.Write("类型："+b.Type+"<br/>");
        Response.Write("名称："+b.Browser+"<br/>");
        Response.Write("版本："+b.Version+"<br/>");
        Response.Write("操作平台：" + b.Platform+ "<br/>");
        Response.Write("是否支持框架：" + b.Frames + "<br/>");
        Response.Write("是否支持表格：" + b.Tables + "<br/>");
        Response.Write("是否支持Cookies：" + b.Cookies+ "<br/>");
        Response.Write("<hr>");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string UserIP = Request.UserHostAddress.ToString();
        Response.Cookies["IP"].Value = UserIP;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        this.Label1.Text = Request.Cookies["IP"].Value;
    }
}