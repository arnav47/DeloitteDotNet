<%@ Page Title="" Language="C#" MasterPageFile="~/logo.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="CheckInProject.Checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            width: 100%;
            background-color: #20B2AA;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <table class="auto-style6" >
        <tr>
            <td>Visitors In</td>
            <td>
                <asp:TextBox ID="txtname" runat="server" BorderColor="#999999" BorderWidth="2px" Height="20px" Width="157px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnid" runat="server" BackColor="#CCCCCC" BorderColor="Silver" BorderStyle="Double" Height="30px" OnClick="btnid_Click" Text="Search by ID" Width="112px" />
            </td>
            <td>
                <asp:Button ID="btnname" runat="server" BackColor="#CCCCCC" BorderColor="Silver" BorderStyle="Double" Height="30px" Text="Search by Name" Width="112px" />
            </td>
        </tr>
    </table>
        </p>
    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="229px" Width="966px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />

        <Columns>
            <asp:TemplateField HeaderText="Sign Out" >
                <ItemTemplate>
                    <asp:Button id ="b1" runat="server" Text="Click here to Sign Out" OnClick="b1_Click"   />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Label ID="Label1" runat="server" Text="Status"></asp:Label>
    <br />
    <br />
    <asp:Button ID="Button2" runat="server" BackColor="#33CCCC" BorderColor="#00CC99" BorderStyle="Solid" BorderWidth="6px" Font-Bold="True" Font-Names="Franklin Gothic Book" Font-Overline="False" Font-Size="Medium" Font-Underline="False" ForeColor="White" Height="45px" OnClick="Button2_Click" Text="Return to Home" Width="183px" />
    <br />
    <br />
</asp:Content>
