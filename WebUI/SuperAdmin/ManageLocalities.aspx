<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="ManageLocalities.aspx.cs" Inherits="SuperAdmin_ManageLocalities" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 150px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="LeftContent" runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="Server">

    <h1>Manage Localities
    </h1>

    <br />

    <table>
        <tr>
            <td>Select State:</td>
            <td class="auto-style1">
                <asp:DropDownList ID="ddlState" runat="server" Width="90%" DataSourceID="ObjectDataSource1" DataTextField="Name" DataValueField="Id" AutoPostBack="True" OnDataBound="ddlVillage_DataBound"></asp:DropDownList>

                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAll" TypeName="BusinessLogic.StateBL"></asp:ObjectDataSource>

            </td>
        </tr>



        <tr>
            <td>Select City:
            </td>

            <td class="auto-style1">
                <asp:DropDownList ID="ddlCity" runat="server" Width="90%" DataSourceID="ObjectDataSource2" DataTextField="Name" DataValueField="Id" AutoPostBack="True" OnDataBound="ddlVillage_DataBound"></asp:DropDownList>


                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetAllByState" TypeName="BusinessLogic.CityBL">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="ddlState" Name="stateId" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>

            </td>
        </tr>

        <tr>
            <td>Select Village: </td>
            <td class="auto-style1">
                <asp:DropDownList ID="ddlVillage" AutoPostBack="true" Width="90%" runat="server" DataSourceID="ObjectDataSource3" DataTextField="Name" DataValueField="Id" OnDataBound="ddlVillage_DataBound"></asp:DropDownList>

                <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="GetAllForCity" TypeName="BusinessLogic.VillageBL">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="ddlCity" Name="cityId" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>

            </td>
        </tr>
    </table>
    <br />
    <asp:Button ID="btnGEtLocalities" runat="server" Text="Get Localities"/>

    <br />
    <br />
    <asp:GridView ID="GridView1" DataKeyNames="Id" Width="100%" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource4" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" OnRowDeleted="GridView1_RowDeleted">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            
    
            <asp:CommandField ShowDeleteButton="True" ShowSelectButton="True" />
            
    
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Pincode" HeaderText="Pincode" SortExpression="Pincode" />
            <asp:BoundField DataField="Latitude" HeaderText="Latitude" SortExpression="Latitude" />
            <asp:BoundField DataField="Longitude" HeaderText="Longitude" SortExpression="Longitude" />
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
            <p>Select Credentials from above.</p>
        </EmptyDataTemplate>
    </asp:GridView>



    <asp:ObjectDataSource ID="ObjectDataSource4" runat="server" SelectMethod="GetDetails" TypeName="BusinessLogic.LocalityBL" DataObjectTypeName="BusinessObjects.Locality" DeleteMethod="Delete">
        <SelectParameters>
            <asp:ControlParameter ControlID="ddlCity" Name="CityId" PropertyName="SelectedValue" Type="Int32" />
            <asp:ControlParameter ControlID="ddlVillage" Name="VillageId" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>

    <br />
    <asp:Button ID="btnNewLocality" runat="server" Text="New Locality" OnClick="btnNewLocality_Click" />
    <br /><br />

    
    <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="100%" DataKeyNames="Id" AutoGenerateRows="False" DataSourceID="ObjectDataSource5" CellPadding="4" ForeColor="#333333" GridLines="None" OnItemInserting="DetailsView1_ItemInserting" OnItemInserted="DetailsView1_ItemInserted1" OnItemUpdated="DetailsView1_ItemUpdated1" OnItemUpdating="DetailsView1_ItemUpdating">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
        <EditRowStyle BackColor="#999999" />
        <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
        <Fields>
            
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Pincode" HeaderText="Pincode" SortExpression="Pincode" />
            <asp:BoundField DataField="Latitude" HeaderText="Latitude" SortExpression="Latitude" />
            <asp:BoundField DataField="Longitude" HeaderText="Longitude" SortExpression="Longitude" />
            <asp:CommandField ShowEditButton="True" ShowInsertButton="True" />
        </Fields>
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
    </asp:DetailsView>


    <asp:ObjectDataSource ID="ObjectDataSource5" runat="server" DataObjectTypeName="BusinessObjects.Locality" InsertMethod="Add" SelectMethod="GetDetails" TypeName="BusinessLogic.LocalityBL" UpdateMethod="Update">
        <SelectParameters>
            <asp:ControlParameter ControlID="GridView1" Name="id" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>



</asp:Content>

