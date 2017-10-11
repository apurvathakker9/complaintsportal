<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="AssignRoles.aspx.cs" Inherits="SuperAdmin_AssignRoles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="LeftContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" Runat="Server">
    <h2>
        Assign Roles:
    </h2>
    <table>
        <tr>
            <td>
                Select User:
            </td>
            <td>
                <asp:DropDownList ID="ddAllUsers" runat="server" DataSourceID="objAllUsers" DataTextField="Name" DataValueField="Name" OnDataBound="ddAllUsers_DataBound"></asp:DropDownList>
                <asp:ObjectDataSource ID="objAllUsers" runat="server" SelectMethod="GetAllUsers" TypeName="WebUI.AppUsersBL"></asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td>
                Select Role:
            </td>
            <td>
                <asp:DropDownList ID="ddAllRoles" runat="server" DataSourceID="objAllRoles" DataTextField="Name" DataValueField="Name" OnDataBound="ddAllUsers_DataBound"></asp:DropDownList>
                <asp:ObjectDataSource ID="objAllRoles" runat="server" SelectMethod="GetAllRoles" TypeName="WebUI.RolesBL"></asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td>

            </td>
            <td>
                <asp:Button ID="btnAssignRoles" runat="server" Text="Assign" OnClick="btnAssignRoles_Click" />
            </td>
        </tr>
    </table>

    <asp:Panel ID="pnlAfterAssign" runat="server" Visible="false">
        <p style="color:green">The Role is Assigned.</p>
    </asp:Panel>
</asp:Content>

