<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Confirm.aspx.cs" Inherits="Quotation.Confirm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Price quotation</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <script src="Scripts/jquery-3.4.1.min.js"></script>    
    <script src="Scripts/bootstrap.min.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="form-horizontal">

        <main class="container">

            <h1 class="jumbotron">Quotation confirmation</h1>

            <div class="form-group">
                <label class="col-sm-3 control-label">Sales price</label>
                <asp:Label ID="priceLabel" runat="server" CssClass="col-sm-3 bold"></asp:Label>
            </div>

            <div class="form-group">
                <label class="col-sm-3 control-label">Discount amount</label>
                <asp:Label ID="discountLabel" runat="server" CssClass="col-sm-3 bold"></asp:Label>
            </div>

            <div class="form-group">
                <label class="col-sm-3 control-label">Total price</label>
                <asp:Label ID="totalLabel" runat="server" CssClass="col-sm-3 bold"></asp:Label>
            </div> 

            <div class="row">
                <h3 class="col-sm-offset-2 col-sm-10">Send confirmation to</h3>
            </div>
            
            <div class="form-group">
                <label class="col-sm-3 control-label">Name</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="nameTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-sm-6">                    
                     <%-- RequiredFieldValidator goes here --%>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Required" ControlToValidate="nameTextBox"></asp:RequiredFieldValidator>
                </div>  
            </div>  
            
            <div class="form-group">
                <label class="col-sm-3 control-label">Email address</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="emailTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-sm-6">
                      <%-- RequiredFieldValidator goes here --%>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Required" ControlToValidate="emailTextBox"></asp:RequiredFieldValidator>
               </div>  
            </div>  

            <%-- Quotation and Return buttons --%>
            <div class="form-group">
                <div class="col-sm-offset-3 col-sm-9">
                    <%-- buttons go here --%>
                    <asp:Button ID="quotationButton" runat="server" Text="Send Quatation" CssClass="btn btn-primary" OnClick="quotationButton_Click"/>
                    <asp:Button ID="returnButton" runat="server" Text="Return" CssClass="btn btn-primary" CausesValidation="False" PostBackUrl="Default.aspx"/>
                </div>
            </div> 
            
            <%-- message label --%>
            <div class="form-group">
                <div class="col-sm-offset-1 col-sm-11">
                    <%-- message label goes here --%>
                    <asp:Label ID="messageLabel" runat="server" Text="Click the Send Quotation button to send the quotation via email." CssClass="text-info"></asp:Label>
                </div>
            </div>

        </main>

    </form>
</body>
</html>
