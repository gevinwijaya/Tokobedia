using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Repository;

namespace TokoBeDia.View
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            warningConfirmPassword.Visible = false;
            warningNewPassword.Visible = false;
            warningOldPassword.Visible = false;
        }

        protected void btnConfirmPassword_Click(object sender, EventArgs e)
        {
            bool PassRequirements = true;
            User u = UserRepository.FindUser(Request.Cookies["auth_user"].Value);
            if(txtOldPassword.Text != u.Password || txtOldPassword.Text == "")
            {
                PassRequirements = false;
                warningOldPassword.Visible = true;
            }
            if(txtNewPassword.Text == "")
            {
                PassRequirements = false;
                warningNewPassword.Visible = true;
            }
            if(txtConfirmPassword.Text == "" || txtConfirmPassword.Text != txtNewPassword.Text)
            {
                PassRequirements = false;
                warningConfirmPassword.Visible = true;
            }
            if(PassRequirements == true)
            {
                String newpassword = txtNewPassword.Text;
                UserRepository.UpdatePassword(u.UserId,newpassword);
                Response.Redirect("Home.aspx");
            }
        }
        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}