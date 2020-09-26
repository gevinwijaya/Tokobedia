<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertProductType.aspx.cs" Inherits="TokoBeDia.View.InsertProductType" %>

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
    <div>
        <h2 class="text-center">Insert Product Type</h2>
        <div class="col-md-2 offset-5">


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


            <asp:Button ID="btnInsert" CssClass="btn btn-lg btn-primary btn-block" runat="server" Text="Insert" OnClick="btnInsert_Click" />
        </div>
    </div>
    </form>
</body>
</html>