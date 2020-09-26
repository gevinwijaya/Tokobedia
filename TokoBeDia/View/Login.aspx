<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TokoBeDia.View.WebForm1" %>

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
        <h2 class="text-center">Login Page</h2>
        <div class="row">
            <div class="col-md-2 offset-5">
                <div>
                    <asp:Label runat="server" text="Username" id="lblUsername"></asp:Label>
                    <asp:Textbox runat="server" cssclass="form-control" id="txtUsername" placeholder="Input Username"></asp:Textbox>
                    
                    <asp:Label runat="server" Text="Username does not exist / is empty" ID="warningUsername" CssClass="text-danger"></asp:Label>
                </div>

                <div>
                    <asp:Label id="lblPassword" runat="server" text="Password"></asp:Label>
                    <asp:Textbox id="txtPassword" cssclass="form-control" runat="server" placeholder="Input Password" textmode="Password"></asp:Textbox>
                    
                    <asp:Label runat="server" Text="Password does not match / is empty" ID="warningPassword" CssClass="text-danger"></asp:Label>
                </div>

                <div>
                    <asp:Label runat="server" Text="You are blocked" ID="warningStatus" CssClass="text-danger"></asp:Label>
                </div>

                <div>
                    <asp:CheckBox id="rememberMe" Text="Remember me" runat="server"/>
                </div>

                <asp:Button runat="server" cssclass="btn btn-lg btn-primary btn-block" id="btnLogin" text="Login" validationgroup="groupLogin" OnClick="btnLogin_Click" />
                <hr />
                <small>No Account ?</small>
                <a href="Register.aspx"><small>Register</small></a>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
