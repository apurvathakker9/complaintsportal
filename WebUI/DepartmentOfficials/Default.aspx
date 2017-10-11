<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaster.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="DepartmentOfficials_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="LeftContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1 style="text-align:center;">Welcome to Official page.</h1>

    <div class="contain_DepartmentOfficials">
        <ul id="menuList" class="nav navbar-nav">
                    <li><asp:HyperLink ID="AddedVsFixed" runat="server" NavigateUrl="~/DepartmentOfficials/ComplaintsAddedVsFixedReport.aspx">Complaints Added vs Fixed</asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="AverageTime" runat="server" NavigateUrl="~/DepartmentOfficials/ComplaintsAvrageTimeReport.aspx">Average Time for Complaints Fixed</asp:HyperLink>
            </li>

            <li>
                <asp:HyperLink ID="CurrentComplaintReport" runat="server" NavigateUrl="~/DepartmentOfficials/DepartmentCurrentComplaintsReport.aspx">Current Complaints Reports</asp:HyperLink>
            </li>
        </ul>
    </div>
</asp:Content>

