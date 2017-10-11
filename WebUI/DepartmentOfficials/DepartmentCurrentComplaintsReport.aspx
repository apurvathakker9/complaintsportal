<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaster.master" AutoEventWireup="true" CodeFile="DepartmentCurrentComplaintsReport.aspx.cs" Inherits="DepartmentOfficials_DepartmentCurrentComplaintsReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="LeftContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" Runat="Server">

    <asp:HiddenField ID="hfUserName" runat="server" />

    <h1>Report - Open Complaints Status</h1>
    Select Department : <asp:DropDownList ID="ddlDepartment" runat="server" DataSourceID="ObjectDataSource1" DataTextField="Name" DataValueField="Id">
                               
                        </asp:DropDownList>
   
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAllByUseraname" TypeName="BusinessLogic.DepartmentBL">
        <SelectParameters>
            <asp:ControlParameter ControlID="hfUserName" Name="username" PropertyName="Value" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
   
    <asp:Button ID="btnShowComplaintsStatus" runat="server" Text="Show Complaints Status" OnClick="btnShowComplaintsStatus_Click" />
    <table>
        <tr>
            <td>
                <span style="font-size:60px"> <asp:Label runat="server" ID="lblAllComplaints"></asp:Label> </span>
                <br />
                Complaints
            </td>
            <td>
                <span style="font-size:60px"><asp:Label runat="server" ID="lblOpenComplaints"></asp:Label></span>
                <br />
                Open Complaints
            </td>
            <td>
                <span style="font-size:60px"><asp:Label runat="server" ID="lblFixedComplaints"></asp:Label></span>
                <br />
                Fixed but not closed
            </td>
        </tr>
    </table>
    <h2>Open Complaints List</h2>
    <asp:GridView runat="server" ID="grdOpenComplaints">
        <EmptyDataTemplate>
            No open complaints found for selected department.
        </EmptyDataTemplate>
    </asp:GridView>
</asp:Content>

