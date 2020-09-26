<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProductType.aspx.cs" Inherits="TokoBeDia.View.UpdateProductType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TokoBeDia</title>
    <link href="../Content/css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <div>
        <div class="navbar-header" style="background-color: darkslategrey">
        <h1 class="navbar-brand text-black" style="text-align: left; margin: 10px; margin-left: 20px; color: white;">TokoBeDia</h1>
        </div>
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
        <h2 class="text-center">Update Product Type</h2>
        <div class="col-md-2 offset-5">

            <div>
                <asp:Label ID="lblProductTypeId" runat="server" Text="Product Type Id"></asp:Label>
                <asp:TextBox ID="txtProductTypeId" CssClass="form-control" runat="server" placeholder="Input Product Type Id"></asp:TextBox>
                <asp:Label runat="server" Text="Product Type Id must exist" ID="warningProductTypeId" CssClass="text-danger"></asp:Label>
            </div>

            <div>
                <asp:Label ID="lblProductTypeName" runat="server" Text="Product Type"></asp:Label>
                <asp:TextBox ID="txtProductTypeName" CssClass="form-control" runat="server" placeholder="Input Product Type"></asp:TextBox>
                <asp:Label runat="server" Text="Product name must not be empty / must be unique / must consist of 5 characters or more" ID="warningProductTypeName" CssClass="text-danger"></asp:Label>
            </div>

            <div>
                <asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label>
                <asp:TextBox ID="txtDescription" CssClass="form-control" runat="server" placeholder="Input Description"></asp:TextBox>
                <asp:Label runat="server" Text="Description must not be empty" ID="warningDescription" CssClass="text-danger"></asp:Label>
            </div>


            <asp:Button ID="btnUpdate" CssClass="btn btn-lg btn-primary btn-block" runat="server" Text="Update" OnClick="btnUpdate_Click" />
        </div>
    </div>
    </form>

</body>
</html>
