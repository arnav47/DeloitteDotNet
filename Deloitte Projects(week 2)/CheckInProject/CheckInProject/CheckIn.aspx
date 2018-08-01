<%@ Page Title="" Language="C#" MasterPageFile="~/logo.Master" AutoEventWireup="true" CodeBehind="CheckIn.aspx.cs" Inherits="CheckInProject.CheckIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            width: 100%;
        }
        .auto-style7 {
            height: 31px;
        }
        .auto-style8 {
            text-align: center;
            font-family: "Bodoni MT Black";
            text-decoration: underline;
            background-color: #99FFCC;
        }
        .newStyle1 {
            font-family: "Lucida Calligraphy";
        }
        .newStyle2 {
            font-family: "Bodoni MT Black";
        }
        .auto-style9 {
            width: 190px;
            height: 31px;
        }
        .auto-style10 {
            height: 31px;
            width: 202px;
        }
        .auto-style11 {
            height: 31px;
            width: 219px;
        }
        .auto-style12 {
            width: 219px;
        }
        .auto-style13 {
            height: 31px;
            width: 129px;
        }
    .auto-style14 {
        height: 33px;
    }
    .auto-style15 {
        height: 33px;
        width: 219px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style6">
        <tr>
            <td class="auto-style8" colspan="5">Visitor Info</td>
        </tr>
        <tr>
            <td class="auto-style7" colspan="3">First Name:</td>
            <td class="auto-style11">
                <asp:TextBox ID="txtfname" runat="server" Height="23px" Width="225px"></asp:TextBox>
            </td>
            <td class="auto-style7">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtfname" ErrorMessage="Enter some data!"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="3">Last Name:</td>
            <td class="auto-style12">
                <asp:TextBox ID="txtlname" runat="server" Height="23px" Width="225px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtlname" ErrorMessage="Enter some data!"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="3">Company:</td>
            <td class="auto-style12">
                <asp:TextBox ID="txtcomp" runat="server" Height="23px" Width="225px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter some data!" ControlToValidate="txtcomp"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="3">Visiting:</td>
            <td class="auto-style12">
                <asp:TextBox ID="txtvis" runat="server" Height="23px" Width="225px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtvis" ErrorMessage="Enter some data!"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">ID Type:</td>
            <td class="auto-style10">
                <asp:DropDownList ID="ddlid" runat="server" Height="25px" Width="190px">
                    <asp:ListItem>PAN Card</asp:ListItem>
                    <asp:ListItem>Passport</asp:ListItem>
                    <asp:ListItem>Aadhar card</asp:ListItem>
                    <asp:ListItem>Company ID</asp:ListItem>
                    <asp:ListItem>Drivers License</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style13">ID Num:</td>
            <td class="auto-style11">
                <asp:TextBox ID="txtidno" runat="server" Height="22px" Width="225px"></asp:TextBox>
            </td>
            <td class="auto-style7">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="ddlid" ErrorMessage="Enter some data!"></asp:RequiredFieldValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtidno" ErrorMessage="Enter some data!"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="3">Vehicle Number:</td>
            <td class="auto-style12">
                <asp:TextBox ID="txtvehicle" runat="server" Height="23px" Width="225px"></asp:TextBox>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtvehicle" ErrorMessage="Enter Valid Car no.!" ValidationExpression="^[A-Z]{2}[0-9]{2}[-][A-Z]{2}[0-9]{4}"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td colspan="3">Contact Number:</td>
            <td class="auto-style12">
                <asp:TextBox ID="txtcon" runat="server" Height="23px" Width="225px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtcon" ErrorMessage="Enter some data!"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtcon" ErrorMessage="Enter 10 digits!" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td colspan="3">Purpose of Visit:</td>
            <td class="auto-style12">
                <asp:TextBox ID="txtpov" runat="server" Height="23px" Width="225px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtpov" ErrorMessage="Enter some data!"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="3">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14" colspan="3">
                <asp:Button ID="btncancel" runat="server" Text="Cancel" BackColor="#33CCCC" BorderColor="White" Height="46px" Width="86px" CausesValidation="False" OnClick="btncancel_Click" />
                <br />
            </td>
            <td class="auto-style15"></td>
            <td class="auto-style14">
                <asp:Button ID="btnSave" runat="server" Text="Enter" BackColor="#33CCCC" BorderColor="White" Height="40px" Width="70px" OnClick="btnSave_Click" />
            </td>
        </tr>
    </table>
    <br />
    <br />
    <asp:Button ID="Button2" runat="server" BackColor="#33CCCC" BorderColor="#00CC99" BorderStyle="Solid" BorderWidth="6px" Font-Bold="True" Font-Names="Franklin Gothic Book" Font-Overline="False" Font-Size="Medium" Font-Underline="False" ForeColor="White" Height="45px" OnClick="Button2_Click" Text="Return to Home" Width="183px" />
</asp:Content>
