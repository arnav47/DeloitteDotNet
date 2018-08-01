<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertUserInfo.aspx.cs" Inherits="WebProjects.InsertUserInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 3px solid #3366CC;
            background-color: #CCFFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <table cellpadding="10" cellspacing="15" class="auto-style1">
            <tr>
                <td>Enter Name</td>
                <td>
                    <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Status</td>
                <td>
                    <asp:TextBox ID="txtstatus" runat="server" Enabled="False">Inactive</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btninsert" runat="server" Font-Bold="True" Font-Italic="False" Font-Overline="True" Font-Size="Large" OnClick="btninsert_Click" Text="Insert" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
