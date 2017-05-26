<%@ Page Title=" Log In" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Controls_Default" %>

<asp:Content ID="Content4" ContentPlaceHolderID="cphMain" Runat="Server">
    <br />

    <!-- Sign Up/Log In Div -->
    <div class="row">
        <div class="col s12">

            <div class="row">
                <div class="offset-s4 col s4 offset-s4">
                    <!-- Page Title -->
                    <h5>Welcome to House of Pizza!</h5>  
                    <p>Please log in below to place an order.</p>
                    <br /><br />
                </div>
            </div>

            <div class="row">
                <div class="input-field offset-s3 col s6 offset-s3">
                        
                    <!-- User Name -->
                    <asp:Label ID="lblUserName" runat="server" Text="Username"></asp:Label>
                    <asp:TextBox ID="txtUserName" runat="server" Text="Scott"></asp:TextBox>
                    <br />
                    <br />

                    <!-- Password -->
                    <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                    <asp:TextBox ID="txtPassword" runat="server" Text ="NEIT"></asp:TextBox>
                    <br />
                    <br />

                </div><!-- /input-field -->
            </div><!-- /row -->

            <div class="row">
                <div class="input-field offset-s3 col s6 offset-s3">
                    
                    <!-- Log In Button -->
                    <asp:Button ID="btnLogIn" runat="server" Text="Log In" OnClick="btnLogIn_Click" Class="waves-effect waves-light btn grey darken-4" />
                    <br />

                    <!-- Feedback Label -->
                    <asp:Label ID="lblFeedback" runat="server"></asp:Label>

                </div><!-- /input-field -->
            </div><!-- /row -->
        </div><!-- /col s12 -->
    </div><!-- /row -->
</asp:Content>

