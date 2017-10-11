<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="ManageAdhaarXContactNumber.aspx.cs" Inherits="SuperAdmin_AdhaarXContactNumber" %>


<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="LeftContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" Runat="Server">
    
    <h1>
        Manage Adhaar And Contact Number
    </h1>

    <br />

    <h2>
        All Adhaar And Contact Numbers :
    </h2>

    <asp:GridView DataKeyNames="Id" ID="GridView1" Width="100%" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" OnRowDeleted="GridView1_RowDeleted">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowSelectButton="True" />
            <asp:BoundField DataField="AdhaarNumber" HeaderText="AdhaarNumber" SortExpression="AdhaarNumber" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
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
    
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="BusinessObjects.AdhaarXContactNumber" DeleteMethod="Delete" SelectMethod="GetAll" TypeName="BusinessLogic.AdharXContactNumberBL"></asp:ObjectDataSource>
    
    <br />

    <asp:Button ID="btnAddNewAdhaarAndContactNumber" runat="server" Text="Add New Contact And Adhaar Number" OnClick="btnAddNewAdhaarAndContactNumber_Click" />

    <br />

    <h2>
        Adhaar And Contact Number Details :
    </h2>

    <br />

    <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="100%" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateRows="False" DataSourceID="ObjectDataSource2" OnItemInserted="DetailsView1_ItemInserted" OnItemUpdated="DetailsView1_ItemUpdated">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
        <EditRowStyle BackColor="#999999" />
        <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
        <Fields>
            <asp:BoundField DataField="AdhaarNumber" HeaderText="AdhaarNumber" SortExpression="AdhaarNumber" />
            <asp:BoundField DataField="ContactNumber" HeaderText="ContactNumber" SortExpression="ContactNumber" />
            <asp:CommandField ShowEditButton="True" ShowInsertButton="True" />
        </Fields>
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
    </asp:DetailsView>

    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" DataObjectTypeName="BusinessObjects.AdhaarXContactNumber" InsertMethod="Add" SelectMethod="GetDetails" TypeName="BusinessLogic.AdharXContactNumberBL" UpdateMethod="Update">
        <SelectParameters>
            <asp:ControlParameter ControlID="GridView1" Name="id" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>

</asp:Content>

