<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>第一页</title>
    <link href="StyleSheet.css" rel="Stylesheet" type="text/css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>HellowWorld</h1>
        <div class="loginbody">
        <div class="title">
            <asp:Label ID="Label" runat="server" Text="会员登录" CssClass="Label"></asp:Label>
        </div>

        <div class="login">
            <asp:Label ID="Label1" runat="server" Text="用户名："></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" TextMode="SingleLine"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="用户名不能为空！" ControlToValidate="TextBox1" SetFocusOnError="True"></asp:RequiredFieldValidator><br />
            <asp:Label ID="Label2" runat="server" Text="密  码："></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox><br />
            <asp:Label ID="Label5" runat="server" Text="确认密码："></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="确认密码与输入密码不匹配！" ControlToValidate="TextBox3" ControlToCompare="TextBox2" SetFocusOnError="False"></asp:CompareValidator><br />
            <asp:Label ID="Label6" runat="server" Text="出生日期："></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="日期格式有误！" ControlToValidate="TextBox4" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator><br />
            <asp:Label ID="Label7" runat="server" Text="邮箱："></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="邮箱格式有误！" ControlToValidate="TextBox5" ValidationExpression="\w+([-+'.]\w+)*@\w+(([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="确认" onclick="Button1_Click" />
            <asp:Button ID="Button3" runat="server" Text="重置" onclick="Button3_Click" />           
        </div>
        </div>
        <div class="fileupload">
            <asp:Label ID="Label3" runat="server" Text="选择上传文件："></asp:Label>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:Button ID="Button2" runat="server" Text="上传" onclick="Button2_Click" /><br /><br />
            <asp:Image ID="Image1" runat="server" /><br /><br />
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        </div>
    </div>
    </form>
</body>
</html> 
            
