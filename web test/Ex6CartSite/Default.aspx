<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBoxList ID="chklsPet1" runat="server">
                <asp:ListItem>波斯猫</asp:ListItem>
            </asp:CheckBoxList>
            <asp:CheckBoxList ID="chklsPet2" runat="server">
                <asp:ListItem>千里马</asp:ListItem>
            </asp:CheckBoxList>
            <asp:CheckBoxList ID="chklsPet3" runat="server">
                <asp:ListItem>哈士奇</asp:ListItem>
            </asp:CheckBoxList>
            <asp:CheckBoxList ID="chklsPet4" runat="server">
                <asp:ListItem>斑马</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:Button ID="btnBuy" runat="server" Text="放入购物车" Width="120px" OnClick="btnBuy_Click" />
            <asp:Button ID="btnView" runat="server" Text="查看购物车" Width="120px" OnClick="btnView_Click" />
        </div>
    </form>
</body>
</html>
