<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProductType.aspx.cs" Inherits="TokoBeDia.View.WebForm3" %>

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
    <div class="col-md-12" style="margin-top: 30px">
        <div style="margin: 0 auto; margin-top: 20px; display: inline-block;">
            <asp:Button CssClass="btn btn-primary" ID="btnHome" runat="server" Text="Back to Home" OnClick="btnHome_Click" />
        </div>
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
        <div style="margin: 0 auto; margin-top: 20px; display: inline-block;">
            <asp:Button CssClass="btn btn-primary" ID="btnInsertProductType" runat="server" Text="Insert Product Type" OnClick="btnInsertProductType_Click" />
            <asp:Button CssClass="btn btn-primary" ID="btnUpdateProductType" runat="server" Text="Update Product Type" OnClick="btnUpdateProductType_Click" />
        </div>
        <div>
            <asp:Label runat="server" Text="Product Type ID" ID="lblProductId"></asp:Label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtProductTypeId" placeholder="Input Product Type ID"></asp:TextBox>
            <asp:Label runat="server" Text="Product Type ID must not be empty / must exist" ID="warningProductTypeId" CssClass="text-danger"></asp:Label>
        </div>
        <div style="margin: 0 auto; margin-top: 20px; display: inline-block;">
            <asp:Button CssClass="btn btn-primary" ID="btnDeleteProductType" runat="server" Text="Delete Product Type" OnClick="btnDeleteProductType_Click" />
        </div>
    </div>
    
        
    </form>
</body>
</html>
