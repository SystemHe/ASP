using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string name=Request.Params["Name"];
        Response.Write("欢迎用户："+name);
        Label3.Text = "你是第" + Application["count"].ToString() + "个访问该网页的人";
        Label3.Text += "<br/>"+"您登录的时间为：" + Session["LoginTime"].ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string upName = FileUpload1.FileName;
            string nameLast = upName.Substring(upName.LastIndexOf('.'));
            string fileName = TextBox1.Text + nameLast;
            string path = Server.MapPath("./File/") + fileName;
            FileUpload1.PostedFile.SaveAs(path);
            ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('上传成功！')</script>");
        }
        catch(Exception ex)
        {
            Response.Write(ex.Message.ToString());
            ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('上传失败！')</script>");
        }
    }
    protected void button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default3.aspx?Value=获取页面间的传值内容！");
    }
}