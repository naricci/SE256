<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ContentMgr.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphHeader" Runat="Server">
    <h1 class="nav-title">Boston Bruins Unofficial Website</h1>
    <!-- Nav Bar Buttons -->
    <asp:Button ID="btnLogOut" runat="server" Text="Log Out" class="nav-btn" OnClick="btnLogOut_Click" /><!-- /Log-Out Button -->
    <asp:Label ID="lblContactMgr" runat="server" Text="CONTENT MGR" class="nav-btn"><a href="ContentMgr.aspx">CONTENT MGR</a></asp:Label>
    <asp:Label ID="lblContactUs" runat="server" Text="CONTACT US" class="nav-btn"><a href="../ContactUs.aspx">CONTACT US</a></asp:Label>
    <asp:Label ID="lblAboutUs" runat="server" Text="ABOUT US" class="nav-btn"><a href="../AboutUs.aspx">ABOUT US</a></asp:Label>
    <asp:Label ID="lblHome" runat="server" Text="HOME" class="nav-btn"><a href="Default.aspx">HOME</a></asp:Label>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="cphMain" Runat="Server">
    <div>
    <!-- Page Title -->
    <h2>Content Manager Page</h2>
    <hr /><br /><br />

    <!-- Salutation div -->
    <div>
        <asp:label id="lblSalutation" runat="server" text="Salutation" Font-Bold="True"></asp:label>&nbsp;&nbsp;
        <!-- Radio Button List -->
        <asp:RadioButtonList ID="rblSalutation" runat="server" BorderStyle="None" Height="20px" RepeatDirection="Horizontal" Width="300px" style="display: inline;" BorderColor="#669999">
            <asp:ListItem>Mr.</asp:ListItem>
            <asp:ListItem>Mrs.</asp:ListItem>
            <asp:ListItem>Ms.</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <br />
    </div><!--/Salutation-div-->
    
    <!-- Main div -->
    <div style="float: left; height: 175px; width: 65%;">

        <!-- First Name -->
        <asp:Label ID="lblFName" runat="server" Text="First Name" Font-Bold="True"></asp:Label>
            &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtFName" runat="server" Width="175px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
        <!-- Last Name -->
        <asp:Label ID="lblLName" runat="server" Font-Bold="True" Text="Last Name"></asp:Label>
            &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtLName" runat="server" Width="175px"></asp:TextBox>
        <br />
        <br />

        <!-- Street 1 -->
        <asp:Label ID="lblStreet1" runat="server" Font-Bold="True" Text="Street 1"></asp:Label>
            &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtStreet1" runat="server" Width="200px"></asp:TextBox>
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
        <br />
        <br />
        
        <!-- Street 2 -->
        <asp:Label ID="lblStreet2" runat="server" Font-Bold="True" Text="Street 2"></asp:Label>
            &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtStreet2" runat="server" Width="200px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
        <!-- Zip Code -->
        <asp:Label ID="lblZipCode" runat="server" Font-Bold="True" Text="Zip Code"></asp:Label>
            &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtZipCode" runat="server"></asp:TextBox>
        <br />
        <br />
        
        <!-- City -->
        <asp:Label ID="lblCity" runat="server" Font-Bold="True" Text="City"></asp:Label>
            &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCity" runat="server" Width="200px"></asp:TextBox>
        <br />
    </div><!--/Main-div-->

    <!-- Notes div -->
    <div style="width: 35%; height: 175px; float:left;">
        &nbsp;&nbsp;
        <asp:Label ID="lblNotes" runat="server" Font-Bold="True" Text="Notes"></asp:Label>
        <br />&nbsp;  
        <asp:TextBox ID="txtNotes" runat="server" Height="136px" Width="300px"></asp:TextBox>
        <br />
        <br />
    </div><!--/Notes-div->

    <!-- Calendars div -->
    <div style="clear: both; width: 100%;">
            
        <!-- Birthday div-->
        <div style="width: 300px; float: left;">
            <asp:Label ID="lblBirthday" runat="server" Font-Bold="True" Text="Birthday"></asp:Label>
            <asp:Calendar ID="calBirthday" runat="server" Height="16px" Width="16px"></asp:Calendar>
        </div><!--/Birthday-div-->
            
        <!-- Anniversary div-->
        <div style="width: 300px; float: left;">    
            <asp:Label ID="lblAnniversary" runat="server" Font-Bold="True" Text="Anniversary"></asp:Label>
            <asp:Calendar ID="calAnniversary" runat="server" Height="16px" Width="16px"></asp:Calendar>
        </div><!--/Anniversary-div--> 
            
        <!-- Feedback Listbox div -->
        <div style="width: 377px; float: left; height: 206px;">
            <asp:Label ID="lblFeedback" runat="server" Font-Bold="True" Text="Feedback"></asp:Label>
            <br />
            <asp:ListBox ID="lbxFeedback" runat="server" Height="193px" Width="288px" style="margin-left: 0px"></asp:ListBox>
        </div><!--/Feedback-div-->
    </div><!--/Calendars div-->
    <br />

    <!--Contact Info div -->
    <div style="clear: both; width: 676px; height: 124px;">
        <asp:Label ID="lblHomePhone" runat="server" Font-Bold="True" Text="Home Phone"></asp:Label>
            &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtHomePhone" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="chkCardWorthy" runat="server" Font-Bold="True" Text="Card Worthy?" />
        <br />
        <br />
        <asp:Label ID="lblWorkPhone" runat="server" Font-Bold="True" Text="Work Phone"></asp:Label>
            &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtWorkPhone" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblRelationship" runat="server" Font-Bold="True" Text="Relationship"></asp:Label>
&nbsp;&nbsp;
        <!-- Relationship Drop Down List -->
        <asp:DropDownList ID="ddlRelationship" runat="server" Width="161px">
            <asp:ListItem>Please Choose One..</asp:ListItem>
            <asp:ListItem>Parent</asp:ListItem>
            <asp:ListItem>Sibling</asp:ListItem>
            <asp:ListItem>Friend</asp:ListItem>
            <asp:ListItem>Co-worker</asp:ListItem>
            <asp:ListItem>Enemy</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="lblCellPhone" runat="server" Font-Bold="True" Text="Cell Phone"></asp:Label>
            &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCellPhone" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblEmail" runat="server" Font-Bold="True" Text="Email"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtEmail" runat="server" Width="192px"></asp:TextBox>
    </div><!--/Contact-info-div-->
        
    <!-- Buttons div -->
    <div style="width: 300px; float: right;">
            
        <!-- Clear Form Button -->
        <asp:Button ID="btnClear" runat="server" Text="Clear Form" style="float: right;" Width="100px" OnClick="btnClear_Click" />
            
        <!-- Add Contact Button -->
        <asp:Button ID="btnAdd" runat="server" Text="Add Contact" style="float: right;" Width="100px" OnClick="btnAdd_Click" />
    </div><!--/Button-div-->        
</div><!--/First-Div-->
</asp:Content>
