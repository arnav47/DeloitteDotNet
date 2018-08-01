<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Redirect.aspx.cs" Inherits="StateManagementAndCaching.Redirect" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border-style: solid;
            border-width: 4px;
            background-color: #C0C0C0;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table cellpadding="10" cellspacing="20" class="auto-style1">
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Height="31px" OnClick="Button1_Click" Text="Show Data" Width="99px" />
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" Height="31px" OnClick="Button2_Click" Text="Time Out" Width="84px" />
                </td>
                <td>
                    <asp:Button ID="Button3" runat="server" Height="31px" OnClick="Button3_Click" Text="Abandon" Width="84px" />
                </td>
            </tr>
        </table>
    
    </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
