<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="TokoBeDia.View.ChangePassword" %>

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
        <div style="text-align: center;" class="col-md-2 offset-5">
            <h2 class="text-center">Change Password</h2>
            <div>
                <asp:Label runat="server" Text="Old Password" ID="lblOldPassword"></asp:Label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtOldPassword" placeholder="Input Old Password" TextMode ="Password"></asp:TextBox>
                <asp:Label runat="server" Text="Old password must not be empty / must match" ID="warningOldPassword" CssClass="text-danger"></asp:Label>
            </div>
            <div>
                <asp:Label runat="server" Text="New Password" ID="lblNewPassword"></asp:Label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtNewPassword" placeholder="Input New Password" TextMode ="Password"></asp:TextBox>
                <asp:Label runat="server" Text="New password must not be empty" ID="warningNewPassword" CssClass="text-danger"></asp:Label>
            </div>
            <div>
                <asp:Label runat="server" Text="Confirm Password" ID="lblConfirmPassword"></asp:Label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtConfirmPassword" placeholder="Input Confirm Password" TextMode ="Password"></asp:TextBox>
                <asp:Label runat="server" Text="Old password must match" ID="warningConfirmPassword" CssClass="text-danger"></asp:Label>
            </div>
            <div>
                <asp:Button ID="btnChangePassword" CssClass="btn btn-lg btn-primary btn-block" runat="server" Text="ChangePassword" OnClick="btnConfirmPassword_Click" />
            </div>
        </div>
    </div>
    </form>
</body>
</html>
