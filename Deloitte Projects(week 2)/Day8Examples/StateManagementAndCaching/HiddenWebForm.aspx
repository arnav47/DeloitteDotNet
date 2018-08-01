<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HiddenWebForm.aspx.cs" Inherits="StateManagementAndCaching.HiddenWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border-style: solid;
            border-width: 4px;
            background-color: #000066;
        }
        .auto-style2 {
            color: #FFFFFF;
        }
        .auto-style3 {
            font-weight: normal;
        }
        .auto-style4 {
            color: #FFFFFF;
            font-size: x-large;
        }
        .newStyle1 {
            font-family: Broadway;
        }
        .auto-style5 {
            font-family: Broadway;
            font-size: x-large;
            color: #FFFFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table cellpadding="10" cellspacing="20" class="auto-style1">
            <tr>
                <td class="auto-style4"><strong>Enter Name:</strong></td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Height="29px" Width="141px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <h3 class="auto-style3"><strong>Rating:</strong></h3>
                </td>
                <td>
                    <asp:Label ID="Label1" runat="server" CssClass="auto-style5" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Height="28px" OnClick="Button1_Click" Text="Button" Width="67px" />
                </td>
                <td>
                    <asp:HiddenField ID="HiddenField1" runat="server" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
