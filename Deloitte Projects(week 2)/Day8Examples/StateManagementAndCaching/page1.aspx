<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page1.aspx.cs" Inherits="StateManagementAndCaching.page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border-style: solid;
            border-width: 1px;
            background-color: #CCFFCC;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table cellpadding="10" cellspacing="15" class="auto-style1">
            <tr>
                <td>Enter Name</td>
                <td>
                    <asp:TextBox ID="txtname" runat="server" Height="20px" Width="201px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Enter Age</td>
                <td>
                    <asp:TextBox ID="txtage" runat="server" Height="20px" Width="201px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Enter Email</td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <td>
                    <asp:TextBox ID="txtemail" runat="server" Height="20px" Width="201px"></asp:TextBox>
                </td>
            </tr>
        </table>
    
    </div>
        <asp:Button ID="Button1" runat="server" BorderStyle="Solid" BorderWidth="5px" Height="48px" OnClick="Button1_Click" Text="Query String" Width="147px" />
    </form>
</body>
</html>
