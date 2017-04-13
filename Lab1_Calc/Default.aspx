<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lab 1: Calculator</title>
    <style>
        .button {margin-bottom: 3px;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="txtLCD" runat="server" Width="109px" Height="25px" style="margin-bottom: 5px;"></asp:TextBox>
        <asp:Label ID="lblNum1" runat="server" Visible="False"></asp:Label>
        <asp:Label ID="lblNum2" runat="server" Visible="False"></asp:Label>
        <asp:Label ID="lblOperator" runat="server" Visible="False"></asp:Label>

        <div>
            <div>
                <asp:Button ID="btn1" runat="server" Text="1" OnClick="btn1_Click" Height="25px" Width="25px" class="button" />
                <asp:Button ID="btn2" runat="server" Text="2" OnClick="btn2_Click" Height="25px" Width="25px" class="button" />
                <asp:Button ID="btn3" runat="server" Text="3" OnClick="btn3_Click" Height="25px" Width="25px" class="button" />
                <asp:Button ID="btnPlus" runat="server" Text="+" OnClick="btnPlus_Click" Width="25px" Height="25px" class="button" />
            </div>
            
            <div>
                <asp:Button ID="btn4" runat="server" Text="4" OnClick="btn4_Click" Height="25px" Width="25px" class="button" />
                <asp:Button ID="btn5" runat="server" Text="5" OnClick="btn5_Click" Height="25px" Width="25px" class="button" />
                <asp:Button ID="btn6" runat="server" Text="6" OnClick="btn6_Click" Height="25px" Width="25px" class="button" />
                <asp:Button ID="btnMinus" runat="server" Text="-" Width="25px" OnClick="btnMinus_Click" Height="25px" class="button" />
            </div>
            
            <div>
                <asp:Button ID="btn7" runat="server" Text="7" OnClick="btn7_Click" Height="25px" Width="25px" class="button" />
                <asp:Button ID="btn8" runat="server" Text="8" OnClick="btn8_Click" Height="25px" Width="25px" class="button" />
                <asp:Button ID="btn9" runat="server" Text="9" OnClick="btn9_Click" Height="25px" Width="25px" class="button" />
                <asp:Button ID="btnMultiply" runat="server" Text="*" Width="25px" OnClick="btnMultiply_Click" Height="25px" class="button" />
            </div>
            
            <div>
                <asp:Button ID="btnMS" runat="server" Text="MS" Height="25px" Width="25px" style="font-size: 9px;" class="button" /><!-- Doesn't Work -->
                <asp:Button ID="btn0" runat="server" Text="0" OnClick="btn0_Click" Height="25px" Width="25px" class="button" />
                <asp:Button ID="btnMR" runat="server" Text="MR" Height="25px" Width="25px" style="font-size: 9px;" class="button" /><!-- Doesn't Work -->
                <asp:Button ID="btnDivide" runat="server" Text="/" Width="25px" OnClick="btnDivide_Click" Height="25px" class="button" />
            </div>
            
            <div>
                <asp:Button ID="btnMC" runat="server" Text="MC" Height="25px" Width="25px" style="font-size: 9px;" class="button" /><!-- Doesn't Work -->
                <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" Width="55px" Height="25px" class="button" />
                <asp:Button ID="btnEquals" runat="server" Text="=" OnClick="btnEquals_Click" Width="25px" Height="25px" style="margin-bottom: 3px;" />
            </div>
            <br />
        </div>
    </form>
</body>
</html>
