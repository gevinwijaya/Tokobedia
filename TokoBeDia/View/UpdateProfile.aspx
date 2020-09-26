<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="TokoBeDia.View.UpdateProfile" %>

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
    <div class="col-md-2 offset-5" >
        <h2 class="text-center">Update Profile</h2>

        <div>
            <asp:Label runat="server" Text="Name" ID="lblName"></asp:Label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtName"></asp:TextBox> 
            <asp:Label runat="server" Text="Name must not be empty" ID="warningName" CssClass="text-danger"></asp:Label>
        </div>

        <div>
            <asp:Label runat="server" Text="Email" ID="lblEmail"></asp:Label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtEmail"></asp:TextBox>
            <asp:Label runat="server" Text="Email must not be empty" ID="warningEmail" CssClass="text-danger"></asp:Label>
        </div>

        <div>
            <asp:RadioButtonList ID="radioGender" runat="server" RepeatLayout="Flow">
                <asp:ListItem Value="Male">Male</asp:ListItem>
                <asp:ListItem Value="Female">Female</asp:ListItem>
            </asp:RadioButtonList>
            <asp:Label runat="server" Text="Gender must not be empty" ID="warningGender" CssClass="text-danger"></asp:Label>
        </div>
        <div>
            <asp:Button ID="btnUpdateProfile" CssClass="btn btn-lg btn-primary btn-block" runat="server" Text="Update Profile" OnClick="btnUpdateProfile_Click" />
        </div>
    </div>
    </form>
</body>
</html>
