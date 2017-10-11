<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="ManageCities.aspx.cs" Inherits="SuperAdmin_ManageCities" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="LeftContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>Manage Cities</h1>
    Select State : <asp:DropDownList ID="ddlStates" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource1" DataTextField="Name" DataValueField="Id" OnDataBound="ddlStates_DataBound"></asp:DropDownList>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAll" TypeName="BusinessLogic.StateBL"></asp:ObjectDataSource>

    <br />
    <h2>All Cities In Selected State
    </h2>
    <asp:GridView ID="GridView1" DataKeyNames="Id" runat="server" AutoGenerateColumns="False" Width="100%" CellPadding="4" DataSourceID="ObjectDataSource2" ForeColor="#333333" GridLines="None" OnRowDeleted="GridView1_RowDeleted" AllowPaging="True">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowSelectButton="True" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
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

    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" DataObjectTypeName="BusinessObjects.City" DeleteMethod="Delete" SelectMethod="GetAllByState" TypeName="BusinessLogic.CityBL">
        <SelectParameters>
            <asp:ControlParameter ControlID="ddlStates" Name="stateId" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>

    <br />

    <asp:Button ID="btnAddCity" runat="server" Text="Add New City" OnClick="btnAddCity_Click" />

        <br />
        <h2>City Details
        </h2>
        <asp:DetailsView ID="DetailsView1" DataKeyNames="Id" runat="server" Height="50px" Width="100%" AutoGenerateRows="False" CellPadding="4" DataSourceID="ObjectDataSource3" ForeColor="#333333" GridLines="None" OnItemInserted="DetailsView1_ItemInserted" OnItemUpdated="DetailsView1_ItemUpdated" OnItemInserting="DetailsView1_ItemInserting">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
        <EditRowStyle BackColor="#999999" />
        <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
        <Fields>
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="PinCode" HeaderText="PinCode" SortExpression="PinCode" />
            <asp:CommandField ShowEditButton="True" ShowInsertButton="True" />
        </Fields>
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />

            <EmptyDataTemplate>
                <p>Select from Above.</p>
            </EmptyDataTemplate>
    </asp:DetailsView>
    <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" DataObjectTypeName="BusinessObjects.City" InsertMethod="Add" SelectMethod="GetDetails" TypeName="BusinessLogic.CityBL" UpdateMethod="Update">
        <SelectParameters>
            <asp:ControlParameter ControlID="GridView1" Name="id" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>

