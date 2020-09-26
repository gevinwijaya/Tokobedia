<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="TokoBeDia.View.WebForm2" %>

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
    <div style="text-align: center;">
        <div style="margin: 0 auto; margin-top: 20px; display: inline-block;">
            <asp:Button CssClass="btn btn-primary" ID="btnViewUser" runat="server" Text="View User" OnClick="btnViewUser_Click" />
            <asp:Button CssClass="btn btn-primary" ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            <asp:Button CssClass="btn btn-primary" ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
            <asp:Button CssClass="btn btn-primary" ID="btnChangePassword" runat="server" Text="Change Password" OnClick="btnChangePassword_Click" />
            <asp:Button CssClass="btn btn-primary" ID="btnProfile" runat="server" Text="Profile" OnClick="btnProfile_Click" />
            <asp:Button CssClass="btn btn-primary" ID="btnUpdateProfile" runat="server" Text="Update Profile" OnClick="btnUpdateProfile_Click" />
            <asp:Button CssClass="btn btn-primary" ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
        </div>
        <br />
        <div style="margin: 0 auto; margin-top: 20px; display: inline-block;">
            <asp:Button CssClass="btn btn-primary" ID="btnViewProduct" runat="server" Text="View Product" OnClick="btnViewProduct_Click" />
            <asp:Button CssClass="btn btn-primary" ID="btnInsertProduct" runat="server" Text="Insert Product" OnClick="btnInsertProduct_Click" />
            <asp:Button CssClass="btn btn-primary" ID="btnUpdateProduct" runat="server" Text="Update Product" OnClick="btnUpdateProduct_Click" />
            <asp:Button CssClass="btn btn-primary" ID="btnViewProductType" runat="server" Text="View Product Type" OnClick="btnViewProductType_Click" />
            <asp:Button CssClass="btn btn-primary" ID="btnInsertProductType" runat="server" Text="Insert Product Type" OnClick="btnInsertProductType_Click" />
            <asp:Button CssClass="btn btn-primary" ID="btnUpdateProductType" runat="server" Text="Update Product Type" OnClick="btnUpdateProductType_Click" />
        </div>
    </div>
    </form>
</body>
</html>
