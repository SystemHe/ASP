<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>第二页</title>
    <link href="StyleSheet.css" rel="Stylesheet" type="text/css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>第二页</h1>
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    <div class="fileupload">
        <asp:Label ID="Label1" runat="server" Text="上传文件名称："></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </div>
    <div class="fileupload">
        <asp:Label ID="Label2" runat="server" Text="选择要上传的文件："></asp:Label>
        <asp:FileUpload ID="FileUpload1" runat="server" />
    </div>
    <div>
        <asp:Button ID="Button1" runat="server" Text="提交" onclick="Button1_Click" />
        <asp:Button ID="Button3" runat="server" Text="传值" onclick="button3_Click"/>
    </div>
    </div>
    </form>
</body>
</html>
