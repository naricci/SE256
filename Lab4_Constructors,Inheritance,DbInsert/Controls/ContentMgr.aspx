<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ContentMgr.aspx.cs" Inherits="Controls_ContentMgr" %>

<asp:Content ID="Content4" ContentPlaceHolderID="cphMain" Runat="Server">
    <div class="row">
    <form class="col s12">
      <div class="row">
        <div class="input-field col s4">

            <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>

        </div>
        <div class="input-field col s4">

            <asp:Label ID="lblMiddleName" runat="server" Text="Middle Name"></asp:Label>
            <asp:TextBox ID="txtMiddleName" runat="server"></asp:TextBox>

        </div>
        <div class="input-field col s4">

            <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>

        </div>
      </div>
      <div class="row">
        <div class="input-field col s6">
          
            <asp:Label ID="lblStreet1" runat="server" Text="Street 1"></asp:Label>
            <asp:TextBox ID="txtStreet1" runat="server"></asp:TextBox>
          
        </div>
        <div class="input-field col s6">
          
            <asp:Label ID="lblStreet2" runat="server" Text="Street 2"></asp:Label>
            <asp:TextBox ID="txtStreet2" runat="server"></asp:TextBox>
          
        </div>
      </div>
      <div class="row">
        <div class="input-field col s4">

            <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>

        </div>
        <div class="input-field col s4 offset-s1">

            <asp:Label ID="lblState" runat="server" Text="State"></asp:Label>
            <asp:DropDownList ID="ddlState" runat="server" CssClass="browser-default">
                <asp:ListItem>Choose a State...</asp:ListItem>
                <asp:ListItem>CT</asp:ListItem>
                <asp:ListItem>MA</asp:ListItem>
                <asp:ListItem>ME</asp:ListItem>
                <asp:ListItem>NH</asp:ListItem>
                <asp:ListItem>NJ</asp:ListItem>
                <asp:ListItem>NY</asp:ListItem>
                <asp:ListItem>RI</asp:ListItem>
                <asp:ListItem>VT</asp:ListItem>
            </asp:DropDownList>

        </div>
        <div class="input-field col s2 offset-s1">

            <asp:Label ID="lblZipCode" runat="server" Text="Zip Code"></asp:Label>
            <asp:TextBox ID="txtZipCode" runat="server"></asp:TextBox>

        </div>
      </div>
      <div class="row">
          <div class="input-field col s6">

              <asp:Label ID="lblBirthday" runat="server" Text="Birthday"></asp:Label>
              <asp:Calendar ID="calBirthday" runat="server"></asp:Calendar>

          </div>
          <div class="input-field col s6">

              <asp:Label ID="lblAnniversary" runat="server" Text="Anniversary"></asp:Label>
              <asp:Calendar ID="calAnniversary" runat="server"></asp:Calendar>

          </div>
      </div>
      <div class="row">
          <div class="input-field col s4">

              <asp:Label ID="lblHomePhone" runat="server" Text="Home Phone"></asp:Label>
              <asp:TextBox ID="txtHomePhone" runat="server"></asp:TextBox>

          </div>
          <div class="input-field col s4">

              <asp:Label ID="lblWorkPhone" runat="server" Text="WorkPhone"></asp:Label>
              <asp:TextBox ID="txtWorkPhone" runat="server"></asp:TextBox>

          </div>
          <div class="input-field col s4">

              <asp:Label ID="lblCellPhone" runat="server" Text="Cell Phone"></asp:Label>
              <asp:TextBox ID="txtCellPhone" runat="server"></asp:TextBox>

          </div>
      </div>
      <div class="row">
          <div class="input-field col s4">

              <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
              <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>

          </div>
          <div class="input-field col s4">

              <center>
                  <asp:CheckBox ID="chkCardWorthy" runat="server" Text="Card Worthy?" />
              </center>

          </div>
          <div class="input-field col s4">

              <asp:Label ID="lblRelationship" runat="server" Text="Relationship"></asp:Label>
              <asp:DropDownList ID="ddlRelationship" runat="server" CssClass="browser-default">
                  <asp:ListItem>Choose a Relationship...</asp:ListItem>
                  <asp:ListItem>Spouse</asp:ListItem>
                  <asp:ListItem>Parent</asp:ListItem>
                  <asp:ListItem>Child</asp:ListItem>
                  <asp:ListItem>Friend</asp:ListItem>
                  <asp:ListItem>Co-worker</asp:ListItem>
                  <asp:ListItem>Other</asp:ListItem>
              </asp:DropDownList>

          </div>
      </div>
      <div class="row">
          <div class="input-field col s12">
          
              <asp:Label ID="lblNotes" runat="server" Text="Notes"></asp:Label>
              <asp:TextBox ID="txtNotes" runat="server" TextMode="MultiLine" Height="100px"></asp:TextBox>
          
          </div>
      </div>
      <div class="row">
          <div class="input-field col s6">

              <asp:Label ID="lblContact" runat="server" Text="Contact"></asp:Label>
              <br />
              <asp:ListBox ID="lbxContact" runat="server" CssClass="browser-default" ></asp:ListBox>

          </div>
          <div class="input-field col s6">

              <asp:Button ID="btnSubmit" runat="server" Text="Submit" class="btn waves-effect waves-light grey darken-4" />
              <asp:Button ID="btnClear" runat="server" Text="Clear" class="btn waves-effect waves-light grey darken-4" />

          </div>
      </div>
      <div class="row">
          <div class="input-field col s12">

              <asp:Label ID="lblFeedback" runat="server" Text="Feedback"></asp:Label>

          </div>
      </div>
    </form>
  </div>
</asp:Content>

