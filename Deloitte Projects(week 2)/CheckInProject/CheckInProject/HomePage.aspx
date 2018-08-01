<%@ Page Title="" Language="C#" MasterPageFile="~/logo.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="CheckInProject.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        <table class="auto-style6">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" BackColor="#33CCCC" BorderColor="#00CC99" BorderStyle="Solid" BorderWidth="6px" Font-Bold="True" Font-Names="Franklin Gothic Book" Font-Overline="False" Font-Size="Medium" Font-Underline="False" ForeColor="White" Height="40px" OnClick="Button1_Click" Text="Check In" Width="89px" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button2" runat="server" BackColor="#33CCCC" BorderColor="#00CC99" BorderStyle="Solid" BorderWidth="6px" Font-Bold="True" Font-Names="Franklin Gothic Book" Font-Overline="False" Font-Size="Medium" Font-Underline="False" ForeColor="White" Height="40px" OnClick="Button2_Click" Text="Check Out" Width="89px" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </p>
</asp:Content>
