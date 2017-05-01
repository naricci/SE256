<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" Runat="Server">
    <title>Home</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphHeader" Runat="Server">

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphMain" Runat="Server">
    <!-- Page Title -->
    <h2>This is the Log In Page</h2>
    <hr /><br /><br />

    <!-- Sign Up/Log In Div -->
    <div>
        <center>
            <!-- User Name -->
            <asp:Label ID="lblUserName" runat="server" Text="Username"></asp:Label>&nbsp;
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            <br /><br />

            <!-- Password -->
            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>&nbsp;
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="btnLogIn" runat="server" Text="Log In" OnClick="btnLogIn_Click" />
            <br />
            <br />
            <asp:Label ID="lblFeedback" runat="server"></asp:Label>
        </center>
    </div>
</asp:Content>
