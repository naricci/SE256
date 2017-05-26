<%@ Page Title="Order Form" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OrderForm.aspx.cs" Inherits="OrderForm" %>

<asp:Content ID="Content4" ContentPlaceHolderID="cphMain" Runat="Server">
    
    <br />
    <div class="row">
        <div class="col s12">

          <div class="row">
            <div class="offset-s4 col s4 offset-s4">
                <!-- Page Title -->
                <h5>Pizza Order Form</h5>
                <br />
            </div>
          </div>  
        
          <div class="row">
          
            <div class="col s4">
            
                <asp:Label ID="lblSize" runat="server" Text="Pizza Sizes"></asp:Label>
                <br />
                <asp:RadioButton ID="rbSmall" runat="server" Text="Small ($7.00)" GroupName="Size" OnCheckedChanged="rbSmall_CheckedChanged" />
                <br />
                <asp:RadioButton ID="rbMedium" runat="server" Text="Medium ($10.00)" GroupName="Size" OnCheckedChanged="rbMedium_CheckedChanged" />
                <br />
                <asp:RadioButton ID="rbLarge" runat="server" Text="Large ($12.00)" GroupName="Size" OnCheckedChanged="rbLarge_CheckedChanged" />
                <br />

            </div>

            <div class="col s8">

                <asp:Label ID="lblToppings" runat="server" Text="Pizza Toppings"></asp:Label>
                <br />
                <div class="col s4" style="width: 50%">
                    <asp:CheckBox ID="chkPepperoni" Text="Pepperoni" runat="server" OnCheckedChanged="chkPepperoni_CheckedChanged" />
                    <br />
                    <asp:CheckBox ID="chkSausage" Text="Sausage" runat="server" OnCheckedChanged="chkSausage_CheckedChanged" />
                    <br />
                    <asp:CheckBox ID="chkMeatball" Text="Meatball" runat="server" OnCheckedChanged="chkMeatball_CheckedChanged" />
                    <br />
                    <asp:CheckBox ID="chkHam" Text="Ham" runat="server" OnCheckedChanged="chkHam_CheckedChanged" />
                    <br />
                    <asp:CheckBox ID="chkPeppers" Text="Peppers" runat="server" OnCheckedChanged="chkPeppers_CheckedChanged" />
                    <br />
                    <asp:CheckBox ID="chkOnions" Text="Onions" runat="server" OnCheckedChanged="chkOnions_CheckedChanged" />
                </div>

                <div class="col s4" style="width: 50%">
                    <asp:CheckBox ID="chkOlives" Text="Olives" runat="server" OnCheckedChanged="chkOlives_CheckedChanged" />
                    <br />
                    <asp:CheckBox ID="chkSpinach" Text="Spinach" runat="server" OnCheckedChanged="chkSpinach_CheckedChanged" />
                    <br />
                    <asp:CheckBox ID="chkPineapple" Text="Pineapple" runat="server" OnCheckedChanged="chkPineapple_CheckedChanged" />
                    <br />
                    <asp:CheckBox ID="chkBBQSauce" Text="BBQ Sauce" runat="server" OnCheckedChanged="chkBBQSauce_CheckedChanged" />
                    <br />
                    <asp:CheckBox ID="chkExtraCheese" Text="Extra Cheese"  runat="server" OnCheckedChanged="chkExtraCheese_CheckedChanged"/>
                </div>
                <br />

            </div><!--/ col s8 -->
          </div><!--/ row -->

          <div class="row">
            <div class="input-field col s6">

                <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
                <asp:TextBox ID="txtFirstName" runat="server" MaxLength="25"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvFirstName"
                    runat="server"
                    ControlToValidate="txtFirstName"
                    ErrorMessage="You must enter a First Name..."
                    Display="Dynamic">* You must enter a First Name...</asp:RequiredFieldValidator>

            </div>

            <div class="input-field col s6">

                <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
                <asp:TextBox ID="txtLastName" runat="server" MaxLength="25"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvLastName"
                    runat="server"
                    ControlToValidate="txtLastName"
                    ErrorMessage="You must enter a Last Name..."
                    Display="Dynamic">* You must enter a Last Name...</asp:RequiredFieldValidator>

            </div>
          </div>

          <div class="row">
            <div class="input-field col s6">
          
                <asp:Label ID="lblStreet1" runat="server" Text="Street 1"></asp:Label>
                <asp:TextBox ID="txtStreet1" runat="server" MaxLength="50"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvStreet1"
                    runat="server"
                    ControlToValidate="txtStreet1"
                    ErrorMessage="You must enter a Street Address..."
                    Display="Dynamic">* You must enter a Street Address...</asp:RequiredFieldValidator>

            </div>

            <div class="input-field col s6">
          
                <asp:Label ID="lblStreet2" runat="server" Text="Street 2"></asp:Label>
                <asp:TextBox ID="txtStreet2" runat="server" MaxLength="50"></asp:TextBox>
          
            </div>
          </div>

          <div class="row">
            <div class="input-field col s4">

                <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
                <asp:DropDownList ID="ddlCity" runat="server" CssClass="browser-default">
                    <asp:ListItem>East Greenwich</asp:ListItem>
                    <asp:ListItem>North Kingstown</asp:ListItem>
                    <asp:ListItem>Warwick</asp:ListItem>
                </asp:DropDownList>
            
            </div>

            <div class="input-field col s4">

                <asp:Label ID="lblState" runat="server" Text="State"></asp:Label>
                <asp:DropDownList ID="ddlState" runat="server" CssClass="browser-default">
                    <asp:ListItem>Connecticut</asp:ListItem>
                    <asp:ListItem>Massachusetts</asp:ListItem>
                    <asp:ListItem>New Hampshire</asp:ListItem>
                    <asp:ListItem>Rhode Island</asp:ListItem>
                    <asp:ListItem>Vermont</asp:ListItem>
                </asp:DropDownList>
  
            </div>

            <div class="input-field col s4">

                <asp:Label ID="lblZipCode" runat="server" Text="Zip Code"></asp:Label>
                <asp:TextBox ID="txtZipCode" runat="server" MaxLength="5"></asp:TextBox>
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

                  <asp:Label ID="lblPhone" runat="server" Text="Phone"></asp:Label>
                  <asp:TextBox ID="txtPhone" runat="server" MaxLength="10"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="rfvPhone"
                    runat="server"
                    ControlToValidate="txtPhone"
                    ErrorMessage="You must enter a Phone Number"
                    Display="Dynamic">* You must enter a Phone Number...</asp:RequiredFieldValidator>

              </div>
          
              <div class="input-field col s6">

                  <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                  <asp:TextBox ID="txtEmail" runat="server" MaxLength="50"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="rfvEmail" 
                      runat="server" ControlToValidate="txtEmail"
                      ErrorMessage="Email Address is not filled in..."/><br />
                  <asp:RegularExpressionValidator ID="revEmail" 
                      runat="server" ErrorMessage="Email Address is not in a proper format." 
                      ControlToValidate="txtEmail" 
                      ValidationExpression="[\w\.-]+(\+[\w-]*)?@([\w-]+\.)+[\w-]+">
                  </asp:RegularExpressionValidator>

              </div>
          </div>
      
          <div class="row">
              <div class="input-field col s4">

                  <asp:Label ID="lblOrder" runat="server" Text="Order"></asp:Label>
                  <br />
                  <asp:ListBox ID="lbxOrder" runat="server" CssClass="browser-default"></asp:ListBox>

              </div>

              <div class="col s8">

                  <asp:Button ID="btnSubmit" runat="server" Text="Submit" class="btn waves-effect waves-light grey darken-4" OnClick="btnSubmit_Click" style="margin-bottom: 5px;"/>&nbsp;
                  <asp:ValidationSummary ID="vsMainAdd" runat="server" ShowMessageBox="True" />
                  <asp:Button ID="btnUpdate" runat="server" Text="Update" class="btn waves-effect waves-light grey darken-4" OnClick="btnUpdate_Click" style="margin-bottom: 5px;" />&nbsp;
                  <asp:Button ID="btnDelete" runat="server" Text="Delete" class="btn waves-effect waves-light grey darken-4" OnClick="btnDelete_Click" style="margin-bottom: 5px;" />&nbsp;
                  <asp:Button ID="btnClear" runat="server" Text="Clear" class="btn waves-effect waves-light grey darken-4" OnClick="btnClear_Click" CausesValidation="false" style="margin-bottom: 5px;" />&nbsp;
                  <asp:Button ID="btnLogOut" runat="server"  Text="Log Out" class="btn waves-effect waves-light red darken-4" CausesValidation="false" OnClick="btnLogOut_Click" style="margin-bottom: 5px;" />

              </div>
          </div>

          <div class="row">
              <div class="col s12">
              
                  <asp:Label ID="lblOrder_ID" runat="server" Text=""></asp:Label>
                  <br />
                  <asp:Label ID="lblFeedback" runat="server" Text=""></asp:Label>

              </div>
          </div>

      </div><!--/ col s12 -->
  </div><!--/ row -->
</asp:Content>

