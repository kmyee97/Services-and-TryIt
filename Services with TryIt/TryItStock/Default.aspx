<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TryItStock._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Stock Quote and Stock News</h1>
        <p class="lead"> About, The operation takes in a string that represents a stock symbol. After clicking the button, there are two services that will be running. One service will display the current price, trade day date, openning price, highest price, lowest price, change, and change in percent. The other service will gather a list of news urls about the stock.</p>
        <p class="lead"> The service is from, </p>
        <p class="lead"> (1) string Stockquote(string symbol) returns a string containing the stock symbol&#39;s current price, trade day date, openning price, highest price, lowest price, change, and change in percent.</p>
        <p class="lead"> (2) string Stocknews(string symbol) returns a list of news urls about the stock symbol.</p>
        <p class="lead"> Input Stock Symbol here:
            <asp:TextBox ID="TextBox" runat="server"></asp:TextBox>
            &nbsp;&nbsp;
        </p>
        <asp:Button Text="submit" ID="Button1" OnClick="getQuote" runat="server" /><br />
        <asp:Label ID="output" runat="server" Text="Output"></asp:Label>
        <br />
        <br />
        <asp:Label ID="output2" runat="server" Text="News URLs here"></asp:Label>
    </div>

</asp:Content>
