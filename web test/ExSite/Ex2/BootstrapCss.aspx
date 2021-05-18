<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BootstrapCss.aspx.cs" Inherits="Ex2_BootstrapCss" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../Content/bootstrap.css" rel="stylesheet" type="text/css"/>
    <link href="../Style/Style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <header class="header">
            <asp:Image ID="imgLogo" runat="server" ImageURL="~/img/logo.jpeg" style="width:16px;" />
            <ul class="nav nav-pills ">
                <li class="navDark">
                    <asp:LinkButton ID="InkbtnDefault" runat="server">首页</asp:LinkButton>
                </li>
                <li  class="navDark">
                    <asp:LinkButton ID="InkbtnRegister" runat="server">注册</asp:LinkButton>
                </li>
                <li  class="navDark">
                    <asp:LinkButton ID="InkbtnLogin" runat="server">登录</asp:LinkButton>
                </li>
                <li  class="navDark">
                    <asp:LinkButton ID="InkbtnCart" runat="server">购物车</asp:LinkButton>
                </li>
                <li  class="navDark">
                    <asp:LinkButton ID="InkbtnSiteMap" runat="server">网站地图</asp:LinkButton>
                </li>
            </ul>
            <div class="status">
                登录状态
            </div>
        </header>
        <nav class="sitemap">您的位置</nav>
    </form>
</body>
</html>
