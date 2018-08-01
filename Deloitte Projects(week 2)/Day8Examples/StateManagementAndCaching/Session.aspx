<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Session.aspx.cs" Inherits="StateManagementAndCaching.Session" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 17px solid #000000;
            background-color: #CCCCCC;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table cellpadding="10" cellspacing="20" class="auto-style1">
            <tr>
                <td>Enter Name</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Height="26px" Width="138px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Enter Age</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Height="26px" Width="138px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Height="29px" OnClick="Button1_Click" Text="Redirect" Width="78px" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
