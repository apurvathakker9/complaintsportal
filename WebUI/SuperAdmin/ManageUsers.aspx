<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="ManageUsers.aspx.cs" Inherits="SuperAdmin_ManageUsers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="LeftContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>
        Manage Users
    </h1>
    <h2>
        All Users:
    </h2>
    Username: <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
    <asp:Button ID="txtSerchUser" runat="server" Text="Find Assinged Roles" />
    <br /><br />
    <asp:GridView ID="gridUserInRoles" runat="server" Width="100%" AutoGenerateColumns="False" CellPadding="4" DataSourceID="objUserInRoles" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="Role Names" SortExpression="Name" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <EmptyDataTemplate>
            No User found!<br /> Enter Username above to see Assigned Roles.
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
    <asp:ObjectDataSource ID="objUserInRoles" runat="server" SelectMethod="GetUserInRoles" TypeName="WebUI.RolesBL">
        <SelectParameters>
            <asp:ControlParameter ControlID="txtUsername" Name="username" PropertyName="Text" Type="String" DefaultValue="nouser" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>

