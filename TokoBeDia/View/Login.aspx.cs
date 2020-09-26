using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Repository;

namespace TokoBeDia.View
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] != null)
            {
                Response.Redirect("Home.aspx");
            }
            if (Page.IsPostBack == false)
            {
                if (Request.Cookies["username"] != null)
                {
                    txtUsername.Text = Response.Cookies["username"].Value;
                }
            }
            warningUsername.Visible = false;
            warningPassword.Visible = false;
            warningStatus.Visible = false;
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            bool passRequirements = true;
            if (txtPassword.Text == "")
            {
                warningPassword.Visible = true;
                passRequirements = false;
            }
            if (txtUsername.Text == "")
            {
                warningUsername.Visible = true;
                passRequirements = false;
            }
            if(passRequirements == true && txtUsername.Text!="" && txtPassword.Text!="")
            {
                User u = UserRepository.FindUser(username, password);
                passRequirements = true;
                if (u == null)
                {
                    passRequirements = false;
                    warningUsername.Visible = true;
                }
                if (txtPassword.Text != u.Password)
                {
                    passRequirements = false;
                    warningPassword.Visible = true;
                }
                if (u.Status.ToString() == "Blocked")
                {
                    passRequirements = false;
                    warningStatus.Visible = true;
                }
                if (passRequirements == true)
                {
                    Session["id"] = u.UserId;
                    Session["auth_user"] = u.Email;
                    Response.Cookies["auth_user"].Value = u.Email;

                    if (rememberMe.Checked)
                    {
                        Response.Cookies["auth_user"].Expires = DateTime.Now.AddDays(3);
                    }
                    Response.Redirect("Home.aspx");
                }
            }

            
        }
    }
}