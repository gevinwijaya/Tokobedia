<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProduct.aspx.cs" Inherits="TokoBeDia.View.ViewProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TokoBeDia</title>
    <link href="../Content/css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="navbar-header" style="background-color: darkslategrey">
        <h1 class="navbar-brand text-black" style="text-align: left; margin: 10px; margin-left: 20px; color: white;">TokoBeDia</h1>
        </div>
    </div>
    <div style="margin: 0 auto; margin-top: 20px; display: inline-block;">
        <asp:Button CssClass="btn btn-primary" ID="btnHome" runat="server" Text="Back to Home" OnClick="btnHome_Click" />
    </div>
    <div class="col-md-12" style="margin-top: 30px">
        <div class="container">
            <asp:Table ID="Product" CssClass="table table-bordered text-center" runat="server">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell CssClass="text-center">No.</asp:TableHeaderCell>
                    <asp:TableHeaderCell CssClass="text-center">Product ID</asp:TableHeaderCell>
                    <asp:TableHeaderCell CssClass="text-center">Product Name</asp:TableHeaderCell>
                    <asp:TableHeaderCell CssClass="text-center">Product Stock</asp:TableHeaderCell>
                    <asp:TableHeaderCell CssClass="text-center">Product Type</asp:TableHeaderCell>
                    <asp:TableHeaderCell CssClass="text-center">Product Price</asp:TableHeaderCell>
                </asp:TableHeaderRow>
            </asp:Table>
        </div>
    </div>
    <div style="margin: 0 auto; margin-top: 20px; display: inline-block;">
        <asp:Button CssClass="btn btn-primary" ID="btnInsertProduct" runat="server" Text="Insert Product" OnClick="btnInsertProduct_Click" />
        <asp:Button CssClass="btn btn-primary" ID="btnUpdateProduct" runat="server" Text="Update Product" OnClick="btnUpdateProduct_Click" />
    </div>
    <div>
        <asp:Label runat="server" Text="Product ID" ID="lblProductId"></asp:Label>
        <asp:TextBox runat="server" CssClass="form-control" ID="txtProductId" placeholder="Input Product ID"></asp:TextBox>
        <asp:Label runat="server" Text="Product ID must not be empty / must exist" ID="warningProductId" CssClass="text-danger"></asp:Label>
    </div>
    <div style="margin: 0 auto; margin-top: 20px; display: inline-block;">
        <asp:Button CssClass="btn btn-primary" ID="btnDeleteProduct" runat="server" Text="Delete Product" OnClick="btnDeleteProduct_Click" />
    </div>
        
    </form>
</body>
</html>
