<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphHeader" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphSideBar" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphMain" Runat="Server">
    
    <!-- Salutation div -->
    <div>
        <asp:label id="lblSalutation" runat="server" text="Salutation" Font-Bold="True"></asp:label>&nbsp;&nbsp;
        <!-- Radio Button List -->
        <asp:RadioButtonList ID="rblSalutation" runat="server" BorderStyle="Solid" Height="20px" RepeatDirection="Horizontal" Width="250px" style="display: inline;" BorderColor="#669999">
            <asp:ListItem>Mr.</asp:ListItem>
            <asp:ListItem>Mrs.</asp:ListItem>
            <asp:ListItem>Ms.</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <br />
    </div>
    
    <!-- Main div -->
    <div style="float: left; height: 175px; width: 65%;">

        <!-- First Name -->
        <asp:Label ID="lblFName" runat="server" Text="First Name" Font-Bold="True"></asp:Label>
            &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtFName" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
        <!-- Last Name -->
        <asp:Label ID="lblLName" runat="server" Font-Bold="True" Text="Last Name"></asp:Label>
            &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtLName" runat="server"></asp:TextBox>
        <br /><br />

        <!-- Street 1 -->
        <asp:Label ID="lblStreet1" runat="server" Font-Bold="True" Text="Street 1"></asp:Label>
            &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtStreet1" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblState" runat="server" Font-Bold="True" Text="State"></asp:Label>
            &nbsp;&nbsp;&nbsp;

        <!-- State Drop Down List -->
        <asp:DropDownList ID="ddlState" runat="server" Width="150px">
            <asp:ListItem>Choose a State...</asp:ListItem>
            <asp:ListItem>Connecticut</asp:ListItem>
            <asp:ListItem>Massachusetts</asp:ListItem>
            <asp:ListItem>Maine</asp:ListItem>
            <asp:ListItem>New Hampshire</asp:ListItem>
            <asp:ListItem>New York</asp:ListItem>
            <asp:ListItem>Rhode Island</asp:ListItem>
            <asp:ListItem>Vermont</asp:ListItem>
        </asp:DropDownList>
        <br /><br />
        
        <!-- Street 2 -->
        <asp:Label ID="lblStreet2" runat="server" Font-Bold="True" Text="Street 2"></asp:Label>
            &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtStreet2" runat="server" OnTextChanged="txtStreet2_TextChanged"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
        <!-- Zip Code -->
        <asp:Label ID="lblZipCode" runat="server" Font-Bold="True" Text="Zip Code"></asp:Label>
            &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtZipCode" runat="server" OnTextChanged="txtStreet2_TextChanged"></asp:TextBox>
        <br /><br />
        
        <!-- City -->
        <asp:Label ID="lblCity" runat="server" Font-Bold="True" Text="City"></asp:Label>
            &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
        <br />
    </div>

    <!-- Notes div -->
    <div style="width: 35%; height: 175px;">
        <asp:Label ID="lblNotes" runat="server" Font-Bold="True" Text="Notes"></asp:Label>
        <br />&nbsp;  
        <asp:TextBox ID="txtNotes" runat="server" Height="136px" Width="248px"></asp:TextBox>
        <br /><br />
    </div>

    <!-- Calendar div -->
    <div style="clear: both; width= 100%;">
        <br />
        <!-- Birthday -->
        <asp:Label ID="lblBirthday" runat="server" Font-Bold="True" Text="Birthday"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblAnniversary" runat="server" Font-Bold="True" Text="Anniversary"></asp:Label>
        <asp:Calendar ID="calBirthday" runat="server" Height="16px" Width="16px"></asp:Calendar>
        <asp:Calendar ID="calAnniversary" runat="server" Height="16px" Width="16px"></asp:Calendar>
        &nbsp;
        <br /><br />
        <asp:Label ID="lblHomePhone" runat="server" Font-Bold="True" Text="Home Phone"></asp:Label>
            &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtHomePhone" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="lblWorkPhone" runat="server" Font-Bold="True" Text="Work Phone"></asp:Label>
            &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtWorkPhone" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblCellPhone" runat="server" Font-Bold="True" Text="Cell Phone"></asp:Label>
            &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCellPhone" runat="server"></asp:TextBox>

    </div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="cphFooter" Runat="Server">
</asp:Content>

