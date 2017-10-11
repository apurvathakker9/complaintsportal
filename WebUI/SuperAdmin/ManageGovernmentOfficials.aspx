<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="ManageGovernmentOfficials.aspx.cs" Inherits="SuperAdmin_ManageGovernmentOfficials" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="LeftContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" Runat="Server">


    <h2>Manage Officials: </h2>
    Select Designation: 
    <asp:DropDownList ID="ddlDesignation" runat="server" AutoPostBack="true" DataSourceID="ObjectDataSource1" DataTextField="Name" DataValueField="Id" OnDataBound="ddlDesignation_DataBound"></asp:DropDownList>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAll" TypeName="BusinessLogic.DepartmentDesignationBL"></asp:ObjectDataSource>

    <br /><br />

    <asp:GridView ID="grdAllOfficials" runat="server" Width="100%" DataKeyNames="Id" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            
            <asp:CommandField ShowDeleteButton="True" ShowSelectButton="True" />
            
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="ContactNumber" HeaderText="ContactNumber" SortExpression="ContactNumber" />
            <asp:BoundField DataField="ContactEmail" HeaderText="ContactEmail" SortExpression="ContactEmail" />
            
            <asp:TemplateField HeaderText="Picture">

                <ItemTemplate>
                    <asp:Image ID="Image1" runat="server" Height="100px" Width="100px" ImageUrl='<%# Eval("Picture") %>' />
                </ItemTemplate>

            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Designation" SortExpression="DesignationId">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("DepartmentDesignation.Name") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("DepartmentDesignation.Name") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            
            
            <asp:BoundField DataField="OfficialCode" HeaderText="OfficialCode" SortExpression="OfficialCode" />
        </Columns>


        <EditRowStyle BackColor="#999999" />


        <EmptyDataTemplate>
            <p>Select from the above List</p>
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



    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetAllByDesignation" TypeName="BusinessLogic.GovernmentOfficialsBL" DataObjectTypeName="BusinessObjects.GovernmentOfficial" DeleteMethod="Delete">
        <SelectParameters>
            <asp:ControlParameter ControlID="ddlDesignation" Name="designationId" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>

    <br />
    <asp:Button ID="btnAddNewOfficial" runat="server" Text="Add New Official" OnClick="btnAddNewOfficial_Click" />
    <br /><br />

    <asp:DetailsView ID="dvOfficialDetails" DataKeyNames="Id" runat="server" Width="100%" AutoGenerateRows="False" DataSourceID="ObjectDataSource3" CellPadding="4" ForeColor="#333333" GridLines="None" OnItemInserted="dvOfficialDetails_ItemInserted" OnItemInserting="dvOfficialDetails_ItemInserting" OnItemUpdated="dvOfficialDetails_ItemUpdated" OnItemUpdating="dvOfficialDetails_ItemUpdating">
        <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
        <Fields>
            
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="ContactNumber" HeaderText="ContactNumber" SortExpression="ContactNumber" />
            <asp:BoundField DataField="ContactEmail" HeaderText="ContactEmail" SortExpression="ContactEmail" />
            
            <asp:TemplateField HeaderText="Picture">

                <EditItemTemplate>
                    <asp:Image ID="Image3" runat="server" Width="100px" Height="100px" ImageUrl='<%# Eval("Picture") %>' />
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </EditItemTemplate>
                <InsertItemTemplate>
                    <asp:FileUpload ID="FileUpload2" runat="server" />
                </InsertItemTemplate>
                <ItemTemplate>
                    <asp:Image ID="Image2" runat="server" Height="100px" Width="100px" ImageUrl='<%# Eval("Picture") %>' />
                </ItemTemplate>

            </asp:TemplateField>
            
            
            <asp:TemplateField HeaderText="Designation" SortExpression="DesignationId">
                <EditItemTemplate>
                    
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource1" DataTextField="Name" DataValueField="Id" SelectedValue='<%# Bind("DesignationId") %>'>
                    </asp:DropDownList>
                    
                </EditItemTemplate>
                <InsertItemTemplate>
                    
                    <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="ObjectDataSource1" DataTextField="Name" DataValueField="Id" SelectedValue='<%# Bind("DesignationId") %>'>
                    </asp:DropDownList>
                    
                </InsertItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("DesignationId") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            
            
            <asp:BoundField DataField="OfficialCode" HeaderText="OfficialCode" SortExpression="OfficialCode" />
            <asp:CommandField ShowEditButton="True" ShowInsertButton="True" />
        </Fields>


        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
        <EditRowStyle BackColor="#999999" />


        <EmptyDataTemplate>
            <p>Select Data Form Above.</p>
        </EmptyDataTemplate>
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
    </asp:DetailsView>
    <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" DataObjectTypeName="BusinessObjects.GovernmentOfficial" InsertMethod="Add" SelectMethod="GetDetails" TypeName="BusinessLogic.GovernmentOfficialsBL" UpdateMethod="Update">
        <SelectParameters>
            <asp:ControlParameter ControlID="grdAllOfficials" Name="id" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>




</asp:Content>

