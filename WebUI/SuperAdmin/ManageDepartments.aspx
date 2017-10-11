<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="ManageDepartments.aspx.cs" Inherits="SuperAdmin_ManageDepartments" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="LeftContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" Runat="Server">

    <h1>Manage Departments</h1>

    <table>
        <tr>
            <td>Select State: </td>
            <td><asp:DropDownList ID="ddlState" AutoPostBack="true" runat="server" DataSourceID="ObjectDataSource1" DataTextField="Name" DataValueField="Id" OnSelectedIndexChanged="ddlState_SelectedIndexChanged" OnDataBound="ddlVillage_DataBound"></asp:DropDownList>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAll" TypeName="BusinessLogic.StateBL"></asp:ObjectDataSource>
            </td>
        </tr>

        <tr>
            <td>Select City: </td>
            <td><asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="true" DataSourceID="ObjectDataSource2" DataTextField="Name" DataValueField="Id" OnDataBound="ddlVillage_DataBound"></asp:DropDownList>
                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetAllByState" TypeName="BusinessLogic.CityBL">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="ddlState" Name="stateId" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>


        <tr>
            <td>Select Village: </td>
            <td><asp:DropDownList ID="ddlVillage" runat="server" AutoPostBack="true" DataSourceID="ObjectDataSource3" DataTextField="Name" DataValueField="Id" OnDataBound="ddlVillage_DataBound"></asp:DropDownList>
                <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="GetAllForCity" TypeName="BusinessLogic.VillageBL">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="ddlCity" Name="cityId" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>


        <tr>
            <td>Select Locality: </td>
            <td><asp:DropDownList ID="ddlLocality" runat="server" DataSourceID="ObjectDataSource6" DataTextField="Name" DataValueField="Id" OnDataBound="ddlVillage_DataBound"></asp:DropDownList>
                <asp:ObjectDataSource ID="ObjectDataSource6" runat="server" SelectMethod="GetDetails" TypeName="BusinessLogic.LocalityBL">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="ddlCity" Name="CityId" PropertyName="SelectedValue" Type="Int32" />
                        <asp:ControlParameter ControlID="ddlVillage" Name="VillageId" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>


        <tr>
            <td>Select DepartmentType: </td>
            <td><asp:DropDownList ID="ddlDepartmentType" runat="server" AutoPostBack="true" DataSourceID="ObjectDataSource4" DataTextField="Name" DataValueField="Id" OnDataBound="ddlVillage_DataBound"></asp:DropDownList>
                <asp:ObjectDataSource ID="ObjectDataSource4" runat="server" SelectMethod="GetAll" TypeName="BusinessLogic.DepartmentTypeBL"></asp:ObjectDataSource>
            </td>
        </tr>
    </table>


    <asp:GridView ID="GridView1" DataKeyNames="Id" Width="100%" runat="server" CellPadding="4" DataSourceID="ObjectDataSource5" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" AllowPaging="True">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            
            <asp:CommandField ShowDeleteButton="True" ShowSelectButton="True" />
            
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="OfficeAddress" HeaderText="OfficeAddress" SortExpression="OfficeAddress" />
            <asp:BoundField DataField="Website" HeaderText="Website" SortExpression="Website" />
            <asp:BoundField DataField="ContactEmails" HeaderText="ContactEmails" SortExpression="ContactEmails" />
            <asp:BoundField DataField="ContactNumbers" HeaderText="ContactNumbers" SortExpression="ContactNumbers" />
            <asp:BoundField DataField="ContactTimings" HeaderText="ContactTimings" SortExpression="ContactTimings" />
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


        <EmptyDataTemplate>
            <p>Select Credentials from Above.</p>
        </EmptyDataTemplate>
    </asp:GridView>

    <asp:ObjectDataSource ID="ObjectDataSource5" runat="server" DataObjectTypeName="BusinessObjects.Department" DeleteMethod="Delete" SelectMethod="GetAllByLocationAndType" TypeName="BusinessLogic.DepartmentBL">
        <SelectParameters>
            <asp:ControlParameter ControlID="ddlState" Name="stateId" PropertyName="SelectedValue" Type="Int32" />
            <asp:ControlParameter ControlID="ddlCity" Name="cityId" PropertyName="SelectedValue" Type="Int32" />
            <asp:ControlParameter ControlID="ddlVillage" Name="villageId" PropertyName="SelectedValue" Type="Int32" />
            <asp:ControlParameter ControlID="ddlLocality" Name="localityId" PropertyName="SelectedValue" Type="Int32" />
            <asp:ControlParameter ControlID="ddlDepartmentType" Name="departmentTypeId" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>

    <br />
    <asp:Button ID="btnAddDepartment" runat="server" Text="Add Department" OnClick="btnAddDepartment_Click" />
    <br /><br />



    <asp:DetailsView ID="DetailsView1" DataKeyNames="Id" runat="server" Width="100%" AutoGenerateRows="False" DataSourceID="ObjectDataSource7" CellPadding="4" ForeColor="#333333" GridLines="None" OnItemInserted="DetailsView1_ItemInserted" OnItemInserting="DetailsView1_ItemInserting" OnItemUpdated="DetailsView1_ItemUpdated" OnItemUpdating="DetailsView1_ItemUpdating">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
        <EditRowStyle BackColor="#999999" />
        <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
        <Fields>
            <asp:TemplateField>

                <EditItemTemplate>
                    <asp:HiddenField ID="HiddenField1" runat="server" Value='<%# Bind("DepartmentTypeId") %>' />
                    <asp:HiddenField ID="HiddenField4" runat="server" Value='<%# Bind("StateId") %>' />
                    <asp:HiddenField ID="HiddenField5" runat="server" Value='<%# Bind("CityId") %>' />
                    <asp:HiddenField ID="HiddenField3" runat="server" Value='<%# Bind("VillageId") %>' />
                    <asp:HiddenField ID="HiddenField2" runat="server" Value='<%# Bind("LocalityId") %>' />
                </EditItemTemplate>

            </asp:TemplateField>
            
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="OfficeAddress" HeaderText="OfficeAddress" SortExpression="OfficeAddress" />
            <asp:BoundField DataField="Website" HeaderText="Website" SortExpression="Website" />
            <asp:BoundField DataField="ContactEmails" HeaderText="ContactEmails" SortExpression="ContactEmails" />
            <asp:BoundField DataField="ContactNumbers" HeaderText="ContactNumbers" SortExpression="ContactNumbers" />
            <asp:BoundField DataField="ContactTimings" HeaderText="ContactTimings" SortExpression="ContactTimings" />
            <asp:CommandField ShowEditButton="True" ShowInsertButton="True" />
        </Fields>
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />


        <EmptyDataTemplate>
            <p>Select a value from above.</p>
        </EmptyDataTemplate>


    </asp:DetailsView>

    <asp:ObjectDataSource ID="ObjectDataSource7" runat="server" DataObjectTypeName="BusinessObjects.Department" InsertMethod="Add" SelectMethod="GetDetails" TypeName="BusinessLogic.DepartmentBL" UpdateMethod="Update">
        <SelectParameters>
            <asp:ControlParameter ControlID="GridView1" Name="id" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>

</asp:Content>

