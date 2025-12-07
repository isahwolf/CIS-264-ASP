 <%-- Exam 1, By Isaiah Wolf --%>

 <%-- I'm not sure why the css isn't being applied like how it is in the exam document --%>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerSurvey.aspx.cs" Inherits="CustomerSurvey.CustomerSurvey" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Survey Customer</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <script src="Scripts/jquery-3.4.1.min.js"></script>    
    <script src="Scripts/bootstrap.min.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/site.css" rel="stylesheet" /></head>
<body>
<div class="container">
    <header class="jumbotron">
        <h1>SportsPro</h1>
        <h2>Sports management software for the sports enthusiast</h2>
    </header>
    <main>
    <form id="form1" runat="server" class="form-horizontal">

        <div class="form-group">
            <div class="col-sm-3">Please choose your name:</div>
            <div class="col-sm-3">
            </div>
            <div class="col-sm-6">
            </div>
        </div>

        <div class="form-group">
            <div class="col-sm-10">
                <asp:ListBox ID="customersListBox" runat="server" CssClass="form-control" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="CustomerID" ></asp:ListBox>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT [CustomerID], [Name] FROM [Customers]"></asp:SqlDataSource>
                <%-- RequiredFieldValidator for customersListBox here --%>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Required" ControlToValidate="customersListBox"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="form-group options">
            <div class="col-sm-12">
                <label>Please rate your satisfaction:</label>
            </div>

            <div class="col-sm-3">Response time:</div>
            <div class="col-sm-9">
                <asp:RadioButtonList ID="responseTimeRBL" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Value="1">Not satisfied</asp:ListItem>
                    <asp:ListItem Value="2">Somewhat satisfied</asp:ListItem>
                    <asp:ListItem Value="3">Satisfied</asp:ListItem>
                    <asp:ListItem Value="4">Completely satisfied</asp:ListItem>
                </asp:RadioButtonList>
                <%-- RequiredFieldValidator for responseTimeRBL here --%>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Required" ControlToValidate="responseTimeRBL"></asp:RequiredFieldValidator>
            </div>

            <div class="col-sm-3">Technician efficiency:</div>
            <div class="col-sm-9">
                <asp:RadioButtonList ID="efficiencyRBL" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Value="1">Not satisfied</asp:ListItem>
                    <asp:ListItem Value="2">Somewhat satisfied</asp:ListItem>
                    <asp:ListItem Value="3">Satisfied</asp:ListItem>
                    <asp:ListItem Value="4">Completely satisfied</asp:ListItem>
                </asp:RadioButtonList>
                <%-- RequiredFieldValidator for efficiencyRBL here --%>   
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Required" ControlToValidate="efficiencyRBL"></asp:RequiredFieldValidator>
            </div>

            <div class="col-sm-3">Problem resolution:</div>
            <div class="col-sm-9">
                <asp:RadioButtonList ID="resolutionRBL" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Value="1">Not satisfied</asp:ListItem>
                    <asp:ListItem Value="2">Somewhat satisfied</asp:ListItem>
                    <asp:ListItem Value="3">Satisfied</asp:ListItem>
                    <asp:ListItem Value="4">Completely satisfied</asp:ListItem>
                </asp:RadioButtonList>
                <%-- RequiredFieldValidator for resolutionRBL here --%>   
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Required" ControlToValidate="resolutionRBL"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="form-group">
            <div class="col-sm-3">Additional comments:</div>
            <div class="col-sm-7">
                <asp:TextBox ID="commentsTextBox" runat="server" Rows="4" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

        <div class="form-group options">
            <div class="col-sm-12">
                <asp:CheckBox ID="contactCheckBox" runat="server" Text="Please contact me by phone to discuss" />
            </div>
            <div class="col-sm-offset-1 col-sm-11">
                <br />
            </div>
        </div>

        <div class="form-group"><%-- Submit button --%>
            <div class="col-sm-3">
                <asp:Button ID="submitButton" runat="server" Text="Submit" CssClass="btn btn-primary" OnClick="submitButton_Click" />
            </div>
            <div class="col-sm-7">
            </div>
        </div>
        
    </form>
    </main>
</div>
</body>
</html>
