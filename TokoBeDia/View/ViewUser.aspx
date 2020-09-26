<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewUser.aspx.cs" Inherits="TokoBeDia.View.ViewUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TokoBeDia</title>
    <link href="../Content/css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="navbar-header" style="background-color: darkslategrey">
        <h1 class="navbar-brand text-black" style="text-align: left; margin: 10px; margin-left: 20px; color: white;">TokoBeDia</h1>
    </div>
    <div style="margin: 0 auto; margin-top: 20px; display: inline-block;">
        <asp:Button CssClass="btn btn-primary" ID="btnHome" runat="server" Text="Back to Home" OnClick="btnHome_Click" />
    </div>
    <div class="col-md-12" style="margin-top: 30px">

        <div class="container">
            <asp:Table ID="User" CssClass="table table-bordered text-center" runat="server">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell CssClass="text-center">No.</asp:TableHeaderCell>
                    <asp:TableHeaderCell CssClass="text-center">User ID</asp:TableHeaderCell>
                    <asp:TableHeaderCell CssClass="text-center">Role</asp:TableHeaderCell>
                    <asp:TableHeaderCell CssClass="text-center">Name</asp:TableHeaderCell>
                    <asp:TableHeaderCell CssClass="text-center">Email</asp:TableHeaderCell>
                    <asp:TableHeaderCell CssClass="text-center">Gender</asp:TableHeaderCell>
                    <asp:TableHeaderCell CssClass="text-center">Status</asp:TableHeaderCell>
                </asp:TableHeaderRow>
            </asp:Table>
        </div>
    </div>
    
        <div class="col-md-12">
            <div class="container">
                <h2 class="text-center">Edit Users</h2>
                <div style="display: flex; flex-direction: column; align-items: center; margin: 0 auto; margin-bottom: 20px;">
                    <div>
                        <asp:Label ID="lblUserId" runat="server" Text="Edit User Id"></asp:Label>
                        <br />
                        <asp:TextBox ID="editUserId" runat="server" CssClass="col-md-3" Placeholder="Edit User ID"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="lblRole" runat="server" Text="Role"></asp:Label>
                        <br />
                        <asp:RadioButtonList ID="editRole" runat="server" RepeatLayout="Flow">
                            <asp:ListItem Value="1">Administrator</asp:ListItem>
                            <asp:ListItem Value="2">Member</asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                    <div>
                        <asp:Label ID="lblStatus" runat="server" Text="Status"></asp:Label>
                        <br />
                        <asp:RadioButtonList ID="editStatus" runat="server" RepeatLayout="Flow">
                            <asp:ListItem Value="Active">Active</asp:ListItem>
                            <asp:ListItem Value="Blocked">Blocked</asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                    <div style="margin: 10px;">
                        <asp:Button ID="editBtn" runat="server" Text="Edit User" OnClick="btnEdit_Click" CssClass="btn btn-warning " />
                    </div>
                    <div>
                        <asp:Label runat="server" Text="You can not edit your own role and status" ID="warningSelf" CssClass="text-danger"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
