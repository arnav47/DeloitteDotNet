<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validator Example.aspx.cs" Inherits="ControlsExample.Validator_Example" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 197px;
            border: 3px solid #333333;
            background-color: #CCFF99;
        }
        .auto-style2 {
            height: 31px;
        }
        .auto-style3 {
            width: 361px;
        }
        .auto-style4 {
            height: 31px;
            width: 361px;
        }
        .auto-style5 {
            width: 361px;
            height: 56px;
        }
        .auto-style6 {
            height: 56px;
        }
        .auto-style7 {
            width: 250px;
        }
        .auto-style8 {
            height: 31px;
            width: 250px;
        }
        .auto-style9 {
            height: 56px;
            width: 250px;
        }
        .auto-style10 {
            width: 361px;
            height: 34px;
        }
        .auto-style11 {
            width: 250px;
            height: 34px;
        }
        .auto-style12 {
            height: 34px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table align="center" cellpadding="4" cellspacing="4" class="auto-style1">
            <tr>
                <td class="auto-style3">Enter Name </td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="None" ErrorMessage="Can't be blank"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Age</td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" Display="None" ErrorMessage="Can't be blank"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" Display="None" ErrorMessage="Enter only number" ValidationExpression="^\t+$"></asp:RegularExpressionValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox2" Display="None" ErrorMessage="Age should be between 18 and 58" MaximumValue="58" MinimumValue="18" Type="Integer"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Dept</td>
                <td class="auto-style8">
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="18px" Width="144px">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>CS</asp:ListItem>
                        <asp:ListItem>IS</asp:ListItem>
                        <asp:ListItem>ECE</asp:ListItem>
                        <asp:ListItem>EEE</asp:ListItem>
                        <asp:ListItem>BT</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="DropDownList1" Display="None" ErrorMessage="Can't be blank" InitialValue="Select"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Email</td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox3" Display="None" ErrorMessage="Can't be blank"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox3" Display="None" ErrorMessage="Not correct Email format" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">Password</td>
                <td class="auto-style11">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style12">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox4" Display="None" ErrorMessage="Can't be blank"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Retype password</td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox5" Display="None" ErrorMessage="Can't be blank"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox4" ControlToValidate="TextBox5" Display="None" ErrorMessage="Passwords do not match"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Button ID="Button1" runat="server" Text="Submit" />
                </td>
                <td class="auto-style9">
                    <asp:Button ID="Button2" runat="server" CausesValidation="False" Text="Cancel" />
                </td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
        </table>
    
    </div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
