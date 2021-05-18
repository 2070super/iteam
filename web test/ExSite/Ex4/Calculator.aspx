<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Calculator.aspx.cs" Inherits="Ex4_Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center">简易计算器</div>
        <p>
            <asp:TextBox ID="txtDisplay" runat="server" ReadOnly="True" Width="110px"></asp:TextBox>
        </p>
        <asp:Button ID="btnOne" runat="server" Text="1" OnClick="btnOne_Click" Width="40px" />
        <asp:Button ID="btnTwo" runat="server" Text="2" OnClick="Button2_Click" Width="40px" />
        <asp:Button ID="btnThree" runat="server" Text="3" OnClick="btnThree_Click" Width="40px" />
        <p>
            <asp:Button ID="btnAdd" runat="server" Text="+" OnClick="btnAdd_Click" Width="40px" />
            <asp:Button ID="btnstract" runat="server" Text="-" OnClick="Button5_Click" Width="40px" />
            <asp:Button ID="btnEqual" runat="server" Text="=" OnClick="btnEqual_Click" Width="40px" />
        </p>
    </form>
</body>
</html>
