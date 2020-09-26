using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Repository;

namespace TokoBeDia.View
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User u = UserRepository.FindUser(Request.Cookies["auth_user"].Value);
            txtName.Text = u.Name;
            txtEmail.Text = u.Email;
            txtGender.Text = u.Gender;
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProfile.aspx");
        }
    }
}