<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="TokoBeDia.View.Register" %>

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
        <h2 class="text-center">Register Page</h2>
        <div class="col-md-2 offset-5">

            <div>
                <asp:RadioButtonList ID="radioRole" runat="server" RepeatLayout="Flow">
                    <asp:ListItem Value="1">Administrator</asp:ListItem>
                    <asp:ListItem Value="2">Member</asp:ListItem>
                </asp:RadioButtonList>
                <asp:Label runat="server" Text="Role must not be empty" ID="warningRole" CssClass="text-danger"></asp:Label>
            </div>

            <div>
                <asp:Label runat="server" Text="Username" ID="lblUsername"></asp:Label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtUsername" placeholder="Input Username"></asp:TextBox>
                <%--<asp:RequiredFieldValidator runat="server" ErrorMessage="Username Required" CssClass="text-danger" ValidationGroup="groupLogin" ControlToValidate="txtUsername"></asp:RequiredFieldValidator>--%>
                <asp:Label runat="server" Text="Username must not be empty" ID="warningUsername" CssClass="text-danger"></asp:Label>
            </div>

            <div>
                <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                <asp:TextBox ID="txtPassword" CssClass="form-control" runat="server" placeholder="Input Password" TextMode="Password"></asp:TextBox>
                <%--<asp:RequiredFieldValidator runat="server" ErrorMessage="Password Required" CssClass="text-danger" ValidationGroup="groupLogin" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>--%>
                <asp:Label runat="server" Text="Password must not be empty" ID="warningPassword" CssClass="text-danger"></asp:Label>
            </div>

            <div>
                <asp:Label ID="lblConfirmPassword" runat="server" Text="Confirm Password"></asp:Label>
                <asp:TextBox ID="txtConfirmPassword" CssClass="form-control" runat="server" placeholder="Confirm Password" TextMode="Password"></asp:TextBox>
                <%--<asp:RequiredFieldValidator runat="server" ErrorMessage="Password does not match" CssClass="text-danger" ValidationGroup="groupLogin" ControlToValidate="txtConfirmPassword"></asp:RequiredFieldValidator>--%>
                <asp:Label runat="server" Text="Password must be the same / must not be empty" ID="warningConfirmPassword" CssClass="text-danger"></asp:Label>
            </div>

            <div>
                <asp:Label runat="server" Text="Email" ID="lblEmail"></asp:Label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtEmail" placeholder="Input Email"></asp:TextBox>
               <%-- <asp:RequiredFieldValidator runat="server" ErrorMessage="Email Required" CssClass="text-danger" ValidationGroup="groupLogin" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>--%>
                <asp:Label runat="server" Text="Email must not be empty" ID="warningEmail" CssClass="text-danger"></asp:Label>
            </div>

            <div>
                <asp:RadioButtonList ID="radioGender" runat="server" RepeatLayout="Flow">
                    <asp:ListItem Value="Male">Male</asp:ListItem>
                    <asp:ListItem Value="Female">Female</asp:ListItem>
                </asp:RadioButtonList>
                <asp:Label runat="server" Text="Gender must not be empty" ID="warningGender" CssClass="text-danger"></asp:Label>
            </div>

            <asp:Button ID="btnRegister" CssClass="btn btn-lg btn-primary btn-block" runat="server" Text="Register" OnClick="btnRegister_Click" />
        </div>
    </div>
    </form>
</body>
</html>
