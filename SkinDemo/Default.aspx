<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Theme="TextBoxSkin"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
    <tr>
    <td>选择主题：</td>
    <td>
        <asp:DropDownList ID="DropDownList1" runat="server" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="TextBoxSkin">主题一</asp:ListItem>
            <asp:ListItem Value="Theme2">主题二</asp:ListItem>
        </asp:DropDownList>
    </td>
    </tr>
    <tr>
        <td style="width:100px">默认外观：</td>
        <td style="width:250px">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td style="width:100px">命名外观：</td>
        <td style="width:250px">
            <asp:TextBox ID="TextBox2" runat="server" SkinID="textboxSkin"></asp:TextBox></td>
    </tr>
    <tr>
        <td style="width:100px">
            <a href="Default.aspx">测试主题1</a>
        </td>
        <td style="width:100px">
            <a href="Default.aspx">测试主题2</a>
        </td>
    </tr>
    <tr>
        <td style="width:100px">
            <input id="Button1" type="button" value="Button"/>
        </td>
        <td style="width:100px"></td>
    </tr>
    </table>
    </div>
    </form>
</body>
</html>
