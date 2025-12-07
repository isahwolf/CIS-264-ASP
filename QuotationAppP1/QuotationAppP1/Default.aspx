<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="QuotationAppP1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Price quotation</title>
</head>
<body>
    <form id="form1" runat="server">

        <h1>Price quotation</h1>

        <table style="width: 100%;">
            <tr>
                <td>Sales price &nbsp; <asp:TextBox ID="salesTextBox" runat="server"></asp:TextBox><br /></td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>

            <tr>
                <td>Discount percent &nbsp; <asp:TextBox ID="percentTextBox" runat="server"></asp:TextBox><br /></td>
            </tr>

            <tr>
                <td>Discount amount &nbsp; <asp:Label ID="amountLabel" runat="server" Font-Bold="True"></asp:Label><br /></td>
            </tr>

            <tr>
                <td>&nbsp;</td>
            </tr>

            <tr>
                <td>Total price &nbsp; <asp:Label ID="totalLabel" runat="server" Font-Bold="True"></asp:Label></td>

            </tr>

            <tr>
                <td>&nbsp;</td>
            </tr>

            <tr>
                <td><asp:Button ID="calculateButton" runat="server" Text="Calculate" OnClick="calculateButton_Click" /></td>
            </tr>

        </table>

    </form>
</body>
</html>

