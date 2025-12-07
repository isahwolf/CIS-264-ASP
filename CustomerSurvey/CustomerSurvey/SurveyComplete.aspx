<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SurveyComplete.aspx.cs" Inherits="CustomerSurvey.SurveyComplete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Survey Customer</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <script src="Scripts/jquery-3.4.1.min.js"></script>    
    <script src="Scripts/bootstrap.min.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/site.css" rel="stylesheet" />
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
            <div class="col-sm-offset-1 col-sm-10">
                <asp:Label ID="messageLabel" runat="server" CssClass="text-info"></asp:Label>
            </div>
        </div>

        <div class="row">
            <div class="col-sm-offset-1 col-sm-10">
                <asp:Button ID="returnButton" runat="server" Text="Return to Survey" CssClass="btn btn-primary" PostBackUrl="CustomerSurvey.aspx" />
            </div>
        </div>
        
    </form>
    </main>
</div>
</body>

</html>
