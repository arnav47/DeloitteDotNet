<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterShopping.aspx.cs" Inherits="ControlsExample.RegisterShopping" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 447px;
            background-color: #CCCCFF;
        }
        .auto-style2 {
            width: 257px;
        }
        .auto-style3 {
            width: 257px;
            height: 45px;
        }
        .auto-style4 {
            height: 45px;
        }
        .auto-style5 {
            width: 257px;
            height: 49px;
        }
        .auto-style6 {
            height: 49px;
        }
        .auto-style7 {
            width: 257px;
            height: 56px;
        }
        .auto-style8 {
            height: 56px;
        }
        .auto-style9 {
            width: 257px;
            height: 36px;
        }
        .auto-style10 {
            height: 36px;
        }
        .auto-style11 {
            width: 257px;
            height: 51px;
        }
        .auto-style12 {
            height: 51px;
        }
    </style>
</head>
<body style="width: 634px">
    <form id="form1" runat="server">
    <div>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">Enter Name</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Select Gender</td>
                <td class="auto-style10">
                    <asp:DropDownList ID="ddlgender" runat="server" Height="88px" Width="135px">
                        <asp:ListItem>MALE</asp:ListItem>
                        <asp:ListItem>FEMALE</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Select Membership</td>
                <td class="auto-style4">
                    <asp:RadioButton ID="rbfree" runat="server" GroupName="MEMBER" Text="FREE                                                                                    " />
                    <asp:RadioButton ID="rbpaid" runat="server" GroupName="MEMBER" Text="PAID" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Select Shopping Preference</td>
                <td>
                    <asp:CheckBoxList ID="cblshopping" runat="server" OnSelectedIndexChanged="cblshopping_SelectedIndexChanged" Width="139px">
                        <asp:ListItem>Mobiles</asp:ListItem>
                        <asp:ListItem>tablets</asp:ListItem>
                        <asp:ListItem>Watch</asp:ListItem>
                        <asp:ListItem>Laptop</asp:ListItem>
                        <asp:ListItem>Clothes</asp:ListItem>
                        <asp:ListItem>Charger</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Prefer COD?</td>
                <td class="auto-style6">
                    <asp:CheckBox ID="cbcod" runat="server" Text="Yes" />
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <br />
                    Enter Password</td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtpass" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style11">
                    <asp:Button ID="Button1" runat="server" BackColor="#FFCCFF" BorderColor="White" BorderStyle="Solid" OnClick="Button1_Click" Text="Register" />
                </td>
                <td class="auto-style12">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
