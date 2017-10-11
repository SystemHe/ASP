<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="Stylesheet" type="text/css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td class="title">投票</td>
        </tr>
        <tr>
            <td class="question">您喜欢哪位明星？</td>
        </tr>
        <tr>
            <td>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem>赵XX</asp:ListItem>
                    <asp:ListItem>王XX</asp:ListItem>
                    <asp:ListItem>李XX</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="button">
                <asp:Button ID="Button1" runat="server" Text="投票" onclick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Text="查看结果" />
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
