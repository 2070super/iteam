<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TableCss.aspx.cs" Inherits="Ex2_TableCss" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../Style/Table.css" rel="stylesheet"  type="text/css" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td rowspan="2" style="width:100px;">
                    <asp:Image ID="imgLogo" runat="server" ImageUrl="~/img/logo.jpeg" style="height: 16px" />
                </td>
                <td class="navigation">
                    <asp:LinkButton ID="InkbtnDefault" runat="server" ForeColor="White" OnClick="LinkButton1_Click">首页</asp:LinkButton>
                </td >
                <td class="navigation">
                    <asp:LinkButton ID="InkbtnRegister" runat="server" ForeColor="White" OnClick="LinkButton2_Click">注册</asp:LinkButton>
                </td>
                <td class="navigation">
                    <asp:LinkButton ID="InkbtnLogin" runat="server" ForeColor="White" OnClick="LinkButton3_Click">登录</asp:LinkButton>
                </td>
                <td class="navigation">
                    <asp:LinkButton ID="InkbtnCart" runat="server" ForeColor="White" OnClick="LinkButton4_Click">购物车</asp:LinkButton>
                </td>
                <td class="navigation" >
                    <asp:LinkButton ID="InkbtnSiteMap" runat="server" ForeColor="White" OnClick="LinkButton5_Click">网站地图</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="status"colspan="5">登录状态</td>
            </tr>
            <tr>
                <td class="position" colspan="6">您的位置</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
