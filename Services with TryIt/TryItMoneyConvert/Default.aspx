<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TryItMoneyConvert._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Currency Conversion</h1>
        <p class="lead"> About, The operation converts the value of one currency to another.</p>
        <p class="lead"> (1) double moneyConvert(double value, string currency1, string currency2) returns a double variable value that has been converted into a new currency</p>
        <p class="lead"> Currency converting from: <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>USD</asp:ListItem>
                <asp:ListItem>EUR</asp:ListItem>
                <asp:ListItem>YEN</asp:ListItem>
                <asp:ListItem>CAN</asp:ListItem>
                <asp:ListItem>GBP</asp:ListItem>
                <asp:ListItem>CNY</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp; Currency converting to:
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem>USD</asp:ListItem>
                <asp:ListItem>EUR</asp:ListItem>
                <asp:ListItem>YEN</asp:ListItem>
                <asp:ListItem>CAN</asp:ListItem>
                <asp:ListItem>GBP</asp:ListItem>
                <asp:ListItem>CNY</asp:ListItem>
            </asp:DropDownList>
&nbsp;the value input:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <asp:Button Text="submit" ID="Button1" OnClick="ConvertToNewCurrency" runat="server" /><br />
        <asp:Label ID="output" runat="server" Text="Output"></asp:Label>
    </div>

</asp:Content>
