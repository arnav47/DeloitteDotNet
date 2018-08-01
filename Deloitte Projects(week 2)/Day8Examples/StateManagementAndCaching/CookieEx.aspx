<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookieEx.aspx.cs" Inherits="StateManagementAndCaching.CookieEx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border-style: solid;
            border-width: 2px;
            background-color: #FFFFCC;
        }
        .auto-style2 {
            height: 78px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <table cellpadding="10" cellspacing="20" class="auto-style1">
            <tr>
                <td class="auto-style2">Enter Username</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtusername" runat="server" BorderStyle="Dotted" BorderWidth="5px" Height="26px" OnTextChanged="TextBox1_TextChanged" Width="164px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Enter Password</td>
                <td>
                    <asp:TextBox ID="txtpassword" runat="server" BorderStyle="Dashed" BorderWidth="5px" Height="26px" Width="164px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnadd" runat="server" BackColor="#FFCC66" BorderStyle="Dotted" BorderWidth="3px" Height="38px" OnClick="btnadd_Click" Text="Add Cookie" Width="92px" />
                </td>
                <td>
                    <asp:Button ID="btnread" runat="server" BackColor="#FFCC99" BorderStyle="Dashed" BorderWidth="3px" Height="36px" OnClick="btnread_Click" Text="Read Cookie" Width="84px" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
