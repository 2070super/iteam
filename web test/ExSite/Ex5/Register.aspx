<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Ex5_Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td style="text-align: right">用户名：</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" Display="Dynamic" ErrorMessage="请输入用户名！" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="text-align: right">密码：</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword" Display="Dynamic" ErrorMessage="请输入密码！" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="text-align: right">确认密码：</td>
                <td>
                    <asp:TextBox ID="txtPasswordAgain" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvPasswordAgain" runat="server" ControlToValidate="txtPasswordAgain" Display="Dynamic" ErrorMessage="请输入密码！" SetFocusOnError="True">*</asp:RequiredFieldValidator>
&nbsp;<asp:CompareValidator ID="cvPassword" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtPasswordAgain" Display="Dynamic" ErrorMessage="密码与确认密码不一致" SetFocusOnError="True"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td style="text-align: right">生日：</td>
                <td>
                    <asp:TextBox ID="txtBirthday" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvBirthday" runat="server" ControlToValidate="txtBirthday" Display="Dynamic" ErrorMessage="请输入生日！" SetFocusOnError="True">*</asp:RequiredFieldValidator>
&nbsp;<asp:RangeValidator ID="rvBirthday" runat="server" ControlToValidate="txtBirthday" Display="Dynamic" ErrorMessage="日期应在1900-1-1到2020-1-1之间！" MaximumValue="2020-1-1" MinimumValue="1900-1-1" SetFocusOnError="True" Type="Date"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td style="text-align: right">电话号码：</td>
                <td>
                    <asp:TextBox ID="txtTelephone" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvTelephone" runat="server" ControlToValidate="txtTelephone" Display="Dynamic" ErrorMessage="请输入电话号码！" SetFocusOnError="True">*</asp:RequiredFieldValidator>
&nbsp;
                    <asp:RegularExpressionValidator ID="revTelephone" runat="server" ControlToValidate="txtTelephone" Display="Dynamic" ErrorMessage="电话号码的格式应为021-1112224！" SetFocusOnError="True" ValidationExpression="\d{3}-\d{8}"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="text-align: right">身份证号：</td>
                <td>
                    <asp:TextBox ID="txtIdentity" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvIdentity" runat="server" ErrorMessage="请输入身份证号码" ControlToValidate="txtIdentity" Display="Dynamic" SetFocusOnError="True">*</asp:RequiredFieldValidator>
&nbsp;<asp:CustomValidator ID="csvIdentity" runat="server" ControlToValidate="txtIdentity" Display="Dynamic" ErrorMessage="身份证号码错误" OnServerValidate="csvIdentity_ServerValidate" SetFocusOnError="True"></asp:CustomValidator>
                </td>
            </tr>
        </table>
        <div>
        </div>
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="确定" />
        <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label>
        <asp:ValidationSummary ID="vsSubmit" runat="server" ShowMessageBox="True" ShowSummary="False" />
    </form>
</body>
</html>
