<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PersonSearch.aspx.cs" Inherits="PersonSearch" %>
<%--
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphNav" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphSide" Runat="Server">
</asp:Content> 
--%>

<asp:Content ID="Content4" ContentPlaceHolderID="cphMain" Runat="Server">
    <br />

    <!-- Search/Edit -->
    <div class="row">
        <div class="col s12">
            
            <div class="row">
                <div class="offset-s4 col s4 offset-s4">
                    <!-- Page Title -->
                    <h5>Contact Search</h5>
                    <br />
                </div>
            </div>

            <div class="row">    
                <!-- First Name -->
                <div class="input-field col s4">        
                    <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>&nbsp;
                    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                </div><!--/ input-field -->

                <!-- Middle Name -->
                <div class="input-field col s4">
                    <asp:Label ID="lblMiddleName" runat="server" Text="Middle Name"></asp:Label>&nbsp;
                    <asp:TextBox ID="txtMiddleName" runat="server"></asp:TextBox>
                </div><!--/ input-field -->
                
                <!-- Last Name -->
                <div class="input-field col s4">
                    <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>&nbsp;
                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                </div><!--/ input-field -->
            </div><!--/ row -->
        
            <div class="row">
                <div class="input-field offset-s6 col s6">
                    
                    <!-- Search Button -->
                    <asp:Button ID="btnSearch" runat="server" Text="Search" Class="waves-effect waves-light btn grey darken-4" OnClick="btnSearch_Click" />&nbsp;

                    <!-- Clear Button -->
                    <asp:Button ID="btnClear" runat="server" Text="Clear" Class="waves-effect waves-light btn grey darken-4" OnClick="btnClear_Click" />&nbsp;

                     <!-- Log Out Button -->
                    <asp:Button ID="btnLogOut" runat="server" Text="Log Out" Class="waves-effect waves-light btn red darken-4" OnClick="btnLogOut_Click" />
                    <br />

                </div><!--/ input-field -->
            </div><!--/ row -->

            <div class="row">
                <div class="col s12">

                    <!-- Data Grid View for Search Results -->
                    <asp:GridView runat="server" ID="gvPersons" AutoGenerateColumns="False" >
                        <Columns>
                            <asp:BoundField DataField="FirstName" HeaderText="First Name"  />
                            <asp:BoundField DataField="MiddleName" HeaderText="Middle Name" />
                            <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                            <asp:HyperLinkField Text="Edit" DataNavigateUrlFormatString="/Controls/ContentMgr.aspx?Per_ID={0}" DataNavigateUrlFields="Person_ID" />
                        </Columns>
                    </asp:GridView>

                </div><!--/ col s12 -->
            </div><!--/ row -->

        </div><!--/ col s12 -->
    </div><!--/ row -->


</asp:Content>

<%--
<asp:Content ID="Content5" ContentPlaceHolderID="cphFooter" Runat="Server">
</asp:Content> 
--%>

