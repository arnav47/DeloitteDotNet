<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BindingDataList.aspx.cs" Inherits="WebProjects.BindingDataList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:DataList ID="DataList1" runat="server" CellPadding="4" DataKeyField="Id" DataSourceID="SqlDataSource1" ForeColor="#333333">
            <AlternatingItemStyle BackColor="White" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#EFF3FB" />
            <ItemTemplate>
                Id:
                <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                <br />
                Name:
                <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                <br />
                Gender:
                <asp:Label ID="GenderLabel" runat="server" Text='<%# Eval("Gender") %>' />
                <br />
                Membership:
                <asp:Label ID="MembershipLabel" runat="server" Text='<%# Eval("Membership") %>' />
                <br />
                ShoppingPreference:
                <asp:Label ID="ShoppingPreferenceLabel" runat="server" Text='<%# Eval("ShoppingPreference") %>' />
                <br />
                COD:
                <asp:Label ID="CODLabel" runat="server" Text='<%# Eval("COD") %>' />
                <br />
                Password:
                <asp:Label ID="PasswordLabel" runat="server" Text='<%# Eval("Password") %>' />
                <br />
                <br />
            </ItemTemplate>
            <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TrainingDBConnectionString %>" SelectCommand="SELECT * FROM [RegisterShopping]"></asp:SqlDataSource>
    </form>
</body>
</html>
