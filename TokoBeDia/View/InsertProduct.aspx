<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertProduct.aspx.cs" Inherits="TokoBeDia.View.InsertProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TokoBeDia</title>
    <link href="../Content/css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <div class="navbar-header" style="background-color: darkslategrey">
        <h1 class="navbar-brand text-black" style="text-align: left; margin: 10px; margin-left: 20px; color: white;">TokoBeDia</h1>
    </div>
    <form id="form1" runat="server">
    <div style="margin: 0 auto; margin-top: 20px; display: inline-block;">
        <asp:Button CssClass="btn btn-primary" ID="btnHome" runat="server" Text="Back to Home" OnClick="btnHome_Click" />
    </div>
    <div class="col-md-12" style="margin-top: 30px">
        <div class="container">
            <asp:Table ID="ProductType" CssClass="table table-bordered text-center" runat="server">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell CssClass="text-center">No.</asp:TableHeaderCell>
                    <asp:TableHeaderCell CssClass="text-center">Product Type ID</asp:TableHeaderCell>
                    <asp:TableHeaderCell CssClass="text-center">Product Type</asp:TableHeaderCell>
                    <asp:TableHeaderCell CssClass="text-center">Description</asp:TableHeaderCell>
                </asp:TableHeaderRow>
            </asp:Table>
        </div>
    </div>
    
    <div>
        <h2 class="text-center">Insert Product</h2>
        <div class="col-md-2 offset-5">

            <div>
                <asp:Label runat="server" Text="Product Type ID" ID="lblProductTypeId"></asp:Label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtProductTypeId" placeholder="Input Product Type ID"></asp:TextBox>
                <asp:Label runat="server" Text="Product Type ID must not be empty / must exist" ID="warningProductTypeId" CssClass="text-danger"></asp:Label>
            </div>

            <div>
                <asp:Label ID="lblProductName" runat="server" Text="ProductName"></asp:Label>
                <asp:TextBox ID="txtProductName" CssClass="form-control" runat="server" placeholder="Input Product Name"></asp:TextBox>
                <asp:Label runat="server" Text="Product name must not be empty" ID="warningProductName" CssClass="text-danger"></asp:Label>
            </div>

            <div>
                <asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label>
                <asp:TextBox ID="txtPrice" CssClass="form-control" runat="server" placeholder="Input Price"></asp:TextBox>
                <asp:Label runat="server" Text="Price must be above 1000 and multiply of 1000" ID="warningPrice" CssClass="text-danger"></asp:Label>
            </div>

            <div>
                <asp:Label runat="server" Text="Stock" ID="lblStock"></asp:Label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtStock" placeholder="Input Stock"></asp:TextBox>
                <asp:Label runat="server" Text="Stock must be 1 or more" ID="warningStock" CssClass="text-danger"></asp:Label>
            </div>


            <asp:Button ID="btnInsert" CssClass="btn btn-lg btn-primary btn-block" runat="server" Text="Insert" OnClick="btnInsert_Click" />
        </div>
    </div>
    </form>
</body>
</html>
