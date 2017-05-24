<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OrderForm.aspx.cs" Inherits="OrderForm" %>

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
        <div class="input-field col s6">

            <asp:Label ID="lblSize" runat="server" Text="Pizza Sizes"></asp:Label>
            <asp:RadioButton ID="rbSmall" runat="server" Text="Small ($7.00)" OnCheckedChanged="rbSmall_CheckedChanged" />
            <asp:RadioButton ID="rbMedium" runat="server" Text="Medium ($10.00)" OnCheckedChanged="rbMedium_CheckedChanged" />
            <asp:RadioButton ID="rbLarge" runat="server" Text="Large ($12.00)" OnCheckedChanged="rbLarge_CheckedChanged" />

            <%--<asp:RadioButtonList ID="rblSize" runat="server" OnSelectedIndexChanged="rblSize_CheckChanged">
                
                <asp:ListItem Text="Small" Value="Small">Small ($7)</asp:ListItem>
                <asp:ListItem Text="Medium" Value="Medium">Medium ($10)</asp:ListItem>
                <asp:ListItem Text="Large" Value="Large">Large ($12)</asp:ListItem>
                
            </asp:RadioButtonList>--%>
            <br />
            <br />
            <br />
            <br />

            <asp:Label ID="lblTotalCost" runat="server" Text="Total Cost"></asp:Label>
            <asp:TextBox ID="txtTotalCost" runat="server" Text="0.00"></asp:TextBox>

        </div>
        <div class="input-field col s6">

            <asp:Label ID="lblToppings" runat="server" Text="Toppings"></asp:Label>
            <asp:CheckBox ID="chkPepperoni" Text="Pepperoni" runat="server" OnCheckedChanged="chkPepperoni_CheckedChanged" />
            <asp:CheckBox ID="chkSausage" Text="Sausage" runat="server" OnCheckedChanged="chkSausage_CheckedChanged" />
            <asp:CheckBox ID="chkMeatball" Text="Meatball" runat="server" OnCheckedChanged="chkMeatball_CheckedChanged" />
            <asp:CheckBox ID="chkHam" Text="Ham" runat="server" OnCheckedChanged="chkHam_CheckedChanged" />
            <asp:CheckBox ID="chkPeppers" Text="Peppers" runat="server" OnCheckedChanged="chkPeppers_CheckedChanged" />
            <asp:CheckBox ID="chkOnions" Text="Onions" runat="server" OnCheckedChanged="chkOnions_CheckedChanged" />
            <asp:CheckBox ID="chkOlives" Text="Olives" runat="server" OnCheckedChanged="chkOlives_CheckedChanged" />
            <asp:CheckBox ID="chkSpinach" Text="Spinach" runat="server" OnCheckedChanged="chkSpinach_CheckedChanged" />
            <asp:CheckBox ID="chkPineapple" Text="Pineapple" runat="server" OnCheckedChanged="chkPineapple_CheckedChanged" />
            <asp:CheckBox ID="chkBBQSauce" Text="BBQ Sauce" runat="server" OnCheckedChanged="chkBBQSauce_CheckedChanged" />
            <asp:CheckBox ID="chkExtraCheese" Text="Extra Cheese"  runat="server" OnCheckedChanged="chkExtraCheese_CheckedChanged"/>

            <%-- 
            <asp:CheckBoxList ID="cblToppings" runat="server" OnSelectedIndexChanged="cblToppings_CheckChanged">

                <asp:ListItem Text="Pepperoni" Value="Pepperoni">Pepperoni</asp:ListItem>
                <asp:ListItem Text="Sausage" Value="Sausage">Sausage</asp:ListItem>
                <asp:ListItem Text="Meatball" Value="Meatball">Meatball</asp:ListItem>
                <asp:ListItem Text="Ham" Value="Ham">Ham</asp:ListItem>
                <asp:ListItem Text="Peppers" Value="Peppers">Peppers</asp:ListItem>
                <asp:ListItem Text="Onions" Value="Onions">Onions</asp:ListItem>
                <asp:ListItem Text="Olives" Value="Olives">Olives</asp:ListItem>
                <asp:ListItem Text="Spinach" Value="Spinach">Spinach</asp:ListItem>
                <asp:ListItem Text="Pineapple" Value="Spinach">Pineapple</asp:ListItem>
                <asp:ListItem Text="BBQ Sauce" Value="BBQ Sauce">BBQ Sauce</asp:ListItem>
                <asp:ListItem Text="Extra Cheese" Value="Extra Cheese">Extra Cheese</asp:ListItem>

            </asp:CheckBoxList>
            --%>
        </div>
      </div>

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
          <div class="input-field col s6">

              <asp:Label ID="lblOrder" runat="server" Text="Order"></asp:Label>
              <br />
              <asp:ListBox ID="lbxOrder" runat="server" CssClass="browser-default"></asp:ListBox>

          </div>
          <div class="input-field col s6">

              <asp:Button ID="btnSubmit" runat="server" Text="Submit" class="btn waves-effect waves-light grey darken-4" OnClick="btnSubmit_Click" style="margin-bottom: 5px;"/>&nbsp;
              <asp:ValidationSummary ID="vsMainAdd" runat="server" ShowMessageBox="True" />
              <asp:Button ID="btnUpdate" runat="server" Text="Update" class="btn waves-effect waves-light grey darken-4" OnClick="btnUpdate_Click" style="margin-bottom: 5px;" />&nbsp;
              <asp:Button ID="btnDelete" runat="server" Text="Delete" class="btn waves-effect waves-light grey darken-4" OnClick="btnDelete_Click" style="margin-bottom: 5px;" />&nbsp;
              <asp:Button ID="btnClear" runat="server" Text="Clear" class="btn waves-effect waves-light grey darken-4" OnClick="btnClear_Click" CausesValidation="false" style="margin-bottom: 5px;" />&nbsp;
              <asp:Button ID="btnLogOut" runat="server"  Text="Log Out" class="btn waves-effect waves-light red darken-4" CausesValidation="false" OnClick="btnLogOut_Click" style="margin-bottom: 5px;" />

          </div>
      </div>

      <div class="row">
          <div class="input-field col s12">
              
              <asp:Label ID="lblOrder_ID" runat="server" Text=""></asp:Label>
              <asp:Label ID="lblFeedback" runat="server" Text=""></asp:Label>

          </div>
          
      </div>
    </div>
  </div>
</asp:Content>

