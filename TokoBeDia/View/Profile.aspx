<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="TokoBeDia.View.Profile" %>

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
    <div class="col-md-2 offset-5">
        <h2 class="text-center">Profile</h2>
        <div>
            <asp:Label runat="server" ID="txtName" CssClass="text-danger"></asp:Label>
        </div>
        <div>
            <asp:Label runat="server" ID="txtEmail" CssClass="text-danger"></asp:Label>
        </div>
        <div>
            <asp:Label runat="server" ID="txtGender" CssClass="text-danger"></asp:Label>
        </div>
        <div>
            <asp:Button ID="btnUpdateProfile" CssClass="btn btn-lg btn-primary btn-block" runat="server" Text="Update Profile" OnClick="btnUpdateProfile_Click" />
        </div>
    </div>
    </form>
</body>
</html>
