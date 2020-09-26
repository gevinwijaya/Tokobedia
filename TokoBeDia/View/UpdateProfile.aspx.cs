using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Repository;

namespace TokoBeDia.View
{
    public partial class UpdateProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User u = UserRepository.FindUser(Request.Cookies["auth_user"].Value);
            txtEmail.Text = u.Email;
            txtName.Text = u.Name;
            warningEmail.Visible = false;
            warningGender.Visible = false;
            warningName.Visible = false;
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            bool passRequirements = true;
            String email = txtEmail.Text;
            User u = UserRepository.FindUser(Request.Cookies["auth_user"].Value);
            User u2 = UserRepository.FindUser(email);
            if(txtName.Text == "")
            {
                warningName.Visible = true;
                passRequirements = false;
            }
            if(txtEmail.Text == "" || u2 != null)
            {
                warningEmail.Visible = true;
                passRequirements = false;
            }
            if(radioGender.SelectedValue == null)
            {
                warningGender.Visible = true;
                passRequirements = false;
            }
            if(passRequirements == true)
            {
                String name = txtName.Text;
                String gender = radioGender.Text;
                UserRepository.UpdateProfile(u.UserId, name, email, gender);
            }
        }
    }
}