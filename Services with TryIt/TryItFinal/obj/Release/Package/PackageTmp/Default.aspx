<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TryItFinal._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Currency Conversion</h1>
        <p class="lead"> About, The operation uses a RESTful service that converts the value of one currency to another.</p>
        <p class="lead"> This service from, http://webstrar34.fulton.asu.edu/index.html</p>
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

     <div class="jumbotron">
        <h1>Stock Quote and Stock News</h1>
        <p class="lead"> About, The operation takes in a string that represents a stock symbol. After clicking the button, there are two services that will be running. One service will display the current price, trade day date, openning price, highest price, lowest price, change, and change in percent. The other service will gather a list of news urls about the stock.</p>
        <p class="lead"> This service from, http://webstrar34.fulton.asu.edu/index.html</p>
        <p class="lead"> (1) string Stockquote(string symbol) returns a string containing the stock symbol&#39;s current price, trade day date, openning price, highest price, lowest price, change, and change in percent.</p>
        <p class="lead"> (2) string Stocknews(string symbol) returns a list of news urls about the stock symbol.</p>
        <p class="lead"> Input Stock Symbol here:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            &nbsp;&nbsp;
        </p>
        <asp:Button Text="submit" ID="Button3" OnClick="getQuote" runat="server" /><br />
        <asp:Label ID="Label2" runat="server" Text="Output"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="News URLs here"></asp:Label>
    </div>
    <div class="jumbotron">
        <h1>Word Filter</h1>
        <p class="lead"> About, The operation takes in an input from the user and outputs a string with the stop words removed.</p>
        <p class="lead"> This service from, http://webstrar34.fulton.asu.edu/index.html</p>
        <p class="lead"> (1) string WordFilter(string str) 
                returns a string with the stop words removed
        </p>
        <p class="lead"> Please type in a string below.</p>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:Button Text="submit" ID="Button2" OnClick="WordFilter" runat="server" /><br />
        <asp:Label ID="Label1" runat="server" Text="Output"></asp:Label>
    </div>
    <div class="jumbotron">
        <h1>Find the Nearest Store</h1>
        <p class="lead"> About, The operation takes in inputs and returns the location of the nearest store or a message saying &quot;no stores within 20 miles&quot;</p>
        <p class="lead"> This service from, http://webstrar34.fulton.asu.edu/index.html</p>
        <p class="lead"> (1) string findNearestStore(string zipcode, string storeName) returns the location of the nearest store based on the zipcode in a string format</p>
        <p class="lead"> Input zipcode here:
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;&nbsp; Input store name here:
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </p>
        <asp:Button Text="submit" ID="Button4" OnClick="findNearestStore" runat="server" /><br />
        <asp:Label ID="Label4" runat="server" Text="Output"></asp:Label>
    </div>

</asp:Content>


