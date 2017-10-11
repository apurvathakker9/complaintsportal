<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaster.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Citizens_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" Runat="Server">
    Add or View Complaints
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" Runat="Server">
    <table>
        <tr>
            <td>
                <asp:Button ID="btnAddComplaint" CssClass="button" runat="server" Text="Add Complaint" OnClick="btnAddComplaint_Click" />
            </td>
            <td>
                <asp:Button ID="btnMyComplaints" CssClass="button" runat="server" Text="My Complaints" OnClick="btnMyComplaints_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

