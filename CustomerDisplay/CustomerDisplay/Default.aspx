<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CustomerDisplay.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Display Customers</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/Site.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.4.1.min.js"></script>
    <script src="Scripts/bootstrap.js"></script>
</head>
<body>
<div class="container">
    <header class="jumbotron">
        <h1>SportsPro</h1>
        <h2>Sports management software for the sports enthusiast</h2>
    </header>
    <main>
    <form id="form1" runat="server" class="form-horizontal">

        <div class="row">
            <div class="col-sm-offset-1 col-sm-3">Select a customer:</div>
            <div class="col-sm-6">
                <asp:DropDownList ID="custDropDownList" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="CustomerID" OnSelectedIndexChanged="custDropDownList_SelectedIndexChanged">
                    <asp:ListItem>Name 1</asp:ListItem>
                    <asp:ListItem>Name 2</asp:ListItem>
                    <asp:ListItem>Name 3</asp:ListItem>
                </asp:DropDownList>            
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT [CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email] FROM [Customers] ORDER BY [Name]"></asp:SqlDataSource>
            </div>
        </div>

        <div class="row">
            <div class="col-sm-offset-1 col-sm-3">Address:</div>
            <div class="col-sm-6">
                <asp:Label ID="addrLabel" runat="server"></asp:Label></div>
        </div>
        <div class="row">
            <div class="col-sm-offset-1 col-sm-3">&nbsp;</div>
            <div class="col-sm-6">
                <asp:Label ID="cityLabel" runat="server"></asp:Label></div>
        </div>
        <div class="row">
            <div class="col-sm-offset-1 col-sm-3">Phone:</div>
            <div class="col-sm-6">
                <asp:Label ID="phoneLabel" runat="server"></asp:Label></div>
        </div>
        <div class="row">
            <div class="col-sm-offset-1 col-sm-3">Email:</div>
            <div class="col-sm-6">
                <asp:Label ID="emailLabel" runat="server"></asp:Label></div>
        </div>
    </form>
    </main>
</div>
</body>
</html>
