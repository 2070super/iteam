<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Chat.aspx.cs" Inherits="Chat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src =" Scripts/jquery-3.0.0.min.js"></script>
    <script type="text/javascript">
        function refresh() {
            $.ajax({
                url: "Ajax.Aspx",
                cache: flase,
                success: function (text) {
                    document.getElementById("divMsg").innerHTML = text;
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    alert("网络连接有问题，请重试！");
                }
            });
            setTimeout("refresh()", 500);
        }
    </script>
        
</head>
<body>
    <form id="form1" runat="server">
        <div id="divMsg">

            </div>
        <div>
            <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:TextBox ID="txtMessage" runat="server" Height="69px" TextMode="MultiLine"></asp:TextBox>
            <br />
            <asp:Button ID="btnSend" runat="server" Text="发送" OnClick="btnSend_Click" />
        </div>
    </form>
</body>
</html>
