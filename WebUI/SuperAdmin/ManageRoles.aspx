<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="ManageRoles.aspx.cs" Inherits="SuperAdmin_ManageRoles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="LeftContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>
        Manage Roles
    </h1>
    <h2>
        Add Role:
    </h2>
    Role Name: <asp:TextBox ID="txtRoleName" runat="server"></asp:TextBox>
    <asp:Button ID="btnAddroles" runat="server" Text="Add Role" OnClick="btnAddroles_Click" />
    <br />
    <h2>
        All roles:
    </h2>
    <asp:GridView ID="gridAllRoles" runat="server" AutoGenerateColumns="False" Width="100%" DataSourceID="objAllRoles" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="Existing Roles" SortExpression="Name" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <EmptyDataTemplate>
            No Role Found in the Database.<br />Create a Role from Above.
        </EmptyDataTemplate>
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <asp:ObjectDataSource ID="objAllRoles" runat="server" SelectMethod="GetAllRoles" TypeName="WebUI.RolesBL"></asp:ObjectDataSource>
</asp:Content>

