<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TableLay.aspx.cs" Inherits="Ex2_TableLay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
         a
         {
            text-decoration :none;
         }
    </style>
</head>
<body style="background-color: #616378; font-size: 12px; margin: 0px; text-align: center">
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1" style="padding: 4px 2px 2px 10px; background-color: #fff; height: 86px; margin: 0 auto; text-align: left; width: 778px;">
                <tr>
                    <td rowspan="2">
                        <asp:Image ID="imgLogo" runat="server" ImageUrl="~/img/logo.jpeg" style="width: 14px" />
                    </td>
                    <td style="background-color: #8c8ea3; text-align: center; width: 96.4px">
                        <asp:LinkButton ID="InkbtnDefault" runat="server">首页</asp:LinkButton>
                    </td>
                    <td style="background-color: #8c8ea3; text-align: center; width: 96.4px">
                        <asp:LinkButton ID="InkbtnRegister" runat="server" ForeColor="Black">注册</asp:LinkButton>
                    </td>
                    <td style="background-color: #8c8ea3; text-align: center; width: 96.4px">
                        <asp:LinkButton ID="InkbtnLogin" runat="server" ForeColor="Black">登录</asp:LinkButton>
                    </td>
                    <td style="background-color: #8c8ea3; text-align: center; width: 96.4px">
                        <asp:LinkButton ID="InkbtnCart" runat="server" ForeColor="Black">购物车</asp:LinkButton>
                    </td>
                    <td style="background-color: #8c8ea3; text-align: center; width: 96.4px">
                        <asp:LinkButton ID="InkbtnSiteMap" runat="server" ForeColor="Black">网站地图</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td colspan="5" style="background-color: #666688; color: #fff">登录状态</td>
                </tr>
                <tr>
                    <td colspan="6" style="background-color: #ccccd4; margin: 0 auto; padding-left: 6px; text-align: left; width: 778px">您的位置</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
