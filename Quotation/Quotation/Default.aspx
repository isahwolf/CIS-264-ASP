                     <%-- QuotationAppP2, By Isaiah Wolf --%>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Quotation.Default" %>

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

            <h1 class="jumbotron">Price quotation</h1>

            <div class="row">
                <label class="col-sm-3 control-label">Sales price</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="priceTextBox" runat="server" CssClass="form-control bold">100</asp:TextBox>
                </div>
                <div class="col-sm-6">
                     <%-- RequiredFieldValidator and RangeValidator go here --%>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Required" ControlToValidate="priceTextBox"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Price must be 10 to 1000" ControlToValidate="priceTextBox" MaximumValue="1000" MinimumValue="10" Type="Integer"></asp:RangeValidator>
                </div>
            </div>

            <div class="row">
                <label class="col-sm-3 control-label">Discount percent</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="percentTextBox" runat="server" CssClass="form-control">20</asp:TextBox>
                </div>
                <div class="col-sm-6">
                     <%-- RequiredFieldValidator and RangeValidator go here --%>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Required" ControlToValidate="percentTextBox"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator2" runat="server" ErrorMessage="Percent must be 10 to 50" MaximumValue="50" MinimumValue="10" ControlToValidate="percentTextBox" Type="Integer"></asp:RangeValidator>
                </div>  
            </div>

            <div class="row">
                <label class="col-sm-3 control-label">Discount amount</label>
                <asp:Label ID="discountLabel" runat="server" CssClass="col-sm-3 bold"></asp:Label>
            </div>

            <div class="row">
                <label class="col-sm-3 control-label">Total price</label>
                <asp:Label ID="totalLabel" runat="server" CssClass="col-sm-3 bold"></asp:Label>
            </div> 

            <%-- Calculate and Confirm buttons --%>
            <div class="row">
                <div class="col-sm-offset-3 col-sm-9">
                    <asp:Button ID="calcButton" runat="server" Text="Calculate"
                        CssClass="btn btn-primary" OnClick="btnCalculate_Click" />
                    <%-- confirm button goes here --%>
                    <asp:Button ID="confirmButton" runat="server" Text="Confirm" CssClass="btn btn-primary" OnClick="confirmButton_Click" />
                </div>
            </div> 
            
            <%-- message label --%>
            <div class="row">
                <div class="col-sm-offset-1 col-sm-11">
                    <%-- message label goes here --%>
                    <asp:Label ID="messageLabel" runat="server" Text="Enter price and discount amount and click Calculate." CssClass ="text-info"></asp:Label>
                </div>
            </div>   

        </main>

    </form>
</body>
</html>
