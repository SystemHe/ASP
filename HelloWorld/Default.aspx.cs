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
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "he" && TextBox2.Text == "123")
        {
            string name = TextBox1.Text;
            Session["LoginTime"]= DateTime.Now;
            Response.Redirect("~/Default2.aspx?Name="+name);
        }
        else
        {
            Response.Write("<script>alert('不成功！')</script>");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        bool filelsValid = false;
        if (this.FileUpload1.HasFile)
        {
            //获取上传文件的后缀名
            string fileExtension = System.IO.Path.GetExtension(this.FileUpload1.FileName);
            string[] restrictExtension = { ".gif", ".jpg", ".bmp", ".png" };
            //判断文件类型是否符合要求
            for (int i = 0; i < restrictExtension.Length; i++)
            {
                if (fileExtension == restrictExtension[i])
                {
                    filelsValid = true;
                }
            }
            //如果文件符合要求则调用SaveAs方法实现上传并显示相关信息
            if (filelsValid == true)
            {
                try
                {
                    this.Image1.ImageUrl = "~/images/" + FileUpload1.FileName;
                    this.FileUpload1.SaveAs(Server.MapPath("~/images/") + FileUpload1.FileName);
                    this.Label4.Text = "文件上传成功！";
                    this.Label4.Text += "<br/>";
                    this.Label4.Text += "<li>" + "源文件路径：" + this.FileUpload1.PostedFile.FileName;
                    this.Label4.Text += "<br/>";
                    this.Label4.Text += "<li>" + "文件大小：" + this.FileUpload1.PostedFile.ContentLength + "字节";
                    this.Label4.Text += "<br/>";
                    this.Label4.Text += "<li>" + "文件类型：" + this.FileUpload1.PostedFile.ContentType;
                }
                catch(Exception ex)
                {
                    this.Label4.Text = ex.ToString();
                    //this.Label4.Text = "文件上传不成功！";
                }
            }
            else
            {
                this.Label4.Text = "只能上传格式为 .gif, .jpg, .bmp, .png 的文件!";
            }
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
    }
}