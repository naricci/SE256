<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Controls_Default" %>

<asp:Content ID="Content4" ContentPlaceHolderID="cphMain" Runat="Server">
    <br />
    <!-- Page Title -->
    <h5>Welcome.  Please log in below.</h5>
    <br /><br />

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

