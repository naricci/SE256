<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ContentMgr.aspx.cs" Inherits="Controls_ContentMgr" %>

<asp:Content ID="Content4" ContentPlaceHolderID="cphMain" Runat="Server">
    <div class="row">
    <div class="col s12">
      <div class="row">
        <div class="input-field col s4">

            <asp:Label ID="lblFirstName" runat="server" Text="First Name" MaxLength="20"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvFirstName"
                runat="server"
                ControlToValidate="txtFirstName"
                ErrorMessage="You must enter a First Name..."
                Display="Dynamic">* You must enter a First Name...</asp:RequiredFieldValidator>

        </div>
        <div class="input-field col s4">

            <asp:Label ID="lblMiddleName" runat="server" Text="Middle Name" MaxLength="20"></asp:Label>
            <asp:TextBox ID="txtMiddleName" runat="server"></asp:TextBox>

        </div>
        <div class="input-field col s4">

            <asp:Label ID="lblLastName" runat="server" Text="Last Name" MaxLength="30"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvLastName"
                runat="server"
                ControlToValidate="txtLastName"
                ErrorMessage="You must enter a Last Name..."
                Display="Dynamic">* You must enter a Last Name...</asp:RequiredFieldValidator>

        </div>
      </div>
      <div class="row">
        <div class="input-field col s6">
          
            <asp:Label ID="lblStreet1" runat="server" Text="Street 1" MaxLength="50"></asp:Label>
            <asp:TextBox ID="txtStreet1" runat="server"></asp:TextBox>
          
        </div>
        <div class="input-field col s6">
          
            <asp:Label ID="lblStreet2" runat="server" Text="Street 2" MaxLength="50"></asp:Label>
            <asp:TextBox ID="txtStreet2" runat="server"></asp:TextBox>
          
        </div>
      </div>
      <div class="row">
        <div class="input-field col s4">

            <asp:Label ID="lblCity" runat="server" Text="City" MaxLength="25"></asp:Label>
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>

        </div>
        <div class="input-field col s4">

            <asp:Label ID="lblState" runat="server" Text="State" MaxLength="2"></asp:Label>
            <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
            
        
        </div>
        <div class="input-field col s4">

            <asp:Label ID="lblZipCode" runat="server" Text="Zip Code" MaxLength="5"></asp:Label>
            <asp:TextBox ID="txtZipCode" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvZipCode"
                runat="server"
                ControlToValidate="txtZipCode"
                ErrorMessage="You must enter a Zip Code..."
                Display="Dynamic">* You must enter a Zip Code...</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revZipCode"
                runat="server" 
                ControlToValidate="txtZipCode"
                ValidationExpression="\d{5}" 
                Display="Dynamic"
                ErrorMessage="Must be a 5-digit U.S. Zip Code.">* Must be a 5-digit U.S. Zip Code.</asp:RegularExpressionValidator>

        </div>
      </div>
      <div class="row">
          <div class="input-field col s6">

              <asp:Label ID="lblBirthday" runat="server" Text="Birthday"></asp:Label>
              <asp:Calendar ID="calBirthday" runat="server" ShowGridLines="True"></asp:Calendar>

          </div>
          <div class="input-field col s6">

              <asp:Label ID="lblAnniversary" runat="server" Text="Anniversary"></asp:Label>
              <asp:Calendar ID="calAnniversary" runat="server" ShowGridLines="True"></asp:Calendar>

          </div>
      </div>
      <div class="row">
          <div class="input-field col s4">

              <asp:Label ID="lblHomePhone" runat="server" Text="Home Phone" MaxLength="10"></asp:Label>
              <asp:TextBox ID="txtHomePhone" runat="server"></asp:TextBox>

          </div>
          <div class="input-field col s4">

              <asp:Label ID="lblWorkPhone" runat="server" Text="WorkPhone" MaxLength="10"></asp:Label>
              <asp:TextBox ID="txtWorkPhone" runat="server"></asp:TextBox>

          </div>
          <div class="input-field col s4">

              <asp:Label ID="lblCellPhone" runat="server" Text="Cell Phone" MaxLength="10"></asp:Label>
              <asp:TextBox ID="txtCellPhone" runat="server"></asp:TextBox>

          </div>
      </div>
      <div class="row">
          <div class="input-field col s4">

              <asp:Label ID="lblEmail" runat="server" Text="Email" MaxLength="50"></asp:Label>
              <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
              <asp:RequiredFieldValidator ID="rfvEmail" 
                  runat="server" ControlToValidate="txtEmail"
                  ErrorMessage="Email Address is not filled in..."/><br />
              <asp:RegularExpressionValidator ID="revEmail" 
                  runat="server" ErrorMessage="Email Address is not in a proper format." 
                  ControlToValidate="txtEmail" 
                  ValidationExpression="[\w\.-]+(\+[\w-]*)?@([\w-]+\.)+[\w-]+">
              </asp:RegularExpressionValidator>

          </div>
          <div class="input-field col s4">

              <asp:CheckBox ID="chkCardWorthy" runat="server" Text="Card Worthy?" />

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
          
              <asp:Label ID="lblNotes" runat="server" Text="Notes" MaxLength="100"></asp:Label>
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

              <asp:Button ID="btnSubmit" runat="server" Text="Submit" class="btn waves-effect waves-light grey darken-4" OnClick="btnSubmit_Click" style="margin-bottom: 5px;"/>&nbsp;
              <asp:ValidationSummary ID="vsMainAdd" runat="server" ShowMessageBox="True" />
              <asp:Button ID="btnUpdate" runat="server" Text="Update" class="btn waves-effect waves-light grey darken-4" OnClick="btnUpdate_Click" style="margin-bottom: 5px;" />&nbsp;
              <asp:Button ID="btnDelete" runat="server" Text="Delete" class="btn waves-effect waves-light grey darken-4" OnClick="btnDelete_Click" style="margin-bottom: 5px;" />&nbsp;
              <asp:Button ID="btnClear" runat="server" Text="Clear" class="btn waves-effect waves-light grey darken-4" OnClick="btnClear_Click" CausesValidation="false" />&nbsp;
              <asp:Button ID="btnLogOut" runat="server"  Text="Log Out" class="btn waves-effect waves-light red darken-4" CausesValidation="false" OnClick="btnLogOut_Click" />

          </div>
      </div>
      <div class="row">
          <div class="input-field col s12">
              
              <asp:Label ID="lblPerson_ID" runat="server"></asp:Label>
              <asp:Label ID="lblFeedback" runat="server" Text="Feedback"></asp:Label>

          </div>
          
      </div>
    </div>
  </div>
</asp:Content>

